//for문만 사용해서 삼각형 표현 
using System;

namespace ConsoleApp3
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j <= i; j++) //i+1번 실행
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < 5; i++) 
            {
                for (int j = 5; j >i; j--) //5-i번 실행  -> j =5 고정 (i => 1,2,3,4) 까지 반복
                { 
                    Console.Write("*");
                }
                Console.WriteLine();

            }



        }
    }
}
