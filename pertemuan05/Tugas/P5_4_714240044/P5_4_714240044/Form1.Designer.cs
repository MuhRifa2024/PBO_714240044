namespace P5_4_714240044
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
            this.NamaDF = new System.Windows.Forms.Label();
            this.JkDF = new System.Windows.Forms.Label();
            this.TlDF = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.Jk = new System.Windows.Forms.ComboBox();
            this.tl = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_pan = new System.Windows.Forms.CheckBox();
            this.cb_bola = new System.Windows.Forms.CheckBox();
            this.cb_vol = new System.Windows.Forms.CheckBox();
            this.cb_renang = new System.Windows.Forms.CheckBox();
            this.cb_bultang = new System.Windows.Forms.CheckBox();
            this.cb_ten = new System.Windows.Forms.CheckBox();
            this.cb_Bas = new System.Windows.Forms.CheckBox();
            this.cb_yoga = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_ming = new System.Windows.Forms.RadioButton();
            this.rb_sen = new System.Windows.Forms.RadioButton();
            this.rb_sab = new System.Windows.Forms.RadioButton();
            this.rb_sel = new System.Windows.Forms.RadioButton();
            this.Judul = new System.Windows.Forms.Label();
            this.BtnDF = new System.Windows.Forms.Button();
            this.btn_beres = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // NamaDF
            // 
            this.NamaDF.AutoSize = true;
            this.NamaDF.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NamaDF.Location = new System.Drawing.Point(196, 38);
            this.NamaDF.Name = "NamaDF";
            this.NamaDF.Size = new System.Drawing.Size(53, 22);
            this.NamaDF.TabIndex = 0;
            this.NamaDF.Text = "Nama";
            // 
            // JkDF
            // 
            this.JkDF.AutoSize = true;
            this.JkDF.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JkDF.Location = new System.Drawing.Point(195, 64);
            this.JkDF.Name = "JkDF";
            this.JkDF.Size = new System.Drawing.Size(114, 22);
            this.JkDF.TabIndex = 1;
            this.JkDF.Text = "Jenis Kelamin";
            this.JkDF.Click += new System.EventHandler(this.label2_Click);
            // 
            // TlDF
            // 
            this.TlDF.AutoSize = true;
            this.TlDF.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TlDF.Location = new System.Drawing.Point(195, 91);
            this.TlDF.Name = "TlDF";
            this.TlDF.Size = new System.Drawing.Size(111, 22);
            this.TlDF.TabIndex = 2;
            this.TlDF.Text = "Tanggal Lahir";
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(354, 38);
            this.txtNama.MaxLength = 50;
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(249, 20);
            this.txtNama.TabIndex = 3;
            this.txtNama.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Jk
            // 
            this.Jk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Jk.FormattingEnabled = true;
            this.Jk.Items.AddRange(new object[] {
            "---Pilih Jenis Kelamin---",
            "Laki-laki",
            "Perempuan"});
            this.Jk.Location = new System.Drawing.Point(354, 64);
            this.Jk.Name = "Jk";
            this.Jk.Size = new System.Drawing.Size(249, 21);
            this.Jk.TabIndex = 4;
            this.Jk.SelectedIndexChanged += new System.EventHandler(this.Jk_SelectedIndexChanged);
            // 
            // tl
            // 
            this.tl.CustomFormat = "dd MMMM yyyy";
            this.tl.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tl.Location = new System.Drawing.Point(354, 91);
            this.tl.Name = "tl";
            this.tl.Size = new System.Drawing.Size(249, 20);
            this.tl.TabIndex = 5;
            this.tl.Value = new System.DateTime(2025, 11, 13, 0, 0, 0, 0);
            this.tl.ValueChanged += new System.EventHandler(this.InpTlDF_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_pan);
            this.groupBox1.Controls.Add(this.cb_bola);
            this.groupBox1.Controls.Add(this.cb_vol);
            this.groupBox1.Controls.Add(this.cb_renang);
            this.groupBox1.Controls.Add(this.cb_bultang);
            this.groupBox1.Controls.Add(this.cb_ten);
            this.groupBox1.Controls.Add(this.cb_Bas);
            this.groupBox1.Controls.Add(this.cb_yoga);
            this.groupBox1.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.groupBox1.Location = new System.Drawing.Point(150, 180);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 180);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pilihan Kelas";
            // 
            // cb_pan
            // 
            this.cb_pan.AutoSize = true;
            this.cb_pan.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.cb_pan.Location = new System.Drawing.Point(128, 130);
            this.cb_pan.Name = "cb_pan";
            this.cb_pan.Size = new System.Drawing.Size(86, 26);
            this.cb_pan.TabIndex = 18;
            this.cb_pan.Text = "Panahan";
            this.cb_pan.UseVisualStyleBackColor = true;
            this.cb_pan.CheckedChanged += new System.EventHandler(this.checkBox8_CheckedChanged);
            // 
            // cb_bola
            // 
            this.cb_bola.AutoSize = true;
            this.cb_bola.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.cb_bola.Location = new System.Drawing.Point(6, 27);
            this.cb_bola.Name = "cb_bola";
            this.cb_bola.Size = new System.Drawing.Size(106, 26);
            this.cb_bola.TabIndex = 12;
            this.cb_bola.Text = "Sepak Bola";
            this.cb_bola.UseVisualStyleBackColor = true;
            // 
            // cb_vol
            // 
            this.cb_vol.AutoSize = true;
            this.cb_vol.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.cb_vol.Location = new System.Drawing.Point(128, 94);
            this.cb_vol.Name = "cb_vol";
            this.cb_vol.Size = new System.Drawing.Size(55, 26);
            this.cb_vol.TabIndex = 17;
            this.cb_vol.Text = "Voli";
            this.cb_vol.UseVisualStyleBackColor = true;
            // 
            // cb_renang
            // 
            this.cb_renang.AutoSize = true;
            this.cb_renang.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.cb_renang.Location = new System.Drawing.Point(6, 58);
            this.cb_renang.Name = "cb_renang";
            this.cb_renang.Size = new System.Drawing.Size(78, 26);
            this.cb_renang.TabIndex = 13;
            this.cb_renang.Text = "Renang";
            this.cb_renang.UseVisualStyleBackColor = true;
            this.cb_renang.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // cb_bultang
            // 
            this.cb_bultang.AutoSize = true;
            this.cb_bultang.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.cb_bultang.Location = new System.Drawing.Point(128, 58);
            this.cb_bultang.Name = "cb_bultang";
            this.cb_bultang.Size = new System.Drawing.Size(113, 26);
            this.cb_bultang.TabIndex = 16;
            this.cb_bultang.Text = "Bulu Tangkis";
            this.cb_bultang.UseVisualStyleBackColor = true;
            // 
            // cb_ten
            // 
            this.cb_ten.AutoSize = true;
            this.cb_ten.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.cb_ten.Location = new System.Drawing.Point(6, 94);
            this.cb_ten.Name = "cb_ten";
            this.cb_ten.Size = new System.Drawing.Size(64, 26);
            this.cb_ten.TabIndex = 0;
            this.cb_ten.Text = "Tenis";
            this.cb_ten.UseVisualStyleBackColor = true;
            this.cb_ten.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // cb_Bas
            // 
            this.cb_Bas.AutoSize = true;
            this.cb_Bas.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.cb_Bas.Location = new System.Drawing.Point(128, 27);
            this.cb_Bas.Name = "cb_Bas";
            this.cb_Bas.Size = new System.Drawing.Size(75, 26);
            this.cb_Bas.TabIndex = 15;
            this.cb_Bas.Text = "Basket";
            this.cb_Bas.UseVisualStyleBackColor = true;
            // 
            // cb_yoga
            // 
            this.cb_yoga.AutoSize = true;
            this.cb_yoga.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_yoga.Location = new System.Drawing.Point(6, 130);
            this.cb_yoga.Name = "cb_yoga";
            this.cb_yoga.Size = new System.Drawing.Size(61, 26);
            this.cb_yoga.TabIndex = 14;
            this.cb_yoga.Text = "Yoga";
            this.cb_yoga.UseVisualStyleBackColor = true;
            this.cb_yoga.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_ming);
            this.groupBox2.Controls.Add(this.rb_sen);
            this.groupBox2.Controls.Add(this.rb_sab);
            this.groupBox2.Controls.Add(this.rb_sel);
            this.groupBox2.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.groupBox2.Location = new System.Drawing.Point(446, 180);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 180);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pilihan Jadwal";
            // 
            // rb_ming
            // 
            this.rb_ming.AutoSize = true;
            this.rb_ming.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
            this.rb_ming.Location = new System.Drawing.Point(10, 132);
            this.rb_ming.Name = "rb_ming";
            this.rb_ming.Size = new System.Drawing.Size(156, 22);
            this.rb_ming.TabIndex = 11;
            this.rb_ming.TabStop = true;
            this.rb_ming.Text = "Minggu, 13.00 - 20.00";
            this.rb_ming.UseVisualStyleBackColor = true;
            // 
            // rb_sen
            // 
            this.rb_sen.AutoSize = true;
            this.rb_sen.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_sen.Location = new System.Drawing.Point(10, 29);
            this.rb_sen.Name = "rb_sen";
            this.rb_sen.Size = new System.Drawing.Size(203, 22);
            this.rb_sen.TabIndex = 8;
            this.rb_sen.TabStop = true;
            this.rb_sen.Text = "Senin s/d Rabu, 14.00 - 16.00";
            this.rb_sen.UseVisualStyleBackColor = true;
            // 
            // rb_sab
            // 
            this.rb_sab.AutoSize = true;
            this.rb_sab.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
            this.rb_sab.Location = new System.Drawing.Point(10, 98);
            this.rb_sab.Name = "rb_sab";
            this.rb_sab.Size = new System.Drawing.Size(217, 22);
            this.rb_sab.TabIndex = 10;
            this.rb_sab.TabStop = true;
            this.rb_sab.Text = "Sabtu s/d Minggu, 09.00 - 11.00";
            this.rb_sab.UseVisualStyleBackColor = true;
            this.rb_sab.CheckedChanged += new System.EventHandler(this.rb_sab_CheckedChanged);
            // 
            // rb_sel
            // 
            this.rb_sel.AutoSize = true;
            this.rb_sel.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
            this.rb_sel.Location = new System.Drawing.Point(10, 65);
            this.rb_sel.Name = "rb_sel";
            this.rb_sel.Size = new System.Drawing.Size(214, 22);
            this.rb_sel.TabIndex = 9;
            this.rb_sel.TabStop = true;
            this.rb_sel.Text = "Selasa s/d Kamis, 14.00 - 16.00";
            this.rb_sel.UseVisualStyleBackColor = true;
            // 
            // Judul
            // 
            this.Judul.AutoSize = true;
            this.Judul.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Judul.ForeColor = System.Drawing.Color.Navy;
            this.Judul.Location = new System.Drawing.Point(304, 0);
            this.Judul.Name = "Judul";
            this.Judul.Size = new System.Drawing.Size(195, 24);
            this.Judul.TabIndex = 8;
            this.Judul.Text = "FORM PENDAFTARAN";
            this.Judul.Click += new System.EventHandler(this.label1_Click);
            // 
            // BtnDF
            // 
            this.BtnDF.BackColor = System.Drawing.Color.Aquamarine;
            this.BtnDF.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDF.Location = new System.Drawing.Point(295, 400);
            this.BtnDF.Name = "BtnDF";
            this.BtnDF.Size = new System.Drawing.Size(105, 33);
            this.BtnDF.TabIndex = 9;
            this.BtnDF.Text = "Tampilkan";
            this.BtnDF.UseVisualStyleBackColor = false;
            this.BtnDF.Click += new System.EventHandler(this.BtnDF_Click);
            // 
            // btn_beres
            // 
            this.btn_beres.BackColor = System.Drawing.Color.Aquamarine;
            this.btn_beres.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_beres.Location = new System.Drawing.Point(446, 400);
            this.btn_beres.Name = "btn_beres";
            this.btn_beres.Size = new System.Drawing.Size(105, 33);
            this.btn_beres.TabIndex = 10;
            this.btn_beres.Text = "Selesai";
            this.btn_beres.UseVisualStyleBackColor = false;
            this.btn_beres.Click += new System.EventHandler(this.btn_beres_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(804, 476);
            this.Controls.Add(this.btn_beres);
            this.Controls.Add(this.BtnDF);
            this.Controls.Add(this.Judul);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tl);
            this.Controls.Add(this.Jk);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.TlDF);
            this.Controls.Add(this.JkDF);
            this.Controls.Add(this.NamaDF);
            this.Name = "Form1";
            this.Text = "ULBI SPORT SCHOOL";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NamaDF;
        private System.Windows.Forms.Label JkDF;
        private System.Windows.Forms.Label TlDF;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.ComboBox Jk;
        private System.Windows.Forms.DateTimePicker tl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cb_pan;
        private System.Windows.Forms.CheckBox cb_bola;
        private System.Windows.Forms.CheckBox cb_vol;
        private System.Windows.Forms.CheckBox cb_renang;
        private System.Windows.Forms.CheckBox cb_bultang;
        private System.Windows.Forms.CheckBox cb_ten;
        private System.Windows.Forms.CheckBox cb_Bas;
        private System.Windows.Forms.CheckBox cb_yoga;
        private System.Windows.Forms.RadioButton rb_ming;
        private System.Windows.Forms.RadioButton rb_sen;
        private System.Windows.Forms.RadioButton rb_sab;
        private System.Windows.Forms.RadioButton rb_sel;
        private System.Windows.Forms.Label Judul;
        private System.Windows.Forms.Button BtnDF;
        private System.Windows.Forms.Button btn_beres;
    }
}

