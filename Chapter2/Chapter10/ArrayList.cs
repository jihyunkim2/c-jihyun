//chapter10 ArrayList
using System;
using System.Collections;

namespace Chapter10
{
    class ArrayList
    {
        static void Main10_7_1(string[] args)
        {
            ArrayList list= new ArrayList();
            for (int i = 0; i < 5; i++) 
                list.Add(i); // 가장 마지막에 있는 요소 뒤에 하나씩 추가

            foreach (object obj in list)
                Console.Write($"{obj}");
            Console.WriteLine(); // 결과 0 1 2 3 4

            list.RemoveAt(2); //두번째 인덱스 삭제  

            foreach(object obj in list)
                Console.Write

            
        }
    }
}
