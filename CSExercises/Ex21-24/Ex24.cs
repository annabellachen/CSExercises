using System;

namespace CSExercises
{
    public class Ex24
    {
        public static void Main(string[] args)
        {
            double num,guess;
            Random ran=new Random();
            do{
                Console.WriteLine("Please input a number");
                num = Convert.ToDouble(Console.ReadLine());
                guess = ran.NextDouble()*num;
            }while (guess * guess != num)
            { 
                
            }
        }
    }
}
