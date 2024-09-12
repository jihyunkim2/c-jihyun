//Chapter4 4.11 null 병합 연산자
using System;
namespace NullCoalescing
{
    internal class NullCoalescing
    {
        static void Main(string[] args)
        {
            //int 뒤에는 ? 가 붙는데 string 뒤에는 안 붙는 이유는....?

            int? num = null;
            Console.WriteLine($"{num ?? 0}"); //num이 null이기 때문에 오른쪽 출력

            num = 29;
            Console.WriteLine($"{num ?? 0}"); //null이 아니기 때문에 29가 출력 

            string str = null;  //string은 대괄호 잊지말기 
            Console.WriteLine($"{str ?? "ABCD"}"); //null이기 때문에 ABCD 출력

            str = "APPLE";
            Console.WriteLine($"{str ?? "A"}");// null이 아니기 때문에 APPLE 출력




        }
    }
}
