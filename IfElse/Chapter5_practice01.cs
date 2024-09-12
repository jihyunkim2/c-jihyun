//chapter5 연습문제1
using System;

namespace Chapter5
{
    internal class Chapter5_practice01
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++) 
                //i가 0부터 5 미만까지 1씩 커지도록 for문 정의 (=총 5개의 줄이 나온다)
                // 내림차순으로 나타내려면 for(int=4;i>=0;i--) 으로 변경  
            {
                for (int j = 0; j <= i; j++) //줄이 한줄씩 늘어날수록 * 의 갯수도 하나씩 늘어나도록  for문 중첩 정의 
                {
                    Console.WriteLine("*");
                }
                Console.WriteLine(); //한줄씩 추가 되도록 설정
            }
                }
    }
}
