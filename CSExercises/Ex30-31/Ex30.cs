using System;
namespace CSExercises
{
    public class Ex30
    {
        public static void Main(string[] args)
        {
            int j = 2,i,k;
            int [] Prime=new int[100];
            for(k=0;k<Prime.Length;k++)
                Prime[k]=0;
            k=0;
            for (i=5; i <= 10000; i++)
            {
                j = 2;
                while ((i % j != 0 )&& (j <= Math.Sqrt(i)))
                {
                    j++;  
                }
                if (j >=Math.Ceiling(Math.Sqrt(i)))
                {
                    Prime[k++] = i;
                }
                
            }
            for (i = 0; i < k; i++)
            {
                   Console.Write("{0}"+"\t",Prime[i]);               
            }
        }
    }
}
