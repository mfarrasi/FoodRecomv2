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
    public partial class LittleManis : Form
    {
        public LittleManis()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            picBuah.Visible = true;
            lblBuah.Visible = true;
            picIndomaret.Visible = false;
            picRoti.Visible = false;
            picSereal.Visible = false;
            lblIndo.Visible = false;
            lblRoti.Visible = false;
            lblSereal.Visible = false;
        }

        private void btnProses_Click(object sender, EventArgs e)
        {
            picIndomaret.Visible = true;
            picRoti.Visible = true;
            picSereal.Visible = true;
            lblIndo.Visible = true;
            lblRoti.Visible = true;
            lblSereal.Visible = true;
            picBuah.Visible = false;
            lblBuah.Visible = false;
        }
    }
}
