using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex14
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please input the number 1:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please input the number 2:");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please input the number 3:");
            double c = Convert.ToDouble(Console.ReadLine());
            double s = (a+b+c)/2;
            double res;
            //check if the trangle is valid or not
            if ((a + b > c) && (a + c > b) && (b + c > a))
            {
                res = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
                Console.WriteLine("The square of the trangle is {0}",res);
            }
            else Console.WriteLine("The input is wrong, please try again.");
        }
    }
}