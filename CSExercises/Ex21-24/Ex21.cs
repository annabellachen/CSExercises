using System;

namespace CSExercises
{
    public class Ex21
    {
        public static void Main(string[] args)
        {
            String msg1 = "Please input the number:";
            String msg2 = "Please input again";
            String msg3 = "Lucky you ...";
            Console.WriteLine(msg1);
            String num = Console.ReadLine();
            while (!num.Equals("88"))
            {
                Console.WriteLine(msg2);
                num = Console.ReadLine();
            }
            Console.WriteLine(msg3);
        }
    }
}
