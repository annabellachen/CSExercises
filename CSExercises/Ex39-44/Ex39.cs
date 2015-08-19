using System;
namespace CSExercises
{
    public class Ex39
    {
        public static long Factorial(long n)
        {
            int fac=1;
            if (n >= 0)
            { 
                for(int i=1;i<=n;i++)
                {
                    fac = fac * i;
                }
            }            
            return fac;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine(Factorial(5));
        }
    }
}
