//Chapter6 
//메소드는 복잡한 프로그램을 만들기 위해서는 Main() 메소드 안에 모든 코드를 넣기 어려워서 사용

using System;

namespace Chapter6
{
    internal class Calaulator
    {
        public static int Plus(int a, int b) // [한정자] [반환형식] [메소드 이름] (매개변수 목록)                                          
        {
            return a + b;
        }
        //사용 예제: int x=Calaulator.Plus (3,4); x=7       // 인수 =3,4 

        public static int Minus(int a, int b)
        {
            return a - b;
        }
        //사용 예제: int x=Calaulatoe.Minus(4,3); x=1
    }

    internal class Calaulator2
    {
        public static void Main()
        {

            int result = Calaulator.Plus(1, 2); //인수 1,2  *Calaulator.Plus() 에 매개변수를 넘김*
            Console.WriteLine(result);

            int result2 = Calaulator.Minus(3, 4); //인수 3,4
            Console.WriteLine(result2);


        }
    }

    
}
