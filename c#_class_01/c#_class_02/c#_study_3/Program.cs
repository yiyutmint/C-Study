using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace c__study_3
{
    internal class Program
    {
        //staic이 붗어 있는 메서드 안에는 static이 붙은 
        //메서드나 변수만 사용 가능함
        //staic없는 애는 쓸수 없음
        static void Helloworld(string[] args)
        {
            Console.WriteLine("hello world");

        }
        void Hiworld()
        {
            Console.WriteLine("Hi World");
        }
        static void Main(string[] arg)
        {
            Helloworld();

            Console.WriteLine(count);

            new Program().HelIoworld();

            Product p1 = new Product();
            p1.name = "감자";
            p1.price = 1000;
            Product.countOfProduct++;

            Product p2 = new Product() { name = "당근", price = 500 };
            Product.countOfProduct++;

            Console.WriteLine(p1.name);
            Console.WriteLine(p1.price);
            Console.WriteLine(p2.name);
            Console.WriteLine(p2.price);
            Console.WriteLine(Product.countOfProduct);
        }
    }
}
