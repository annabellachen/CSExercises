using System;

namespace CSExercises
{
    public class Ex26
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("  NO        INVERSE       SQUARE ROOT      SQUARE  ");
            Console.WriteLine("---------------------------------------------------");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(" {0:0.0}\t      {1:0.0##}\t    {2:0.0##}\t\t{3:0.0}"+"\n", i, 1 / Convert.ToDouble(i), Math.Sqrt(i), i * i);
            }
        }
    }
}
