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
            int numa = 0;
            int nume = 0;
            int numi = 0;
            int numo = 0;
            int numu = 0;
            for (int i = 0; i < phrase.Length; i++)
            {
                if (phrase[i].Equals('a') || phrase[i].Equals('e') || phrase[i].Equals('i') || phrase[i].Equals('o') || phrase[i].Equals('u'))
                    num++;
            }
            for (int i = 0; i < phrase.Length; i++)
            {
                if (phrase[i].Equals('a'))
                    numa++;
                else if (phrase[i].Equals('e'))
                    nume++;
                else if (phrase[i].Equals('i'))
                    numi++;
                else if (phrase[i].Equals('o'))
                    numo++;
                else if (phrase[i].Equals('u'))
                    numu++;
            }
            Console.WriteLine("Total number of vowels: {0}",num);
            Console.WriteLine("Number of a: {0}", numa);
            Console.WriteLine("Number of e: {0}", nume);
            Console.WriteLine("Number of i: {0}", numi);
            Console.WriteLine("Number of o: {0}", numo);
            Console.WriteLine("Number of u: {0}", numu);
        }
    }
}
