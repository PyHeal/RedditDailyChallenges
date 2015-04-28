﻿using System;
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

        public Date(int year, int month, int day)
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

        public int yearCompare (Date other)
        {
            int yearDistance = other.year - this.year;

            if( yearDistance == 1)
            {
                if (other.month > this.month) //It's been a year
                {
                    return 1;
                }
                else if (other.month < this.month) //It hasn't been a year
                {
                    return 0;
                }
                else if (other.month == this.month) //It might have been a year
                {
                    if(other.day < this.day) //Not a year
                    {
                        return 0;
                    }
                    else if (other.day > this.day) //It's been a year
                    {
                        return 1;
                    }
                    else //They must be the same day, so it's been a year exactly 
                    {
                        return -1;
                    }
                }
            }

            return other.year - this.year;
        }
    }

    class Program
    {
        int yearDiffernece;
        int currentYear;

        void Program(int yd, int cy)
        {
            this.yearDiffernece = yd;
            this.currentYear = cy;
        }

        void printDateRange()
        {

        }


        static int Main(string[] args)
        {
            if(args.Length != 2)
            {
                Console.WriteLine("Please enter two dates");
                return 1;
            }

            string[] dateOne = args[0].Split('-');
/*            foreach (string s in what)
            {
                Console.WriteLine(s);
            }*/

            string[] dateTwo = args[1].Split('-');
 /*           foreach (string s in otherWhat)
            {
                Console.WriteLine(s);
            }*/

            Date one = new Date(Convert.ToInt32(dateOne[0]), Convert.ToInt32(dateOne[1]), Convert.ToInt32(dateOne[2]));
            Date two = new Date(Convert.ToInt32(dateTwo[0]), Convert.ToInt32(dateTwo[1]), Convert.ToInt32(dateTwo[2]));

            one.findMonth();
            one.dateCrap();

            two.findMonth();
            two.dateCrap();

            Console.Write(one.strMonth + " " + one.day + one.dateSuff + ", " + one.year + " - ");
            Console.WriteLine(two.strMonth + " " + two.day + two.dateSuff + ", " + two.year);

            int catchMe = one.yearCompare(two);

            Console.WriteLine(catchMe);

            return 0;
        }
    }
}
