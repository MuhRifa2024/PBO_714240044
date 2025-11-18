using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace P6_3_714240044
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void SetErrorMessages(TextBox textBox, string warningMessage, string wrongMessage, string correctMessage)
        {
            epWarning.SetError(textBox, warningMessage);
            epWrong.SetError(textBox, wrongMessage);
            epCorrect.SetError(textBox, correctMessage);
        }

        private void txtHuruf_Leave(object sender, EventArgs e)
        {
            if (txtHuruf.Text == "")
            {
                SetErrorMessages(txtHuruf, "Textbox Huruf tidak boleh kosong!", "", "");
            }
            else if (txtHuruf.Text.All(Char.IsLetter))
            {
                SetErrorMessages(txtHuruf, "", "", "Betul!");
            }
            else
            {
                SetErrorMessages(txtHuruf, "", "Inputan hanya boleh huruf!", "");
            }
        }

        private void txtAngka_TextChanged(object sender, EventArgs e)
        {
            if (txtAngka.Text == "")
            {
                SetErrorMessages(txtAngka, "Textbox Angka tidak boleh kosong!", "", "");
            }
            else if (txtAngka.Text.All(Char.IsNumber))
            {
                SetErrorMessages(txtAngka, "", "", "Betul!");
            }
            else
            {
                SetErrorMessages(txtAngka, "", "Inputan hanya boleh angka!", "");
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                SetErrorMessages(txtEmail, "Textbox Email tidak boleh kosong!", "", "");
            }
            else if (Regex.IsMatch(txtEmail.Text, @"^^[^@\s]+@[^@\s]+(\.[^@\s]+)+$"))
            {
                SetErrorMessages(txtEmail, "", "", "Betul!");
            }
            else
            {
                SetErrorMessages(txtEmail, "", "Format email salah!\nContoh: a@b.c", "");
            }
        }

        private void txtAngka1_Leave(object sender, EventArgs e)
        {
            if (txtAngka1.Text == "")
            {
                SetErrorMessages(txtHuruf, "Angka 1 tidak boleh kosong!", "", "");
            }
            else if (txtAngka1.Text.All(Char.IsNumber))
            {
                SetErrorMessages(txtAngka1, "", "", "Betul!");
            }
            else
            {
                SetErrorMessages(txtAngka1, "", "Inputan hanya boleh angka!", "");
            }
        }

        private void txtAngka2_Leave(object sender, EventArgs e)
        {
            if (txtAngka2.Text == "")
            {
                SetErrorMessages(txtAngka2, "Angka 2 tidak boleh kosong!", "", "");
            }
            else if (!txtAngka2.Text.All(Char.IsNumber))
            {
                SetErrorMessages(txtAngka2, "", "Inputan hanya boleh angka!", "");
            }
            else
            {
                int a1 = int.Parse(txtAngka1.Text);
                int a2 = int.Parse(txtAngka2.Text);

                if (a2 < a1)
                {
                    SetErrorMessages(txtAngka2, "", "", "Betul!");
                }
                else
                {
                    SetErrorMessages(txtAngka2, "", "Angka 2 harus lebih kecil dari Angka 1!", "");
                }
            }
        }
    }
}
