﻿//Chapter7장 정적 필드와 메소드 
using System;

namespace Chapter7
{
    class Global
    {
        public static int Count = 0; 
    }

    class ClassA
    {
       public ClassA()
        {
            Global.Count++;
        }
        
    }

    class  ClassB
    {
        public ClassB()
        {
            Global.Count++;
        }
        
    }

    //class MainApp
    //{
    //    static void Main()
    //    {
    //        Console.WriteLine($"Global.Count : {Global.Count}");   // 0

    //        new ClassA();
    //        new ClassA();
    //        new ClassB();
    //        new ClassB();

    //        Console.WriteLine($"Global.Count : {Global.Count}");   //4
    //    }
    //}

}
