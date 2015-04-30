using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expected
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            System.IO.StreamReader output = new System.IO.StreamReader(@"C:\Users\tyler\Documents\Visual Studio 2013\Projects\Expected\Expected\output.txt");
            System.IO.StreamReader expected = new System.IO.StreamReader(@"C:\Users\tyler\Documents\Visual Studio 2013\Projects\Expected\Expected\expected.txt");
            while((line= output.ReadLine()) !=null)
            {
                Console.WriteLine(line);                
            }

            while((line =  expected.ReadLine()) !=null)
            {
                Console.WriteLine(line);                
            }

            output.Close();
            expected.Close();
            System.Console.ReadLine();


        }
    }
}
