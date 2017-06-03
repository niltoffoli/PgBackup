using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Diagnostics;
using System.IO.Compression;
using Ionic.Zip;
using Google.Apis.Drive.v2;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Util.Store;
using Google.Apis.Services;
using Google.Apis.Drive.v2.Data;
using System.Xml;
using System.Web;
using System.Timers;
using Microsoft.Win32;
using Npgsql;

/*
 * verificar se diretório de origem e destino existem
 * verificar espaço do diretório de destino
 * salvar em pasta temporária no sistema
*/


namespace ProdanBackup
{
   
    public partial class frmBackup : Form
    {
        Thread _ThVerificacao;
        string Banco;
        System.Timers.Timer timer = null;


        public frmBackup()
        {            
            InitializeComponent();
            tray.Text = "Backup Prodan";
            NextTimer();
           // conectaPg();

            //timer.Enabled = true;
            //timer.AutoReset = true;
            //timer.Elapsed += new System.Timers.ElapsedEventHandler(VerificaHora);
            //timer.Start();          
        }

      

        private void NextTimer()
        {
            //Codigo Nilton
            DateTime horaatual = new DateTime();
            DateTime proximo = new DateTime();
            
            

            timer = new System.Timers.Timer(TimeSpan.FromSeconds(5).TotalMilliseconds);
            timer.Enabled = true;
            timer.AutoReset = false;
            timer.Elapsed += new System.Timers.ElapsedEventHandler(VerificaHora);
            timer.Start();   
        }

        public NpgsqlDataReader PostgresCmd(string host, string port, string user, string pass, string query)
        {
            try
            {
                //ATENÇÃO!  a dll Npgsql mantém abertas as conexões feitas no postgres, MESMO se voce usar o comando Close(). Ela deixa aberto pra evitar ter que abrir de novo caso necessário... pra fechar de fato tem que usar na string de conexão o comando pooling=false.
                NpgsqlConnection con = new NpgsqlConnection("Server='" + host + "';Port='" + port + "';User Id='" + user + "';Password='" + pass + "';Protocol=3;Pooling=false;");
                con.Open();
                NpgsqlCommand comando = new NpgsqlCommand(query, con);
                NpgsqlDataReader reader = comando.ExecuteReader();

                reader.Close();
                con.ClearPool();
                con.Close();

                return reader;
            }
            catch (Exception excp)
            {
                MessageBox.Show(excp.Message);
                return null;
            }
        }

        public void Verifica()
        {
            //_ThVerificacao = new Thread(VerificaHora);
            //_ThVerificacao.Start();
        }

        protected void VerificaHora(object objeto, EventArgs args)
        {

            Dump();
            Zip();
            NextTimer();
            //while (true)
            //{
            //    //string time = dateTimePicker1.Value.ToShortTimeString();
                                   
            //    if (DateTime.Now.ToString("HH:mm") ==  configuracoes.Default.horabackup.ToString("HH:mm"))
            //    {
                   
            //        //Copy();
            //        Thread.Sleep(60000);
            //    }
            //    else
            //    {
            //        Thread.Sleep(3000);
            //    }
            //}
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide(); // minimiza ao ser executado
            Verifica();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                this.ShowInTaskbar = false;
            }
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = false;
        }                        


        public void Zip()
        {
            ZipFile zipf = new ZipFile();
            zipf.AddDirectory(@"c:\prodan");
            zipf.Save(@"c:\sss.rar");

        }

        public void Dump()
        {
            try
            {
                tray.BalloonTipText = "Cópia Iniciada";
                tray.ShowBalloonTip(6);
                string dumpfile = configuracoes.Default.destino + configuracoes.Default.dadosOdbc.banc +
                                  DateTime.Now.ToString(" yyyy-MM-dd_HHmmss") +
                                  ".backup";
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.CreateNoWindow = true;
                startInfo.UseShellExecute = false;
                startInfo.FileName = @"o:\prodan\backup\pg_dump.exe";
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                Environment.SetEnvironmentVariable("PGPASSWORD", configuracoes.Default.dadosOdbc.pass);
                startInfo.Arguments = "-i -h " + configuracoes.Default.dadosOdbc.host + " -p " + configuracoes.Default.dadosOdbc.port + " -U " + configuracoes.Default.dadosOdbc.user + "postgres -F c -b -v -f " + dumpfile.ToString() + Banco;
                using (Process exeProcess = Process.Start(startInfo))
                {
                    exeProcess.WaitForExit();
                    tray.BalloonTipText = "Backup de banco efetuado com sucesso";
                    tray.ShowBalloonTip(6);
                }
            }
            catch (Exception excp)
            {

                MessageBox.Show(excp.Message);
            }
        }

        public void Copy()
        {
            string fileName = "test.txt";
            string sourcePath = @"C:\Users\Public\TestFolder";
            string targetPath = @"C:\Users\Public\TestFolder\SubDir";

            // Use Path class to manipulate file and directory paths.
            string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
            string destFile = System.IO.Path.Combine(targetPath, fileName);

            // To copy a folder's contents to a new location:
            // Create a new target folder, if necessary.
            if (!System.IO.Directory.Exists(targetPath))
            {
                System.IO.Directory.CreateDirectory(targetPath);
            }
            // To copy a file to another location and 
            // overwrite the destination file if it already exists.
            System.IO.File.Copy(sourceFile, destFile, true);
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            frmConfig config = new frmConfig();
            config.Show();
        }    
     
    }
}
