using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace kendiprojem
{
    public partial class Form3 : Form
    {
        MySqlConnection conn = new MySqlConnection("Server=localhost; Database=projem; Uid=root; Pwd='nurdan37.';");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;
        public Form3()
        {
            InitializeComponent();
        }

        void VeriGetirr()
        {
            dt = new DataTable();
            conn.Open();
            adapter = new MySqlDataAdapter("SELECT * FROM notlar", conn);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }
        void GecmeNotuHesapla()
        {
            foreach (DataRow row in dt.Rows)
            {
                double vize = Convert.ToDouble(row["vize"]);
                double final = Convert.ToDouble(row["final"]);
                double gecmeNotu = vize * 0.4 + final * 0.6;
                row["gecmeNotu"] = gecmeNotu;

                string harfNotu;
                if (gecmeNotu >= 90)
                    harfNotu = "AA";
                else if (gecmeNotu >= 80)
                    harfNotu = "BA";
                else if (gecmeNotu >= 75)
                    harfNotu = "BB";
                else if (gecmeNotu >= 70)
                    harfNotu = "CB";
                else if (gecmeNotu >= 60)
                    harfNotu = "CC";
                else if (gecmeNotu >= 50)
                    harfNotu = "DC";
                else if (gecmeNotu >= 40)
                    harfNotu = "DD";
                else if (gecmeNotu >= 30)
                    harfNotu = "FD";
                else
                    harfNotu = "FF";

                row["harf_notu"] = harfNotu;
            }
        }

        private void txtOrtHesapla_TextChanged(object sender, EventArgs e)
        {
            string isim = txtOrtHesapla.Text.Trim(); // TextBox'a girilen metni al ve baştaki ve sondaki boşlukları kaldır

            // Veritabanından isme göre arama sorgusu
            string sql = "SELECT * FROM notlar WHERE ders LIKE @ders";
            cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ders", "%" + isim + "%"); // Aranan isim içeren herhangi bir sonuç döndürmek için '%' kullanarak arama
            try
            {
                conn.Open();
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                conn.Close();

                // DataGridView'i doldur
                dataGridView1.DataSource = dt;
            }
            catch
            {

            }
        }

        private void btngerii_Click(object sender, EventArgs e)
        {
            OgrenciEkrani ogrenciEkrani = new OgrenciEkrani();
            ogrenciEkrani.Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            VeriGetirr();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dersAdi = txtOrtHesapla.Text.Trim(); // TextBox'a girilen metni al ve baştaki ve sondaki boşlukları kaldır

            DataView dv = new DataView(dt);
            dv.RowFilter = string.Format("ders LIKE '%{0}%' AND gecmeNotu >= 55", dersAdi);

            dataGridView1.DataSource = dv;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string isim = txtOrtHesapla.Text.Trim(); // TextBox'a girilen metni al ve baştaki ve sondaki boşlukları kaldır

            // Veritabanından isme göre arama sorgusu
            string sql = "SELECT * FROM bolum_ortalama WHERE bolum_adi LIKE @bolum_ortalama";
            cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@bolum_ortalama", "%" + isim + "%"); // Aranan isim içeren herhangi bir sonuç döndürmek için '%' kullanarak arama
            try
            {
                conn.Open();
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                conn.Close();

                // DataGridView'i doldur
                dataGridView1.DataSource = dt;
            }
            catch
            {

            }
           
        }
    }
}
