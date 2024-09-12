
namespace Chapter10
{
    internal class ArraySample
    {
        static void Main(string[] args)
        {
            int[] scores=new int[5];
            scores[0] = 10;
            scores[1] = 20;
            scores[2] = 30;
            scores[3] = 40;
            scores[4] = 50;    //인덱스 값을 정하고 차례대로 값을 넣어줌

            foreach(int i in scores) 
                Console.WriteLine(i);  //값들이 차례대로 출력되게 함

            int sum = 0;
            foreach (int i in scores) //값들을 차례대로 더해줌
                sum += i;

            int average = sum/scores.Length;  //(Length는 배열의 용량)

            Console.WriteLine($"Average Score:{average}");
                
        }
    }
}

