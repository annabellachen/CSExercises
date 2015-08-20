using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises.Business_Cases
{
    class Program2
    {
        static void Main(string[] args)
        {
            Console.Write("The old code:");
            string ocode = "1852";
            string blk = "932B";
            string post = "Block 932B Singapore 1852";
            string post1 = "Blk 932B Singapore 1852";
            Console.WriteLine(ocode);
            Console.WriteLine("The blk num:");
            Console.WriteLine(TransferToNewCode(ocode, blk));
            Console.WriteLine(TransferToCode(post));
            Console.WriteLine(TransferToBlock(post));
            Console.Write("The new one:");
            Console.WriteLine(TransferToNewCode(TransferToCode(post), TransferToBlock(post)));
        }
        static string TransferToNewCode(string code, string blk)
        {
            string sp = null;
            if (blk.Length > 3)
            {
                switch (blk.Substring(3, 1))
                {
                    case "A": sp = "1"; break;
                    case "B": sp = "2"; break;
                    case "C": sp = "3"; break;
                    case "D": sp = "4"; break;
                    case "E": sp = "5"; break;
                    case "F": sp = "6"; break;
                    case "G": sp = "7"; break;
                    case "H": sp = "8"; break;
                    default: sp = "0"; break;
                }
            }
            code = code.Substring(2, 2) + sp + blk;
            return code;
        }
        static string TransferToBlock(string post)
        {
            string[] arr = new string[4];
            arr = post.Split(' ');
            String blk = arr[1];
            return blk;
        }
        static string TransferToCode(string post)
        {
            string[] arr = new string[4];
            arr = post.Split(' ');
            string code = arr[3];
            return code;
        }
    }
}
