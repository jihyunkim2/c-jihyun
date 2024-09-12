//Chapter6 출력 전용 매개변수 (복습 필요)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter6
{
    internal class UsingOut
    {
        static void Divide(int a, int b, out int q, out int r)  //1) Dicide 라는 이름의 메소드에 매개변수 int로 입력 될 인수와 출력 될 인수를 설정
        {
            q = a / b; 
            r = a % b; //2) 앞서 설정한 인수들로 출력 값이 어떻게 나올지 식을 설정

        }

        static void Main(string[] args) //3) 첫번째 메소드에 값을 설정 해 줄 두번째 메소드 
        {
            int a = 20; 
            int b = 3; //4)매개변수의 값을 정함


            Divide(a, b, out int c, out int d); // 5) 첫번째 메소드를 사용해서 입력값과 출력값을 담음

            Console.WriteLine($"a:{a}, b:{b}, a/b:{c}, a%b:{d}"); //6) 최종 출력

            }
    }
}
