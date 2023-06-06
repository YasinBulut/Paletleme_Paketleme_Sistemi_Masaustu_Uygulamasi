﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proje_1
{
    public partial class FrmMusteriDüzenle : Form
    {
        public FrmMusteriDüzenle()
        {
            InitializeComponent();
        }
        public string TCno;
        SqlBaglantisi bgl = new SqlBaglantisi();

        private void FrmHastaDüzenle_Load(object sender, EventArgs e)
        {
            msktc.Text = TCno;
            SqlCommand komut = new SqlCommand("Select * From Tbl_Hastalar where MusteriTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",msktc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtad.Text = dr[1].ToString();
                txtsoyad.Text = dr[2].ToString();
                msktelefon.Text = dr[4].ToString();
                txtsifre.Text = dr[5].ToString();
                cmbcinsiyet.Text = dr[6].ToString();
            }
            bgl.baglanti().Close();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("Update Tbl_Hastalar set MusteriAd=@p1,MusteriSoyad=@p2,MusteriTelefon=@p3,MusteriSifre=@p4,MusteriCinsiyet=@p5 where MusteriTc=@p6", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1",txtad.Text);
            komut2.Parameters.AddWithValue("@p2",txtsoyad.Text);
            komut2.Parameters.AddWithValue("@p3", msktelefon.Text);
            komut2.Parameters.AddWithValue("@p4", txtsifre.Text);
            komut2.Parameters.AddWithValue("@p5", cmbcinsiyet.Text);
            komut2.Parameters.AddWithValue("@p6", msktc.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgileriniz Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
