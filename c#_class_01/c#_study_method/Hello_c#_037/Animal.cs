﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Hello_c__037
{
    public class Animal //Animal 상속받은 클래스들은
    {   //age,name 속성 있고, Sleep, LivingWorld, Fight를 쓸 수 있음
        //Animal 상속받지 않은 다른 클래스에서는
        //age,name, Sleep, LivingWorld에 접근 가능함
        public int age { get; set; }
        public string name { get; set; }

        public static string zooName { get; set; }
        public void Sleep()
        {
            Console.WriteLine("잠을 잡니다.");
        }
        public void LivingWorld()
        {
            if (age <= 0)
                Run();
            else
                Fight();
        }
        protected void Fight() //Animal을 상속한 class에서만 호출 가능
        {
            Console.WriteLine("영역을 지키기 위해 싸웁니다.");
        }
        private void Run() //Animal 안에서만 사용 가능
        {
            Console.WriteLine("도망을 갑니다.");
        }
        public void Eat()
        {
            Console.WriteLine("냠냠");
        }
        public virtual void Charm()
        {
            Console.WriteLine("사랑해용~~");
        }
        public virtual void cry()
        {
            Console.WriteLine("ㅠㅠ");
        }

        
    }
}
