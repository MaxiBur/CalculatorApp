internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Добро пожаловать в калькулятор!");
        Console.WriteLine("Введите первое число:");
        double a = double.Parse(Console.ReadLine()!);

        Console.WriteLine("Введите второе число:");
        double b = double.Parse(Console.ReadLine()!);

        Console.WriteLine($"Результат сложения: {a + b}");
    }
}
