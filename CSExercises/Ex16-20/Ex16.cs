using System;

namespace CSExercises
{
    public class Ex16
    {
        public static void Main(string[] args)
        {
            string mes1 = "Please input your name:";
            string mes2 = "Please input your gender(M or F):";
            string mes3 = "Good Morning ";
            string mes4;
            string mes5 = "Please input your gender in correct format(M or F) and try again";
            Console.WriteLine(mes1);
            string name = Console.ReadLine();
            Console.WriteLine(mes2);
            string gender = Console.ReadLine();
            if (gender.Equals("M"))
            {
                mes4 = "Mr. ";
                Console.WriteLine(mes3 + mes4 + name);
            }
            else if (gender.Equals("F"))
            {
                mes4 = "Ms. ";
                Console.WriteLine(mes3 + mes4 + name);
            }
            else
                Console.WriteLine(mes5);
        }
    }
}