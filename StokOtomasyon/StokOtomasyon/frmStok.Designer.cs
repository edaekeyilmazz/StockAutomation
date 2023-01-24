namespace StokOtomasyon
{
    partial class frmStok
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
            this.dgvStok = new System.Windows.Forms.DataGridView();
            this.cID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cKod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAlis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSatis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSatis = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAlis = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKodu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStok)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStok
            // 
            this.dgvStok.AllowUserToAddRows = false;
            this.dgvStok.AllowUserToDeleteRows = false;
            this.dgvStok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStok.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cID,
            this.cKod,
            this.cName,
            this.cAlis,
            this.cSatis});
            this.dgvStok.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvStok.Location = new System.Drawing.Point(0, 95);
            this.dgvStok.Name = "dgvStok";
            this.dgvStok.ReadOnly = true;
            this.dgvStok.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStok.Size = new System.Drawing.Size(544, 318);
            this.dgvStok.TabIndex = 15;
            this.dgvStok.DoubleClick += new System.EventHandler(this.dgvStok_DoubleClick);
            // 
            // cID
            // 
            this.cID.DataPropertyName = "ID";
            this.cID.HeaderText = "Kimlik";
            this.cID.Name = "cID";
            this.cID.ReadOnly = true;
            // 
            // cKod
            // 
            this.cKod.DataPropertyName = "StokKod";
            this.cKod.HeaderText = "Stok Kodu";
            this.cKod.Name = "cKod";
            this.cKod.ReadOnly = true;
            // 
            // cName
            // 
            this.cName.DataPropertyName = "StokAd";
            this.cName.HeaderText = "Stok Adı";
            this.cName.Name = "cName";
            this.cName.ReadOnly = true;
            // 
            // cAlis
            // 
            this.cAlis.DataPropertyName = "AlisFiyat";
            this.cAlis.HeaderText = "Alış Fiyatı";
            this.cAlis.Name = "cAlis";
            this.cAlis.ReadOnly = true;
            // 
            // cSatis
            // 
            this.cSatis.DataPropertyName = "SatisFiyat";
            this.cSatis.HeaderText = "Satış Fiyatı";
            this.cSatis.Name = "cSatis";
            this.cSatis.ReadOnly = true;
            // 
            // txtSatis
            // 
            this.txtSatis.Location = new System.Drawing.Point(283, 50);
            this.txtSatis.Name = "txtSatis";
            this.txtSatis.Size = new System.Drawing.Size(100, 20);
            this.txtSatis.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(217, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Satış Fiyatı:";
            // 
            // txtAlis
            // 
            this.txtAlis.Location = new System.Drawing.Point(283, 24);
            this.txtAlis.Name = "txtAlis";
            this.txtAlis.Size = new System.Drawing.Size(100, 20);
            this.txtAlis.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Alış Fiyatı:";
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(84, 50);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(100, 20);
            this.txtAdi.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Stok Adı:";
            // 
            // txtKodu
            // 
            this.txtKodu.Location = new System.Drawing.Point(84, 24);
            this.txtKodu.Name = "txtKodu";
            this.txtKodu.Size = new System.Drawing.Size(100, 20);
            this.txtKodu.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Stok Kodu:";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(406, 24);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(119, 31);
            this.btnKaydet.TabIndex = 14;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(406, 61);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(119, 28);
            this.btnSil.TabIndex = 14;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // frmStok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 413);
            this.Controls.Add(this.dgvStok);
            this.Controls.Add(this.txtSatis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAlis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKodu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKaydet);
            this.Name = "frmStok";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok";
            this.Load += new System.EventHandler(this.frmStok_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStok;
        private System.Windows.Forms.TextBox txtSatis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAlis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKodu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.DataGridViewTextBoxColumn cID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cKod;
        private System.Windows.Forms.DataGridViewTextBoxColumn cName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAlis;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSatis;
        private System.Windows.Forms.Button btnSil;


    }
}