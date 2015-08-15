using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex05
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please input the number:");
            string numo = Console.ReadLine();
            double num = Convert.ToDouble(numo);
            double result = Math.Sqrt(num);
            Console.WriteLine("The square of " + num + " is {0:0.000}", result);
        }
    }
}
