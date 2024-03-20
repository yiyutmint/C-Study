using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace begin_study04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            for (int k = 0; k <= 100; k++) {
                i = i + k;
            }
            Console.WriteLine(i);

            StartPos;

            for (int h = 0xAC00; h <= 0xD7A3; h++)
            {
                Console.Write(char.ConvertFromUtf32(h));
            }
            // nums라는 배열 안에 있는 값들을 하나씩 item에 집어 넣어서
            // nums의 길이 만큼 반복문을 수행하는 것
            // foreach(var 요소 in 컬렉션){}
            // 켈렉션 = 배열이나 리스트
            Console.WriteLine();
            int[] nums = { 11, 10, 50, 27, 30 };
            foreach(var item in nums)
                Console.WriteLine(item);

            Console.WriteLine("숫자 입력");
            int num = int.Parse(Console.ReadLine());
            if (num < 0) ;
                goto StartPos;
            Console.WriteLine("프로그램 종료");

        }
    }
}
