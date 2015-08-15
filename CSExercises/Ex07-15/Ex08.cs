using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex08
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please input temperature in Centigrade:");
            String TemInCentigrade=Console.ReadLine();
            Double TemIn = Convert.ToDouble(TemInCentigrade);
            Double TemInFahrenheit = 1.8 * TemIn + 32;
            Console.WriteLine("The Temperature in Fahrenheit is: {0}",TemInFahrenheit);
        }
    }
}
