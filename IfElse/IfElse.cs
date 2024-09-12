//Chapter5 5.1.1

using System;

namespace IfElse
{
    internal class IfElse
    {
        static void Main(string[] args)
        {
            Console.WriteLine("숫자를 입력하세요:");

            string input = Console.ReadLine(); //사용자에게 문자열을 입력받아서 결과를 반환하는 코드
            int number = Int32.Parse(input);

            if (number > 0) 
                Console.WriteLine("양수");

            else if (number < 0) 
                 Console.WriteLine("음수");

            else
                 Console.WriteLine("0");


            if (number % 2 == 0)
                Console.WriteLine("짝수");
            else
                Console.WriteLine("홀수");
                  
            
        }
    }
}
