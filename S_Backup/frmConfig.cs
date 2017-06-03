using Microsoft.Win32;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProdanBackup
{
    public partial class frmConfig : Form
    {
        System.Windows.Forms.ToolTip tpPswPg = new System.Windows.Forms.ToolTip();
        List<string> listaHoras = new List<string>();
        

        public frmConfig()
        {
            InitializeComponent();

            dtHoraBackup.CalendarForeColor = SystemColors.Info;
            dtHoraBackup.Format = DateTimePickerFormat.Custom;
            dtHoraBackup.CustomFormat = "HH:mm";
            dtHoraBackup.ShowUpDown = true;
            txtDest.Text = configuracoes.Default.destino;
            txtPswPostgres.UseSystemPasswordChar = true;
            btnPswPg.ImageIndex = 1;
                       
            ListaDrives();
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
                reader.Read();
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

        public void ListaDrives()
        {
            DriveInfo[] ListAllDrives = DriveInfo.GetDrives();

            foreach (DriveInfo Drive in ListAllDrives)
            {
                cmbDrives.Items.Add(Drive.Name);

            }
            //cmbDrives.SelectedItem = Path.GetPathRoot(System.Reflection.Assembly.GetEntryAssembly().Location);
        }

        private void frmConfig_Load(object sender, EventArgs e)
        {
            Odbc _dadosOdbc = new Odbc();
            _dadosOdbc = BuscaOdbc();

            if (_dadosOdbc != null)
            {
                txtIP.Text = _dadosOdbc.host;
                txtPorta.Text = _dadosOdbc.port;
                txtUser.Text = _dadosOdbc.user;
                txtBanco.Text = _dadosOdbc.banc;
                txtPswPostgres.Text = _dadosOdbc.pass;
            }

            if (String.IsNullOrEmpty(configuracoes.Default.serverdrive))
            {
                cmbDrives.SelectedItem = Path.GetPathRoot(System.Reflection.Assembly.GetEntryAssembly().Location);
            }
            else
            {
                cmbDrives.SelectedItem = configuracoes.Default.serverdrive;
            }
        }

        public Odbc BuscaOdbc()
        {
            Odbc dadosOdbc = new Odbc();
            string chave = string.Empty;

            if (Environment.Is64BitOperatingSystem) chave = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Wow6432Node\\ODBC\\ODBC.INI\\DS-PSQL70";

            else chave = "HKEY_LOCAL_MACHINE\\SOFTWARE\\ODBC\\ODBC.INI\\DS-PSQL70";
            

            dadosOdbc.host = Registry.GetValue(chave, "Servername", "").ToString();
            dadosOdbc.port = Registry.GetValue(chave, "Port", "").ToString();
            dadosOdbc.banc = Registry.GetValue(chave, "Database", "").ToString();
            dadosOdbc.user = Registry.GetValue(chave, "Username", "").ToString();
            dadosOdbc.pass = Registry.GetValue(chave, "Password", "").ToString();

            NpgsqlDataReader reader = PostgresCmd(dadosOdbc.host, dadosOdbc.port, dadosOdbc.user, dadosOdbc.pass, "SELECT version()");
            if (reader != null) return dadosOdbc;
            else return null;
        }

        public string PgVersion(string host, string port, string user, string pass)
        {
            NpgsqlDataReader reader = PostgresCmd(host, port, user, pass, "SELECT version()");
            string vers =  reader.GetString(0);
            //reader.Close();
            return vers;
        }


        private void btnPswPg_Click(object sender, EventArgs e)
        {
            if (txtPswPostgres.UseSystemPasswordChar)
            {
                btnPswPg.ImageIndex = 0;
                tpPswPg.SetToolTip(this.btnPswPg, "Ocultar senha");
            }
            else
            {
                btnPswPg.ImageIndex = 1;
                tpPswPg.SetToolTip(this.btnPswPg, "Mostrar senha");
            }
            txtPswPostgres.UseSystemPasswordChar = !txtPswPostgres.UseSystemPasswordChar;
        }

        private void btnGoogle_Click(object sender, EventArgs e)
        {
            var credencial = GoogleDrive.Autentica();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lstTime.Items.Add(dtHoraBackup.Value.ToShortTimeString());
            listaHoras.Add(dtHoraBackup.Value.ToShortTimeString());
            //configuracoes.Default.Lsthorabackup = listaHoras;
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            string vers = PgVersion(txtIP.Text, txtPorta.Text, txtUser.Text, txtPswPostgres.Text);
            if (!String.IsNullOrEmpty(vers))
            {
                MessageBox.Show("Conectado.\n" + vers);
            }

        }
    }
}
