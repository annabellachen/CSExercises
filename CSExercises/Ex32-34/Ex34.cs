using System;
namespace CSExercises
{
    public class Ex34
    {
        public static void Main(string[] args)
        {
            int[,] gra = new int[12, 4];
            //int[,] gra = new int [4,4];
            double[] total = new double[13] {0,0,0,0,0,0,0,0,0,0,0,0,0};
            double[] average=new double[4] {0,0,0,0};
            double[] vari = new double[4] { 0, 0, 0, 0 };
            int j;
            //for (int i = 0; i < 4; i++)
            for(int i=0;i<12;i++)
            {
                Console.WriteLine("Please input the grades for student {0}: ",i);
                for(j=0;j<4;j++)
                {
                    Console.WriteLine("Please input the grade for the subjest {0}: ",j);
                    gra[i,j]=Convert.ToInt32(Console.ReadLine());
                }
            }
            //for (int i = 0; i < 4; i++)
            for (int i = 0; i < 12; i++)
            {
                for (int k = 0; k < 4; k++)
                {
                    total[i] = total[i] + gra[i,k];
                }
                Console.WriteLine("The total marks for subject {0} is {1}", i, total[i]);
            }
            for (int i = 0; i < 4; i++)
            {
                for (int k = 0; k < 12; k++)
                //for (int k = 0; k < 4; k++)
                {
                    average[i] = average[i] + gra[k,i];
                }
            }
            for (int i = 0; i < 4; i++)
            {
                //average[i] /= 4;
                average[i] /= 12;
                Console.WriteLine("The average marks for subject {0} is {1}", i, average[i]);

            }
            for (int i = 0; i < 4; i++)
            {
                //for (int k = 0; k < 4; k++)
                for (int k = 0; k < 12; k++)
                {
                    vari[i] = vari[i] + (gra[k, i]  - average[i]) * (gra[k, i] - average[i]) / 12.0;
                    
                }
                Console.WriteLine("The variance for subject {0} is {1}", i, vari[i]);
            }
            Console.WriteLine("The total marks is {0}", (average[0] + average[1] + average[2] + average[3]) / 4);
        }
    }
}
