using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5
{
    public class CheckDate
    {
        enum Months31
        {
            January = 1, // 31 days
           March = 3, // 31
           May = 5, // 31
            July = 7, // 31
            August = 8, // 31
            October = 10, // 31
            Decembe = 12 // 31
        };
        enum Months30
        {
            February = 2,
            April = 4,
            June = 6,
            September = 9,
            November = 11
        };

        public bool isLeap(int year)
        {
            //(divisible by 4 AND NOT Divisble by 100) OR (Divisble by 100 AND divisble by 400)
            return (year%4 == 0 && year%100 != 0) || (year%100 == 0 && year%400 == 0);
        }
        public bool validDay(int day)
        {
            // day is between 1 and 31.
            return (day > 0 && day < 32);
        }
        public bool validMonth(int month)
        {
            // just check the enums to make sure that month is defined. 
            return (Enum.IsDefined(typeof(Months30), month) || (Enum.IsDefined(typeof(Months31), month)));
        }
        public bool validYearRange(int year)
        {
            return (year > 1800 && year < 2020);
        }

        public bool validDayAndMonth(int day, int month)
        {
            if (validDay(day) && validMonth(month)) // check to make sure they're valid days and months first
            {
                if (day > 30 && !Enum.IsDefined(typeof(Months31), month)) // 31 days in Months that DON'T have 31 days.
                {
                    Console.WriteLine((Months30)month + " does not have {0} days",day);
                    return false;
                }
                if (day > 29 && (month == (int) Months30.February)) // February having 30 days...
                {
                    Console.WriteLine((Months30)month + " does not have {0} days",day);
                    return false;
                }
                return true;
            }
            Console.WriteLine("Invalid Day or Month");
            return false;
        }

        
    }
}
