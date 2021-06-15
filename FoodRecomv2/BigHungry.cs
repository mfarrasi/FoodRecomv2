using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodRecomv2
{
    public partial class BigHungry : Form
    {
        public BigHungry()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOpsiLain_Click(object sender, EventArgs e)
        {
            Form opsilain = new OpsiLain();
            opsilain.Show();
        }
    }
}
