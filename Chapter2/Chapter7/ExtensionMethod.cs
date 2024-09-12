//Chapter7 확장 메소드
using Chapter7;
using System;

//확장메소드를 선언
namespace Chapter7
{
    public static class IntegerExtnesion
    {
        public static int  Square(this int myInt) //확장 메소드 1
        {
            return myInt*myInt;
        }

        public static int Power(this int myInt, int exponent) //확장 메소드2
        {
            int result = myInt;
            for (int i = 1; i <= exponent; i++)
                result = result * myInt;

            return result;
        }

    }
}

//확장메소드를 사용
namespace ExtensionMethod
{
    class MainApp
    {
        static void Main3(string[] args)
        {
            Console.WriteLine($"3^2:{ 3.Square()} "); //3x3
            Console.WriteLine($"3^4:{3.Power(4)}");  //3x3^3
            Console.WriteLine($"2^10:{2.Power(10)}"); //2x2^9

        }
    }
}
