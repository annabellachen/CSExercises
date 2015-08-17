using System;
namespace CSExercises
{
    public class Ex19
    {
        public static void Main(string[] args)
        {
            double distance;
            double distanceOri;
            double charge;           
            string msg1 = "Please input the distance:";
            string msg2 = "Please try again";
            Console.WriteLine(msg1);
            try {
                distanceOri = Convert.ToDouble(Console.ReadLine());
                distance = Math.Ceiling(distanceOri*10)/10;
                if (distance <= 0.5)
                    charge = 2.40;
                else if (distance <= 9)
                    charge = 2.40 + (distance - 0.5) * 0.4;
                else
                    charge = 2.40 + 85 * 0.04 + (distance - 9) * 0.5;               
                Console.WriteLine("The cost is ${0:0.00}",charge);
            } catch { Console.WriteLine(msg2); }        
        }
    }
}