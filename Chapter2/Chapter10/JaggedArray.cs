//Chapter10 10.7 가변배열 
using System;

namespace Chapter10
{
    class JaggedArray
    {
       static void Main10_7(string[] args)
        {
            int[][] jagged = new int[3][];
            jagged[0] =new int[5] {1,2,3,4,5};
            jagged[1] = new int[] { 10, 20, 30 };
            jagged[2] = new int[] { 100, 2000 };

            foreach (int[] arr in jagged)
            {
                Console.Write("");
            }
            Console.WriteLine("");

            int[][] jagged2 = new int[2][]
            {
                new int[] { 1000, 2000 },
                new int[4] {6,7,8,9 } };

            foreach (int[] arr in jagged2)
            {
                Console.Write($"Length:{arr.Length},");
                foreach (int e in arr)
                {
                    Console.Write($"{e} ");
                }
                Console.WriteLine();
            }
        }
    }
}
