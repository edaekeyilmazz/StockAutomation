namespace StokOtomasyon
{
    partial class frmDepoSec
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
            this.btnDepoAktar = new System.Windows.Forms.Button();
            this.dgvDepoSec = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepoSec)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDepoAktar
            // 
            this.btnDepoAktar.Location = new System.Drawing.Point(238, 269);
            this.btnDepoAktar.Name = "btnDepoAktar";
            this.btnDepoAktar.Size = new System.Drawing.Size(104, 23);
            this.btnDepoAktar.TabIndex = 9;
            this.btnDepoAktar.Text = "Depoyu Seç";
            this.btnDepoAktar.UseVisualStyleBackColor = true;
            this.btnDepoAktar.Click += new System.EventHandler(this.btnDepoAktar_Click);
            // 
            // dgvDepoSec
            // 
            this.dgvDepoSec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepoSec.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvDepoSec.Location = new System.Drawing.Point(0, 0);
            this.dgvDepoSec.MultiSelect = false;
            this.dgvDepoSec.Name = "dgvDepoSec";
            this.dgvDepoSec.ReadOnly = true;
            this.dgvDepoSec.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDepoSec.Size = new System.Drawing.Size(580, 250);
            this.dgvDepoSec.TabIndex = 8;
            // 
            // frmDepoSec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 307);
            this.Controls.Add(this.btnDepoAktar);
            this.Controls.Add(this.dgvDepoSec);
            this.Name = "frmDepoSec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Depolar";
            this.Load += new System.EventHandler(this.frmDepoSec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepoSec)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvDepoSec;
        public System.Windows.Forms.Button btnDepoAktar;
    }
}