using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4
{
    internal class Program
    {
        static void Power(int input)
        {
            int k;
            k = input*input;
            Console.WriteLine(k);
        }

        static void Power(int input, int count)
        {
            int k=1;
            for (int i = 0; i < count; i++)
            {
                k *= input;
            }
            Console.WriteLine(k);
        }

        static void SumAll(int end)
        {
            int k = 0;
            for (int i = 0; i <= end; i++)
            {
                k += i;
            }
            Console.WriteLine(k);
        }

        static void SumAll(int start, int end)
        {
            for (int i=start+1; i <= end; i++)
            {
                start += i;
            }
            Console.WriteLine(start);

        }
        static void Main(string[] args)
        {
            Power(2);

            Power(2, 4);

            SumAll(5);

            SumAll(1, 6);

            int a = new Program().power(2);
            Console.WriteLine(a);

            a= new Program().power(2, 3);
            Console.WriteLine(a);

        }


        public int power(int input)
        {
            return input*input;
        }

        public int power(int input, int count)
        {
            int result = 1;
            for(int i = 0;i < count; i++)
            {
                result *= input;
            }
            return result;
        }
    }
}
