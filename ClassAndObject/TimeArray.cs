using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObject
{
    public class Model: IModel
    {
        List<Time> timeArray;

        public int index
        {
            get
            {
                return 1;
            }
        }

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

        public void ShowArray()
        {
            throw new NotImplementedException();
        }


        
    }
}
