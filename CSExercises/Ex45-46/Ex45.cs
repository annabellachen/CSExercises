using System;
namespace CSExercises
{
    public class Ex45
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please input the amount:");
            double amount=Convert.ToDouble(Console.ReadLine());
            int x1=0, x2=0, x3=0, x4=0, x5=0;
                if (amount >= 1)
                {
                    x1 = Convert.ToInt32(Math.Floor(amount / 1));
                    amount = amount - x1;
                    amount = Math.Round(amount, 2);
                }
                else x1 = 0;
                if (amount / 0.5 >= 1)
                {

                    x2 = Convert.ToInt32(Math.Floor(amount / 0.5));
                    amount = amount - x2 * 0.5;
                    amount = Math.Round(amount,2);
                }
                else x2 = 0;
                if (amount / 0.2 >= 1)
                {

                    x3 = Convert.ToInt32(Math.Floor(amount / 0.2));
                    amount = amount - x3 * 0.2;
                    amount = Math.Round(amount, 2);

                }
                else x3 = 0;
                if (amount / 0.1 >= 1)
                {

                    x4 = Convert.ToInt32(Math.Floor(amount / 0.1));
                    amount = amount - x4 * 0.1;
                    amount = Math.Round(amount, 2);

                }
                else x4 = 0;
                if (amount / 0.05 >= 1)
                {

                    x5 = Convert.ToInt32(Math.Floor(amount / 0.05));
                    amount = amount - x5 * 0.05;
                    amount = Math.Round(amount, 2);

                }
                else x5 = 0;
            
            Console.WriteLine(x1);
            Console.WriteLine(x2);
            Console.WriteLine(x3);
            Console.WriteLine(x4);
            Console.WriteLine(x5);
            int[] res = new int[5] { x1, x2, x3, x4, x5 };
            string [] type = new string[5] {"100c","50c","20c","10c","5c"};
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < res[i]; j++)
                {
                    Console.WriteLine(type[i]);
                }
            }
    }
    }
}
