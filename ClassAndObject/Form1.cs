using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassAndObject
{
    public partial class Form1 : Form, IView
    {

        public event EventHandler CreateObjectClick;
        public event EventHandler IncreaseClick;
        public event EventHandler DicreaseClick;
        public event EventHandler ShowClick;
        public event EventHandler ShowCountObject;

        public Form1()
        {
            InitializeComponent();
        }


        public void MessageError()
        {
            throw new NotImplementedException();
        }

        public void MessageSuccess()
        {
            throw new NotImplementedException();
        }

        public void MessageShow()
        {
            throw new NotImplementedException();
        }
    }
}
