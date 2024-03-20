using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            label1.Text = "";
            label2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text=textBox_test.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox_test_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (false)
            {
                Random losstto = new Random();

                int[] lottonum = new int[6];
                int rNum = 0;

                for (int i = 0; i < lottonum.Length; i++)
                {
                    while (lottonum[i] < lottonum[i + 1])
                    {
                        while (lottonum[i] != lottonum[i + 1])
                        {
                            rNum = losstto.Next(1, 49);
                            lottonum[i] = rNum;
                        }
                    }

                }
            }

            int[] lotto = new int[6];
            Random r = new Random();
            for (int i = 0;i < lotto.Length;i++)
            {
                int num = r.Next(45)+1;
                if (lotto.Contains(num)) // num이 로또안에 이미 있는 경우
                {
                    i--;
                    continue;
                }
                lotto[i] = num;
            }
            int bns = r.Next(45)+1;
            while (lotto.Contains(bns))
            {
                bns = r.Next(45) + 1;
            }
            Array.Sort(lotto); // 오름차순 정령
            label2.Text = string.Join(", ", lotto);
            label2.Text += "보너스 번호 :" + bns;
            


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //디자인 창에서는 없었던 텍스트 박스를 생성

        private void button3_Click(object sender, EventArgs e)
        {
            TextBox temp = new TextBox();
            temp.Text = "임시 텍스트 박스";
            temp.Location = new Point(100, 100);
            Controls.Add(temp);
        }


    }
}
