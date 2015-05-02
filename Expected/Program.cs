using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expected
{
    class Program
    {
        static int Main(string[] args)
        {
            

            if(args.Length != 2)
            {
                Console.WriteLine("Format is Expected <ouput> <expected>");
                return 1;
            }

            string line;
            string outputCon = args[0];
            string expectedCon = args[1];

            int counter = 0;
            //TODO How do I use these strings to open the files?

            System.IO.StreamReader output = new System.IO.StreamReader(@"C:\Users\tyler\Documents\Visual Studio 2013\Projects\Expected\Expected\output.txt");
            System.IO.StreamReader expected = new System.IO.StreamReader(@"C:\Users\tyler\Documents\Visual Studio 2013\Projects\Expected\Expected\expected.txt");

            for (int i = 0; i < output.Length; i++ )
            {
                if(output[i].Equals(expected[i]))
                {
                    Console.WriteLine("SAME");
                }
                else
                {
                    Console.WriteLine("Different");
                    counter++;
                }
            }
            if(counter != 0)
            {
                Console.WriteLine(counter + " Number of lines wrong");
            }



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

            return 0;
        }
    }
}
