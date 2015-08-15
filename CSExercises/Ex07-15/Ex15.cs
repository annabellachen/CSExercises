using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex15
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please input a integer:");
            String num = Console.ReadLine();
            int a,b,c;
            try
            {
                int NUM = Convert.ToInt32(num);
                if (NUM < 1000 && NUM > 99)
                {
                    a = NUM / 100;
                    b = (NUM % 100) / 10;
                    c = NUM % 10;
                    if (NUM == a * a * a + b * b * b + c * c * c)
                    {
                        Console.WriteLine("{0} is a Armstrong number", NUM);
                    }
                    else Console.WriteLine("{0} is not a Armstrong number", NUM);
                }
                else Console.WriteLine("Please input a valid name from 100 to 999");
            }
            catch { Console.WriteLine("Please input a valid name from 100 to 999"); }
         }
    }
        
}
