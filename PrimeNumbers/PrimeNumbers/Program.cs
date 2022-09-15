namespace PrimeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int prints = 0;
            for (int i = 0; prints < 1000; i++)
            {
                int count = 0;
                for (int j = 1; j < i+1; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                    }
                }
                if (count == 2)
                {
                    Console.WriteLine(i);
                    prints++;
                }//test
            }
        }
    }
}