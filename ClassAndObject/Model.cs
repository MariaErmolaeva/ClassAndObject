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

        public int count { get { return timeArray.Count(); } }

        public Time element { get { return timeArray[indexArray]; } set { timeArray[indexArray] = value;} }

        public List<Time> allArray { get { return timeArray; } }

        public Model() { timeArray = new List<Time>(); }

        public Model(int size)
        {
            Random rnd = new Random();
            timeArray = new List<Time>();

            for (int i = 0; i < size; i++)
                timeArray.Add(new Time(rnd.Next(22), rnd.Next(58)));
            
        }

        public Model (params Time [] timeArr)
        {
            timeArray = new List<Time>();
            for (int i = 0; i < timeArr.Count(); i++)
            {
                timeArray.Add(timeArr[i]);
              
            }
        }

        public void AddElement(Time time)
        {
            timeArray.Add(time);
        }

    }
}
