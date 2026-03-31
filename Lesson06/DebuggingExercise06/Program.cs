class Program
{
    static void Main()
    {
        int[] numbers = { 3, 1, 4, 1, 5, 9, 2, 6 };
        int minValue = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] < minValue)
            {
                minValue = numbers[i];
            }
        }

        System.Console.WriteLine($"The smallest number is: {minValue}");
    }
}
