using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__study_08
{
    internal class Rectangle
    {
        public int width {  get; set; }
        public int height { get; set; }
        public static string color { get; set; }
        
        public int getArea() { return width * height;}
        //일반적인 사각형의 넓이 구해주는 메서드
        //클래스 메서드이므로 메개변수에 따라서 결과가 변함
        public static int calcRecArea(int w, int h) { return w * h; }
    }
}
