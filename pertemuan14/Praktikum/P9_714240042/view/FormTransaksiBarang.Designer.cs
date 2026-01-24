namespace P9_714240042.view
{
    partial class FormTransaksiBarang
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DataTransaksi = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textboxCari = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupboxTransaksi = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textboxQty = new System.Windows.Forms.TextBox();
            this.textboxTotal = new System.Windows.Forms.TextBox();
            this.groupboxBarang = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboboxIdBarang = new System.Windows.Forms.ComboBox();
            this.textboxHarga = new System.Windows.Forms.TextBox();
            this.textboxNamaBarang = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataTransaksi)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupboxTransaksi.SuspendLayout();
            this.groupboxBarang.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DataTransaksi);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(955, 186);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Table Transaksi Barang";
            // 
            // DataTransaksi
            // 
            this.DataTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataTransaksi.Location = new System.Drawing.Point(0, 11);
            this.DataTransaksi.Name = "DataTransaksi";
            this.DataTransaksi.Size = new System.Drawing.Size(955, 176);
            this.DataTransaksi.TabIndex = 0;
            this.DataTransaksi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataTransaksi_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnExport);
            this.groupBox2.Controls.Add(this.textboxCari);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(616, 232);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(351, 101);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Form Pencarian";
            // 
            // textboxCari
            // 
            this.textboxCari.Location = new System.Drawing.Point(83, 24);
            this.textboxCari.Name = "textboxCari";
            this.textboxCari.Size = new System.Drawing.Size(262, 20);
            this.textboxCari.TabIndex = 5;
            this.textboxCari.TextChanged += new System.EventHandler(this.textboxCari_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cari Data";
            // 
            // groupboxTransaksi
            // 
            this.groupboxTransaksi.Controls.Add(this.label8);
            this.groupboxTransaksi.Controls.Add(this.label1);
            this.groupboxTransaksi.Controls.Add(this.label4);
            this.groupboxTransaksi.Controls.Add(this.label5);
            this.groupboxTransaksi.Controls.Add(this.textboxQty);
            this.groupboxTransaksi.Controls.Add(this.textboxTotal);
            this.groupboxTransaksi.Controls.Add(this.groupboxBarang);
            this.groupboxTransaksi.Location = new System.Drawing.Point(12, 274);
            this.groupboxTransaksi.Name = "groupboxTransaksi";
            this.groupboxTransaksi.Size = new System.Drawing.Size(588, 233);
            this.groupboxTransaksi.TabIndex = 0;
            this.groupboxTransaksi.TabStop = false;
            this.groupboxTransaksi.Text = "Form Transaksi Barang";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(73, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "Rp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Barang";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Total";
            // 
            // textboxQty
            // 
            this.textboxQty.Location = new System.Drawing.Point(93, 125);
            this.textboxQty.Name = "textboxQty";
            this.textboxQty.Size = new System.Drawing.Size(220, 20);
            this.textboxQty.TabIndex = 2;
            this.textboxQty.TextChanged += new System.EventHandler(this.textboxQty_TextChanged);
            // 
            // textboxTotal
            // 
            this.textboxTotal.Location = new System.Drawing.Point(93, 171);
            this.textboxTotal.Name = "textboxTotal";
            this.textboxTotal.Size = new System.Drawing.Size(220, 20);
            this.textboxTotal.TabIndex = 1;
            // 
            // groupboxBarang
            // 
            this.groupboxBarang.Controls.Add(this.label7);
            this.groupboxBarang.Controls.Add(this.label2);
            this.groupboxBarang.Controls.Add(this.label3);
            this.groupboxBarang.Controls.Add(this.comboboxIdBarang);
            this.groupboxBarang.Controls.Add(this.textboxHarga);
            this.groupboxBarang.Controls.Add(this.textboxNamaBarang);
            this.groupboxBarang.Location = new System.Drawing.Point(77, 19);
            this.groupboxBarang.Name = "groupboxBarang";
            this.groupboxBarang.Size = new System.Drawing.Size(505, 91);
            this.groupboxBarang.TabIndex = 0;
            this.groupboxBarang.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(243, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Rp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(13, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama Barang";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(259, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Harga Barang";
            // 
            // comboboxIdBarang
            // 
            this.comboboxIdBarang.FormattingEnabled = true;
            this.comboboxIdBarang.Location = new System.Drawing.Point(16, 19);
            this.comboboxIdBarang.Name = "comboboxIdBarang";
            this.comboboxIdBarang.Size = new System.Drawing.Size(220, 21);
            this.comboboxIdBarang.TabIndex = 3;
            this.comboboxIdBarang.SelectedIndexChanged += new System.EventHandler(this.comboboxIdBarang_SelectedIndexChanged);
            this.comboboxIdBarang.TextChanged += new System.EventHandler(this.comboboxIdBarang_TextChanged);
            // 
            // textboxHarga
            // 
            this.textboxHarga.Location = new System.Drawing.Point(262, 57);
            this.textboxHarga.Name = "textboxHarga";
            this.textboxHarga.Size = new System.Drawing.Size(237, 20);
            this.textboxHarga.TabIndex = 3;
            // 
            // textboxNamaBarang
            // 
            this.textboxNamaBarang.Location = new System.Drawing.Point(16, 57);
            this.textboxNamaBarang.Name = "textboxNamaBarang";
            this.textboxNamaBarang.Size = new System.Drawing.Size(220, 20);
            this.textboxNamaBarang.TabIndex = 4;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnDelete);
            this.groupBox4.Controls.Add(this.btnChange);
            this.groupBox4.Controls.Add(this.btnSave);
            this.groupBox4.Controls.Add(this.btnRefresh);
            this.groupBox4.Location = new System.Drawing.Point(616, 350);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(351, 157);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tombol Action";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(6, 122);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(339, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Hapus";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(6, 90);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(339, 23);
            this.btnChange.TabIndex = 2;
            this.btnChange.Text = "Ubah";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(6, 58);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(339, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Simpan";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(6, 27);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(339, 23);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.SpringGreen;
            this.btnExport.Location = new System.Drawing.Point(26, 61);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(319, 23);
            this.btnExport.TabIndex = 6;
            this.btnExport.Text = "Export Excel";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // FormTransaksiBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(979, 519);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupboxTransaksi);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormTransaksiBarang";
            this.Text = "FormTransaksiBarang";
            this.Load += new System.EventHandler(this.FormTransaksiBarang_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataTransaksi)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupboxTransaksi.ResumeLayout(false);
            this.groupboxTransaksi.PerformLayout();
            this.groupboxBarang.ResumeLayout(false);
            this.groupboxBarang.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupboxTransaksi;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupboxBarang;
        private System.Windows.Forms.TextBox textboxCari;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textboxQty;
        private System.Windows.Forms.TextBox textboxTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboboxIdBarang;
        private System.Windows.Forms.TextBox textboxHarga;
        private System.Windows.Forms.TextBox textboxNamaBarang;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView DataTransaksi;
        private System.Windows.Forms.Button btnExport;
    }
}