using System;
namespace CSExercises
{
    public class Ex30
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("The Prime Number:");
            int j = 2,i,k;
            int [] Prime=new int[10000];
            for(k=0;k<Prime.Length;k++)
                Prime[k]=0;
            k=0;
            for (i=5; i <= 10000; i++)
            {
                j = 2;
                while ((i % j != 0) && (j <= Math.Sqrt(i)))
                //while ((i % j != 0 )&& (j <=i/2))
                {
                    j++;  
                }
                if(j>Math.Sqrt(i))
                //if (j >=i/2)
                {
                    Prime[k++] = i;
                    //Console.Write("{0}" + "\t", i);
                }
                
            }
            for (i = 0; i < k; i++)
            {
                   Console.Write("{0}"+"\t",Prime[i]);               
            }
        }
    }
}
