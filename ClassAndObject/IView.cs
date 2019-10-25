using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObject
{
    public interface IView
    {
        void MessageError();
        void MessageSuccess();

        event EventHandler CreateObjectClick;
        event EventHandler IncreaseClick;
        event EventHandler DicreaseClick;

        event EventHandler ShowClick;
    }
}
