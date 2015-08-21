using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises.Business_Cases
{

    class Program1
    {
        static void Main(string[] args)
        {
            double num = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(TransferToWord(num));
        }
        static string TransferToWord(double num)
        {
            string result = null;
            num = Math.Round(num, 2);
            /*if (num >= 1000)
            {
                a1 = Convert.ToInt32(num / 1000);
                num = num - 1000 * a1;
            }
            else a1 = 0;
            if (num >= 100)
            {
                a2 = Convert.ToInt32(num / 100);
                num = num - 100 * a2;
            }
            else a2 = 0;
            if (num >= 10)
            {
                a3 = Convert.ToInt32(num / 10);
                num = num - 10 * a3;
            }
            else a3 = 0;
            if (num >= 1)
            {
                a4 = Convert.ToInt32(num / 1);
                num = num - 1 * a4;
            }
            else a4 = 0;*/
            double[,] cam = new double[6, 2] { { 1000, 0 }, { 100, 0 }, { 10, 0 }, { 1, 0 }, { 0.1, 0 }, { 0.01, 0 } };
            string[,] res = new string[6, 2];
            //res = null;

            //caculate the number for 1000,100,10,1,0.1,0.01
            for (int i = 0; i < 6; i++)
            {
                if (num >= cam[i, 0])
                {
                    cam[i, 1] = Convert.ToInt32(num / cam[i, 0]);
                    num = num - cam[i, 0] * cam[i, 1];
                    num = Math.Round(num, 2);
                }
            }

            //assign words to each num
            for (int i = 0; i < 6; i++)
            {
                int temp = Convert.ToInt32(Math.Round(cam[i, 1]));
                //give value to 1000 , 100, 1 and 0.01
                if ((i != 2) && (i != 4))
                {
                    switch (temp)
                    {
                        case 0: res[i, 1] = ""; break;
                        case 1: res[i, 1] = "One"; break;
                        case 2: res[i, 1] = "Two"; break;
                        case 3: res[i, 1] = "Three"; break;
                        case 4: res[i, 1] = "Four"; break;
                        case 5: res[i, 1] = "Five"; break;
                        case 6: res[i, 1] = "Six"; break;
                        case 7: res[i, 1] = "Seven"; break;
                        case 8: res[i, 1] = "Eight"; break;
                        case 9: res[i, 1] = "Nine"; break;
                    }
                }
                //give value to 10 and 0.1
                if ((i == 2) || (i == 4))
                {
                    switch (temp)
                    {
                        case 0: res[i, 1] = ""; break;
                        case 1: res[i, 1] = "Ten"; break;
                        case 2: res[i, 1] = "Twenty"; break;
                        case 3: res[i, 1] = "Thirty"; break;
                        case 4: res[i, 1] = "Fourty"; break;
                        case 5: res[i, 1] = "Fifty"; break;
                        case 6: res[i, 1] = "Sixty"; break;
                        case 7: res[i, 1] = "Seventy"; break;
                        case 8: res[i, 1] = "Eighty"; break;
                        case 9: res[i, 1] = "Ninety"; break;
                    }
                }
               
                switch (i)
                {
                    case 0: res[i, 0] = "Thousand"; break;
                    case 1: res[i, 0] = "Hundred"; break;//don't forget "and" after hundred or thousand
                    case 2: res[i, 0] = ""; break;
                    case 3: res[i, 0] = ""; break;
                    case 4: res[i, 0] = ""; break;//before 0.1
                    case 5: res[i, 0] = ""; break;

                }
            }
            for (int i = 0; i < 6; i++)
            {
                if (i == 2 && cam[3, 1] != 0 && cam[1, 1] != 0)//if baiwei !=0 and
                    result = result + "And ";
                if (i == 4 && (cam[4, 1] != 0 || cam[5, 1] != 0))
                    if(cam[0,1]==0&&cam[1,1]==0&&cam[2,1]==0&&cam[3,1]==0)
                        result = result + "Cents ";
                    else
                        result = result + "And Cents ";
                for (int j = 1; j >= 0; j--)
                    if (cam[i, 1] != 0)
                    {
                        result = result + res[i, j] + ' ';


                    }

            }
            if (cam[0, 1] == 0 && cam[1, 1] == 0 && cam[2, 1] == 0 && cam[3, 1] == 0)
                result=result + "only.";
            else
                result = "Dollar " + result + "only.";
            return result;
        }
    }

}