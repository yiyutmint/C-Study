using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace c__study_07_student
{   
    public partial class Form1 : Form
    {   
        public Form1()
        {
            InitializeComponent();
            List<st> students = new List<st>();
            students.Add(new st { name = "이동준", grade = 1 });
            students.Add(new st { name = "동준이", grade = 2 });
            students.Add(new st { name = "준동이", grade = 3 });
            students.Add(new st { name = "준준이", grade = 4 });
            students.Add(new st { name = "동동이", grade = 1 });
            students.Add(new st { name = "이이이", grade = 2 });


            for (int i = 0; i < students.Count; i++)
            {
                // 코드 상으로 라벨을 새로 만드는 것
                Label label = new Label();
                label.Text = $"{students[i].grade} 학년 {students[i].name} 학생";
                label.AutoSize = true;  // 글자 크기에 맞게 라벨 맞추기
                label.Location = new Point(13, 13 + (23 + 3) * i);
                Controls.Add(label);// 이거 없으면 화면에 출력 안됨
            }
            for (int i = 0;i < students.Count-1;i--)
            {
                if (students[i].grade > 1)      
                {
                    students.RemoveAt(i);
                }
            }
            for (int i = 0; i <= students.Count;i++)
            {
                Label label = new Label();
                label.Text = $"{students[i].grade} 학년 {students[i].name} 학생";
                label.AutoSize = true;  // 글자 크기에 맞게 라벨 맞추기
                label.Location = new Point(130, 13 + (23 + 3) * i);
                Controls.Add(label);// 이거 없으면 화면에 출력 안됨
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
