using System;

namespace CSExercises
{
    public class Ex23
    {
        public static void Main(string[] args)
        {
            Random ran = new Random();
            int rannum = ran.Next(0, 10);
            int i = 1;
            Console.WriteLine("Please guess a number");
            int num=Convert.ToInt32(Console.ReadLine());
            while (num != rannum)
            {
                i++; 
                Console.WriteLine("Please try again");
                num = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Congratulate!");
            if(i<=3)
                Console.WriteLine("You are a Wizard!");
            else if(i<=6)
                Console.WriteLine("You are a good guess");
            else
                Console.WriteLine("You are lousy!");         
            Console.WriteLine("You have tried {0} times",i);
        }
    }
}
