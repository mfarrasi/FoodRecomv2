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
    public partial class HungryLevel : Form
    {
        public HungryLevel()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Form veryhungry = new BigHungry();
            veryhungry.Show();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Form mediumhungry = new MediumHungry();
            mediumhungry.Show();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Form littlehungry = new LittleHungry();
            littlehungry.Show();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ini merupakan aplikasi yang merekomendasikan suatu makanan kepada Anda berdasarkan input yang diberikan.\n \n" +
                "Hasilnya hanya sebuah rekomendasi, jadi tidak tentu sesuai dengan selera Anda. \n \n" +
                "Aplikasi ini tidak menyediakan rekomendasi minuman.");
        }
    }
}
