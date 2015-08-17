using System;

namespace CSExercises
{
    public class Ex17
    {
        public static void Main(string[] args)
        {
            string mes1 = "Please input your name:";
            string mes2 = "Please input your gender(M or F):";
            string mes3 = "Please input your age:";
            string mes4;
            string mes5 = "Good morning ";
            string mes6 = "Please input your gender in correct format(M or F) and try again";
            Console.WriteLine(mes1);
            string name = Console.ReadLine();
            Console.WriteLine(mes2);
            string gender = Console.ReadLine();
            Console.WriteLine(mes3);
            string age = Console.ReadLine();
            try
            {
                if (gender.Equals("M"))
                {
                    if (Convert.ToInt32(age) < 40)
                    {
                        mes4 = "Mr. ";
                        Console.WriteLine(mes5 + mes4 + name);
                    }
                    else
                    {
                        mes4 = "Uncle ";
                        Console.WriteLine(mes5 + mes4 + name);
                    }
                }
                else if (gender.Equals("F"))
                {
                    if (Convert.ToInt32(age) < 40)
                    {
                        mes4 = "Ms. ";
                        Console.WriteLine(mes5 + mes4 + name);
                    }
                    else
                    {
                        mes4 = "Aunty ";
                        Console.WriteLine(mes5 + mes4 + name);
                    }
                }
                else
                    Console.WriteLine(mes6);
            }
            catch { Console.WriteLine("Please input valid age and try again"); }

        }
    }
}