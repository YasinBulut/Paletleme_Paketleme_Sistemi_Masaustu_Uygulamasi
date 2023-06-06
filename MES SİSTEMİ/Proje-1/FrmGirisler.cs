using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_1
{
    public partial class FrmGirisler : Form
    {
        public FrmGirisler()
        {
            InitializeComponent();
        }

        private void btnhastagiris_Click(object sender, EventArgs e)
        {
            FrmMusteriGiris fr = new FrmMusteriGiris();
            fr.Show();
            //this.Hide();
        }

        private void btndoktorgiris_Click(object sender, EventArgs e)
        {
            FrmMühendisGiris fr = new FrmMühendisGiris();
            fr.Show();
            //this.Hide();
        }

        private void btnsekretergiris_Click(object sender, EventArgs e)
        {
            FrmİKGiris fr = new FrmİKGiris();
            fr.Show();
            //this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
