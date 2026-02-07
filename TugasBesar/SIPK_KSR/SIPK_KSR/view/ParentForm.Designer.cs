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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParentForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.anggotaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataPenanganToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.penagananToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasienKorbanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anggotaToolStripMenuItem,
            this.dataPenanganToolStripMenuItem,
            this.penagananToolStripMenuItem,
            this.pasienKorbanToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1067, 27);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
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
            // dataPenanganToolStripMenuItem
            // 
            this.dataPenanganToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataPenanganToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.dataPenanganToolStripMenuItem.Name = "dataPenanganToolStripMenuItem";
            this.dataPenanganToolStripMenuItem.Size = new System.Drawing.Size(102, 21);
            this.dataPenanganToolStripMenuItem.Text = "Data Penangan";
            this.dataPenanganToolStripMenuItem.Click += new System.EventHandler(this.dataPenanganToolStripMenuItem_Click);
            // 
            // penagananToolStripMenuItem
            // 
            this.penagananToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.penagananToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.penagananToolStripMenuItem.Name = "penagananToolStripMenuItem";
            this.penagananToolStripMenuItem.Size = new System.Drawing.Size(98, 21);
            this.penagananToolStripMenuItem.Text = "Penaganan";
            this.penagananToolStripMenuItem.Click += new System.EventHandler(this.penagananToolStripMenuItem_Click);
            // 
            // pasienKorbanToolStripMenuItem
            // 
            this.pasienKorbanToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pasienKorbanToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pasienKorbanToolStripMenuItem.ForeColor = System.Drawing.Color.Lime;
            this.pasienKorbanToolStripMenuItem.Name = "pasienKorbanToolStripMenuItem";
            this.pasienKorbanToolStripMenuItem.Size = new System.Drawing.Size(110, 21);
            this.pasienKorbanToolStripMenuItem.Text = "Pasien/Korban";
            this.pasienKorbanToolStripMenuItem.Click += new System.EventHandler(this.pasienKorbanToolStripMenuItem_Click);
            // 
            // ParentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 623);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ParentForm";
            this.Text = "Sistem Informasi Penanganan KSR";
            this.Load += new System.EventHandler(this.ParentForm_Load);
            this.Resize += new System.EventHandler(this.ParentForm_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem anggotaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem penagananToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasienKorbanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataPenanganToolStripMenuItem;
    }
}