//chapter6 연습문제 01
using System;

namespace Chapter6
{

    class MainApp6
    {
        static double Square(double arg)
        {
            //(조건) 받은 값으로 제곱하는 식 

            return arg*arg; // 받은 arg값을 두번 곱해서 결과 값이 제곱이 되어 나오게 만듦

        }

        static void Main66(string[] args)
        {

            Console.WriteLine("수를 입력하세요:");
            string input = Console.ReadLine(); //사용자에게 값을 입력받음
            double arg = Convert.ToDouble(input);  // arg (배열) 형식을 소수점이 있는 수로 바꾸기 위해 ToDouble 사용

            Console.WriteLine("결과 :{0}",Square(arg));

        }
    }
}
