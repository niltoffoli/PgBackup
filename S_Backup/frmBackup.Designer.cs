using System;
namespace ProdanBackup
{
    partial class frmBackup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBackup));
            this.tray = new System.Windows.Forms.NotifyIcon(this.components);
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.pgbarStatus = new System.Windows.Forms.ProgressBar();
            this.btnConfig = new System.Windows.Forms.Button();
            this.btnAtivaServ = new System.Windows.Forms.Button();
            this.btnManBkp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tray
            // 
            this.tray.Icon = ((System.Drawing.Icon)(resources.GetObject("tray.Icon")));
            this.tray.Text = "Backup";
            this.tray.Visible = true;
            this.tray.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // rtbOutput
            // 
            this.rtbOutput.BackColor = System.Drawing.SystemColors.InfoText;
            this.rtbOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbOutput.DetectUrls = false;
            this.rtbOutput.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbOutput.Location = new System.Drawing.Point(11, 12);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.ReadOnly = true;
            this.rtbOutput.Size = new System.Drawing.Size(451, 233);
            this.rtbOutput.TabIndex = 16;
            this.rtbOutput.TabStop = false;
            this.rtbOutput.Text = "";
            // 
            // pgbarStatus
            // 
            this.pgbarStatus.BackColor = System.Drawing.SystemColors.Control;
            this.pgbarStatus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pgbarStatus.Location = new System.Drawing.Point(11, 251);
            this.pgbarStatus.Name = "pgbarStatus";
            this.pgbarStatus.Size = new System.Drawing.Size(450, 20);
            this.pgbarStatus.TabIndex = 18;
            // 
            // btnConfig
            // 
            this.btnConfig.BackColor = System.Drawing.SystemColors.Control;
            this.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfig.Image = global::ProdanBackup.Properties.Resources.config2;
            this.btnConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfig.Location = new System.Drawing.Point(108, 303);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(114, 25);
            this.btnConfig.TabIndex = 19;
            this.btnConfig.Text = "Configurações";
            this.btnConfig.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfig.UseVisualStyleBackColor = false;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // btnAtivaServ
            // 
            this.btnAtivaServ.BackColor = System.Drawing.SystemColors.Control;
            this.btnAtivaServ.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAtivaServ.Image = global::ProdanBackup.Properties.Resources.process_accept;
            this.btnAtivaServ.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtivaServ.Location = new System.Drawing.Point(348, 303);
            this.btnAtivaServ.Name = "btnAtivaServ";
            this.btnAtivaServ.Size = new System.Drawing.Size(114, 25);
            this.btnAtivaServ.TabIndex = 15;
            this.btnAtivaServ.Text = "Ativar Serviço";
            this.btnAtivaServ.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAtivaServ.UseVisualStyleBackColor = false;
            // 
            // btnManBkp
            // 
            this.btnManBkp.BackColor = System.Drawing.SystemColors.Control;
            this.btnManBkp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnManBkp.Image = global::ProdanBackup.Properties.Resources.bkp;
            this.btnManBkp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManBkp.Location = new System.Drawing.Point(228, 303);
            this.btnManBkp.Name = "btnManBkp";
            this.btnManBkp.Size = new System.Drawing.Size(114, 25);
            this.btnManBkp.TabIndex = 14;
            this.btnManBkp.Text = "Backup Manual";
            this.btnManBkp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnManBkp.UseVisualStyleBackColor = false;
            // 
            // frmBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(474, 340);
            this.Controls.Add(this.btnConfig);
            this.Controls.Add(this.pgbarStatus);
            this.Controls.Add(this.rtbOutput);
            this.Controls.Add(this.btnAtivaServ);
            this.Controls.Add(this.btnManBkp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBackup";
            this.Text = "Prodan Backup";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon tray;
        private System.Windows.Forms.Button btnManBkp;
        private System.Windows.Forms.Button btnAtivaServ;
        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.ProgressBar pgbarStatus;
        private System.Windows.Forms.Button btnConfig;
    }
}

