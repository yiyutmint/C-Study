using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__study_08
{
    internal class Program
    {
        //오버로딩 : 매개변수의 개수난 차입이 다르면
        //함수(=메서드) 이름 똑같아도 서로 다른 것으로 간주함
        //java에도 있는 기능
        static void introduce(int age)
        {
            Console.WriteLine("내 나이는" + age + "살 입니다.");
        }
        static void introduce(string name)
        {
            Console.WriteLine("내 이름은" + name + "입니다.");
        }
        static void introduce()
        {
            Console.WriteLine("자기소개 메소드...");
        }
        static void Main(string[] args)
        {
            introduce(35);
            introduce("이동준");
            introduce();
            Rectangle.color = "파랑색";
            Rectangle rec1 = new Rectangle();
            rec1.width = 10;
            rec1.height = 5;
            Rectangle rec2 = new Rectangle();
            rec2.width = 7;
            rec2.height = 8;
            Rectangle rec3 = new Rectangle();
            Console.WriteLine("여기있는 모든 사각형의 색: " + Rectangle.color);
            //alt shift 화살표 위나 아래 누르면 여러 개 선택됨
            //ctrl alt 누르고 마우스클릭하면 여러 군게 선택 가능
            Console.WriteLine(rec1.getArea());
            Console.WriteLine(rec2.getArea());
            Console.WriteLine(rec3.getArea());
            Console.WriteLine(Rectangle.calcRecArea(100, 200));

            //Product p = new Product();
            //
            Product p1 = new Product("고구마", 500);
            Console.WriteLine(p1.name+"의 가격:"+p1.price);
            Product p2 = new Product("대게");
        }
    }
}
