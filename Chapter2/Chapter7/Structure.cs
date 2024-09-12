//Chapter7 구조체 
using System;

namespace Chapter7
{
    struct Strucrure
    {
        public int x;
        public int y;
        public int z;

        public Strucrure(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public override string ToString()
        {
            return string.Format($"{x},{y},{z}");

        }
    }
    class Main8
    {
        static void Main7(string[] args)
        {
            Strucrure A; //구조체 (struct)는 선언만으로 인스턴스 생성 가능 (new 필요 없음) 
            A.x = 10;
            A.y = 20;
            A.z = 30;

            Console.WriteLine(A.ToString());

        }
             
        }
}

