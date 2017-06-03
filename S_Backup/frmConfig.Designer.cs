namespace ProdanBackup
{
    partial class frmConfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfig));
            this.groupDrive = new System.Windows.Forms.GroupBox();
            this.labelGoogle = new System.Windows.Forms.Label();
            this.btnGoogle = new System.Windows.Forms.Button();
            this.groupDB = new System.Windows.Forms.GroupBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnPswPg = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.txtPorta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPswPostgres = new System.Windows.Forms.TextBox();
            this.txtBanco = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.groupDate = new System.Windows.Forms.GroupBox();
            this.chkAll = new System.Windows.Forms.CheckBox();
            this.chkSab = new System.Windows.Forms.CheckBox();
            this.chkDom = new System.Windows.Forms.CheckBox();
            this.chkQua = new System.Windows.Forms.CheckBox();
            this.chkSex = new System.Windows.Forms.CheckBox();
            this.chkQui = new System.Windows.Forms.CheckBox();
            this.chkTer = new System.Windows.Forms.CheckBox();
            this.chkSeg = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnRem = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lstTime = new System.Windows.Forms.ListView();
            this.colunaHora = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.l_horario = new System.Windows.Forms.Label();
            this.dtHoraBackup = new System.Windows.Forms.DateTimePicker();
            this.l_destino = new System.Windows.Forms.Label();
            this.txtDest = new System.Windows.Forms.TextBox();
            this.groupOpt = new System.Windows.Forms.GroupBox();
            this.chkDB = new System.Windows.Forms.CheckBox();
            this.chkSync = new System.Windows.Forms.CheckBox();
            this.chkXML = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAdc = new System.Windows.Forms.Button();
            this.cmbDrives = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDest = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.groupDrive.SuspendLayout();
            this.groupDB.SuspendLayout();
            this.groupDate.SuspendLayout();
            this.groupOpt.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupDrive
            // 
            this.groupDrive.Controls.Add(this.labelGoogle);
            this.groupDrive.Controls.Add(this.btnGoogle);
            this.groupDrive.Location = new System.Drawing.Point(330, 263);
            this.groupDrive.Name = "groupDrive";
            this.groupDrive.Size = new System.Drawing.Size(303, 85);
            this.groupDrive.TabIndex = 11;
            this.groupDrive.TabStop = false;
            this.groupDrive.Text = "Google Drive";
            // 
            // labelGoogle
            // 
            this.labelGoogle.AutoSize = true;
            this.labelGoogle.Location = new System.Drawing.Point(9, 43);
            this.labelGoogle.Name = "labelGoogle";
            this.labelGoogle.Size = new System.Drawing.Size(0, 13);
            this.labelGoogle.TabIndex = 16;
            // 
            // btnGoogle
            // 
            this.btnGoogle.BackColor = System.Drawing.SystemColors.Control;
            this.btnGoogle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGoogle.Image = global::ProdanBackup.Properties.Resources.drive;
            this.btnGoogle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGoogle.Location = new System.Drawing.Point(169, 26);
            this.btnGoogle.Name = "btnGoogle";
            this.btnGoogle.Size = new System.Drawing.Size(121, 30);
            this.btnGoogle.TabIndex = 0;
            this.btnGoogle.Text = "Autorizar";
            this.btnGoogle.UseVisualStyleBackColor = false;
            this.btnGoogle.Click += new System.EventHandler(this.btnGoogle_Click);
            // 
            // groupDB
            // 
            this.groupDB.Controls.Add(this.txtUser);
            this.groupDB.Controls.Add(this.label6);
            this.groupDB.Controls.Add(this.btnTest);
            this.groupDB.Controls.Add(this.btnPswPg);
            this.groupDB.Controls.Add(this.label4);
            this.groupDB.Controls.Add(this.txtPorta);
            this.groupDB.Controls.Add(this.label3);
            this.groupDB.Controls.Add(this.txtPswPostgres);
            this.groupDB.Controls.Add(this.txtBanco);
            this.groupDB.Controls.Add(this.label2);
            this.groupDB.Controls.Add(this.label1);
            this.groupDB.Controls.Add(this.txtIP);
            this.groupDB.Location = new System.Drawing.Point(12, 132);
            this.groupDB.Name = "groupDB";
            this.groupDB.Size = new System.Drawing.Size(303, 122);
            this.groupDB.TabIndex = 9;
            this.groupDB.TabStop = false;
            this.groupDB.Text = "Dados de Acesso ao Banco";
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.SystemColors.Info;
            this.txtUser.Location = new System.Drawing.Point(159, 40);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(84, 20);
            this.txtUser.TabIndex = 19;
            this.txtUser.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(156, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Usuario";
            // 
            // btnTest
            // 
            this.btnTest.BackColor = System.Drawing.SystemColors.Control;
            this.btnTest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTest.Image = global::ProdanBackup.Properties.Resources.conn;
            this.btnTest.Location = new System.Drawing.Point(249, 40);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(38, 25);
            this.btnTest.TabIndex = 11;
            this.btnTest.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTest.UseVisualStyleBackColor = false;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnPswPg
            // 
            this.btnPswPg.BackColor = System.Drawing.SystemColors.Info;
            this.btnPswPg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPswPg.FlatAppearance.BorderSize = 0;
            this.btnPswPg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPswPg.ImageIndex = 1;
            this.btnPswPg.ImageList = this.imageList1;
            this.btnPswPg.Location = new System.Drawing.Point(266, 80);
            this.btnPswPg.Name = "btnPswPg";
            this.btnPswPg.Size = new System.Drawing.Size(17, 17);
            this.btnPswPg.TabIndex = 17;
            this.btnPswPg.TabStop = false;
            this.btnPswPg.UseVisualStyleBackColor = false;
            this.btnPswPg.Click += new System.EventHandler(this.btnPswPg_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "hide.png");
            this.imageList1.Images.SetKeyName(1, "show.png");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Porta";
            // 
            // txtPorta
            // 
            this.txtPorta.BackColor = System.Drawing.SystemColors.Info;
            this.txtPorta.Location = new System.Drawing.Point(114, 40);
            this.txtPorta.Name = "txtPorta";
            this.txtPorta.Size = new System.Drawing.Size(39, 20);
            this.txtPorta.TabIndex = 12;
            this.txtPorta.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Senha Postgres";
            // 
            // txtPswPostgres
            // 
            this.txtPswPostgres.BackColor = System.Drawing.SystemColors.Info;
            this.txtPswPostgres.Location = new System.Drawing.Point(114, 79);
            this.txtPswPostgres.Name = "txtPswPostgres";
            this.txtPswPostgres.Size = new System.Drawing.Size(173, 20);
            this.txtPswPostgres.TabIndex = 4;
            this.txtPswPostgres.TabStop = false;
            this.txtPswPostgres.UseSystemPasswordChar = true;
            // 
            // txtBanco
            // 
            this.txtBanco.BackColor = System.Drawing.SystemColors.Info;
            this.txtBanco.Location = new System.Drawing.Point(6, 79);
            this.txtBanco.Name = "txtBanco";
            this.txtBanco.Size = new System.Drawing.Size(102, 20);
            this.txtBanco.TabIndex = 3;
            this.txtBanco.TabStop = false;
            this.txtBanco.Tag = "888";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Banco";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP";
            // 
            // txtIP
            // 
            this.txtIP.BackColor = System.Drawing.SystemColors.Info;
            this.txtIP.Location = new System.Drawing.Point(6, 40);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(102, 20);
            this.txtIP.TabIndex = 0;
            this.txtIP.TabStop = false;
            // 
            // groupDate
            // 
            this.groupDate.Controls.Add(this.chkAll);
            this.groupDate.Controls.Add(this.chkSab);
            this.groupDate.Controls.Add(this.chkDom);
            this.groupDate.Controls.Add(this.chkQua);
            this.groupDate.Controls.Add(this.chkSex);
            this.groupDate.Controls.Add(this.chkQui);
            this.groupDate.Controls.Add(this.chkTer);
            this.groupDate.Controls.Add(this.chkSeg);
            this.groupDate.Controls.Add(this.label9);
            this.groupDate.Controls.Add(this.btnRem);
            this.groupDate.Controls.Add(this.btnAdd);
            this.groupDate.Controls.Add(this.lstTime);
            this.groupDate.Controls.Add(this.button1);
            this.groupDate.Controls.Add(this.l_horario);
            this.groupDate.Controls.Add(this.dtHoraBackup);
            this.groupDate.Location = new System.Drawing.Point(330, 12);
            this.groupDate.Name = "groupDate";
            this.groupDate.Size = new System.Drawing.Size(303, 242);
            this.groupDate.TabIndex = 10;
            this.groupDate.TabStop = false;
            this.groupDate.Text = "Agendamento";
            // 
            // chkAll
            // 
            this.chkAll.AutoSize = true;
            this.chkAll.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.chkAll.Location = new System.Drawing.Point(14, 51);
            this.chkAll.Name = "chkAll";
            this.chkAll.Size = new System.Drawing.Size(41, 31);
            this.chkAll.TabIndex = 22;
            this.chkAll.Text = "Todos";
            this.chkAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkAll.UseVisualStyleBackColor = true;
            // 
            // chkSab
            // 
            this.chkSab.AutoSize = true;
            this.chkSab.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.chkSab.Location = new System.Drawing.Point(251, 51);
            this.chkSab.Name = "chkSab";
            this.chkSab.Size = new System.Drawing.Size(18, 31);
            this.chkSab.TabIndex = 21;
            this.chkSab.Text = "S";
            this.chkSab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkSab.UseVisualStyleBackColor = true;
            // 
            // chkDom
            // 
            this.chkDom.AutoSize = true;
            this.chkDom.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.chkDom.Location = new System.Drawing.Point(275, 51);
            this.chkDom.Name = "chkDom";
            this.chkDom.Size = new System.Drawing.Size(19, 31);
            this.chkDom.TabIndex = 20;
            this.chkDom.Text = "D";
            this.chkDom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkDom.UseVisualStyleBackColor = true;
            // 
            // chkQua
            // 
            this.chkQua.AutoSize = true;
            this.chkQua.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.chkQua.Location = new System.Drawing.Point(177, 51);
            this.chkQua.Name = "chkQua";
            this.chkQua.Size = new System.Drawing.Size(19, 31);
            this.chkQua.TabIndex = 19;
            this.chkQua.Text = "Q";
            this.chkQua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkQua.UseVisualStyleBackColor = true;
            // 
            // chkSex
            // 
            this.chkSex.AutoSize = true;
            this.chkSex.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.chkSex.Location = new System.Drawing.Point(227, 51);
            this.chkSex.Name = "chkSex";
            this.chkSex.Size = new System.Drawing.Size(18, 31);
            this.chkSex.TabIndex = 18;
            this.chkSex.Text = "S";
            this.chkSex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkSex.UseVisualStyleBackColor = true;
            // 
            // chkQui
            // 
            this.chkQui.AutoSize = true;
            this.chkQui.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.chkQui.Location = new System.Drawing.Point(202, 51);
            this.chkQui.Name = "chkQui";
            this.chkQui.Size = new System.Drawing.Size(19, 31);
            this.chkQui.TabIndex = 17;
            this.chkQui.Text = "Q";
            this.chkQui.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkQui.UseVisualStyleBackColor = true;
            // 
            // chkTer
            // 
            this.chkTer.AutoSize = true;
            this.chkTer.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.chkTer.Location = new System.Drawing.Point(153, 51);
            this.chkTer.Name = "chkTer";
            this.chkTer.Size = new System.Drawing.Size(18, 31);
            this.chkTer.TabIndex = 16;
            this.chkTer.Text = "T";
            this.chkTer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkTer.UseVisualStyleBackColor = true;
            // 
            // chkSeg
            // 
            this.chkSeg.AutoSize = true;
            this.chkSeg.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.chkSeg.Location = new System.Drawing.Point(129, 51);
            this.chkSeg.Name = "chkSeg";
            this.chkSeg.Size = new System.Drawing.Size(18, 31);
            this.chkSeg.TabIndex = 15;
            this.chkSeg.Text = "S";
            this.chkSeg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkSeg.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Dias da semana";
            // 
            // btnRem
            // 
            this.btnRem.BackColor = System.Drawing.SystemColors.Control;
            this.btnRem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRem.Image = global::ProdanBackup.Properties.Resources.rem;
            this.btnRem.Location = new System.Drawing.Point(273, 114);
            this.btnRem.Name = "btnRem";
            this.btnRem.Size = new System.Drawing.Size(21, 21);
            this.btnRem.TabIndex = 13;
            this.btnRem.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Image = global::ProdanBackup.Properties.Resources.add1;
            this.btnAdd.Location = new System.Drawing.Point(246, 114);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(21, 21);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lstTime
            // 
            this.lstTime.BackColor = System.Drawing.SystemColors.Info;
            this.lstTime.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colunaHora});
            this.lstTime.Location = new System.Drawing.Point(14, 150);
            this.lstTime.Name = "lstTime";
            this.lstTime.Size = new System.Drawing.Size(280, 69);
            this.lstTime.TabIndex = 9;
            this.lstTime.TileSize = new System.Drawing.Size(160, 30);
            this.lstTime.UseCompatibleStateImageBehavior = false;
            this.lstTime.View = System.Windows.Forms.View.List;
            // 
            // colunaHora
            // 
            this.colunaHora.Width = 35;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(311, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Agendar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // l_horario
            // 
            this.l_horario.AutoSize = true;
            this.l_horario.Location = new System.Drawing.Point(11, 95);
            this.l_horario.Name = "l_horario";
            this.l_horario.Size = new System.Drawing.Size(90, 13);
            this.l_horario.TabIndex = 5;
            this.l_horario.Text = "Horários de cópia";
            // 
            // dtHoraBackup
            // 
            this.dtHoraBackup.CalendarForeColor = System.Drawing.SystemColors.Info;
            this.dtHoraBackup.CalendarMonthBackground = System.Drawing.SystemColors.Info;
            this.dtHoraBackup.CalendarTitleBackColor = System.Drawing.SystemColors.Info;
            this.dtHoraBackup.CalendarTitleForeColor = System.Drawing.SystemColors.Info;
            this.dtHoraBackup.CalendarTrailingForeColor = System.Drawing.SystemColors.Info;
            this.dtHoraBackup.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtHoraBackup.Location = new System.Drawing.Point(14, 115);
            this.dtHoraBackup.Name = "dtHoraBackup";
            this.dtHoraBackup.Size = new System.Drawing.Size(98, 20);
            this.dtHoraBackup.TabIndex = 2;
            // 
            // l_destino
            // 
            this.l_destino.AutoSize = true;
            this.l_destino.Location = new System.Drawing.Point(6, 76);
            this.l_destino.Name = "l_destino";
            this.l_destino.Size = new System.Drawing.Size(73, 13);
            this.l_destino.TabIndex = 9;
            this.l_destino.Text = "Destino Cópia";
            // 
            // txtDest
            // 
            this.txtDest.BackColor = System.Drawing.SystemColors.Info;
            this.txtDest.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDest.Location = new System.Drawing.Point(6, 92);
            this.txtDest.Name = "txtDest";
            this.txtDest.Size = new System.Drawing.Size(259, 20);
            this.txtDest.TabIndex = 4;
            // 
            // groupOpt
            // 
            this.groupOpt.Controls.Add(this.chkDB);
            this.groupOpt.Controls.Add(this.chkSync);
            this.groupOpt.Controls.Add(this.chkXML);
            this.groupOpt.Location = new System.Drawing.Point(12, 12);
            this.groupOpt.Name = "groupOpt";
            this.groupOpt.Size = new System.Drawing.Size(303, 114);
            this.groupOpt.TabIndex = 18;
            this.groupOpt.TabStop = false;
            this.groupOpt.Text = "Opções de Backup";
            // 
            // chkDB
            // 
            this.chkDB.AutoSize = true;
            this.chkDB.Location = new System.Drawing.Point(6, 28);
            this.chkDB.Name = "chkDB";
            this.chkDB.Size = new System.Drawing.Size(159, 17);
            this.chkDB.TabIndex = 2;
            this.chkDB.Text = "Backup do Banco de dados";
            this.chkDB.UseVisualStyleBackColor = true;
            // 
            // chkSync
            // 
            this.chkSync.AutoSize = true;
            this.chkSync.Location = new System.Drawing.Point(6, 74);
            this.chkSync.Name = "chkSync";
            this.chkSync.Size = new System.Drawing.Size(122, 17);
            this.chkSync.TabIndex = 1;
            this.chkSync.Text = "Sincronizar Arquivos";
            this.chkSync.UseVisualStyleBackColor = true;
            // 
            // chkXML
            // 
            this.chkXML.AutoSize = true;
            this.chkXML.Location = new System.Drawing.Point(6, 51);
            this.chkXML.Name = "chkXML";
            this.chkXML.Size = new System.Drawing.Size(147, 17);
            this.chkXML.TabIndex = 0;
            this.chkXML.Text = "Backup de Arquivos XML";
            this.chkXML.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.textBox1);
            this.groupBox5.Controls.Add(this.btnAdc);
            this.groupBox5.Controls.Add(this.cmbDrives);
            this.groupBox5.Controls.Add(this.l_destino);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.txtDest);
            this.groupBox5.Controls.Add(this.btnDest);
            this.groupBox5.Location = new System.Drawing.Point(12, 263);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(303, 176);
            this.groupBox5.TabIndex = 20;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Arquivos";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Cópia Adicional";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Info;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(6, 133);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(259, 20);
            this.textBox1.TabIndex = 14;
            // 
            // btnAdc
            // 
            this.btnAdc.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdc.Image = global::ProdanBackup.Properties.Resources.browse;
            this.btnAdc.Location = new System.Drawing.Point(266, 133);
            this.btnAdc.Name = "btnAdc";
            this.btnAdc.Size = new System.Drawing.Size(21, 21);
            this.btnAdc.TabIndex = 13;
            this.btnAdc.UseVisualStyleBackColor = false;
            // 
            // cmbDrives
            // 
            this.cmbDrives.BackColor = System.Drawing.SystemColors.Info;
            this.cmbDrives.FormattingEnabled = true;
            this.cmbDrives.Location = new System.Drawing.Point(6, 46);
            this.cmbDrives.Name = "cmbDrives";
            this.cmbDrives.Size = new System.Drawing.Size(121, 21);
            this.cmbDrives.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Unidade do Servidor";
            // 
            // btnDest
            // 
            this.btnDest.BackColor = System.Drawing.SystemColors.Control;
            this.btnDest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDest.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDest.Image = global::ProdanBackup.Properties.Resources.browse;
            this.btnDest.Location = new System.Drawing.Point(266, 92);
            this.btnDest.Name = "btnDest";
            this.btnDest.Size = new System.Drawing.Size(21, 21);
            this.btnDest.TabIndex = 3;
            this.btnDest.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Image = global::ProdanBackup.Properties.Resources.cancel;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(374, 400);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(121, 30);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.SystemColors.Control;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalvar.Image = global::ProdanBackup.Properties.Resources.ok;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(501, 400);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(121, 30);
            this.btnSalvar.TabIndex = 17;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            // 
            // frmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 451);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupOpt);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.groupDrive);
            this.Controls.Add(this.groupDB);
            this.Controls.Add(this.groupDate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConfig";
            this.Text = "Configurações";
            this.Load += new System.EventHandler(this.frmConfig_Load);
            this.groupDrive.ResumeLayout(false);
            this.groupDrive.PerformLayout();
            this.groupDB.ResumeLayout(false);
            this.groupDB.PerformLayout();
            this.groupDate.ResumeLayout(false);
            this.groupDate.PerformLayout();
            this.groupOpt.ResumeLayout(false);
            this.groupOpt.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupDrive;
        private System.Windows.Forms.Label labelGoogle;
        private System.Windows.Forms.Button btnGoogle;
        private System.Windows.Forms.GroupBox groupDB;
        private System.Windows.Forms.Button btnPswPg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPorta;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPswPostgres;
        private System.Windows.Forms.TextBox txtBanco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.GroupBox groupDate;
        private System.Windows.Forms.Label l_destino;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label l_horario;
        private System.Windows.Forms.TextBox txtDest;
        private System.Windows.Forms.Button btnDest;
        private System.Windows.Forms.DateTimePicker dtHoraBackup;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.GroupBox groupOpt;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox chkDB;
        private System.Windows.Forms.CheckBox chkSync;
        private System.Windows.Forms.CheckBox chkXML;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView lstTime;
        private System.Windows.Forms.Button btnRem;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ColumnHeader colunaHora;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnAdc;
        private System.Windows.Forms.ComboBox cmbDrives;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chkAll;
        private System.Windows.Forms.CheckBox chkSab;
        private System.Windows.Forms.CheckBox chkDom;
        private System.Windows.Forms.CheckBox chkQua;
        private System.Windows.Forms.CheckBox chkSex;
        private System.Windows.Forms.CheckBox chkQui;
        private System.Windows.Forms.CheckBox chkTer;
        private System.Windows.Forms.CheckBox chkSeg;
    }
}