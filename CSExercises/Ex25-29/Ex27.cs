using System;

namespace CSExercises
{
    public class Ex27
    {
        public static void Main(string[] args)
        {
            int y;
            Console.WriteLine("X\t\t\tY");
            Console.WriteLine("--------------------------");
            for (int i = -5; i <= 5; i++)
            {
                y = 2 * i * i - 4 * i + 3;               
                Console.WriteLine("{0:0.0}\t\t\t{1:0.0}",i,y);
            }
            for (int i = -5; i <= 5; i++)
            {
                y = 2 * i * i - 4 * i + 3;
                for (int j = 1; j <= y; j++)
                {
                    Console.Write("*");                 
                }
                Console.WriteLine("\n");
            }
        }
    }
}
