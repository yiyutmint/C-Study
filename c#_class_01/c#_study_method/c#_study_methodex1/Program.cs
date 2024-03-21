using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__study_methodex1
{
    internal class Program
    {
        static void change(int d, int f) // 원본에 영향을 미치지 않는다.
        {
            int s;
            
            s = f;
            f = d;
            d = s;

            Console.WriteLine("a1="+d);
            Console.WriteLine("b1=" + f);
        }

        static void change2(student student)
        {
            student.name = "안위재";
            student.age = 30;
            student.score = 0;
        }
        static void swap(ref int a1, ref int b1) // 원본에 영향을 미친다.
        {
            int c = b1;
            b1 = a1;
            a1 = c;
        }
        
        static void Main(string[] args)
        {
            int a = 3;
            int b = 5;
            int c;

            c = b;
            b = a;
            a = c;
            
            Console.WriteLine("a="+a);
            Console.WriteLine("b="+b);

            int a1 = 3;
            int b1 = 5;
            
            change(a1, b1); // 원본에 영향을 못미치는 경우
            Console.WriteLine("a1=" + a1);
            Console.WriteLine("b1=" + b1);

            swap(ref a1, ref b1); // 원본에 영향을 미치는 경우
            Console.WriteLine("a1=" + a1);
            Console.WriteLine("b1=" + b1);

            student s = new student();
            s.age = 30;
            s.name = "권성직";
            s.score = 100;
            
            student dj = s;
            dj.score = 0;
            dj.name = "이동준";
            Console.WriteLine(s.name+","+s.age+","+s.score);
            Console.WriteLine(dj.name+","+dj.age+","+dj.score);

            change2(dj);
            Console.WriteLine(dj.name + "," + dj.age + "," + dj.score);
        }
    }
}
