using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace retry
{
    internal class Program
    {
        static void Helloworld()
        {
            Console.WriteLine("Hello world!");
        }
        void Hiworld()
        {
            Console.WriteLine("Hi world");
        }
        static int count = 0;
        int number = 0;

        static void Main(string[] args)
        {
            Helloworld();
            // Hiworld();//static 붙은 애가 메모리가 먼저 올라감
            //static 시점에선 static 붙지 않은 변수나 함수는
            //아직 존재하지 않은 것이다.
            Console.WriteLine(count);
            //Console.WriteLine(number);

            //굳이 static 없는 걸 main으로 쓰고 싶다면 
            //자기 자신을 객체화 해야 함
            //이렇게 하면 메모리가 할당이 되게 되고
            //그러면 static이 붙은 메서드 안에서도 쓸 수 있음
            new Program().Hiworld();

            //인스턴스 별로 다른 값 갖는 것: 인스턴스 변수(static 없음)
            //클래스 별로 같은 값 갖는 것: 클래스 변수(static 있음)
            Product p1 = new Product();
            p1.name = "감자";
            p1.price = 1000;
            Product.countOfProduct++;

            Product p2 = new Product() {name="당근", price=500};
            Product.countOfProduct++;

            Console.WriteLine(p1.name);
            Console.WriteLine(p1.price);
            Console.WriteLine(p2.name);
            Console.WriteLine(p2.price);
            Console.WriteLine(Product.countOfProduct);
        }
    }
}
