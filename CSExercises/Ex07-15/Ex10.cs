using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex10
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please input the coordinates of two points:");
            Console.WriteLine("Please input for the first points");
            Double x1= Convert.ToDouble(Console.ReadLine());
            Double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please input for the second points");
            Double x2 = Convert.ToDouble(Console.ReadLine());
            Double y2 = Convert.ToDouble(Console.ReadLine());
            Double Distance = Math.Sqrt((x2 - x1)*(x2 - x1) + (y2 - y1)*(y2 - y1));
            Console.WriteLine("The distance is: (0)", Distance);
        }
    }
}
