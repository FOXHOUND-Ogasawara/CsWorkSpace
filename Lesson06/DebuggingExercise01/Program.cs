class Program
{
    static void Main()
    {
        Console.WriteLine("数値1を入力してください:");
        int number1 = int.Parse(Console.ReadLine());

        Console.WriteLine("数値2を入力してください:");
        int number2 = int.Parse(Console.ReadLine());

        int sum = number1 + number2;
        System.Console.WriteLine($"和: {sum}");
    }
}