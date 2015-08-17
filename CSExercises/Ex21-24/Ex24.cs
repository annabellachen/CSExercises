using System;

namespace CSExercises
{
    public class Ex24
    {
        public static void Main(string[] args)
        {
            double num,guess;
            Console.WriteLine("Please input a number");
            num = Convert.ToDouble(Console.ReadLine());
            Random ran=new Random();
            guess = ran.NextDouble() * num;          
            do
            {
                guess = (guess + num / guess) / 2;
            } while (guess*guess!=num);
            Console.WriteLine("The square root caculated is {0:0.00000}",guess);
        }
    }
}
