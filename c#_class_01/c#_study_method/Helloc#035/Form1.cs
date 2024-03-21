using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.SymbolStore;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Helloc_035
{
    public partial class Form1 : Form
    {
        int mytime = 0;
        const int LIMIT = 10;
        int answer = 0;
        public Form1()
        {
            InitializeComponent();
            label1.Text = "";
            answer = new Random().Next(9) + 1;
            Console.WriteLine(answer);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            mytime++;
            if(mytime >= LIMIT)
            {
                label1.Text = "timeover";
            }
            else
            {
                label1.Text = mytime + "/" + LIMIT + "초경과";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int mynum = int.Parse(textBox1.Text);
            if(mynum == answer)
            {
                label1.Text = "정답";
                timer1.Enabled = false;// 타이머 1중단
            }
        }
    }
}
