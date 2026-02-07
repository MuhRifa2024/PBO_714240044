using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIPK_KSR.view
{
    public partial class ParentForm : Form
    {
        public ParentForm()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void anggotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Petugas petugasForm = new Petugas();
            petugasForm.MdiParent = this;
            petugasForm.Show();
        }

        private void penagananToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Penanganan formP = new Penanganan();
            formP.MdiParent = this;
            formP.Show();
        }

        private void pasienKorbanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pasien formPas = new Pasien();
            formPas.MdiParent = this;
            formPas.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ParentForm_Load(object sender, EventArgs e)
        {
            
        }

        private void ParentForm_Resize(object sender, EventArgs e)
        {
            this.Refresh();
        }
    }
}
