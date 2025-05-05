using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kendiprojem
{
    public partial class OgretmenGirisi : Form
    {
        MySqlConnection con;
        MySqlDataReader dr;
        MySqlCommand com;
        public OgretmenGirisi()
        {
            InitializeComponent();
        }

        private void btnogrtgiris2_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtogrtad.Text;
            string sifre = txtogrtsif.Text;
            con = new MySqlConnection("Server=localhost; Database=projem; Uid=root; Pwd='nurdan37.';");
            com = new MySqlCommand();
            con.Open();
            com.Connection = con;
            com.CommandText = "Select*From ogretmen_kullanici where kullaniciAdi='" + txtogrtad.Text +
                "' AND sifre='" + txtogrtsif.Text + "'";
            dr=com.ExecuteReader();
            
            if (dr.Read())
            {
                
                OgretmenForm ogretmenForm = new OgretmenForm();
                ogretmenForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış!");
            }
            con.Close();
        }

        private void btnogrbas_Click(object sender, EventArgs e)
        {
            OgrenciGirisi ogretmenForm = new OgrenciGirisi();
            ogretmenForm.Show();
            this.Hide();
        }
    }
}
