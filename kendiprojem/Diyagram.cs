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
    public partial class Diyagram : Form
    {
        public Diyagram()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AnaForm anaForm = new AnaForm();
            anaForm.Show();
            this.Hide();
        }
    }
}
