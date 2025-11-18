namespace P6_3_714240044
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAngka2 = new System.Windows.Forms.TextBox();
            this.txtAngka1 = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtHuruf = new System.Windows.Forms.TextBox();
            this.txtAngka = new System.Windows.Forms.TextBox();
            this.epWarning = new System.Windows.Forms.ErrorProvider(this.components);
            this.epWrong = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCorrect = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Huruf";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(28, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Angka";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(28, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(29, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "*Angka 1 > Angka 2";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(29, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Angka 1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(29, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Angka 2";
            // 
            // txtAngka2
            // 
            this.txtAngka2.Location = new System.Drawing.Point(171, 260);
            this.txtAngka2.Name = "txtAngka2";
            this.txtAngka2.Size = new System.Drawing.Size(120, 20);
            this.txtAngka2.TabIndex = 6;
            this.txtAngka2.Leave += new System.EventHandler(this.txtAngka2_Leave);
            // 
            // txtAngka1
            // 
            this.txtAngka1.Location = new System.Drawing.Point(171, 208);
            this.txtAngka1.Name = "txtAngka1";
            this.txtAngka1.Size = new System.Drawing.Size(120, 20);
            this.txtAngka1.TabIndex = 7;
            this.txtAngka1.Leave += new System.EventHandler(this.txtAngka1_Leave);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(171, 114);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(120, 20);
            this.txtEmail.TabIndex = 8;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtHuruf
            // 
            this.txtHuruf.Location = new System.Drawing.Point(171, 22);
            this.txtHuruf.Name = "txtHuruf";
            this.txtHuruf.Size = new System.Drawing.Size(120, 20);
            this.txtHuruf.TabIndex = 9;
            this.txtHuruf.Leave += new System.EventHandler(this.txtHuruf_Leave);
            // 
            // txtAngka
            // 
            this.txtAngka.Location = new System.Drawing.Point(171, 67);
            this.txtAngka.Name = "txtAngka";
            this.txtAngka.Size = new System.Drawing.Size(120, 20);
            this.txtAngka.TabIndex = 10;
            this.txtAngka.TextChanged += new System.EventHandler(this.txtAngka_TextChanged);
            // 
            // epWarning
            // 
            this.epWarning.ContainerControl = this;
            this.epWarning.Icon = ((System.Drawing.Icon)(resources.GetObject("epWarning.Icon")));
            // 
            // epWrong
            // 
            this.epWrong.ContainerControl = this;
            this.epWrong.Icon = ((System.Drawing.Icon)(resources.GetObject("epWrong.Icon")));
            // 
            // epCorrect
            // 
            this.epCorrect.ContainerControl = this;
            this.epCorrect.Icon = ((System.Drawing.Icon)(resources.GetObject("epCorrect.Icon")));
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 311);
            this.Controls.Add(this.txtAngka);
            this.Controls.Add(this.txtHuruf);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtAngka1);
            this.Controls.Add(this.txtAngka2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Validasi";
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAngka2;
        private System.Windows.Forms.TextBox txtAngka1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtHuruf;
        private System.Windows.Forms.TextBox txtAngka;
        private System.Windows.Forms.ErrorProvider epWarning;
        private System.Windows.Forms.ErrorProvider epWrong;
        private System.Windows.Forms.ErrorProvider epCorrect;
    }
}

