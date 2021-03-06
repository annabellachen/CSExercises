using System;

namespace CSExercises
{
    public class Ex38
    {
        public static void Main(string[] args)
        {
            string [] name = new string[5] {"John","Venkat","Mary","Victor","Betty"};
            int[] mark = new int[5] { 63, 29, 75, 82, 55 };
            for (int i = 0; i < 5; i++)
            {
                Console.Write(name[i]+"\t");
            }
            Console.Write("\n");
            Console.Write("\n");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(mark[i] + "\t");
            }
            Console.Write("\n");
            //report 1:
            for (int i = 0; i < 4; i++)
            {

                for (int j = i + 1; j < 5; j++)
                {
                    if (mark[i] < mark[j])
                    {
                        int swap;
                        string temp;
                        swap = mark[i];
                        mark[i] = mark[j];
                        mark[j] = swap;
                        temp = name[i];
                        name[i] = name[j];
                        name[j] = temp;
                    }
                }
            }
            Console.Write("\n");
            Console.WriteLine("Report 1: sorted in decending rank for students:\n");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(name[i] + "\t");
            }
            Console.Write("\n");
            Console.Write("\n");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(mark[i] + "\t");
            }


            //report 2
            for (int i = 0; i < 4; i++)
            {

                for (int j = i + 1; j < 5; j++)
                {
                    if (name[i][0] > name[j][0])
                    {
                        int swap;
                        string temp;
                        swap = mark[i];
                        mark[i] = mark[j];
                        mark[j] = swap;
                        temp = name[i];
                        name[i] = name[j];
                        name[j] = temp;
                    }
                    if (name[i][0] == name[j][0])
                    {
                        if (!name[i].Equals(name[j]))
                        {
                            if (name[i][1] > name[j][1])
                            {
                                int swap;
                                string temp;
                                swap = mark[i];
                                mark[i] = mark[j];
                                mark[j] = swap;
                                temp = name[i];
                                name[i] = name[j];
                                name[j] = temp;
                            }
                        }
                    }
                }
            }
            
            Console.Write("\n");
            Console.WriteLine("Report 2: sorted in alphabet for students:\n");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(name[i] + "\t");
            }
            Console.Write("\n");
            Console.Write("\n");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(mark[i] + "\t");
            }
        }
    }
}
