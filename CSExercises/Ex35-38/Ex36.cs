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
            for (int i = 0; i < len; i++)
            {
                while (message[i].Equals(' ') || message[i].Equals('.'))
                {
                    for (int k = i + 1; k < len; k++)
                    {
                        char temp;
                        temp= message[k];
                        //message = message.Remove(k-1, 1);//WRONG SPOT
                        message = message.Substring(0, i) +message.Substring(i + 1, message.Length - i - 1);
                        //message = message.Insert(k-1, temp.ToString());
                        //message[k-1]=temp; 
                        len--;
                    }
                    num++;
                }
            }

            //transfer capital letter
            //message=string.ToLower();
            //message=message.ToLower();
            message = message.ToLower();
            if (len % 2 != 0)
            {
                int i = 0;
                while (i < len / 2 && message[i].Equals(message[len - 1 - i]))
                {
                    i++;
                }
                if (i == len / 2)
                {
                    Console.WriteLine(" IS A PALINDROME.");
                }
                else Console.WriteLine(" IS NOT A PALINDROME.");
            }
            else
            {
                int i = 0;
                while(i<=len/2&&message[i].Equals(message[len - 1 - i]))
                {
                    i++;
                }
                if(i==len/2+1)
                {
                    Console.WriteLine(" IS A PALINDROME.");
                }
                else Console.WriteLine(" IS NOT A PALINDROME.");
            }
        }
    }
}
