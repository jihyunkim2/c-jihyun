


using System.Security.Cryptography.X509Certificates;

class Cat
{
    public string Name;
    public string Color; //고양이의 이름 색깔 변수 (필드)

    public void Meow() //메소드
    {
        Console.WriteLine("{ 0}:야옹", Name);
    }   //메소드는 실체가 아님 실체(인스턴스) 를 만들어야함 

    class Main {
        static void Main4(string[] args)
        {
            Cat Kitty = new Cat();  //실체를 만들어야함 (생성자로 생성)
            Kitty.Name = "키티";
            Kitty.Color = "흰색";
            Kitty.Meow();
            Console.WriteLine($"{ Kitty.Name}:{ Kitty.Color} "};

                }

}