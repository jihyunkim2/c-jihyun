//chapter10  10.5 이차원 배열 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter10
{
    class _2DArray
    {
        static void Main101010(string[] args)
        {
            int[,] arr = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } }; // 이차원 배열 생성 

            for (int i = 0; i < arr.GetLength(0); i++) 
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.WriteLine($"[{i},{j} : {arr[i,j]}");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

        }
    }
}
