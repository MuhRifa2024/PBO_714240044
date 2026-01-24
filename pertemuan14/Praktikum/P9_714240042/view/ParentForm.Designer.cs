namespace P9_714240042.view
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
            this.MdiMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataMahasiswaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataNilaiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tugasPraktikum11ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataMasterBarangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataTransaksiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MdiMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MdiMenu
            // 
            this.MdiMenu.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.MdiMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.dataMahasiswaToolStripMenuItem,
            this.dataNilaiToolStripMenuItem,
            this.tugasPraktikum11ToolStripMenuItem});
            this.MdiMenu.Location = new System.Drawing.Point(0, 0);
            this.MdiMenu.Name = "MdiMenu";
            this.MdiMenu.Size = new System.Drawing.Size(800, 24);
            this.MdiMenu.TabIndex = 1;
            this.MdiMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // dataMahasiswaToolStripMenuItem
            // 
            this.dataMahasiswaToolStripMenuItem.Name = "dataMahasiswaToolStripMenuItem";
            this.dataMahasiswaToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.dataMahasiswaToolStripMenuItem.Text = "Data Mahasiswa";
            this.dataMahasiswaToolStripMenuItem.Click += new System.EventHandler(this.dataMahasiswaToolStripMenuItem_Click);
            // 
            // dataNilaiToolStripMenuItem
            // 
            this.dataNilaiToolStripMenuItem.Name = "dataNilaiToolStripMenuItem";
            this.dataNilaiToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.dataNilaiToolStripMenuItem.Text = "Data Nilai";
            this.dataNilaiToolStripMenuItem.Click += new System.EventHandler(this.dataNilaiToolStripMenuItem_Click);
            // 
            // tugasPraktikum11ToolStripMenuItem
            // 
            this.tugasPraktikum11ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataMasterBarangToolStripMenuItem,
            this.dataTransaksiToolStripMenuItem});
            this.tugasPraktikum11ToolStripMenuItem.Name = "tugasPraktikum11ToolStripMenuItem";
            this.tugasPraktikum11ToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.tugasPraktikum11ToolStripMenuItem.Text = "Tugas Praktikum 11";
            // 
            // dataMasterBarangToolStripMenuItem
            // 
            this.dataMasterBarangToolStripMenuItem.Name = "dataMasterBarangToolStripMenuItem";
            this.dataMasterBarangToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.dataMasterBarangToolStripMenuItem.Text = "Data Master Barang";
            this.dataMasterBarangToolStripMenuItem.Click += new System.EventHandler(this.dataMasterBarangToolStripMenuItem_Click);
            // 
            // dataTransaksiToolStripMenuItem
            // 
            this.dataTransaksiToolStripMenuItem.Name = "dataTransaksiToolStripMenuItem";
            this.dataTransaksiToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.dataTransaksiToolStripMenuItem.Text = "Data Transaksi";
            this.dataTransaksiToolStripMenuItem.Click += new System.EventHandler(this.dataTransaksiToolStripMenuItem_Click);
            // 
            // ParentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MdiMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MdiMenu;
            this.Name = "ParentForm";
            this.Text = "ParentForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ParentForm_FormClosing);
            this.MdiMenu.ResumeLayout(false);
            this.MdiMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MdiMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataMahasiswaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataNilaiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tugasPraktikum11ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataMasterBarangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataTransaksiToolStripMenuItem;
    }
}