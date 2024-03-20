using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace begin_study3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random md = new Random();
            // md.Next(6)
            int num = md.Next(6) + 1;

            switch (num) 
            {
                case 1:
                case 2:
                    Console.WriteLine("1 아님 2 나옴");
                    break;
                case 3:
                    Console.WriteLine("3이 나옴");
                    break;
                case 4:
                    Console.WriteLine("4가 나옴");
                    break;
                case 5:
                case 6:
                    Console.WriteLine("5~6");
                    break;
               
            }
           
            Console.WriteLine("태어난 연도뒷 두자리를 입력하세요");
            int year = int.Parse(Console.ReadLine());
            if ((year % 12) == 0)
            {
                Console.WriteLine("쥐띠 입니다.");
            }else if ((year % 12) == 1)
            {
                Console.WriteLine("소띠 입니다.");
            }
            else if ((year % 12) == 2)
            {
                Console.WriteLine("호랑이띠 입니다.");
            }
            else if ((year % 12) == 3)
            {
                Console.WriteLine("토끼띠 입니다.");
            }
            else if ((year % 12) == 4)
            {
                Console.WriteLine("용띠 입니다.");
            }
            else if ((year % 12) == 5)
            {
                Console.WriteLine("뱀띠 입니다.");
            }
            else if ((year % 12) == 6)
            {
                Console.WriteLine("말띠 입니다.");
            }
            else if ((year % 12) == 7)
            {
                Console.WriteLine("양띠 입니다.");
            }
            else if ((year % 12) == 8)
            {
                Console.WriteLine("원숭이띠 입니다.");
            }
            else if ((year % 12) == 9)
            {
                Console.WriteLine("닭띠 입니다.");
            }
            else if ((year % 12) == 10)
            {
                Console.WriteLine("개띠 입니다.");
            }
            else if ((year % 12) == 11)
            {
                Console.WriteLine("돼지띠 입니다.");
            }

            Console.WriteLine("올해는");
            int k = ((DateTime.Now.Year+8) % 12);
            switch (k)
            {
                case 0:
                    Console.WriteLine("쥐띠 입니다");
                    break;
                case 1:
                    Console.WriteLine("소띠 입니다");
                    break;
                case 2:
                    Console.WriteLine("호랑이띠 입니다");
                    break;
                case 3:
                    Console.WriteLine("토끼띠 입니다");
                    break;
                case 4:
                    Console.WriteLine("용띠 입니다");
                    break;
                case 5:
                    Console.WriteLine("뱀띠 입니다");
                    break;
                case 6:
                    Console.WriteLine("말띠 입니다");
                    break;
                case 7:
                    Console.WriteLine("양띠 입니다");
                    break;
                case 8:
                    Console.WriteLine("원숭이띠 입니다");
                    break;
                case 9:
                    Console.WriteLine("닭띠 입니다");
                    break;
                case 10:
                    Console.WriteLine("개띠 입니다");
                    break;
                case 11:
                    Console.WriteLine("돼지띠 입니다");
                    break;
            }
            
            Console.WriteLine("오늘은 몇 월 입니까?");
            int m = int.Parse(Console.ReadLine());
            if (m == 12 || m == 1 | m == 2)
            {
                Console.WriteLine("지금은 겨울입니다.");
            }else if (m == 3 | m == 4 | m == 5)
            {
                Console.WriteLine("지금은 봄입니다.");
            }
            else if (m == 6 | m == 7 | m == 8)
            {
                Console.WriteLine("지금은 여름입니다.");
            }
            else if (m == 9 | m == 10 | m == 11)
            {
                Console.WriteLine("지금은 가을입니다.");
            }

            Console.WriteLine("이번달은 ");
            int d = (DateTime.Now.Month);
            switch (d)
            {
                case 12:
                    
                case 1:
                    
                case 2:
                    Console.WriteLine("겨울 입니다");
                    break;
                case 3:
                    
                case 4:
                    
                case 5:
                    Console.WriteLine("봄 입니다");
                    break;
                case 6:
                    
                case 7:
                    
                case 8:
                    Console.WriteLine("여름 입니다");
                    break;
                case 9:
                    
                case 10:
                    
                case 11:
                    Console.WriteLine("겨울 입니다");
                    break;
                default:
                    break;
            }
        }
    }
}
