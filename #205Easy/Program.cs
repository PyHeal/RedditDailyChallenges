using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendlyDateRanges
{

    class Date
    {
        public int day;
        public int month;
        public int year;
        public string strMonth;
        public string dateSuff;

        public Date(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        public void findMonth()
        {
            string[] months = { "Jan", "Feb", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            this.strMonth = months[this.month - 1];
        }

        public void dateCrap()
        {
            string date = this.day.ToString();

            date = date.Substring(date.Length - 1, 1);

            if (date.Equals("1") && this.day != 11)
            {
                this.dateSuff = "st";
            }
            else if (date.Equals("2") && this.day != 12)
            {
                this.dateSuff = "nd";
            }
            else if (date.Equals("3") && this.day !=13)
            {
                this.dateSuff = "rd";
            }
            else
            {
                this.dateSuff = "th";
            }
        }
    }

    class Program
    {
        static int Main(string[] args)
        {
            if(args.Length != 2)
            {
                Console.WriteLine("Please enter two dates");
                return 1;
            }




            //Date one = new Date();
            //Date two = new Date();









            return 0;
        }
    }
}
