using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObject
{
    public class TimeArray
    {
        List<Time> timeArray;

        int size;

        public TimeArray() { }

        public TimeArray(int size)
        {
            Random rnd = new Random();

            for (int i =0; i<size; i++)
            {
                //arrayTime[i] = new Time(rnd.Next(0,23), )
            }
        }
    }
}
