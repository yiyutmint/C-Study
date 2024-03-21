using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    internal class Program
    {
        static Dictionary<int, long> memo = new Dictionary<int, long>();
        static long fibo(int i)
        {
            if (i <= 0)
            {
                return 0;
            }
            if(i == 1)
            {
                return 1;
            }
            return fibo(i-2) + fibo(i-1);
        }

        static long Fibo(int i)
        {
            if(i <= 0)
            {
                return 0;
            }
            if(i == 1)
            {
                return 1;
            }
            if(memo.ContainsKey(i))
                return memo[i];
            else
            {
                long value = Fibo(i-2) + Fibo(i - 1);
                memo[i] = value;
                return value;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now.ToString("mm분ss초fff"));
            Console.WriteLine(fibo(40));
            Console.WriteLine(DateTime.Now.ToString("mm분ss초fff"));
            Console.WriteLine(Fibo(100));
            Console.WriteLine(DateTime.Now.ToString("mm분ss초fff"));
        }
    }
}
