namespace MyLib
{
    public class Math
    {
        public void Hello()
        {
            Console.WriteLine("Привет, мир))");
        }
        public void Number(double number) 
        {
            Console.WriteLine($"Вы ввели number: {number}");
        }
        public int Add(int a, int b)
        {
            return a + b;
        }
        public bool IsEven(int number)
        {
            return number % 2 == 0;
        }
        public string Message()
        {
            return "Hello из библиотеки!";
        }
    }
}
