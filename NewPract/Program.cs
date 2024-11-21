using MyLib;

namespace NewPract
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 class1 = new Class1();

            class1.Hello();
            class1.Number(52.78);

            int num1 = 9;
            int num2 = 4;
            int num3 = 0;

            int sum = class1.Add(num1, num2);
            Console.WriteLine($"Сумма {num1} и {num2} равна: {sum}");

            bool isEven = class1.IsEven(num1);
            Console.WriteLine($"{num1} {(isEven ? "четное" : "нечетное")} число");

            string massage = class1.Message();
            Console.WriteLine(massage);
        }
    }
}