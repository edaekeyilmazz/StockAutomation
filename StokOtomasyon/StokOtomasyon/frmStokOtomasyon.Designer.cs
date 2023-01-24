namespace StokOtomasyon
{
    partial class frmStokOtomasyon
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsMainKart = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSubStok = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsSubDepo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSubHareket = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMainKart});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(677, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsMainKart
            // 
            this.tsMainKart.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsSubStok,
            this.toolStripMenuItem1,
            this.tsSubDepo,
            this.tsSubHareket});
            this.tsMainKart.Name = "tsMainKart";
            this.tsMainKart.Size = new System.Drawing.Size(87, 20);
            this.tsMainKart.Text = "Kart İşlemleri";
            // 
            // tsSubStok
            // 
            this.tsSubStok.Name = "tsSubStok";
            this.tsSubStok.Size = new System.Drawing.Size(152, 22);
            this.tsSubStok.Text = "Stok";
            this.tsSubStok.Click += new System.EventHandler(this.tsSubStok_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // tsSubDepo
            // 
            this.tsSubDepo.Name = "tsSubDepo";
            this.tsSubDepo.Size = new System.Drawing.Size(152, 22);
            this.tsSubDepo.Text = "Depo";
            this.tsSubDepo.Click += new System.EventHandler(this.tsSubDepo_Click);
            // 
            // tsSubHareket
            // 
            this.tsSubHareket.Name = "tsSubHareket";
            this.tsSubHareket.Size = new System.Drawing.Size(152, 22);
            this.tsSubHareket.Text = "Hareket";
            this.tsSubHareket.Click += new System.EventHandler(this.tsSubHareket_Click);
            // 
            // frmStokOtomasyon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 404);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmStokOtomasyon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmStokOtomasyon";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsMainKart;
        private System.Windows.Forms.ToolStripMenuItem tsSubStok;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsSubDepo;
        private System.Windows.Forms.ToolStripMenuItem tsSubHareket;
    }
}