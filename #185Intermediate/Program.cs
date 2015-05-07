using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyntaxHighlighting
{
    class Program
    {
        static void Main(string[] args)
        {

            System.IO.StreamReader source = new System.IO.StreamReader(@"C:\Users\tyler\Documents\Visual Studio 2013\Projects\SyntaxHighlighting\SyntaxHighlighting\test.py");


            string test = source.ReadLine();

            string[] what = new string[5];

            what = test.Split(' ');

            if(what[0].Equals("print"))
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("print ");
                Console.ResetColor();
            }
            Console.WriteLine(what[1]);


        }
    }
}
