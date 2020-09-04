namespace MatigaPos
{
    partial class Form1
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
            this.mASTERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uSERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bARANGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bARANGToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sTOKBARANGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tRANSAKSIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEPORTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tENTANGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mASTERToolStripMenuItem,
            this.tRANSAKSIToolStripMenuItem,
            this.rEPORTToolStripMenuItem,
            this.tENTANGToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(763, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mASTERToolStripMenuItem
            // 
            this.mASTERToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uSERToolStripMenuItem,
            this.bARANGToolStripMenuItem,
            this.bARANGToolStripMenuItem1,
            this.sTOKBARANGToolStripMenuItem});
            this.mASTERToolStripMenuItem.Name = "mASTERToolStripMenuItem";
            this.mASTERToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.mASTERToolStripMenuItem.Text = "MASTER";
            // 
            // uSERToolStripMenuItem
            // 
            this.uSERToolStripMenuItem.Name = "uSERToolStripMenuItem";
            this.uSERToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.uSERToolStripMenuItem.Text = "USER";
            // 
            // bARANGToolStripMenuItem
            // 
            this.bARANGToolStripMenuItem.Name = "bARANGToolStripMenuItem";
            this.bARANGToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bARANGToolStripMenuItem.Text = "KARYAWAN";
            this.bARANGToolStripMenuItem.Click += new System.EventHandler(this.bARANGToolStripMenuItem_Click);
            // 
            // bARANGToolStripMenuItem1
            // 
            this.bARANGToolStripMenuItem1.Name = "bARANGToolStripMenuItem1";
            this.bARANGToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.bARANGToolStripMenuItem1.Text = "BARANG";
            // 
            // sTOKBARANGToolStripMenuItem
            // 
            this.sTOKBARANGToolStripMenuItem.Name = "sTOKBARANGToolStripMenuItem";
            this.sTOKBARANGToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sTOKBARANGToolStripMenuItem.Text = "STOK BARANG";
            // 
            // tRANSAKSIToolStripMenuItem
            // 
            this.tRANSAKSIToolStripMenuItem.Name = "tRANSAKSIToolStripMenuItem";
            this.tRANSAKSIToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.tRANSAKSIToolStripMenuItem.Text = "TRANSAKSI";
            // 
            // rEPORTToolStripMenuItem
            // 
            this.rEPORTToolStripMenuItem.Name = "rEPORTToolStripMenuItem";
            this.rEPORTToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.rEPORTToolStripMenuItem.Text = "REPORT";
            // 
            // tENTANGToolStripMenuItem
            // 
            this.tENTANGToolStripMenuItem.Name = "tENTANGToolStripMenuItem";
            this.tENTANGToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.tENTANGToolStripMenuItem.Text = "TENTANG";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 492);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mASTERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uSERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bARANGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bARANGToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sTOKBARANGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tRANSAKSIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEPORTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tENTANGToolStripMenuItem;
    }
}

