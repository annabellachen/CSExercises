using System.Data.SqlClient;
using System;

namespace CSExercises
{
    public class Ex40
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("The square root table");
            Console.WriteLine("\n");
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine("\n");
            for (int i = 1; i <= 10; i++)
            {
                double result=SQT(i);
                Console.Write("{0:0.00000}\t",result);
            }
            Console.WriteLine("\n");
            for (int i = 11; i <= 20; i++)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine("\n");
            for (int i = 11; i <= 20; i++)
            {
                double result = SQT(i);
                Console.Write("{0:0.00000}\t", result);
            }
            Console.WriteLine("\n");
            for (int i = 20; i <= 25; i++)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine("\n");
            for (int i = 20; i <= 25; i++)
            {
                double result = SQT(i);
                Console.Write("{0:0.00000}\t", result);
            }
        }

        public static double SQT(int y)
        {
            double guess;
            Random ran = new Random();
            guess = ran.NextDouble() * (y-1);
            guess = guess + 1;
            do
            {
                guess = (guess + y / guess) / 2;
            } while ((guess * guess >= (y + 0.00001)) || (guess * guess <= (y - 0.00001)));
            //Console.WriteLine("The square root caculated is {0:0.00000}", guess);
            return guess;
        }
    }
}
