using System;
namespace CSExercises
{
    public class Ex33
    {
        public static void Main(string[] args)
        {
            int[] sale = new int[20] {86,35,41,49,89,51,11,71,50,75,25,58,40,14,44,3,63,81,93,79};
            int swap;
            for (int i = 0; i < 19; i++)
            {

                for (int j = i + 1; j < 20; j++)
                {
                    if (sale[i] < sale[j])
                    {
                        swap = sale[i];
                        sale[i] = sale[j];
                        sale[j] = swap;
                    }
                }
                for (int j = 0; j < 20; j++)
                {
                    Console.Write("{0} ", sale[j]);
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("The number in decending order is :");
            for (int i = 0; i < 20; i++)
            {
                Console.Write("{0} ",sale[i]);
            }
        }
    }
}
