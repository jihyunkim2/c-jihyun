//Chapter7 클래스 상속 7.5
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Chapter7
{
    class MyClass
    {
        public int MyField1;
        public int MyField2; //필드 생성

        public MyClass DeepCopy()
        {
            MyClass newCopy = new MyClass();
            newCopy.MyField1 = this.MyField1;
            newCopy.MyField2 = this.MyField2; //객체 내부에서 자신의 필드나 메소드에 접근할때 this 사용

            return newCopy;
        }

    }

    class MainApp2
    {
        static void Main(string[] args)

        {
            MyClass source = new MyClass();
            source.MyField1 = 10;
            source.MyField2 = 20;

            MyClass target = source.DeepCopy();
            target.MyField1 = 10;  // 별도의 힙 공간에 "복사본" 을 만듦
            

            Console.WriteLine($"{source.MyField1},{source.MyField2}");
            Console.WriteLine($"{target.MyField1},{target.MyField2}");

        }


    }
}
