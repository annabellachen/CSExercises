using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex06
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please input the number:");
                string numo = Console.ReadLine();
                int num = Convert.ToInt32(numo);
                double result = Math.Sqrt(num);
                Console.WriteLine("The square of " + num + " is {0}", result);
            }
            catch { Console.WriteLine("Please input an integer,try again"); }
        }
    }
}
