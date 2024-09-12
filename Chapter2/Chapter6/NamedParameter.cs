//Chapter6 6.9 명명된 인수 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter6
{
    internal class NamedParameter
    {
        static void Profile(string name, string phone) // 1) 메소드 안에 매개변수 string 을 넣음 
        {
            Console.WriteLine($"name={name} phone={phone}"); // 4)최종적으로 출력이 될 창 
        }
        
        static void Main(string[] args)  //2) 첫번째 메소드에 값을 넣기 위해 2번째 메소드 생성
        {
            Profile(name: "김지현", phone: "1234"); //3) (명명인수) 첫번째 메소드의 name 과 phone에 값을 정해 줌

        }
    }
}
