using System;
namespace CSExercises
{
    public class Ex35
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a phrase:");
            string phrase=Console.ReadLine();
            int num=0;
            for (int i = 0; i < phrase.Length; i++)
            {
                if (phrase[i].Equals('a') || phrase[i].Equals('e') || phrase[i].Equals('i') || phrase[i].Equals('o') || phrase[i].Equals('u'))
                    num++;
            }
            Console.WriteLine("Total number of vowels: {0}",num);
        }
    }
}
