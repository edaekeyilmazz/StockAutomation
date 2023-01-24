namespace StokOtomasyon
{
    partial class frmStokSec
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
            this.btnStokAktar = new System.Windows.Forms.Button();
            this.dgvStokSec = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStokSec)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStokAktar
            // 
            this.btnStokAktar.Location = new System.Drawing.Point(241, 267);
            this.btnStokAktar.Name = "btnStokAktar";
            this.btnStokAktar.Size = new System.Drawing.Size(104, 23);
            this.btnStokAktar.TabIndex = 7;
            this.btnStokAktar.Text = "Stoğu Seç";
            this.btnStokAktar.UseVisualStyleBackColor = true;
            this.btnStokAktar.Click += new System.EventHandler(this.btnStokAktar_Click);
            // 
            // dgvStokSec
            // 
            this.dgvStokSec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStokSec.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvStokSec.Location = new System.Drawing.Point(0, 0);
            this.dgvStokSec.MultiSelect = false;
            this.dgvStokSec.Name = "dgvStokSec";
            this.dgvStokSec.ReadOnly = true;
            this.dgvStokSec.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStokSec.Size = new System.Drawing.Size(596, 250);
            this.dgvStokSec.TabIndex = 4;
            // 
            // frmStokSec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 302);
            this.Controls.Add(this.btnStokAktar);
            this.Controls.Add(this.dgvStokSec);
            this.Name = "frmStokSec";
            this.Text = "Stoklar";
            this.Load += new System.EventHandler(this.frmStokSec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStokSec)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvStokSec;
        public System.Windows.Forms.Button btnStokAktar;
    }
}