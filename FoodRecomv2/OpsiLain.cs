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
    public partial class OpsiLain : Form
    {
        public OpsiLain()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAsin_Click(object sender, EventArgs e)
        {
            Form opsilainasin = new OpsiLainAsin();
            opsilainasin.Show();
        }

        private void btnManis_Click(object sender, EventArgs e)
        {
            picCake.Visible = true;
            picPie.Visible = true;
            lblCake.Visible = true;
            lblPie.Visible = true;
            lblWarning.Visible = true;
        }
    }
}
