//chapter6 연습문제 03
using System;

namespace Chapter6
{
    class MainAPP666 {
        public static void Main66666()
        {
            int a = 3;
            int b = 4;
            int resultA = 0;

            Plus(a, b, out resultA); // 결과값이 되는곳은 out으로 정의 


            Console.WriteLine("{0}+{1}={2}",a,b,resultA);

            double x = 2.4;
            double y = 3.1;
            double resultB = 0;

            Plus(x, y, out resultB);

            Console.WriteLine("{0}+{1}={2}",x,y,resultB); // 주어진 조건에 따라 설정 
    }

        public static void Plus(int a, int b, out int c) //정수형일때의 메소드 설정
        {
            c = a + b;
        }

        public static void Plus(double a, double b, out double c) //실수형일 때의 메소드 설정 
        {
            c = a + b;
        }
    }

}
