using System;
namespace CSExercises
{
    public class Ex43
    {
        public static string Hex(int i)
        {
            string ten1, one1;
            int ten = i / 16;
            int one = i % 16;
            switch (ten)
            {
                case 10: ten1 = "A"; break;
                case 11: ten1 = "B"; break;
                case 12: ten1 = "C"; break;
                case 13: ten1 = "D"; break;
                case 14: ten1 = "E"; break;
                case 15: ten1 = "F"; break;
                default: ten1 = Convert.ToString(ten); break;
            }
            switch (one)
            {
                case 10: one1 = "A"; break;
                case 11: one1 = "B"; break;
                case 12: one1 = "C"; break;
                case 13: one1 = "D"; break;
                case 14: one1 = "E"; break;
                case 15: one1 = "F"; break;
                default: one1 = Convert.ToString(one); break;
            }
            return ten1 + one1;
        }
        public static void Main(string[] args)
        {
            for (int i = 0; i <= 100; i++)
                Console.WriteLine("The hex form for {0} is {1}.", i, Hex(i));
            for (int i = 0; i <= 100; i++)
            {   
                string ii=i.ToString();
                string hexOutput = String.Format("{0:X}", ii);
                string hexValue = i.ToString("X");
                //Console.WriteLine("The hex form for {0} is {1:x8}.", i,i);//another way to transfer a int to a hex 
                Console.WriteLine("The hex form for {0} is {1}.", i, hexValue);
                
            }
        }
    }
}
