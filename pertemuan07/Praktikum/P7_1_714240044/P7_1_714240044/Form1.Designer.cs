namespace P7_1_714240044
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
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.labelNama = new System.Windows.Forms.Label();
            this.labelAngkatan = new System.Windows.Forms.Label();
            this.labelKelas = new System.Windows.Forms.Label();
            this.comboBoxAngkatan = new System.Windows.Forms.ComboBox();
            this.lKegiatan = new System.Windows.Forms.Label();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.buttonTutup = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonCek = new System.Windows.Forms.Button();
            this.textBoxKelas = new System.Windows.Forms.TextBox();
            this.checkBoxKuliah = new System.Windows.Forms.CheckBox();
            this.checkBoxTidur = new System.Windows.Forms.CheckBox();
            this.checkBoxLiburan = new System.Windows.Forms.CheckBox();
            this.radioButtonWeekday = new System.Windows.Forms.RadioButton();
            this.radioButtonWeekend = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // textBoxNama
            // 
            this.textBoxNama.Location = new System.Drawing.Point(144, 26);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(163, 20);
            this.textBoxNama.TabIndex = 1;
            // 
            // labelNama
            // 
            this.labelNama.AutoSize = true;
            this.labelNama.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNama.Location = new System.Drawing.Point(26, 28);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(41, 18);
            this.labelNama.TabIndex = 2;
            this.labelNama.Text = "Nama";
            // 
            // labelAngkatan
            // 
            this.labelAngkatan.AutoSize = true;
            this.labelAngkatan.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAngkatan.Location = new System.Drawing.Point(26, 59);
            this.labelAngkatan.Name = "labelAngkatan";
            this.labelAngkatan.Size = new System.Drawing.Size(63, 18);
            this.labelAngkatan.TabIndex = 3;
            this.labelAngkatan.Text = "Angkatan";
            // 
            // labelKelas
            // 
            this.labelKelas.AutoSize = true;
            this.labelKelas.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKelas.Location = new System.Drawing.Point(26, 104);
            this.labelKelas.Name = "labelKelas";
            this.labelKelas.Size = new System.Drawing.Size(38, 18);
            this.labelKelas.TabIndex = 4;
            this.labelKelas.Text = "Kelas";
            // 
            // comboBoxAngkatan
            // 
            this.comboBoxAngkatan.FormattingEnabled = true;
            this.comboBoxAngkatan.Location = new System.Drawing.Point(144, 56);
            this.comboBoxAngkatan.Name = "comboBoxAngkatan";
            this.comboBoxAngkatan.Size = new System.Drawing.Size(163, 21);
            this.comboBoxAngkatan.TabIndex = 5;
            this.comboBoxAngkatan.SelectedIndexChanged += new System.EventHandler(this.comboBoxAngkatan_SelectedIndexChanged);
            // 
            // lKegiatan
            // 
            this.lKegiatan.AutoSize = true;
            this.lKegiatan.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lKegiatan.Location = new System.Drawing.Point(131, 266);
            this.lKegiatan.Name = "lKegiatan";
            this.lKegiatan.Size = new System.Drawing.Size(83, 22);
            this.lKegiatan.TabIndex = 6;
            this.lKegiatan.Text = "KEGIATAN";
            // 
            // buttonPrint
            // 
            this.buttonPrint.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrint.Location = new System.Drawing.Point(112, 589);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(75, 23);
            this.buttonPrint.TabIndex = 7;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // buttonTutup
            // 
            this.buttonTutup.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTutup.Location = new System.Drawing.Point(242, 186);
            this.buttonTutup.Name = "buttonTutup";
            this.buttonTutup.Size = new System.Drawing.Size(65, 23);
            this.buttonTutup.TabIndex = 8;
            this.buttonTutup.Text = "Tutup";
            this.buttonTutup.UseVisualStyleBackColor = true;
            this.buttonTutup.Click += new System.EventHandler(this.buttonTutup_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.Location = new System.Drawing.Point(232, 589);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 9;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonCek
            // 
            this.buttonCek.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCek.Location = new System.Drawing.Point(144, 186);
            this.buttonCek.Name = "buttonCek";
            this.buttonCek.Size = new System.Drawing.Size(65, 23);
            this.buttonCek.TabIndex = 10;
            this.buttonCek.Text = "Cek";
            this.buttonCek.UseVisualStyleBackColor = true;
            this.buttonCek.Click += new System.EventHandler(this.buttonCek_Click);
            // 
            // textBoxKelas
            // 
            this.textBoxKelas.Location = new System.Drawing.Point(144, 104);
            this.textBoxKelas.Multiline = true;
            this.textBoxKelas.Name = "textBoxKelas";
            this.textBoxKelas.Size = new System.Drawing.Size(163, 66);
            this.textBoxKelas.TabIndex = 11;
            // 
            // checkBoxKuliah
            // 
            this.checkBoxKuliah.AutoSize = true;
            this.checkBoxKuliah.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxKuliah.Location = new System.Drawing.Point(42, 428);
            this.checkBoxKuliah.Name = "checkBoxKuliah";
            this.checkBoxKuliah.Size = new System.Drawing.Size(62, 22);
            this.checkBoxKuliah.TabIndex = 12;
            this.checkBoxKuliah.Text = "Kuliah";
            this.checkBoxKuliah.UseVisualStyleBackColor = true;
            // 
            // checkBoxTidur
            // 
            this.checkBoxTidur.AutoSize = true;
            this.checkBoxTidur.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxTidur.Location = new System.Drawing.Point(42, 467);
            this.checkBoxTidur.Name = "checkBoxTidur";
            this.checkBoxTidur.Size = new System.Drawing.Size(57, 22);
            this.checkBoxTidur.TabIndex = 13;
            this.checkBoxTidur.Text = "Tidur";
            this.checkBoxTidur.UseVisualStyleBackColor = true;
            // 
            // checkBoxLiburan
            // 
            this.checkBoxLiburan.AutoSize = true;
            this.checkBoxLiburan.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxLiburan.Location = new System.Drawing.Point(42, 506);
            this.checkBoxLiburan.Name = "checkBoxLiburan";
            this.checkBoxLiburan.Size = new System.Drawing.Size(71, 22);
            this.checkBoxLiburan.TabIndex = 14;
            this.checkBoxLiburan.Text = "Liburan";
            this.checkBoxLiburan.UseVisualStyleBackColor = true;
            // 
            // radioButtonWeekday
            // 
            this.radioButtonWeekday.AutoSize = true;
            this.radioButtonWeekday.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonWeekday.Location = new System.Drawing.Point(42, 336);
            this.radioButtonWeekday.Name = "radioButtonWeekday";
            this.radioButtonWeekday.Size = new System.Drawing.Size(109, 22);
            this.radioButtonWeekday.TabIndex = 15;
            this.radioButtonWeekday.TabStop = true;
            this.radioButtonWeekday.Text = "Senin - Jum\'at";
            this.radioButtonWeekday.UseVisualStyleBackColor = true;
            this.radioButtonWeekday.CheckedChanged += new System.EventHandler(this.radioButtonWeekday_CheckedChanged);
            // 
            // radioButtonWeekend
            // 
            this.radioButtonWeekend.AutoSize = true;
            this.radioButtonWeekend.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonWeekend.Location = new System.Drawing.Point(42, 374);
            this.radioButtonWeekend.Name = "radioButtonWeekend";
            this.radioButtonWeekend.Size = new System.Drawing.Size(114, 22);
            this.radioButtonWeekend.TabIndex = 16;
            this.radioButtonWeekend.TabStop = true;
            this.radioButtonWeekend.Text = "Sabtu - Minggu";
            this.radioButtonWeekend.UseVisualStyleBackColor = true;
            this.radioButtonWeekend.CheckedChanged += new System.EventHandler(this.radioButtonWeekend_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 636);
            this.Controls.Add(this.radioButtonWeekend);
            this.Controls.Add(this.radioButtonWeekday);
            this.Controls.Add(this.checkBoxLiburan);
            this.Controls.Add(this.checkBoxTidur);
            this.Controls.Add(this.checkBoxKuliah);
            this.Controls.Add(this.textBoxKelas);
            this.Controls.Add(this.buttonCek);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonTutup);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.lKegiatan);
            this.Controls.Add(this.comboBoxAngkatan);
            this.Controls.Add(this.labelKelas);
            this.Controls.Add(this.labelAngkatan);
            this.Controls.Add(this.labelNama);
            this.Controls.Add(this.textBoxNama);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.Label labelAngkatan;
        private System.Windows.Forms.Label labelKelas;
        private System.Windows.Forms.ComboBox comboBoxAngkatan;
        private System.Windows.Forms.Label lKegiatan;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Button buttonTutup;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonCek;
        private System.Windows.Forms.TextBox textBoxKelas;
        private System.Windows.Forms.CheckBox checkBoxKuliah;
        private System.Windows.Forms.CheckBox checkBoxTidur;
        private System.Windows.Forms.CheckBox checkBoxLiburan;
        private System.Windows.Forms.RadioButton radioButtonWeekday;
        private System.Windows.Forms.RadioButton radioButtonWeekend;
    }
}

