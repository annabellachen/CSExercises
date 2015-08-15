using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex09
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please input the number:");
            double num = Convert.ToDouble(Console.ReadLine());
            double result = 2 * num * num - 4 * num + 3;
            Console.WriteLine("The result of 2x^2-4x+3 is {0}",result);
        }
    }
}
