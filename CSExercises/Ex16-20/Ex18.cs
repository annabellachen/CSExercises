using System;

namespace CSExercises
{
    public class Ex18
    {
        public static void Main(string[] args)
        {
            string msg1 = "Please input the grade:";
            string msg2 = "Please input a valid grade(0-100) and try again";
            string msg3 = "You scored ";
            string msg4 = " marks which is ";
            string msg5 = " grade.";
            string msg;
            Console.WriteLine(msg1);
            string res;
            res = Console.ReadLine();
            try{
                int grade = Convert.ToInt32(res);
                if (grade < 0 || grade > 100)
                    msg = "**Error**";
                else if (grade < 40)
                    msg = msg3 + res + msg4 + "F" + msg5;
                else if (grade < 60)
                    msg = msg3 + res + msg4 + "C" + msg5;
                else if (grade < 80)
                    msg = msg3 + res + msg4 + "B" + msg5;
                else
                    msg = msg3 + res + msg4 + "A" + msg5;
                Console.WriteLine(msg);
            }
            catch {
                Console.WriteLine(msg2);
            }
        }
    }
}