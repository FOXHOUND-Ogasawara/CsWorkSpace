class Program
{
    static void Main()
    {
        int size = 5;
        int start = size / 2;
        int end = start;

        for (int i = 0; i < size; i++)
        {

            for (int j = 0; j < size; j++)
            {

                if (j > start && j < end)
                {
                    System.Console.Write("*");
                }
                else
                {
                    System.Console.Write(" ");
                }
            }

            if (i < size / 2)
            {
                start--;
                end++;
            }
            else
            {
                start++;
                end--;
            }

            System.Console.WriteLine();
        }
    }
}