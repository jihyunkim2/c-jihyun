using System;

namespace ConsoleApp2
{
    class Global
    {
        public static int Count = 0;
    }

    class GlobalA
    {
        public GlobalA()
        { Global.Count++; }

    }

    class GlobalB
    {
        public GlobalB()
        { Global.Count--; }

    }

    class MainApp
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"Global.Count:{Global.Count}");

            new GlobalA();
            new GlobalA();
            new GlobalB();


            Console.WriteLine($"Global.Count:{Global.Count}");

        }
    }
}
