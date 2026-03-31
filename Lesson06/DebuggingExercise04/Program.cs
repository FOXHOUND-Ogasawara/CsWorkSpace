class Program
{
    static void Main()
    {
        int[] numbers = { 2, 4, 6, 8, 10 };
        int target = 5;
        bool found = false;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == target)
            {
                found = true;
                System.Console.WriteLine($"値が見つかりました。位置: {i}");
                break;
            }
        }

        if (!found)
        {
            System.Console.WriteLine("値が見つかりませんでした。");
        }
    }
}
