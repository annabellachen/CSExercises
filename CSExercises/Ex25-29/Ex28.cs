using System;

namespace CSExercises
{
    public class Ex28
    {
        public static void Main(string[] args)
        {
            Console.Write("Please input the number for check:");
            int num=Convert.ToInt16(Console.ReadLine());
            int i=2;
            if (num == 1) Console.WriteLine("Not Prime");
            else if (num == 2) Console.WriteLine("Prime");
            else {
                while (num % i != 0 && i <= Math.Sqrt(num))
                        i++;
                if (i <= Math.Sqrt(num))
                    Console.WriteLine("Not Prime");
                else Console.WriteLine("Prime");              
            }
            
        }
    }
}
