using System;
namespace CSExercises
{
    public class Ex41
    {
        public static bool InString(string s1, string s2)
        {
            int len1=s1.Length;
            int len2=s2.Length;
            bool CheckForSameChar=false;
            for (int i = 0; i <= len1 - len2; i++)
            {
                /*if (s1[i].Equals(s2[0]))
                {
                    CheckForSameChar = true;
                }
                if (CheckForSameChar)
                { 
                    int m=1;
                    int k=i+1;
                    while(k<i+len2-1 && s1[k].Equals(s2[m++]))
                    {
                        k++;
                    }
                    if (k >= i + len2 - 1)
                    {
                        return true;
                    }
                    else
                    {
                        CheckForSameChar = false;
                    } 
                }*/
                if (s1[i].Equals(s2[0]))
                { 
                    if(s1.Substring(i,s2.Length).Equals(s2))
                    {
                        CheckForSameChar = true;
                        return true;
                    }
                }
            }
            if (CheckForSameChar == false) return false;
            else return true;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine(InString("ASDERTFG","DER"));
        }
    }
}
