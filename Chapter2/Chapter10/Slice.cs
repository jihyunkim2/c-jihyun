//Chapter10 10.4
using System;

namespace Chapter10
{
    class MainApp1010
    {
        static void PrintArray(System.Array array) //배열 출력 메소드 
        {
            foreach (var a in array)
                Console.Write(a); //배열의 오소 출력
            Console.WriteLine(); //줄바꿈

        }
        static void Main(string[] args)
        {
            char[] array = new char['Z' - 'A' + 1];
            for (int i = 0; i < array.Length; i++)  // for문 사용해서 array에 A부터 Z까지 입력
                array[i] = (char)('A' + i);

            PrintArray(array[..]);//0번째부터 마지막까지
            PrintArray(array); //5번째부터 끝까지 

            Range range_5_10 = 5..10;
            PrintArray(array[range_5_10]); //5번째부터 9번째까지

            Index last = ^0; //마지막 인덱스 
            Range range_5_last = 5..last;
            PrintArray(array[range_5_last]);

            PrintArray(array[^4..^1]); //끝에서 4번째부터 끝에서 2번째까지 

        }
    }
}
