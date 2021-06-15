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
    public partial class MediumHungry : Form
    {
        public MediumHungry()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAsin_Click(object sender, EventArgs e)
        {
            picBurger.Visible = true;
            picKebab.Visible = true;
            picMarMesir.Visible = true;
            picSate.Visible = true;
            lblBurger.Visible = true;
            lblKebab.Visible = true;
            lblMarMesir.Visible = true;
            lblSate.Visible = true;
            picMarManis.Visible = false;
            picRotBar.Visible = false;
            lblMarManis.Visible = false;
            lblRotBar.Visible = false;
        }

        private void lblMarManis_Click(object sender, EventArgs e)
        {

        }

        private void btnManis_Click(object sender, EventArgs e)
        {
            picMarManis.Visible = true;
            picRotBar.Visible = true;
            lblMarManis.Visible = true;
            lblRotBar.Visible = true;
            picBurger.Visible = false;
            picKebab.Visible = false;
            picMarMesir.Visible = false;
            picSate.Visible = false;
            lblBurger.Visible = false;
            lblKebab.Visible = false;
            lblMarMesir.Visible = false;
            lblSate.Visible = false;
        }
    }
}
