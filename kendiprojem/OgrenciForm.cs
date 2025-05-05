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
using System.Data.SqlClient;

namespace kendiprojem
{
    public partial class OgrenciForm : Form
    {
        MySqlConnection conn = new MySqlConnection("Server=localhost; Database=projem; Uid=root; Pwd='nurdan37.';");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;

        public OgrenciForm()
        {
            InitializeComponent();
        }
        void VeriGetir()
        {
            dt = new DataTable();
            conn.Open();
            adapter = new MySqlDataAdapter("SELECT * FROM sinavlarim", conn);
            adapter.Fill(dt);
            datagridsinav.DataSource = dt;
            conn.Close();
        }

        private void OgrenciForm_Load(object sender, EventArgs e)
        {
            VeriGetir();
            
        }

        private void txtSınavlarım_TextChanged(object sender, EventArgs e)
        {
            string isim = txtSınavlarım.Text.Trim(); 

            // Veritabanından her gün için ayrı ayrı arama sorgusu
            string sql = "SELECT * FROM sinavlarim WHERE dersAdı LIKE @dersAdı";
            cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@dersAdı", "%" + isim + "%"); // Aranan ders adını içeren herhangi bir sonuç döndürmek için '%' kullanarak arama
            try
            {
                conn.Open();
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                conn.Close();

                // DataGridView'i doldur
                datagridsinav.DataSource = dt;
            }
            catch
            {

            }
        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            OgrenciEkrani ogrenciEkrani = new OgrenciEkrani();
            ogrenciEkrani.Show();
            this.Hide();
        }
    }
}
