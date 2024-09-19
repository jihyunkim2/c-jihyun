//if문& for문 사용해서 삼각형 만들기 
using System;

namespace ConsoleApp7
{
    class MainApp
    {
        public static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (j > (5 - (i * 2)) / 2)
                    {
                        if (j <= (5 - (i * 2)) / 2)
                        { Console.Write("*"); }

                    }
                    else
                    { Console.Write(" "); }
                }
                Console.WriteLine();

            }
        }
    }
}
