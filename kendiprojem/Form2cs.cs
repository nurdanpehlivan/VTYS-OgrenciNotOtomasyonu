using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kendiprojem
{
    public partial class Form2cs : Form
    {

        MySqlConnection conn = new MySqlConnection("Server=localhost; Database=projem; Uid=root; Pwd='nurdan37.';");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;
        public Form2cs()
        {
            InitializeComponent();
        }
        void VeriGetirr()
        {
            dt = new DataTable();
            conn.Open();
            adapter = new MySqlDataAdapter("SELECT * FROM program", conn);
            adapter.Fill(dt);
            datagridprogram.DataSource = dt;
            conn.Close();
        }
        private void txtDerslerim_TextChanged(object sender, EventArgs e)
        {

                string isim = txtDerslerim.Text.Trim(); // TextBox'a girilen metni al ve baştaki ve sondaki boşlukları kaldır

                // Veritabanından isme göre arama sorgusu
                string sql = "SELECT * FROM program WHERE pazartesi LIKE @pazartesi";
                cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@pazartesi", "%" + isim + "%"); // Aranan isim içeren herhangi bir sonuç döndürmek için '%' kullanarak arama
                try
                {
                    conn.Open();
                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());
                    conn.Close();

                    // DataGridView'i doldur
                    datagridprogram.DataSource = dt;
                }
                catch
                {

                }
            }

        private void Form2cs_Load(object sender, EventArgs e)
        {
            VeriGetirr();
        }

        private void btngeriş_Click(object sender, EventArgs e)
        {
            OgrenciEkrani ogrenciEkrani = new OgrenciEkrani();
            ogrenciEkrani.Show();
            this.Hide();
        }
    }
    }

