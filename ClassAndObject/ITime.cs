using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObject
{
    public interface ITime
    {
        int hours { get; }
        int minutes { get; }

        void Increase();
        void Dicrease();
    }
}
