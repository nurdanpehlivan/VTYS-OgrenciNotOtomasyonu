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
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void btnogrgiris_Click(object sender, EventArgs e)
        {
            OgrenciGirisi ogrenci = new OgrenciGirisi();
            ogrenci.Show();
            this.Hide();
        }

        private void btnogrtgiris_Click(object sender, EventArgs e)
        {
            OgretmenGirisi ogretmen = new OgretmenGirisi();
            ogretmen.Show();
            this.Hide();
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {

        }

        private void btnyardim_Click(object sender, EventArgs e)
        {
            Diyagram dyg = new Diyagram();
            dyg.Show();
            this.Hide();
        }
    }
}
