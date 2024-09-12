using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
//using 뒤의 시스템을 사용하겠다고 컴파일러에 알리는 역할 (코드 글자 수를 줄일 수 있음)

namespace Hello
{
    internal class MainApp
    {
        static void Main(string[] args)  //프로그램 실행 시작 되는 곳 (이름이 Main인 메소드)
        {
            if (args.Length ==0)
            {
                WriteLine("사용법 : Hello.exe <이름>");
                return;

            }
            WriteLine("Hello, {0}!", args[0]);
            
        }

        
    }
}
