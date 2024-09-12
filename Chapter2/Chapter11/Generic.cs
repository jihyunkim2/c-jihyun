//chapter11 일반화 클래스 
using System;

namespace Chapter11
{
    class MyList<T> //형식 매개변수 T 추가 
    {
        private T[] array;

        public MyList()
        {
            array = new T[3]; //초기 배열 길이 3으로 설정 
        }

        public T this[int index]
        {
            get
            {
                return array[index]; //배열에서 주어진 인덱스 위치의 값을 반환 
            }

            set
            {
                if (index >= array.Length)
                {
                    Array.Resize<T>(ref array, index + 1);
                    Console.WriteLine($"Array Resized : {array.Length}");

                }
                array[index] = value;
            }

        }

        public int Length
        {
            get { return array.Length; }
        }
    }

        class Mainapp1111  //어떤 형식으로 출력할지는 여기서 정함 
        {
            static void Main1111(string[] args)
            {
                MyList<string> str_list = new MyList<string>();
                str_list[0] = "abc";
                str_list[1] = "def";
                str_list[2] = "abc";


                for (int i = 0; i < str_list.Length; i++)
                    Console.WriteLine(str_list[i]);

                Console.WriteLine();
            }
        }
    }
