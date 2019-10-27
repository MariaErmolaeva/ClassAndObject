using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObject
{
    public class Model: IModel
    {
        private List<Time> timeArray;
        private int indexArray;

        public int index { set { if (indexArray < timeArray.Count) indexArray = value; } }

        public Time element { get { return timeArray[indexArray]; } }

        public List<Time> allArray { get { return timeArray; } }

        public Model() { }

        public Model(int size)
        {
            Random rnd = new Random();

            for (int i = 0; i < size; i++)
                timeArray.Add(new Time(rnd.Next(23), rnd.Next(59)));
        }

        public Model (params Time [] timeArr)
        {
            for (int i = 0; i < timeArr.Count(); i++)
                timeArray.Add(timeArr[i]);
        }

        void AddElement(Time time)
        {
            timeArray.Add(time);
        }

    }
}
