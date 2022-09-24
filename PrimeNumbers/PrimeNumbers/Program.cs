using System.Diagnostics;


namespace PrimeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> lst = new List<int>();
            int prints = 0;
            lst.Add(2);
            for (int i = 3; prints < 1000000 -1; i++)
            {
                if (i % 2 != 0)
                {
                    int count = 0;
                    for (int j = 2; j <= Math.Sqrt(i); j++)
                    {
                        if (i % j == 0)
                        {
                            count++;
                            break;
                        }
                    }
                    if (count == 0)
                    {
                        //Debug.Print(i.ToString());
                        //lst.Add(i);
                        prints++;
                    }
                }
            }
            //foreach (var num in lst)
                //Console.WriteLine(num);
        }
    }
}