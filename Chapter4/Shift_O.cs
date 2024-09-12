//Chapter4 4.9.1 시프트 연산자.
using System;

namespace ShiftOperator
{
    internal class Shift_O
    {
        static void Main(string[] args)
        {
            int a = 1; //양수일 때
            Console.WriteLine("a : {0:D5} (0 x {0:x8})", a);
            // * D5=10진수 5자리 x8=16진수 8자리 
            Console.WriteLine("a<<1 :{0:D5} (0 x {0:x8})", a << 1);

            int b = -5; //음수일 때
            Console.WriteLine("b : {0:D5} (0 x {0:x8})", b);
            Console.WriteLine("b>>1: {0:D5} (0 x {0:x8})", b >> 1);

        }
    }
}
