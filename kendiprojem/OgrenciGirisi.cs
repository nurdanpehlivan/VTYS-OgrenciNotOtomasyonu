using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace kendiprojem
{
    public partial class OgrenciGirisi : Form
    {
        MySqlConnection con;
        MySqlDataReader dr;
        MySqlCommand com;
        public OgrenciGirisi()
        {
            InitializeComponent();
        }
       

        private void btnogrgiris2_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtograd.Text;
            string sifre = txtogrsif.Text;

            con = new MySqlConnection("Server=localhost; Database=projem; Uid=root; Pwd='nurdan37.';");
            com = new MySqlCommand();
            con.Open();
            com.Connection = con;
            com.CommandText = "Select*From ogrenci_kullanici where kullaniciAdi='" + txtograd.Text +
                "' AND sifre='" + txtogrsif.Text + "'";
            dr = com.ExecuteReader();

            if (dr.Read())
            {

                OgrenciEkrani ogrenciForm = new OgrenciEkrani();
                ogrenciForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış!");
            }
            con.Close();
        }

        private void btnogrtbas_Click(object sender, EventArgs e)
        {
            OgretmenGirisi ogrenciForm = new OgretmenGirisi();
            ogrenciForm.Show();
            this.Hide();
        }

        private void btnogrtbas_Click_1(object sender, EventArgs e)
        {
            OgretmenGirisi ogrenciForm = new OgretmenGirisi();
            ogrenciForm.Show();
            this.Hide();
        }
    }
}
