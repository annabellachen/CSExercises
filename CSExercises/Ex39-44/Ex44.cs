using System;
namespace CSExercises
{
    public class Ex44
    {
        public static string Substitute(string s, char c1, char c2)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i].Equals(c1))
                {
                    s = s.Substring(0, i) + Convert.ToString(c2) + s.Substring(i + 1, s.Length - i - 1);
                    /*s = s.Remove(i);
                    s = s.Insert(i, Convert.ToString(c2));*/
                }

            }
            //if (s[s.Length - 1] == c2) s = s.Substring(0, s.Length - 2) + Convert.ToString(c2);
            return s;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine(Substitute("asdwerrr", 'r', 'o'));
        }
    }
}
