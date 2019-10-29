using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObject
{
    public class Time
    {
        private int hours;
        private int minutes;

        public int hoursGetSet { get { return hours; } }

        public int minutesGetSet { get { return minutes; } }

        public Time(int hours, int minutes)
        {
            if (hours < 24)
                this.hours = hours;

            if (minutes < 60)
                this.minutes = minutes;
        }


        public static Time AddMinutes(Time time)
        {
            if (time.minutes < 60)
                time.minutes++;

            return time;
        }

        public Time AddMin(Time time)
        {
            if (time.minutes < 59)
                time.minutes++;
            else
            {
                time.hours++;
                time.minutes = 0;
            }
            return time;
        }

        public static Time operator ++(Time time)
        {
            if (time.minutes < 59)
                time.minutes++;
            else
            {
                time.hours++;
                time.minutes = 0;
            }

            return time;
        }

        public static Time operator --(Time time)
        {
            if (time.hours > 0)
            {
                if (time.minutes > 0)
                    time.minutes--;
                else
                {
                    time.hours--;
                    time.minutes = 59;
                }
            }

            return time;
        }

        public static bool operator true(Time time)
        {            
            return time.hours != 0 && time.minutes != 0;
        }

        public static bool operator false(Time time)
        {
           return time.hours == 0 || time.minutes == 0;
        }

    }
}
