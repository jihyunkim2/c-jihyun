//중첩 if문
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElse
{
    internal class IfIf                    
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int number = Int32.Parse(input);

            if (number < 0)
            {
                if (number % 2 == 0)
                    Console.WriteLine("0보다 작은 짝수");
                else
                    Console.WriteLine("0보다 큰 홀수");
            }
            else
            {
                Console.WriteLine("0보다 크거나 같은 수");
            }
        }
    }
}
