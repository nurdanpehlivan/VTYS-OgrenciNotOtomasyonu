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
    public partial class OgrenciEkrani : Form
    {
        public OgrenciEkrani()
        {
            InitializeComponent();
        }

        private void btnsinavekranı_Click(object sender, EventArgs e)
        {
           OgrenciForm ogrenciForm = new OgrenciForm();
           ogrenciForm.Show();
           this.Hide();
        }

        private void btnOrtalamaEkranı_Click_1(object sender, EventArgs e)
        {
            Form3 ogrenciForm = new Form3();
            ogrenciForm.Show();
            this.Hide();
        }

        private void btnDersPEkranı_Click(object sender, EventArgs e)
        {
            Form2cs ogrenciForm = new Form2cs();
            ogrenciForm.Show();
            this.Hide();
        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            OgrenciGirisi ogrenciForm = new OgrenciGirisi();
            ogrenciForm.Show();
            this.Hide();
        }

        /*  private void btnDersPEkranı_Click_1(object sender, EventArgs e)
          {

          }*/
    }
    }

