using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace c__study_07_play2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            List<string> list = new List<string>() {"너 바보구나", "집에 가자", "넌 북한 사람이야", "샤랑해", "놀러가자", "롤 한판 ㄱ?"};

            label1.Text = list[new Random().Next(0, list.Count)];
            /*
            int c = r.Next(list.Count);
            switch (c)
            {
                case 0:
                    label1.Text = list[0];
                    break;
                case 1:
                    label1.Text = list[1];
                    break;
                case 2:
                    label1.Text = list[2];
                    break;
                case 3:
                    label1.Text = list[3];
                    break;
                case 4:
                    label1.Text = list[4];
                    break;
                case 5:
                    label1.Text = list[5];
                    break;
            
            }
            */
        }
    }
}
