using System;
namespace CSExercises
{
    public class Ex34
    {
        public static void Main(string[] args)
        {
            int[,] sale = new int [12,4];
            for(int i=0;i<12;i++)
            {
                Console.Write("Please input the grades for student {0}: ",i);
                for(int j=0;j<4;j++)
                {
                    Console.Write("Please input the grade for the subjest {0}: ",j);
                    sale[i,j]=Convert.ToInt32(Console.ReadLine());
                }
            }
                

        }
    }
}
