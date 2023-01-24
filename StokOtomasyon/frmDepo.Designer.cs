namespace StokOtomasyon
{
    partial class frmDepo
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
            this.dgvDepo = new System.Windows.Forms.DataGridView();
            this.cID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cKod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKodu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDepo
            // 
            this.dgvDepo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cID,
            this.cAd,
            this.cKod});
            this.dgvDepo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDepo.Location = new System.Drawing.Point(0, 108);
            this.dgvDepo.Name = "dgvDepo";
            this.dgvDepo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDepo.Size = new System.Drawing.Size(343, 222);
            this.dgvDepo.TabIndex = 0;
            this.dgvDepo.DoubleClick += new System.EventHandler(this.dgvDepo_DoubleClick);
            // 
            // cID
            // 
            this.cID.DataPropertyName = "ID";
            this.cID.HeaderText = "Kimlik";
            this.cID.Name = "cID";
            // 
            // cAd
            // 
            this.cAd.DataPropertyName = "DepoAd";
            this.cAd.HeaderText = "Depo Adı";
            this.cAd.Name = "cAd";
            // 
            // cKod
            // 
            this.cKod.DataPropertyName = "DepoKod";
            this.cKod.HeaderText = "Depo Kodu";
            this.cKod.Name = "cKod";
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(84, 54);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(100, 20);
            this.txtAdi.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Depo Adı:";
            // 
            // txtKodu
            // 
            this.txtKodu.Location = new System.Drawing.Point(84, 28);
            this.txtKodu.Name = "txtKodu";
            this.txtKodu.Size = new System.Drawing.Size(100, 20);
            this.txtKodu.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Depo Kodu:";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(199, 28);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(119, 46);
            this.btnKaydet.TabIndex = 19;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // frmDepo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 330);
            this.Controls.Add(this.txtAdi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKodu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.dgvDepo);
            this.Name = "frmDepo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Depo";
            this.Load += new System.EventHandler(this.frmDepo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDepo;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKodu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.DataGridViewTextBoxColumn cID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn cKod;
    }
}