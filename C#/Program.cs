using System;

namespace C_
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            string a0 = "캔디";
            int b = 3;

            string ab = a0 + b + "개";
            Console.WriteLine(ab);   //결과: 캔디 3개 

            //-배열-
            int[] a1 = new int[10];
            a1[0] = 1;
            a1[2] = 10; //0에는 1 2에는 10 ~...

            int[] a = new int[10]; //1차원 배열
            int[,] a = new int[10, 20]; //2차원 배열
            int[,,] a = new int[10, 20, 30]; //3차원 배열

            int[,] a3 =
            {
                {10,20},
                {30,20},
                {50,60}
            };

            Console.WriteLine("a3[0,0]=" + a3[0, 0] + "a3[1,0]=" + a3[1, 0]);
            Console.WriteLine("a3[1,0]=" + a3[1, 0] + "a3[1,1]=" + a3[1, 1]);
            Console.WriteLine("a3[2,0]=" + a3[2, 0] + "a3[2,1]=" + a3[2, 1]);   //재그 배열 추가 공부 (2차원 이상의 배열에서 요소 수가 일정하지 않고 들쭉날쭉한 배열)

            // 배열의 수 
            int[] a4 = new int[4];
            int b4 = a4.Length; //-> b4는 4

            int[,] a5 = new int[2, 4];
            int b5 = a5.Length; //->8
        }
        //열거형 (enum)

        enum Animal { mouse, cat, bird, dog = 100, koala, pig = 200, lion };
        //정수값은 0 1 2 100 101 200 201 순으로 증가 하게됨 (기본적으로 0부터 시작)

        //여기서 식별자를 참조하는 방법

            Console.WriteLine(Animal.cat); //cat
            Console.WriteLine((int) Animal.pig); //200    (연습문제 2,3,4 복습하기)

            //연산자 
            //산술 연산자 (수의 연산에 사용)
            //대입 연산자 
             int a9 = 10;

            a9 += 11;

            Console.WriteLine("10에 11을 더하면" + a9 +"입니다.");

            //비교 연산자 
            //우선 순위가 낮은 연산자는 ()로 묶어준다.

            //조건 연산자 ([?:]) 맞으면 왼쪽값 맞지 않으면 오른쪽 값;

            bool= value;
            value =true;  //참이라면
            string a5 = value ? A : B; //A가 출력 됨 참이 나ㅣ면 B 출력


            // 논리 연산자는 좀 더 복잡한 조건일때 사용
            //(a>=10)&&(a<50)   <- &&가 논리 연산자 

            //형의 변환  *정수끼리 계산에서는 범위가 가장 큰 범위의 형으로 변환 됨)

           // 2진수 접수사 0b / 16진수 접두사  0x 또는 x0

           //어떤 값도 가지지 않는 변수가 필요 할 때 변수에 할당된 메모리 공간을 비워 둘 수 있도록 Nullable을 사용한다.



           

            




        }

       





            
            


           

            






            

























        }
    }
}
