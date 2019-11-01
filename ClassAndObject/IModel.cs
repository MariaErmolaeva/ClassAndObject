
using System.Collections.Generic;

namespace ClassAndObject
{
    public interface IModel
    {
        int index { set; }

        int count { get; }

        Time element { get; set; }

        List<Time> allArray { get; }

        void AddElement(Time time);
    }
}
