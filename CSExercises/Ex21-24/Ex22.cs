using System;

namespace CSExercises
{
    public class Ex22
    {
        public static void Main(string[] args)
        {
            int a, b;
            double HCF,LCM;
            try {
                Console.WriteLine("Please input the first number");
                int A = Convert.ToInt32(Console.ReadLine());
                a=A;
                Console.WriteLine("Please input the second number");
                int B = Convert.ToInt32(Console.ReadLine());
                b=B;
                while (A != B)
                {
                    if (A > B)
                        A = A - B;//A-=B
                    else if (A < B)
                        B = B - A;//B-=A
                }
                HCF = B;
                LCM = a * b / HCF;
                Console.WriteLine("HCF:{0}",HCF);
                Console.WriteLine("LCM:{0}",LCM);
            }
            catch {
                Console.WriteLine("Please input valid numbers");
            }
        }
    }
}
