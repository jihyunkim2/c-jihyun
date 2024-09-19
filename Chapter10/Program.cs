//chapter10 배열 
using System;
using System.Diagnostics.CodeAnalysis;
using System.Xml.Serialization;
using System.Collections; 

namespace Chapter10
{
    class MainApp
    {
        static void Main(string[] args)
        {
            ArrayList A = new ArrayList();
            for (int i = 0; i < 5; i++)
                A.Add(i);

            foreach (object obj in A)
                Console.Write($"{obj}  ");

            Console.WriteLine();

            A.Remove(3);

            foreach (object obj in A)
                Console.Write($"{obj}  ");

            Console.WriteLine();

            A.Insert(3, 1000);
            foreach (object obj in A)
                Console.Write($"{obj}  ");

            Console.WriteLine();
        }
          
    }
}
