//Chapter3 3.4.1

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Chapter3
{
    internal class integralTypes
    {
        static void Main(string[] args)
        {

            sbyte a = -10; //부호 있는 정수 (부호 비트 0=양수 & 1=음수)
             byte b = 10; //양의 값만 가능


            Console.WriteLine($"a={a}, b={b}");

            int e = -1000_0000; //정수 
            uint f = 3_0000_0000; //_로 구분하면 편하다.

            Console.WriteLine($"e={e}, f={f}");
        
        
        }
    }
}
