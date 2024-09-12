//Chapter9 9.2
using Chapter9;
using System;

namespace Chapter9
{
    class BirthdayInfo
    {
        private string name;
        private DateTime birthday;

        public string Name
        {
            get { return name; } // name 필드로부터 값 읽어오기 

            set { name = value; } //name필드에 값 할당하기 
        }

        public DateTime Birthday
        {
            get
            { 
                return birthday;
            }
            set
            {
                birthday = value; //마찬가지로 접근자 생성 
            }
        }

        public int Age  //Age 메소드 생성
        {
            get
            {
                return new DateTime(DateTime.Now.Subtract(birthday).Ticks).Year;

            }
        }

    }

    class MainApp //메인 클래스 생성(메인 클래스의 값들을 통해 위의 메소드들을 이용해서 출력이 되도록 함)
    {
        static void Main99(string[] args)  //메소드 생성
        {
            BirthdayInfo birth = new BirthdayInfo(); // 객체 생성 
            birth.Name = "지현";
            birth.Birthday = new DateTime(1991, 6, 28);  // BirthdayInfo 클래스의 메소드들을 이용해 객체에 입력 할 값들을 지정 
            Console.WriteLine($"Name : {birth.Name}");
            Console.WriteLine($"Birthday: {birth.Birthday.ToShortDateString()}");
            Console.WriteLine($"Age:{birth.Age}");   // 최종 출력 
        }
    }
}
