using System;

namespace CSExercises
{
    public class Ex32
    {
        public static void Main(string[] args)
        {
            int[] sale = new int[12];
            int max,min,average=0;
            int m=0;
            int n=0;
            for (int i = 0; i < 12; i++)
            {
                Console.Write("Enter sales for month {0}: ", i);
                sale[i] = Convert.ToInt32(Console.ReadLine());
            }
            max = sale[0];
            min = sale[0];
            for (int i = 1; i < 12; i++)
            {
                
                if (sale[i] > max)
                {
                    max = sale[i];
                    m=i;
                }
                if (sale[i] < min)
                {
                    min = sale[i]; 
                    n=i;
                }                                 
            }
            for (int i = 0; i < 12; i++)
                average = average + sale[i];
            average = average / 12;//average/=12
            Console.WriteLine("Maxmum Sales: {0}", m);
            Console.WriteLine("Minmum Sales: {0}", n);
            Console.WriteLine("Average Sales: {0}", average);
        }
    }
}
