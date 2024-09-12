//Chapter3 3.4.5 

using static System.Console;
using System;


namespace Object
{
    internal class Object_3
    {
        static void Main(string[] args)
        {

            // 어떤 데이터 형식이든 다룰 수 있다.
            object a = 123;
            object b = "안녕하세요";
            object c = true;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

        }
    }
}
