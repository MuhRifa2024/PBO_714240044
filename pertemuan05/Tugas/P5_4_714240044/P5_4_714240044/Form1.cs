using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5_4_714240044
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InisialisasiJK();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void InisialisasiJK()
        {
            Jk.DropDownStyle = ComboBoxStyle.DropDownList;
            if (Jk.Items.Count > 0)
                Jk.SelectedIndex = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void InpTlDF_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Jk_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void rb_sab_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BtnDF_Click(object sender, EventArgs e)
        {
            var kelas = new List<string>();
            if (cb_bola.Checked) kelas.Add("Sepak Bola");
            if (cb_Bas.Checked) kelas.Add("Basket");
            if(cb_bultang.Checked) kelas.Add("Bulu Tangkis");
            if (cb_pan.Checked) kelas.Add("Panahan");
            if(cb_renang.Checked) kelas.Add("Renang");
            if(cb_ten.Checked) kelas.Add("Tenis");
            if(cb_vol.Checked) kelas.Add("Voli");
            if(cb_yoga.Checked) kelas.Add("Yoga");

            if (kelas.Count == 0)
            {
                MessageBox.Show("Harus memilih salah satu dari pilihan kelas", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string jadwal = "";
            if (rb_sen.Checked) jadwal = rb_sen.Text;
            else if (rb_sel.Checked) jadwal = rb_sel.Text;
            else if (rb_sab.Checked) jadwal = rb_sab.Text;
            else if (rb_ming.Checked) jadwal = rb_ming.Text;

            if (jadwal == "")
            {
                MessageBox.Show("Harus memilih salah satu dari pilihan jadwal", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var tanggal = tl.Value.ToString("dd MMMM yyyy");
            MessageBox.Show(
                "Nama: " + txtNama.Text +
                "\nJenis Kelamin: " + Jk.SelectedItem.ToString() +
                "\nTanggal Lahir: " + tanggal +
                "\nPilihan Kelas: " + string.Join(", ", kelas) +
                "\nPilihan Jadwal: " + jadwal,
                "Informasi Pendaftaran",
                MessageBoxButtons.OK, MessageBoxIcon.Information
                );
            
        }

        private void btn_beres_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
