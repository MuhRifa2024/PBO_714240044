namespace SIPK_KSR.view
{
    partial class ParentForm
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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anggotaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.penagananToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasienKorbanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.anggotaToolStripMenuItem,
            this.penagananToolStripMenuItem,
            this.pasienKorbanToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 21);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // anggotaToolStripMenuItem
            // 
            this.anggotaToolStripMenuItem.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anggotaToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.anggotaToolStripMenuItem.Name = "anggotaToolStripMenuItem";
            this.anggotaToolStripMenuItem.Size = new System.Drawing.Size(60, 21);
            this.anggotaToolStripMenuItem.Text = "Anggota";
            this.anggotaToolStripMenuItem.Click += new System.EventHandler(this.anggotaToolStripMenuItem_Click);
            // 
            // penagananToolStripMenuItem
            // 
            this.penagananToolStripMenuItem.Font = new System.Drawing.Font("Futura Bk BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.penagananToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.penagananToolStripMenuItem.Name = "penagananToolStripMenuItem";
            this.penagananToolStripMenuItem.Size = new System.Drawing.Size(91, 21);
            this.penagananToolStripMenuItem.Text = "Penaganan";
            this.penagananToolStripMenuItem.Click += new System.EventHandler(this.penagananToolStripMenuItem_Click);
            // 
            // pasienKorbanToolStripMenuItem
            // 
            this.pasienKorbanToolStripMenuItem.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pasienKorbanToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.pasienKorbanToolStripMenuItem.Name = "pasienKorbanToolStripMenuItem";
            this.pasienKorbanToolStripMenuItem.Size = new System.Drawing.Size(110, 21);
            this.pasienKorbanToolStripMenuItem.Text = "Pasien/Korban";
            this.pasienKorbanToolStripMenuItem.Click += new System.EventHandler(this.pasienKorbanToolStripMenuItem_Click);
            // 
            // ParentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ParentForm";
            this.Text = "ParentForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anggotaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem penagananToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasienKorbanToolStripMenuItem;
    }
}