namespace MaisonDesLigues_2
{
    partial class FrmPrincipale
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipale));
            this.GrpParticipant = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CmbParticipant = new System.Windows.Forms.ComboBox();
            this.LbNomParticipant = new System.Windows.Forms.Label();
            this.PanArrivéParticipant = new System.Windows.Forms.Panel();
            this.BtnEnregistreArrivé = new System.Windows.Forms.Button();
            this.GrpInfoParticipant = new System.Windows.Forms.GroupBox();
            this.TxtTélParticipant = new System.Windows.Forms.MaskedTextBox();
            this.TxtMailParticipant = new System.Windows.Forms.MaskedTextBox();
            this.LbMailParticipant = new System.Windows.Forms.Label();
            this.LbTélParticipant = new System.Windows.Forms.Label();
            this.TxtVilleParticipant = new System.Windows.Forms.MaskedTextBox();
            this.LbVilleParticipant = new System.Windows.Forms.Label();
            this.TxtCpParticipant = new System.Windows.Forms.MaskedTextBox();
            this.LbCpParticipant = new System.Windows.Forms.Label();
            this.TxtAdresse2 = new System.Windows.Forms.MaskedTextBox();
            this.TxtAdresse1 = new System.Windows.Forms.MaskedTextBox();
            this.LbAdresse = new System.Windows.Forms.Label();
            this.GrpCléWifi = new System.Windows.Forms.GroupBox();
            this.RdbWifiNon = new System.Windows.Forms.RadioButton();
            this.RdbWifiOui = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnQuitter = new System.Windows.Forms.Button();
            this.picEncode = new System.Windows.Forms.PictureBox();
            this.BtnImprimQrCode = new System.Windows.Forms.Button();
            this.printQrCode = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.PanBtnQrCode = new System.Windows.Forms.Panel();
            this.BtnNewEnregistrementPart = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picCléwifi = new System.Windows.Forms.PictureBox();
            this.GrpParticipant.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.PanArrivéParticipant.SuspendLayout();
            this.GrpInfoParticipant.SuspendLayout();
            this.GrpCléWifi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEncode)).BeginInit();
            this.PanBtnQrCode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCléwifi)).BeginInit();
            this.SuspendLayout();
            // 
            // GrpParticipant
            // 
            this.GrpParticipant.Controls.Add(this.groupBox1);
            this.GrpParticipant.Controls.Add(this.PanArrivéParticipant);
            this.GrpParticipant.Location = new System.Drawing.Point(12, 12);
            this.GrpParticipant.Name = "GrpParticipant";
            this.GrpParticipant.Size = new System.Drawing.Size(542, 478);
            this.GrpParticipant.TabIndex = 0;
            this.GrpParticipant.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CmbParticipant);
            this.groupBox1.Controls.Add(this.LbNomParticipant);
            this.groupBox1.Location = new System.Drawing.Point(22, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 81);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recherche Participant";
            // 
            // CmbParticipant
            // 
            this.CmbParticipant.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CmbParticipant.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmbParticipant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CmbParticipant.DropDownHeight = 95;
            this.CmbParticipant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbParticipant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbParticipant.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CmbParticipant.FormattingEnabled = true;
            this.CmbParticipant.IntegralHeight = false;
            this.CmbParticipant.ItemHeight = 16;
            this.CmbParticipant.Location = new System.Drawing.Point(215, 32);
            this.CmbParticipant.MaxDropDownItems = 4;
            this.CmbParticipant.Name = "CmbParticipant";
            this.CmbParticipant.Size = new System.Drawing.Size(204, 24);
            this.CmbParticipant.TabIndex = 5;
            this.CmbParticipant.SelectionChangeCommitted += new System.EventHandler(this.CmbParticipant_SelectionChangeCommitted);
            // 
            // LbNomParticipant
            // 
            this.LbNomParticipant.AutoSize = true;
            this.LbNomParticipant.Location = new System.Drawing.Point(16, 37);
            this.LbNomParticipant.Name = "LbNomParticipant";
            this.LbNomParticipant.Size = new System.Drawing.Size(177, 13);
            this.LbNomParticipant.TabIndex = 3;
            this.LbNomParticipant.Text = "Veuillez séléctionner un Participant :";
            // 
            // PanArrivéParticipant
            // 
            this.PanArrivéParticipant.Controls.Add(this.BtnEnregistreArrivé);
            this.PanArrivéParticipant.Controls.Add(this.GrpInfoParticipant);
            this.PanArrivéParticipant.Controls.Add(this.GrpCléWifi);
            this.PanArrivéParticipant.Location = new System.Drawing.Point(6, 117);
            this.PanArrivéParticipant.Name = "PanArrivéParticipant";
            this.PanArrivéParticipant.Size = new System.Drawing.Size(530, 355);
            this.PanArrivéParticipant.TabIndex = 1;
            this.PanArrivéParticipant.Visible = false;
            // 
            // BtnEnregistreArrivé
            // 
            this.BtnEnregistreArrivé.Enabled = false;
            this.BtnEnregistreArrivé.Location = new System.Drawing.Point(363, 310);
            this.BtnEnregistreArrivé.Name = "BtnEnregistreArrivé";
            this.BtnEnregistreArrivé.Size = new System.Drawing.Size(153, 23);
            this.BtnEnregistreArrivé.TabIndex = 7;
            this.BtnEnregistreArrivé.Text = "Enregistrer Arrivé Participant";
            this.BtnEnregistreArrivé.UseVisualStyleBackColor = true;
            this.BtnEnregistreArrivé.Click += new System.EventHandler(this.BtnEnregistreArrivé_Click);
            // 
            // GrpInfoParticipant
            // 
            this.GrpInfoParticipant.Controls.Add(this.TxtTélParticipant);
            this.GrpInfoParticipant.Controls.Add(this.TxtMailParticipant);
            this.GrpInfoParticipant.Controls.Add(this.LbMailParticipant);
            this.GrpInfoParticipant.Controls.Add(this.LbTélParticipant);
            this.GrpInfoParticipant.Controls.Add(this.TxtVilleParticipant);
            this.GrpInfoParticipant.Controls.Add(this.LbVilleParticipant);
            this.GrpInfoParticipant.Controls.Add(this.TxtCpParticipant);
            this.GrpInfoParticipant.Controls.Add(this.LbCpParticipant);
            this.GrpInfoParticipant.Controls.Add(this.TxtAdresse2);
            this.GrpInfoParticipant.Controls.Add(this.TxtAdresse1);
            this.GrpInfoParticipant.Controls.Add(this.LbAdresse);
            this.GrpInfoParticipant.Location = new System.Drawing.Point(16, 3);
            this.GrpInfoParticipant.Name = "GrpInfoParticipant";
            this.GrpInfoParticipant.Size = new System.Drawing.Size(500, 196);
            this.GrpInfoParticipant.TabIndex = 6;
            this.GrpInfoParticipant.TabStop = false;
            this.GrpInfoParticipant.Text = "Informations du Participant";
            // 
            // TxtTélParticipant
            // 
            this.TxtTélParticipant.Enabled = false;
            this.TxtTélParticipant.Location = new System.Drawing.Point(81, 150);
            this.TxtTélParticipant.Name = "TxtTélParticipant";
            this.TxtTélParticipant.Size = new System.Drawing.Size(147, 20);
            this.TxtTélParticipant.TabIndex = 10;
            // 
            // TxtMailParticipant
            // 
            this.TxtMailParticipant.Enabled = false;
            this.TxtMailParticipant.Location = new System.Drawing.Point(290, 150);
            this.TxtMailParticipant.Name = "TxtMailParticipant";
            this.TxtMailParticipant.Size = new System.Drawing.Size(192, 20);
            this.TxtMailParticipant.TabIndex = 9;
            // 
            // LbMailParticipant
            // 
            this.LbMailParticipant.AutoSize = true;
            this.LbMailParticipant.Location = new System.Drawing.Point(252, 153);
            this.LbMailParticipant.Name = "LbMailParticipant";
            this.LbMailParticipant.Size = new System.Drawing.Size(32, 13);
            this.LbMailParticipant.TabIndex = 8;
            this.LbMailParticipant.Text = "Mail :";
            // 
            // LbTélParticipant
            // 
            this.LbTélParticipant.AutoSize = true;
            this.LbTélParticipant.Location = new System.Drawing.Point(34, 153);
            this.LbTélParticipant.Name = "LbTélParticipant";
            this.LbTélParticipant.Size = new System.Drawing.Size(28, 13);
            this.LbTélParticipant.TabIndex = 7;
            this.LbTélParticipant.Text = "Tél :";
            // 
            // TxtVilleParticipant
            // 
            this.TxtVilleParticipant.Enabled = false;
            this.TxtVilleParticipant.Location = new System.Drawing.Point(290, 114);
            this.TxtVilleParticipant.Name = "TxtVilleParticipant";
            this.TxtVilleParticipant.Size = new System.Drawing.Size(192, 20);
            this.TxtVilleParticipant.TabIndex = 6;
            // 
            // LbVilleParticipant
            // 
            this.LbVilleParticipant.AutoSize = true;
            this.LbVilleParticipant.Location = new System.Drawing.Point(252, 117);
            this.LbVilleParticipant.Name = "LbVilleParticipant";
            this.LbVilleParticipant.Size = new System.Drawing.Size(32, 13);
            this.LbVilleParticipant.TabIndex = 5;
            this.LbVilleParticipant.Text = "Ville :";
            // 
            // TxtCpParticipant
            // 
            this.TxtCpParticipant.Enabled = false;
            this.TxtCpParticipant.Location = new System.Drawing.Point(81, 114);
            this.TxtCpParticipant.Name = "TxtCpParticipant";
            this.TxtCpParticipant.Size = new System.Drawing.Size(147, 20);
            this.TxtCpParticipant.TabIndex = 4;
            // 
            // LbCpParticipant
            // 
            this.LbCpParticipant.AutoSize = true;
            this.LbCpParticipant.Location = new System.Drawing.Point(34, 117);
            this.LbCpParticipant.Name = "LbCpParticipant";
            this.LbCpParticipant.Size = new System.Drawing.Size(27, 13);
            this.LbCpParticipant.TabIndex = 3;
            this.LbCpParticipant.Text = "CP :";
            // 
            // TxtAdresse2
            // 
            this.TxtAdresse2.Enabled = false;
            this.TxtAdresse2.Location = new System.Drawing.Point(81, 66);
            this.TxtAdresse2.Name = "TxtAdresse2";
            this.TxtAdresse2.Size = new System.Drawing.Size(401, 20);
            this.TxtAdresse2.TabIndex = 2;
            // 
            // TxtAdresse1
            // 
            this.TxtAdresse1.Enabled = false;
            this.TxtAdresse1.Location = new System.Drawing.Point(81, 39);
            this.TxtAdresse1.Name = "TxtAdresse1";
            this.TxtAdresse1.Size = new System.Drawing.Size(401, 20);
            this.TxtAdresse1.TabIndex = 1;
            // 
            // LbAdresse
            // 
            this.LbAdresse.AutoSize = true;
            this.LbAdresse.Location = new System.Drawing.Point(16, 42);
            this.LbAdresse.Name = "LbAdresse";
            this.LbAdresse.Size = new System.Drawing.Size(45, 13);
            this.LbAdresse.TabIndex = 0;
            this.LbAdresse.Text = "Adresse";
            // 
            // GrpCléWifi
            // 
            this.GrpCléWifi.Controls.Add(this.RdbWifiNon);
            this.GrpCléWifi.Controls.Add(this.RdbWifiOui);
            this.GrpCléWifi.Controls.Add(this.label6);
            this.GrpCléWifi.Location = new System.Drawing.Point(16, 205);
            this.GrpCléWifi.Name = "GrpCléWifi";
            this.GrpCléWifi.Size = new System.Drawing.Size(500, 73);
            this.GrpCléWifi.TabIndex = 8;
            this.GrpCléWifi.TabStop = false;
            this.GrpCléWifi.Text = "Clé Wifi";
            // 
            // RdbWifiNon
            // 
            this.RdbWifiNon.AutoSize = true;
            this.RdbWifiNon.Checked = true;
            this.RdbWifiNon.Location = new System.Drawing.Point(290, 34);
            this.RdbWifiNon.Name = "RdbWifiNon";
            this.RdbWifiNon.Size = new System.Drawing.Size(45, 17);
            this.RdbWifiNon.TabIndex = 2;
            this.RdbWifiNon.TabStop = true;
            this.RdbWifiNon.Text = "Non";
            this.RdbWifiNon.UseVisualStyleBackColor = true;
            // 
            // RdbWifiOui
            // 
            this.RdbWifiOui.AutoSize = true;
            this.RdbWifiOui.Location = new System.Drawing.Point(206, 34);
            this.RdbWifiOui.Name = "RdbWifiOui";
            this.RdbWifiOui.Size = new System.Drawing.Size(41, 17);
            this.RdbWifiOui.TabIndex = 1;
            this.RdbWifiOui.Text = "Oui";
            this.RdbWifiOui.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Le Participant veut-il une clé wifi ?";
            // 
            // BtnQuitter
            // 
            this.BtnQuitter.Location = new System.Drawing.Point(766, 250);
            this.BtnQuitter.Name = "BtnQuitter";
            this.BtnQuitter.Size = new System.Drawing.Size(123, 33);
            this.BtnQuitter.TabIndex = 1;
            this.BtnQuitter.Text = "Quitter";
            this.BtnQuitter.UseVisualStyleBackColor = true;
            this.BtnQuitter.Click += new System.EventHandler(this.BtnQuitter_Click);
            // 
            // picEncode
            // 
            this.picEncode.Location = new System.Drawing.Point(560, 31);
            this.picEncode.Name = "picEncode";
            this.picEncode.Size = new System.Drawing.Size(191, 187);
            this.picEncode.TabIndex = 2;
            this.picEncode.TabStop = false;
            // 
            // BtnImprimQrCode
            // 
            this.BtnImprimQrCode.Location = new System.Drawing.Point(3, 3);
            this.BtnImprimQrCode.Name = "BtnImprimQrCode";
            this.BtnImprimQrCode.Size = new System.Drawing.Size(78, 27);
            this.BtnImprimQrCode.TabIndex = 4;
            this.BtnImprimQrCode.Text = "Imprimer";
            this.BtnImprimQrCode.UseVisualStyleBackColor = true;
            this.BtnImprimQrCode.Click += new System.EventHandler(this.BtnImprimQrCode_Click);
            // 
            // printQrCode
            // 
            this.printQrCode.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printQrCode_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printQrCode;
            this.printDialog1.UseEXDialog = true;
            // 
            // PanBtnQrCode
            // 
            this.PanBtnQrCode.Controls.Add(this.BtnNewEnregistrementPart);
            this.PanBtnQrCode.Controls.Add(this.BtnImprimQrCode);
            this.PanBtnQrCode.Location = new System.Drawing.Point(560, 250);
            this.PanBtnQrCode.Name = "PanBtnQrCode";
            this.PanBtnQrCode.Size = new System.Drawing.Size(191, 36);
            this.PanBtnQrCode.TabIndex = 5;
            this.PanBtnQrCode.Visible = false;
            // 
            // BtnNewEnregistrementPart
            // 
            this.BtnNewEnregistrementPart.Location = new System.Drawing.Point(87, 3);
            this.BtnNewEnregistrementPart.Name = "BtnNewEnregistrementPart";
            this.BtnNewEnregistrementPart.Size = new System.Drawing.Size(101, 27);
            this.BtnNewEnregistrementPart.TabIndex = 5;
            this.BtnNewEnregistrementPart.Text = "Nouveau Arrivé";
            this.BtnNewEnregistrementPart.UseVisualStyleBackColor = true;
            this.BtnNewEnregistrementPart.Click += new System.EventHandler(this.BtnNewEnregistrementPart_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MaisonDesLigues_2.Properties.Resources.affiche;
            this.pictureBox1.Location = new System.Drawing.Point(757, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 178);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // picCléwifi
            // 
            this.picCléwifi.Location = new System.Drawing.Point(560, 224);
            this.picCléwifi.Name = "picCléwifi";
            this.picCléwifi.Size = new System.Drawing.Size(274, 20);
            this.picCléwifi.TabIndex = 7;
            this.picCléwifi.TabStop = false;
            // 
            // FrmPrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(892, 502);
            this.Controls.Add(this.picCléwifi);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PanBtnQrCode);
            this.Controls.Add(this.picEncode);
            this.Controls.Add(this.BtnQuitter);
            this.Controls.Add(this.GrpParticipant);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmPrincipale";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmPrincipale_Load);
            this.GrpParticipant.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.PanArrivéParticipant.ResumeLayout(false);
            this.GrpInfoParticipant.ResumeLayout(false);
            this.GrpInfoParticipant.PerformLayout();
            this.GrpCléWifi.ResumeLayout(false);
            this.GrpCléWifi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEncode)).EndInit();
            this.PanBtnQrCode.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCléwifi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpParticipant;
        private System.Windows.Forms.Label LbNomParticipant;
        private System.Windows.Forms.Button BtnEnregistreArrivé;
        private System.Windows.Forms.GroupBox GrpInfoParticipant;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox TxtAdresse1;
        private System.Windows.Forms.Label LbAdresse;
        private System.Windows.Forms.GroupBox GrpCléWifi;
        private System.Windows.Forms.RadioButton RdbWifiNon;
        private System.Windows.Forms.RadioButton RdbWifiOui;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox TxtTélParticipant;
        private System.Windows.Forms.MaskedTextBox TxtMailParticipant;
        private System.Windows.Forms.Label LbMailParticipant;
        private System.Windows.Forms.Label LbTélParticipant;
        private System.Windows.Forms.MaskedTextBox TxtVilleParticipant;
        private System.Windows.Forms.Label LbVilleParticipant;
        private System.Windows.Forms.MaskedTextBox TxtCpParticipant;
        private System.Windows.Forms.Label LbCpParticipant;
        private System.Windows.Forms.MaskedTextBox TxtAdresse2;
        private System.Windows.Forms.Panel PanArrivéParticipant;
        private System.Windows.Forms.Button BtnQuitter;
        private System.Windows.Forms.PictureBox picEncode;
        private System.Windows.Forms.Button BtnImprimQrCode;
        private System.Drawing.Printing.PrintDocument printQrCode;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.ComboBox CmbParticipant;
        private System.Windows.Forms.Panel PanBtnQrCode;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnNewEnregistrementPart;
        private System.Windows.Forms.PictureBox picCléwifi;
    }
}

