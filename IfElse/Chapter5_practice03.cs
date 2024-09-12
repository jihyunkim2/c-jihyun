//chapter5 연습문제 03
//연습문제01을 whlie문 으로 변경
using System.Text;
using System.Threading.Tasks;

namespace Chapter5
{
    internal class Chapter5_practice03
    {
        static void Main(string[] args)
        {
            int i= 0;  //초기값은 0에서 부터 시작하도록 정의 
            while (i < 5) { //i가 1씩 늘어나며 5 미만까지만 증가하도록 정의 
                int j = 0; 
                while (j <= i)
                {
                    Console.WriteLine("*");
                    j += 1; //마찬가지로 *의 개수가 한줄이 늘어날 때 마다 같이 한개씩 늘어나도록 while 중첩문을 통해 정의 
                }
                Console.WriteLine();
                i += 1;
                               
            }
        }
    }
}
