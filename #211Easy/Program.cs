using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheNameGame
{
    class Program
    {
        void PrintRyhme(string firstLetter, string name, string nameLess)
        {                      
            Console.Write(name + ", " + name+ " ");
            if(firstLetter.Equals("B")) { Console.Write("Bo-"); }
            else { Console.Write("bo B"); }
            Console.WriteLine(nameLess + ",");

            Console.Write("Bonana fanna ");
            if (firstLetter.Equals("F")) { Console.Write("Fo-"); }
            else { Console.Write("fo F"); }
            Console.WriteLine(nameLess + ",");

            Console.Write("Fee fy ");
            if (firstLetter.Equals("M")) { Console.Write("Mo-"); }
            else { Console.Write("mo M"); }
            Console.WriteLine(nameLess + ",");

            Console.WriteLine(name + "!");
        }

        int IsException(string letter, string[] args)
        {
            foreach (string s in args)
            {
                if (letter.Equals(s))
                {
                    return 1;
                }
            }

            return 0;
        }

        static int Main(string[] args)
        {
            if(args.Length != 0 && args.Length > 1)
            {
                Console.WriteLine("Please enter only one name");
                return 1;
            }

            int exp = 0;
            string[] exceptions = { "A", "E", "I", "O", "U" };

            Program test = new Program();            

            string name = args[0].Replace("!", "");

            string firstLetter = name.Substring(0, 1);

            exp = test.IsException(firstLetter, exceptions);
            if (exp == 1)
            {
                test.PrintRyhme(firstLetter, name, name.ToLower());
            }
            else
            {
                string nameLess = name.Remove(0,1);
                test.PrintRyhme(firstLetter, name, nameLess);
            }

            return 0;
         }
    }
}
