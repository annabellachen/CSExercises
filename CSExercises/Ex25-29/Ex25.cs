using System;

namespace CSExercises
{
    public class Ex25
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please input a number");
            int num=Convert.ToInt32(Console.ReadLine());
            int i,amount=1,amount1=1;
            for (i = 1; i <= num; i++)
            {
                amount = amount * i;
            }
            for (i = num; i > 1; i--)
            {
                amount1 = amount * i;
            }
            Console.WriteLine("The amount should be {0} {1}",amount,amount1);
        }
    }
}
