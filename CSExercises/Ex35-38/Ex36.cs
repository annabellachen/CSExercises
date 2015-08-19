using System; 

namespace CSExercises
{
    public class Ex36
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please input a string:");
            String message=Console.ReadLine();
            Console.Write(message);
            int len = message.Length;
            int num=0;
            string[] mes = message.Split(new char[] { ' ', '.', ':', '?' }, StringSplitOptions.RemoveEmptyEntries);
            message = null;
            for (int i = 0; i < mes.Length; i++)
            { 
                
                string word=mes[i];
                message = message + mes[i];
            }

            //transfer capital letter

            message = message.ToLower();
            if (message.Length % 2 != 0)
            {
                int i = 0;
                while (i < message.Length / 2 && message[i].Equals(message[message.Length - 1 - i]))
                {
                    i++;
                }
                if (i == message.Length / 2)
                {
                    Console.WriteLine(" IS A PALINDROME.");
                }
                else Console.WriteLine(" IS NOT A PALINDROME.");
            }
            else
            {
                int i = 0;
                while (i <= message.Length / 2 && message[i].Equals(message[message.Length - 1 - i]))
                {
                    i++;
                }
                if (i == message.Length / 2 + 1)
                {
                    Console.WriteLine(" IS A PALINDROME.");
                }
                else Console.WriteLine(" IS NOT A PALINDROME.");
            }
        }
    }
}
