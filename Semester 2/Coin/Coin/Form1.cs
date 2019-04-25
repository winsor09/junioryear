using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coin
{
    public partial class Form1 : Form
    {
        int odds = 0;
        public Form1()
        {
            InitializeComponent();

        }

        private void flip_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            odds = rand.Next(1, 3);

            if (odds == 1)
            {
                pictureBox1.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "heads.jpg"); 
            }

            if (odds == 2)
            {
                pictureBox1.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "tails.jpg"); 
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
