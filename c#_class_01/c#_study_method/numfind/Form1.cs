using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace numfind
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Random r = new Random();
            int num = r.Next(1, 10);
            label1.Text = num.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ( label1.Text == textBox1.)
            {
                Console.WriteLine("정답입니다.");
            }
            if(label1.Text != textBox1.Text)
            {

            }
        }
    }
}
