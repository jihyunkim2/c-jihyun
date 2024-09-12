//chapter5 연습문제 5
using System;

namespace Chapter5
{
    internal class Chapter5_practice04
    {
        static void Main(string[] args)
        {
            Console.WriteLine("반복 횟수를 입력하세요:");
            string input = Console.ReadLine();  //사용자가 반복횟수를 입력함 
            int number = Convert.ToInt32(input); //주어진 조건에서 string형식으로 받았기 때문에 문자열을 숫자로 변환

            if (number <= 0) //만약 사용자가 0보다 작거나 0인값을 입력했을때 (조건)
            {
                Console.WriteLine("0보다 작거나 같은 숫자는 사용할 수 없습니다");
                goto EXIT;  //-> goto를 사용하여 사용자가 처음부터 입력하도록 만듦
            }

            for (int i = 0; i < 5; i++) //위의 조건이 아닐시에는 0부터 시작해서 5미만까지 1씩 증가하는 for문 정의 
            {
                for (int j = 0; j <= i; j++) //for문 중첩 정의 
                {
                    Console.WriteLine("*");
                }
                Console.ReadLine();
            }
        EXIT:
            Console.WriteLine(); //사용자가 0을 입력 할 경우 다시 돌아옴 
        }
    }
}
