using System.Data.SqlClient;
using System;

namespace CSExercises
{
    public class Ex40
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("")
        }

        public static double SQT(int y)
        {
            double guess;
            Random ran = new Random();
            guess = ran.NextDouble() * y;
            do
            {
                guess = (guess + y / guess) / 2;
            } while ((guess * guess >= (y + 0.00001)) || (guess * guess <= (y - 0.00001)));
            //Console.WriteLine("The square root caculated is {0:0.00000}", guess);
            return guess;
        }
    }
}
