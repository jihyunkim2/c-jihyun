//chapter6 return
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter6
{
    internal class Return
    {
        static int Fibonacci(int n) // 반환형식이 int 인 메소드를 정의 
        {
            if (n < 2)
                return 0;
            else
                return Fibonacci(n - 1) + Fibonacci(n - 2);  //자기 자신을 재귀호출
        }
        static void PrintProfile(string name, string phone) // 반환하지 않아도 되는 메소드 
        {
            if (name == "")
            {
                Console.WriteLine("이름을 입력해주세요 ");
                return;
            }
        
             Console.WriteLine("Name:{0}, phone:{1}",name,phone);  //결과가 출력
            }

        static void Main(string[] args) //최종 메인 메소드 
        {
            Console.WriteLine("10번째 피보나치 수 : {0}", Fibonacci(10)); //첫 메소드에서 정의 한 값

            PrintProfile("", "123-4567");
            PrintProfile("김지현", "456-7890");  //두번째 메소드에서 정의됨
        }

    }
}
