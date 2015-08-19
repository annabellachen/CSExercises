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
            string mes=null;//original input
            string[] arr = message.Split(new char [] {' '},StringSplitOptions.RemoveEmptyEntries);//delete up necessary ' ',avoid take up memory 
            for (int i = 0; i < arr.Length; i++)
            { 
                string word =arr[i];
                word = word.ToUpper().Substring(0,1)+word.Substring(1,word.Length-1);
                mes = mes + word+' ';
            }
            //message = char.ToUpper(message[0]) + message.Substring(1).ToLower();
            Console.WriteLine("The message is "+mes);
        }
    }
}
