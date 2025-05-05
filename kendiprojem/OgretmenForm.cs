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
    public partial class OgretmenForm : Form
    {
        MySqlConnection conn = new MySqlConnection("Server=localhost; Database=projem; Uid=root; Pwd='nurdan37.';");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;
        string cinsiyet;

        public OgretmenForm()
        {
            InitializeComponent();
        }
        void VeriGetir()
        {
            dt = new DataTable();
            conn.Open();
            adapter = new MySqlDataAdapter("SELECT * FROM ogrenciler", conn);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }
        void LoadBolumler()
        {
            try
            {
                conn.Open();
                string query = "SELECT bolum_id, bolum_adi FROM bolumler";
                adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                cmbBolum.DataSource = dt;
                cmbBolum.DisplayMember = "bolum_adi";
                cmbBolum.ValueMember = "bolum_id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bölümler yüklenirken bir hata oluştu: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }


        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            string isim = txtAra.Text.Trim(); // TextBox'a girilen metni al ve baştaki ve sondaki boşlukları kaldır

            // Veritabanından isme göre arama sorgusu
            string sql = "SELECT * FROM ogrenciler WHERE isim LIKE @isim";
            cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@isim", "%" + isim + "%"); // Aranan isim içeren herhangi bir sonuç döndürmek için '%' kullanarak arama
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

        private void txtNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            string cinsiyet;

            if (rdbErkek.Checked)
            {
                cinsiyet = "Erkek";
            }
            else if (rdbKadın.Checked)
            {
                cinsiyet = "Kadın";
            }
            else
            {
                // Cinsiyet seçimi yapılmadıysa bir hata mesajı gösterilebilir veya varsayılan bir değer atanabilir.
                MessageBox.Show("Lütfen cinsiyet seçimi yapınız.");
                return; // Metodu burada sonlandırıyoruz, çünkü cinsiyet seçimi yapılmamış.
            }
            int bolumId = (int)cmbBolum.SelectedValue;


            string sql = "INSERT INTO ogrenciler (isim, soyisim, okulno, nott, cinsiyet, bolum_id) " +
                         "VALUES (@isim, @soyisim, @okulno, @nott, @cinsiyet, @bolum_id)";
            cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", txtId.Text);
            cmd.Parameters.AddWithValue("@isim", txtAd.Text);
            cmd.Parameters.AddWithValue("@soyisim", txtSoyad.Text);
            cmd.Parameters.AddWithValue("@okulno", txtNo.Text);
            cmd.Parameters.AddWithValue("@nott", txtNot.Text);
            cmd.Parameters.AddWithValue("@bolum_id", bolumId);

            cmd.Parameters.AddWithValue("@cinsiyet", cinsiyet);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Kayıt eklendi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kayıt eklenirken bir hata oluştu: " + ex.Message);
            }
            finally
            {
                conn.Close();
                VeriGetir();
            }
        }


        private void btnSil_Click(object sender, EventArgs e)
        {
        
           
            string sql = "DELETE FROM ogrenciler WHERE id=@id";
            cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", txtId.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            VeriGetir();
            MessageBox.Show("Kayit silindi");
            
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            string cinsiyet;
            if (rdbErkek.Checked)
            {
                cinsiyet = "Erkek";
            }
            else if (rdbKadın.Checked)
            {
                cinsiyet = "Kadın";
            }
            else
            {
                MessageBox.Show("Lütfen cinsiyet seçimi yapınız.");
                return;
            }

            int bolumId = (int)cmbBolum.SelectedValue;

            string sql = "UPDATE ogrenciler " +
                         "SET isim=@isim, soyisim=@soyisim, nott=@nott, bolum_id=@bolum_id, cinsiyet=@cinsiyet " +
                         "WHERE okulno=@okulno";
            cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@isim", txtAd.Text);
            cmd.Parameters.AddWithValue("@soyisim", txtSoyad.Text);
            cmd.Parameters.AddWithValue("@cinsiyet", cinsiyet);
            cmd.Parameters.AddWithValue("@bolum_id", bolumId);
            cmd.Parameters.AddWithValue("@nott", txtNot.Text);
            cmd.Parameters.AddWithValue("@okulno", txtNo.Text);

            try
            {
                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Kayıt güncellendi.");
                }
                else
                {
                    MessageBox.Show("Kayıt bulunamadı veya güncellenmedi.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kayıt güncellenirken bir hata oluştu: " + ex.Message);
            }
            finally
            {
                conn.Close();
                VeriGetir();
            }
        }


        private void OgretmenForm_Load(object sender, EventArgs e)
        {
            VeriGetir();
            LoadBolumler();
            txtId.ReadOnly = true;

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtSoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtNo.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                cmbBolum.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                txtNot.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                txtId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                int bolumId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[6].Value);
                cmbBolum.SelectedValue = bolumId;
                string cinsiyet = dataGridView1.CurrentRow.Cells["cinsiyet"].Value.ToString();
                if (cinsiyet == "Kadın")
                {
                    rdbKadın.Checked = true;
                    rdbErkek.Checked = false;
                }
                else
                {
                    rdbErkek.Checked = true;
                    rdbKadın.Checked = false;
                }
            }
            catch
            {

            }

        }
        private void rdbKadın_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbKadın.Checked)
            {
                cinsiyet = "Kadın";
            }
        }

        private void rdbErkek_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbErkek.Checked)
            {
                cinsiyet = "Erkek";
            }
        }

        private void cmbBolum_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AnaForm ogrenciEkrani = new AnaForm();
            ogrenciEkrani.Show();
            this.Hide();
        }

        /*  private void rdbKadın_CheckedChanged_1(object sender, EventArgs e)
          {

              rdbKadın.Checked=true;
          }
        */

    }
}
