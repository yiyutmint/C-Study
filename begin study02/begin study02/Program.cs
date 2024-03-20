using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace begin_study02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // java int double char String
            int a = 35;
            double b = 3.14;
            char c = 'A';
            string d = "바보야"; // string이랑 String이 동일함
            String d2 = "이유나";

            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);
            Console.WriteLine(long.MaxValue);
            Console.WriteLine(long.MinValue);
            Console.WriteLine("안녕하세요"[0]);
            Console.WriteLine("Text 입력해 보세요");
            string text = Console.ReadLine();
            Console.WriteLine("정수 입력해보세요");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(num + num);//숫자끼리 덧셈
            Console.WriteLine(text + num);//글자 이어붙이기

            Console.WriteLine("inch형 숫자을 입력하세요");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine($"{num1}inch = " + num1 * 2.54 + "cm");

            Console.WriteLine("kg단위의 숫자을 입력하세요");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"{num2}kg = " + num2 * 2.20462262 + "pound");

            Console.WriteLine("반지름을 입력하세요");
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("원의 반지름은" + num3);
            double pi = 3.14;
            Console.WriteLine("둘레 = " + 2 * pi * num3);
            Console.WriteLine("둘레 = " + pi * num3 * num3);

            Console.WriteLine("inch단위의 숫자를 입력하세요");
            int inch = int.Parse(Console.ReadLine());
            Console.WriteLine($"{inch}inch={inch*2.54}cm");
            Console.WriteLine(inch + "inch = "+(inch*2.54)+"cm");
            Console.WriteLine(string.Format("{0}inch={1}cm",inch,inch*2.54));

            //참고 주의 사항
            Console.WriteLine(10+2+"100");
            Console.WriteLine(10+"100"+2);
            Console.WriteLine(10+2+"100"+2+4);
            //먼저 더해야 하거나 연산 순서가 얘매하면 무조건 괄호로 묶을 것

            Console.WriteLine("몇 kg?");
            int kg = int.Parse(Console.ReadLine());
            Console.WriteLine($"{kg}kg={2.20462262*kg}pound");
            Console.WriteLine("원의 반지름 입력하세요");
            const double PI = 3.14;

            int r = int.Parse(Console.ReadLine());
            Console.WriteLine("둘레:" + (2 * PI * r));
            Console.WriteLine("넓이:" + (r * r * PI));

        }
    }
}
