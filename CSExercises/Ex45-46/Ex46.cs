using System;
namespace CSExercises
{
    public class Ex46
    {
        public static void Main(string[] args)
        {
            int[] OCCUR = new int[10] {0,0,0,0,0,0,0,0,0,0};
            int[] RAN = new int[50];
            Random ran = new Random();
            for (int i = 0; i < 50; i++)
            {
                RAN[i]=ran.Next(0,10);//get random value from 0 to 9
            }
            for(int i=0;i<50;i++)
            {
                switch (RAN[i])
                {
                    case 0: OCCUR[0]++; break;
                    case 1: OCCUR[1]++; break;
                    case 2: OCCUR[2]++; break;
                    case 3: OCCUR[3]++; break;
                    case 4: OCCUR[4]++; break;
                    case 5: OCCUR[5]++; break;
                    case 6: OCCUR[6]++; break;
                    case 7: OCCUR[7]++; break;
                    case 8: OCCUR[8]++; break;
                    case 9: OCCUR[9]++; break;
                }
            }
            Console.WriteLine("Number\t\tCount");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("  {0}\t\t  {1}",i,OCCUR[i]);
            }
            Console.WriteLine("\n");
            Console.WriteLine("\tNumber");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("\t  {0}\t",i);
                for (int j = 0; j < OCCUR[i]; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("\n");
            }
        }
    }
}
