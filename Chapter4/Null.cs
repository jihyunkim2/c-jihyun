//Chapter4 4.8
//?. 연산자는 "객체"가 null이 아닌 경우에 멤버나 메서드에 접근.
//?[] 연산자는 "배열"이 null이 아닌 경우에 인덱스를 통해 요소에 접근.
//->null 참조로 인한 예외를 방지할 수 있는 도구 (간단한 null 체크일때 사용 /복잡할 때는 if문 사용)
using System;
using System.Collections;
using static System.Console;
using System.Collections; //ArrayList를 사용하기 위해 추가 


namespace Null
{
    internal class Null
    {
        static void Main(string[] args)
        {
            ArrayList a = null; //일반 객체를 생성하는 것과 동일
            a?.Add("축구"); //a?.가 null을 반환하므로 Add 메소드는 호출 되지 않는다.
            a?.Add("농구");
            Console.WriteLine($"{a?[0]}");
            Console.WriteLine($"{a?[1]}");

            a=new ArrayList();//a는 이제 null이 아님
            a?.Add("축구"); //배열 a에 "축구" 추가   
            a?.Add("농구");// 마찬가지
            Console.WriteLine($"{a?[0]}"); //배열 a의 0번째 요소
            Console.WriteLine($"{a?[1]}");// 1번째 요소 


        }
    }
}
