using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace c__study_07_play
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int c = r.Next(1, 3);
            switch (c)
            {
                case 1:
                    com.Text = "가위";
                    Resurlt.Text = "비김";
                    break;
                case 2: 
                    com.Text = "바위";
                    Resurlt.Text = "너 짐";
                    break;
                case 3: 
                    com.Text = "보";
                    Resurlt.Text = "이김";
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int c = r.Next(1, 3);
            switch (c)
            {
                case 1:
                    com.Text = "가위";
                    Resurlt.Text = "이김";
                    break;
                case 2:
                    com.Text = "바위";
                    Resurlt.Text = "비김";
                    break;
                case 3:
                    com.Text = "보";
                    Resurlt.Text = "너 짐";
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int c = r.Next(1, 3);
            switch (c)
            {
                case 1:
                    com.Text = "가위";
                    Resurlt.Text = "너 짐";
                    break;
                case 2:
                    com.Text = "바위";
                    Resurlt.Text = "이김";
                    break;
                case 3:
                    com.Text = "보";
                    Resurlt.Text = "비김";
                    break;
            }
        }
    }
}
