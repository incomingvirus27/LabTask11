using System;
using System.Collections.Generic;
using System.Text;

namespace LabTask11ClassesAndObject
{
    class Date
    {
        private int day;
        private int month;
        private int Year { get; set; }
        public Date(int theDay, int theMonth, int theYear)
        {
            Day = theDay;
            Month = theMonth;
            Year = theYear;
            Console.WriteLine($"Date Construtor Called {this}");
        }

        public int Month
        {
            get { return month; }
            private set
            {
                if ((value > 0) && (value <= 12))
                {
                    month = value;
                }
                else
                {
                    throw new System.ArgumentOutOfRangeException("Out of range");
                }
            }
        }
        public int Day
        {
            get { return day; }
            set
            {
                day = value;
               
                int[] DaysPerMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
                if((value > 0) && (value <= 31))
                {
                    day = value;
                }else if ((Month == 2 && value ==29) &&(Year % 4 ==  0 || Year % 400 == 0) && (Year % 100 != 0))
                {
                    day = value;
                }
                else
                {
                    throw new System.ArgumentOutOfRangeException("Day Value out of Range");
                }
                
            }
        }
        public override string ToString()
        {
            return $"{Day}/{Month}/{Year}";
        }
    }
}
