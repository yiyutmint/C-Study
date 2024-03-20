using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace c__study_07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            Comnum.Text = r.Next(1, 5).ToString();
            if (Comnum.Text == button4.Text)
            {
                Result.Text = "Good";
            }
            if (Comnum.Text != button4.Text)
            {
                Result.Text = "bad";
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            Comnum.Text = r.Next(1, 5).ToString();
            if (Comnum.Text == button1.Text)
            {
                Result.Text = "Good";
            }
            if (Comnum.Text != button1.Text)
            {
                Result.Text = "bad";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            Comnum.Text = r.Next(1, 5).ToString();
            if (Comnum.Text == button2.Text)
            {
                Result.Text = "Good";
            }
            if (Comnum.Text != button2.Text)
            {
                Result.Text = "bad";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            Comnum.Text = r.Next(1, 5).ToString();
            if (Comnum.Text == button3.Text)
            {
                Result.Text = "Good";
            }
            if (Comnum.Text != button3.Text)
            {
                Result.Text = "bad";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            Comnum.Text = r.Next(1, 5).ToString();
            if (Comnum.Text == button5.Text)
            {
                Result.Text = "Good";
            }
            if (Comnum.Text != button5.Text)
            {
                Result.Text = "bad";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
