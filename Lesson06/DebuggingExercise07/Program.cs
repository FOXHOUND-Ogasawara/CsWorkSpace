class Program
{
    static void Main()
    {
        int[] numbers = { 5, 3, 8, 4, 2 };

        for (int i = 0; i < numbers.Length - 1; i++)
        {
            for (int j = 0; j < numbers.Length - i - 1; j++)
            {
                if (numbers[j] < numbers[j + 1])
                {
                    int temp = numbers[j];
                    numbers[j] = numbers[j + 1];
                    numbers[j + 1] = temp;
                }
            }
        }

        System.Console.WriteLine("Sorted array:");
        foreach (int number in numbers)
        {
            System.Console.WriteLine(number);
        }
    }
}
