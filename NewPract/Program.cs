using MyLib;

namespace NewPract
{
    class Program
    {
        static void Main(string[] args)
        {
            MyLib.Math Math = new MyLib.Math();

            Math.Hello();
            Math.Number(52.78);

            int num1 = 9;
            int num2 = 6;

            int sum = Math.Add(num1, num2);
            Console.WriteLine($"Сумма {num1} и {num2} равна: {sum}");

            bool isEven = Math.IsEven(num1);
            Console.WriteLine($"{num1} {(isEven ? "четное" : "нечетное")} число");

            string massage = Math.Message();
            Console.WriteLine(massage);
        }
    }
}