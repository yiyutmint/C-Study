using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace c__study_08
{
    internal class Product
    {
        public string name {  get; set; }
        public int price { get; set; }

        //생성자 : new 키워드와 함께쓰이고
        //메모리를 할달하는 시점에 뭘 할지 정해주는 것
        //생성자를 적지 않아도
        // 아래와 같이 아무것도 없는 생성자가
        //자동으로 생성됨
        //public Product


        //
        //
        public Product(string name, int price)
        {
            this.name = name;
            this.price = price;
        }

        public Product (string name)
        {
            this.name = name;
            Console.WriteLine("아직 가격은 몰라요");
        }
        //매개변수 없는 생성자를 쓰고 싶다면

        // 앞에 접근 제한자가 없으면 private이 기본임
        //private은 해당 클래스 안에서만 접근됨
        //즉 다른 클레스에서는 접근이 불가능
        string description { get; set; }
        private int vipPrice { get; set; }

        public void setvipPrice(int vipPrice)
        {
            this.vipPrice = vipPrice;
        }

        public int gerVipPrice()
        {
            return vipPrice;
        }
        //private인 것들을 다른 곳에서
        //접근하려면 public인 메서드가
        //필요해 짐...

        //p2.description

        //java에서 웬만하면 getter/setter쓰듯이 말이다.
    }
}
