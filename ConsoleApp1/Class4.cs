//9장 연습문제 
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;

namespace ConsoleApp1
{
    class MainApp
    {
        static void Main(string[] args)
        {
            var nameCard = new {Name="박상현", Age= 17};
            Console.WriteLine("이름:{0},나이:{1}", nameCard.Name, nameCard.Age);

            var Complex = new { Real = 3, Imaginary = -12 };
            Console.WriteLine("Real:{0}, Imaginary:{1}", Complex.Real, Complex.Imaginary);


        }
    }
    
    
}

