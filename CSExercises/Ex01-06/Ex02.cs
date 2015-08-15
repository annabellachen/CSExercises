using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex02
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please input the number:");
            string numo = Console.ReadLine();
            double nume = Convert.ToDouble(numo);
            int num = Convert.ToInt32(nume);
            int result=num * num;
            Console.WriteLine("The square of " + num + " is {0}", result);
        }
    }
}
