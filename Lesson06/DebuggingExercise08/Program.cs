class Program
{
    static void Main()
    {
        int[] numbers = new int[5];
        int sum = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            System.Console.WriteLine($"Enter number {i + 1}:");
            numbers[i] = int.Parse(System.Console.ReadLine());
            sum += numbers[i];
        }

        double average = sum / numbers.Length;
        System.Console.WriteLine($"The average of the numbers is: {average}");
    }
}
