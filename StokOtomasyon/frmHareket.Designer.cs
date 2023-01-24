namespace StokOtomasyon
{
    partial class frmHareket
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
            this.dgvHareket = new System.Windows.Forms.DataGridView();
            this.cFirmaAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHareketTuru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cStokID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDepoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMiktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFirmaAd = new System.Windows.Forms.TextBox();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.btnStokSec = new System.Windows.Forms.Button();
            this.btnDepoSec = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.lblStokAdiGoster2 = new System.Windows.Forms.Label();
            this.lblDepoAdiGoster = new System.Windows.Forms.Label();
            this.lblDepoAdiGoster1 = new System.Windows.Forms.Label();
            this.cmbHareketTuru = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHareket)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHareket
            // 
            this.dgvHareket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHareket.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cFirmaAdi,
            this.cHareketTuru,
            this.cStokID,
            this.cDepoID,
            this.cMiktar});
            this.dgvHareket.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvHareket.Location = new System.Drawing.Point(0, 142);
            this.dgvHareket.Name = "dgvHareket";
            this.dgvHareket.ReadOnly = true;
            this.dgvHareket.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHareket.Size = new System.Drawing.Size(543, 261);
            this.dgvHareket.TabIndex = 0;
            // 
            // cFirmaAdi
            // 
            this.cFirmaAdi.DataPropertyName = "FirmaAdi";
            this.cFirmaAdi.HeaderText = "Firma Adı";
            this.cFirmaAdi.Name = "cFirmaAdi";
            this.cFirmaAdi.ReadOnly = true;
            // 
            // cHareketTuru
            // 
            this.cHareketTuru.DataPropertyName = "HareketTuru";
            this.cHareketTuru.HeaderText = "Hareket Türü";
            this.cHareketTuru.Name = "cHareketTuru";
            this.cHareketTuru.ReadOnly = true;
            // 
            // cStokID
            // 
            this.cStokID.DataPropertyName = "StokID";
            this.cStokID.HeaderText = "StokID";
            this.cStokID.Name = "cStokID";
            this.cStokID.ReadOnly = true;
            // 
            // cDepoID
            // 
            this.cDepoID.DataPropertyName = "DepoID";
            this.cDepoID.HeaderText = "Depo ID";
            this.cDepoID.Name = "cDepoID";
            this.cDepoID.ReadOnly = true;
            // 
            // cMiktar
            // 
            this.cMiktar.DataPropertyName = "Miktar";
            this.cMiktar.HeaderText = "Miktar";
            this.cMiktar.Name = "cMiktar";
            this.cMiktar.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Firma Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Miktar:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(297, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Stok:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(296, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Depo:";
            // 
            // txtFirmaAd
            // 
            this.txtFirmaAd.Location = new System.Drawing.Point(104, 22);
            this.txtFirmaAd.Name = "txtFirmaAd";
            this.txtFirmaAd.Size = new System.Drawing.Size(151, 20);
            this.txtFirmaAd.TabIndex = 0;
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(104, 48);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(151, 20);
            this.txtMiktar.TabIndex = 1;
            // 
            // btnStokSec
            // 
            this.btnStokSec.Location = new System.Drawing.Point(419, 33);
            this.btnStokSec.Name = "btnStokSec";
            this.btnStokSec.Size = new System.Drawing.Size(70, 23);
            this.btnStokSec.TabIndex = 3;
            this.btnStokSec.Text = "Stok Seç";
            this.btnStokSec.UseVisualStyleBackColor = true;
            this.btnStokSec.Click += new System.EventHandler(this.btnStokSec_Click);
            // 
            // btnDepoSec
            // 
            this.btnDepoSec.Location = new System.Drawing.Point(419, 62);
            this.btnDepoSec.Name = "btnDepoSec";
            this.btnDepoSec.Size = new System.Drawing.Size(70, 23);
            this.btnDepoSec.TabIndex = 4;
            this.btnDepoSec.Text = "Depo Seç";
            this.btnDepoSec.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDepoSec.UseVisualStyleBackColor = true;
            this.btnDepoSec.Click += new System.EventHandler(this.btnDepoSec_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(28, 101);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(227, 35);
            this.btnKaydet.TabIndex = 5;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // lblStokAdiGoster2
            // 
            this.lblStokAdiGoster2.AutoSize = true;
            this.lblStokAdiGoster2.Location = new System.Drawing.Point(335, 38);
            this.lblStokAdiGoster2.Name = "lblStokAdiGoster2";
            this.lblStokAdiGoster2.Size = new System.Drawing.Size(75, 13);
            this.lblStokAdiGoster2.TabIndex = 9;
            this.lblStokAdiGoster2.Text = "Stok Seçiniz...";
            // 
            // lblDepoAdiGoster
            // 
            this.lblDepoAdiGoster.AutoSize = true;
            this.lblDepoAdiGoster.Location = new System.Drawing.Point(101, 109);
            this.lblDepoAdiGoster.Name = "lblDepoAdiGoster";
            this.lblDepoAdiGoster.Size = new System.Drawing.Size(79, 13);
            this.lblDepoAdiGoster.TabIndex = 10;
            this.lblDepoAdiGoster.Text = "Depo Seçiniz...";
            // 
            // lblDepoAdiGoster1
            // 
            this.lblDepoAdiGoster1.AutoSize = true;
            this.lblDepoAdiGoster1.Location = new System.Drawing.Point(335, 68);
            this.lblDepoAdiGoster1.Name = "lblDepoAdiGoster1";
            this.lblDepoAdiGoster1.Size = new System.Drawing.Size(79, 13);
            this.lblDepoAdiGoster1.TabIndex = 12;
            this.lblDepoAdiGoster1.Text = "Depo Seçiniz...";
            // 
            // cmbHareketTuru
            // 
            this.cmbHareketTuru.FormattingEnabled = true;
            this.cmbHareketTuru.Items.AddRange(new object[] {
            "Giriş",
            "Çıkış"});
            this.cmbHareketTuru.Location = new System.Drawing.Point(104, 74);
            this.cmbHareketTuru.Name = "cmbHareketTuru";
            this.cmbHareketTuru.Size = new System.Drawing.Size(151, 21);
            this.cmbHareketTuru.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Hareket Türü:";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(281, 101);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(214, 35);
            this.btnSil.TabIndex = 14;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // frmHareket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 403);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbHareketTuru);
            this.Controls.Add(this.lblDepoAdiGoster1);
            this.Controls.Add(this.lblStokAdiGoster2);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnDepoSec);
            this.Controls.Add(this.btnStokSec);
            this.Controls.Add(this.txtMiktar);
            this.Controls.Add(this.txtFirmaAd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvHareket);
            this.Name = "frmHareket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hareket";
            this.Load += new System.EventHandler(this.frmHareket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHareket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHareket;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFirmaAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn cHareketTuru;
        private System.Windows.Forms.DataGridViewTextBoxColumn cStokID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDepoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMiktar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFirmaAd;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.Button btnStokSec;
        private System.Windows.Forms.Button btnDepoSec;
        private System.Windows.Forms.Button btnKaydet;
        public System.Windows.Forms.Label lblDepoAdiGoster;
        public System.Windows.Forms.Label lblStokAdiGoster2;
        public System.Windows.Forms.Label lblDepoAdiGoster1;
        private System.Windows.Forms.ComboBox cmbHareketTuru;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSil;
    }
}