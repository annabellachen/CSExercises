using System;

namespace CSExercises
{
    public class Ex37
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please input a string:");
            String message = Console.ReadLine();
            Console.WriteLine("The original message is "+message+"\n");
            message = char.ToUpper(message[0]) + message.Substring(1).ToLower();
            Console.WriteLine("The message is "+message);
        }
    }
}
