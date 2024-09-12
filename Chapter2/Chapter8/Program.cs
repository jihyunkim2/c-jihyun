namespace Chapter8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a = 5;

            Console.WriteLine($"Hello, World!");

            string b = $"abc{a}defg";

            Console.WriteLine(b);

            Thread.Sleep(5000);
        }
    }
}
