using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISBN_Validator
{
    class Program
    {
        static int Main(string[] args)
        {
            if( args.Length != 1)
            {
                Console.WriteLine("Not Correct");
                return 1;
            }

            int length = args[0].Length;
//          Console.WriteLine("The Length is " + length);
            int otherLength =args[0].Length-1;
            string ISBN = args[0];
            //int ISBN = Convert.ToInt32(args[0]);
            int[] test = new int[ISBN.Length];

            for (int i = 0; i < args[0].Length; i++ )
            {
//              Console.WriteLine("Substring " + i + " is " + ISBN.Substring(i, 1));        
//              Console.WriteLine(length);
                if ( (ISBN.Substring(i,1)).Equals("X"))
                {
                    test[i] = 10 * length;
                }
                else
                {
                    test[i] = Convert.ToInt32(ISBN.Substring(i, 1)) * length;
                }
//              test[i] = Convert.ToInt32(ISBN.Substring(i, 1)) * length;
//              Console.WriteLine("Test "+ i + " is " + test[i]);
                length = length - 1;
            }


           int sum = test.Sum();
 //        Console.WriteLine("The sum is " + sum);
 //        Console.WriteLine("The sum divided by 11 is "+ sum/11.0);

           if( sum%11 == 0)
           {
               Console.WriteLine("Vaild ISBN");
           }
           else
           {
               Console.WriteLine("Invaild ISBN");
           }
                
            
            return 0;
        }
    }
}
