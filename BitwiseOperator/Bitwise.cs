//Chapter4 4.9.2 비트 논리 연산자
using System;

namespace BitwiseOperator
{
    internal class Bitwise
    {
        static void Main(string[] args)
        {
            int a = 9; //1001
            int b = 10; //1010

            Console.WriteLine($"{a}&{b} : {a&b}"); //AND 논리곱 연산자 사용
            Console.WriteLine($"{a}|{b} : {a}|{b}");//OR 논리합 연산자 사용
            Console.WriteLine($"{a}^{b} : {a}^{b}");//XOR 배타적 논리합 연산자 사용

        }
    }
}
