using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace begin_study05
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int floor = 5;
            
            for (int i = 0; i < floor; i++) 
            {
                // 공백 찍는 부분
                for (int j = floor - i; j > 1; j--)
                {
                    Console.Write(" ");
                }
                
                // *찍는 부분
                for (int j = 0; j < 2 * i + 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            int dloor = 5;

            for (int i = 0; i < dloor; i++)
            {
                //공백 찍는 부분
                for (int j = dloor - i; j > 1; j--)
                    Console.Write(" ");

                //별 찍는 부분
                for (int j = 0; j < 2 * i + 1; j++)
                    Console.Write("*");
                Console.WriteLine();//줄 띄어쓰기
            }

            /*int[] numbers = new int[5];
            for (int i = 0;i < numbers.Length;i++)
            {
                Console.WriteLine(i + 1 + "번쨰 값 입력");
                numbers[i] = int.
            }
            */

            /*
            1, 11, 12, 1121, 122111, 112213
            첫 번째 수열: 1
            두 번째 수열: 1이 1개 = 11
            세 번째 수열: 1이 2개 = 12
            네 번째 수열 1이 1개, 2가 1개 = 1121
            다섯 번째 수열: 1이 2개, 2가 1개, 1이 1개 = 122111
            여섯 번째 수열: 1이 1개, 2가 2개, 1이 3개 = 112213
            일곱 번째 수열: 1이 2개, 2가 2개, 1이 1개, 3이 1개 = 12221131 
            여덟 번째 수열: 1이 1개, 2가 3개, 1이 2개, 3이 1개, 1이 1개 = 1123123111
            아홉 번째 수열: 1이 2개, 2가 1개, 3이 1개, 1이 1개, 2가 1개, 3이 1개, 1이 3개 = 12213111213113
            열 번째 수열: 1이 1개, 2가 2개, 1이 1개, 3이 1개, 1이 3개, 2가 1개, 1이 1개, 3이 1개, 1이 2개, 3이 1개 = 11221131132111311231

            */

            int n = 20; // 출력할 수열의 개수
            int j = 1;

            string num = "1";


            for (int i = 2; i <= n; i++)
            {
                int nums = 1;
                int arraynum =

                string[] array = new string[j];

                while ( == nums)
                if (array[j] == array[j - 1])
                {
                    nums++;
                }
            }




        }

    }
}
