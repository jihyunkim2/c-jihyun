//Chapter7 
using System;

namespace Chapter7
//{0} 위치에는 name을 넣고 {1} 위치에는 색을 넣고 ....
{
    class Cat // 클래스 
    {
        public string Name;
        public string Color;

        public void Meow() // 메소드 
        {
            Console.WriteLine($"{Name} : 야옹");
        }

    }

    //class MainApp
    //{
    //    static void Main(string[] args)
    //    {
    //        Cat kitty = new Cat();  // 객체 생성 (new와 생성자는 항상 같이 쓰기 & 생성자는 클래스 이름과 같은 이름)
    //        kitty.Color = "하얀색";
    //        kitty.Name = "키티";
    //        Console.WriteLine($"{kitty.Name}:{kitty.Color}");
    //    }
    //}

}
