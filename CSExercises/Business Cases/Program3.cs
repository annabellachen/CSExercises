using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises.Business_Cases
{
    class Program3
    {
        static void Main(string[] args)
        {
            Console.Write("Consoder the word: ");
            string word=Console.ReadLine();
            string trans1=Encryption(word);
            Console.Write("First Transformation: ");
            Console.WriteLine(trans1);
            string trans2 = Mirror(trans1);
            Console.Write("Second Transformation: ");
            Console.WriteLine(trans2);

        }

        /**
         * encryption 1: add ascii value to each char
         * */
        static string Encryption(string word)
        {
            char[] sub = new char[word.Length];
            byte[] asciiBytes = Encoding.ASCII.GetBytes(word);
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] != 'Z' && word[i] != '9'&&word[i] != 'z')
                {
                    asciiBytes[i]++;//add ascii value
                    sub[i] = (char)(asciiBytes[i]);//convert to char
                    //word.Replace(word.Substring(i, 1), Convert.ToString(sub[i]));
                    word = word.Remove(i, 1);
                    word = word.Insert(i, Convert.ToString(sub[i]));
                }
                else if (word[i] == 'Z')
                {
                    word = word.Remove(i, 1);
                    word = word.Insert(i, "A");
                }
                else if (word[i] == 'z')
                {
                    word = word.Remove(i, 1);
                    word = word.Insert(i, "a");
                }
                else if (word[i] == '9')
                {
                    word = word.Remove(i, 1);
                    word = word.Insert(i, "0");

                }
            }
            

                /*for (int i = 0; i < word.Length; i++)
                {
                    int ascii = Convert.ToInt32(word.Substring(i, 1));
                    ascii = ascii + 1;
                    char character = (char) (ascii);
                    string text = character.ToString();
                    word.Replace(word.Substring(i, 1), text);
                }*/
            return word;
        }
        /**
         * encryption 2: invert the string
         * */
        static string Mirror(String word)
        { 
            string mirror=null;
            for (int i = word.Length - 1; i >= 0;i-- )
            {
                mirror = mirror+word.Substring(i, 1);
            }
            return mirror;
        }
    }
}