//chater10 10.1
using System;

namespace Chapter10
{
    class MainApp
    {
        static void Main10(string[] args)
        {
            string[] array1 = new string[] { "안녕", "Hello", "Halo" };
            //new string[3]{ "안녕", "Hello", "Halo" }
            //{ "안녕", "Hello", "Halo" }  -> 총 3가지 방법으로 배열 표현 가능
            Console.WriteLine("array1");
            foreach (string s in array1)
                Console.WriteLine($"{s}");

        }
    }
 
}
