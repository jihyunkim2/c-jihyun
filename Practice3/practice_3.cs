//chapter3 연습문제(형식변환 사용)
//Convert.Tostring() :숫자 데이터 형식-> 문자열 
//Convert.Toint32() :숫자 데이터 형식 -> 정수 형식 
//Convert.ToDuble() :숫자 데이터 형식 -> 실수 형식 
//Convert.ToChar() : 입력받은 숫자 또는 문자열 하나 -> 문자로 형식 변경
using System;
using static System.Console;

namespace Practice3
{
    internal class practice_3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("사각형의 너비를 입력하세요"); 
            string width = Console.ReadLine(); 
            //ReadLine을 사용하여
            //콘솔창에서 사용자가 값을 입력뒤 엔터를 누르면 문자열을 반환하고 다음작업 결정하도록 함 

            Console.WriteLine("사각형의 높이를 입력하세요");
            string height = Console.ReadLine(); //마찬가지로 사용자가 높이 입력

            int area = Convert.ToInt32(width) * Convert.ToInt32(height);
            //string 형식의 문자열로 입력을 받았기 때문에 ToInt32를 써서 정수형식으로 바꾸어 줌 

            Console.WriteLine("사각형의 넓이는:{0}",area); //최종 출력으로 사각형의 넓이가 나타나도록 함 
        }
    }
}
