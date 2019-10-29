using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObject
{
    public interface IView
    {
        int index { get; }
        int countList { get; }

        void CreateOnSuccess(string time);
        void EditOnSuccess(string time, int index);

        void MessageShow(string message);

        event EventHandler CreateObjectClick;
        event EventHandler IncreaseClick;
        event EventHandler DicreaseClick;

        event EventHandler ShowClick;

    }
}
