using System;

namespace CSExercises
{
    public class Ex20
    {
        public static void Main(string[] args)
        {
            string msg1 = "Enter quantity for TV:";
            string msg2 = "Enter quantity for DVD:";
            string msg3 = "Enter quantity for MP3:";
            string msg4 = "Please try again";
            string num1, num2, num3;
            int num_1, num_2, num_3;
            double price1, price2, price3, PriceInTotal,PriceTotal;
            Console.WriteLine(msg1);
            num1 = Console.ReadLine();
            Console.WriteLine(msg2);
            num2 = Console.ReadLine();
            Console.WriteLine(msg3);
            num3 = Console.ReadLine();
            try
            {
                num_1 = Convert.ToInt32(num1);
                num_2 = Convert.ToInt32(num2);
                num_3 = Convert.ToInt32(num3);
                
                if (num_1 >= 0 && num_2 >= 0 && num_3 >= 0)
                {
                    price1 = 900 * num_1;
                    price2 = 500 * num_2;
                    price3 = 700 * num_3;
                    PriceTotal = price1 + price2 + price3;
                    if (PriceTotal > 10000)
                    {
                        price1 *= 0.85;
                        price2 *= 0.85;
                    }
                    else if (PriceTotal > 5000)
                    {
                        price1 *= 0.9;
                        price2 *= 0.9;
                    }                    
                    PriceInTotal = price1 + price2 + price3;
                    Console.WriteLine("Total price for this order is {0:c}", PriceInTotal);
                }
                else { Console.WriteLine(msg4); }
            }
            catch { Console.WriteLine(msg4); }
        }
    }
}