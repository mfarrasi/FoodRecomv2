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
    public partial class LittleHungry : Form
    {
        public LittleHungry()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnManis_Click(object sender, EventArgs e)
        {
            Form fresh = new LittleManis();
            fresh.Show();
        }

        private void btnAsin_Click(object sender, EventArgs e)
        {
            picBakso.Visible = true;
            picGorengan.Visible = true;
            lblBakso.Visible = true;
            lblGorengan.Visible = true;
        }
    }
}
