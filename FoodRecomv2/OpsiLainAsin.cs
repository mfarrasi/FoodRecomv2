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
    public partial class OpsiLainAsin : Form
    {
        public OpsiLainAsin()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDaging_Click(object sender, EventArgs e)
        {
            picSteak.Visible = true;
            lblKaya.Visible = true;
            lblRM.Visible = true;
            lblSteak.Visible = true;
            picAyamGoreng.Visible = false;
            picKFC.Visible = false;
            picGeprek.Visible = false;
            picAyamBakar.Visible = false;
            lblAyamBakar.Visible = false;
            lblGeprek.Visible = false;
            lblKFC.Visible = false;
            lblAyamGoreng.Visible = false;
            picIkanBakar.Visible = false;
            picIkanGoreng.Visible = false;
            lblIkan.Visible = false;
            lblIkanBakar.Visible = false;
            lblIkanGoreng.Visible = false;
            picSayur.Visible = false;
            picNasgor.Visible = false;
            picMieGor.Visible = false;
            lblNasgor.Visible = false;
            lblMieGor.Visible = false;
            lblSayur.Visible = false;
        }

        private void btnAyam_Click(object sender, EventArgs e)
        {
            picAyamGoreng.Visible = true;
            picKFC.Visible = true;
            picGeprek.Visible = true;
            picAyamBakar.Visible = true;
            lblAyamBakar.Visible = true;
            lblGeprek.Visible = true;
            lblKFC.Visible = true;
            lblAyamGoreng.Visible = true;
            picSteak.Visible = false;
            lblKaya.Visible = false;
            lblRM.Visible = false;
            lblSteak.Visible = false;
            picIkanBakar.Visible = false;
            picIkanGoreng.Visible = false;
            lblIkan.Visible = false;
            lblIkanBakar.Visible =false;
            lblIkanGoreng.Visible = false;
            picSayur.Visible = false;
            picNasgor.Visible = false;
            picMieGor.Visible = false;
            lblNasgor.Visible = false;
            lblMieGor.Visible = false;
            lblSayur.Visible = false;
        }

        private void btnIkan_Click(object sender, EventArgs e)
        {
            picIkanBakar.Visible = true;
            picIkanGoreng.Visible = true;
            lblIkan.Visible = true;
            lblIkanBakar.Visible = true;
            lblIkanGoreng.Visible = true;
            picSteak.Visible = false;
            lblKaya.Visible = false;
            lblRM.Visible = false;
            lblSteak.Visible = false;
            picAyamGoreng.Visible = false;
            picKFC.Visible = false;
            picGeprek.Visible = false;
            picAyamBakar.Visible = false;
            lblAyamBakar.Visible = false;
            lblGeprek.Visible = false;
            lblKFC.Visible = false;
            lblAyamGoreng.Visible = false;
            picSayur.Visible = false;
            picNasgor.Visible = false;
            picMieGor.Visible = false;
            lblNasgor.Visible = false;
            lblMieGor.Visible = false;
            lblSayur.Visible = false;
        }

        private void btnVegetarian_Click(object sender, EventArgs e)
        {
            picSayur.Visible = true;
            picNasgor.Visible = true;
            picMieGor.Visible = true;
            lblNasgor.Visible = true;
            lblMieGor.Visible = true;
            lblSayur.Visible = true;
            picSteak.Visible = false;
            lblKaya.Visible = false;
            lblRM.Visible = false;
            lblSteak.Visible = false;
            picAyamGoreng.Visible = false;
            picKFC.Visible = false;
            picGeprek.Visible = false;
            picAyamBakar.Visible = false;
            lblAyamBakar.Visible = false;
            lblGeprek.Visible = false;
            lblKFC.Visible = false;
            lblAyamGoreng.Visible = false;
            picIkanBakar.Visible = false;
            picIkanGoreng.Visible = false;
            lblIkan.Visible = false;
            lblIkanBakar.Visible = false;
            lblIkanGoreng.Visible = false;
        }
    }
}
