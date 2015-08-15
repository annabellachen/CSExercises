using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex13
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please input the distance:");
            double Distance = Convert.ToDouble(Console.ReadLine());
            double MinCharge = 2.4;
            double result = MinCharge + Distance * 0.4;
            double RESULT = Math.Ceiling(result*10)/10;
            Console.WriteLine("The total fare is {0:0.00}", RESULT);
        }
    }
}
