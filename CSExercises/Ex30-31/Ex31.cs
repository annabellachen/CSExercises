using System;
namespace CSExercises
{
    public class Ex31
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("The Perfect Number:");
            for (int j = 1; j <= 1000; j++)
            {
                int count = 0;
                for (int i = 1; i <= (j / 2); i++)
                {
                    if (j % i == 0)
                        count = count + i;
                }
                if (count == j) { Console.Write("{0}" + "\t", j); }
            }          
        }
    }
}
