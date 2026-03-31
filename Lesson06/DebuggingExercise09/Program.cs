class Program
{
    static void Main()
    {
        int rowCount = 5;

        for (int i = 1; i <= rowCount; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                if (i <= j)
                {
                    System.Console.Write("*");
                }
            }
            System.Console.WriteLine();
        }
    }
}
