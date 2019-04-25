using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intro_to_WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            do_something.MouseEnter += (o, e) => ChangeColor(Color.Red);
            do_something.MouseLeave += (o, e) => ChangeColor(Color.Blue);
        }

        public void ChangeColor(Color c)
        {
            do_something.BackColor = c;
        }



        private void do_something_Click(object sender, EventArgs e)
        {
            if (fail_safe.Checked && dateTimePicker.Value < DateTime.Now)
            {
                Environment.Exit(0);
            }

            else
            {
                Bitmap b = new Bitmap(pictureBox.Width, pictureBox.Height);
                Random rand = new Random();

                for (int x = 0; x < pictureBox.Width; x++)
                {
                    for (int y = 0; y < pictureBox.Height; y++)
                    {
                        b.SetPixel(x, y, rand.Next(0, 2) == 0 ? Color.Red : Color.Blue);
                    }
                }


                pictureBox.Image = b;
            }


        }

        private void label_Click(object sender, EventArgs e)
        {

        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (textBox.Text == "Quit Program")
            {
                Environment.Exit(0);
            }
        }
    }
}
