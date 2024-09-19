using System;
using System.Collections;
namespace Chapter10_2
{
    class MyEnumerator
    {
        int[] number = { 1, 2, 3, 4 }; //배열설정    
        public IEnumerator GetEnumerator()
        {
            yield return number[0];
            yield return number[1];
            yield return number[2];
            yield break;
            yield return number[3];
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            var obj = new MyEnumerator();
            foreach (var i in obj)
            {
                Console.WriteLine(i);
            }
        }

    }
}
