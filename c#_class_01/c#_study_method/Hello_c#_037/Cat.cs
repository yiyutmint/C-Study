using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_c__037
{
    public class Cat : Animal
    {
        public void Meow()
        {
            Console.WriteLine("야옹");
        }
        public void Eat()// 빨간줄 (=경고)가뜸 
        {
            Console.WriteLine("고양이 처럼 먹는다");
        }
        public override void Charm()
        {
            Console.WriteLine("집사 잘했네");
        }

        public new void cry()
        {
            Console.WriteLine("집사 ㅜㅜㅜ, 이럴줄 몰랐어 ㅠㅠㅠㅠ");
        }
    }
}
