using System;
namespace CSExercises
{
    public class Ex29
    {
        public static void Main(string[] args)
        {
            Console.Write("Please input the number: ");
            int num = Convert.ToInt16(Console.ReadLine());
            int count=0;
            for (int i = 1; i <=(num / 2); i++)
            {
                if (num % i == 0)
                    count = count + i;
            }
            if (count == num)
                Console.WriteLine("The {0} is a perfect number",num);
            else
                Console.WriteLine("The {0} is not a perfect number",num);
        }
    }
}
