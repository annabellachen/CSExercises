using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex07
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please input basic salary:");
            string salary = Console.ReadLine();
            double SalaryNum = Convert.ToDouble(salary);
            double house=0.1*SalaryNum;
            double transport=0.03*SalaryNum;
            double income = SalaryNum + house + transport;
            Console.WriteLine("The total salary is: {0:c}", income);
        }
    }
}
