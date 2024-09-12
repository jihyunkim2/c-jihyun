//Chapter10.3
using System;
using System.Runtime.Serialization;

namespace Chapter10
{
    internal class MoreOnArray
    {
        class MaimApp103
        {
            private static bool CheckPassed(int score)
            {
                return score >= 0;                   
            }
            private static void Print(int value)
            {
                Console.WriteLine($"{value}");
            }

            static void Main(string[] args)
            {
                int[] scores = new int[] { 80, 74, 81, 90, 34 };

                foreach (int score in scores) 
                    Console.WriteLine($"{score}");
                Console.WriteLine();

                Array.Sort(scores); //배열을 정렬시킴
                Array.ForEach<int>(scores, new Action<int>(Print)); //배열의 모든 요소에 대해 동일한 작업 수행시킴
                Console.WriteLine();

                Console.WriteLine($"Number of dimensions : {scores.Rank}"); //배열의 차원 반환

                Console.WriteLine($"BInary Seach : 81 si at "+$"{Array.BinarySearch<int>(scores,81)}"); //이진 탐색 

                Console.WriteLine($"Linear Search : 90 is at" + $"{Array.IndexOf(scores, 90)}");// 배열에서 찾고자 하는 특정 데이터의 인덱스를 반환

                Console.WriteLine($"Everyone passed ?:" + $"{Array.TrueForAll<int>(scores, CheckPassed)}"); //배열의 모든 요소가 지정한 조건에 부합하는지 여부를 반환











            }
        }
    }
}
