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
        public event EventHandler ShowCountObjectClick;

        public Form1()
        {
            InitializeComponent();
        }



        public void MessageSuccess()
        {
            throw new NotImplementedException();
        }

        public void MessageShow(string message)
        {
            MessageBox.Show(message);
        }

        private void CreateObject_Click(object sender, EventArgs e)
        {
            if (CreateObjectClick != null)
                CreateObjectClick(this, EventArgs.Empty);
        }

        private void Increase_Click(object sender, EventArgs e)
        {
            if (IncreaseClick != null)
                IncreaseClick(this, EventArgs.Empty);
        }

        private void Dicrease_Click(object sender, EventArgs e)
        {
            if (DicreaseClick != null)
                DicreaseClick(this, EventArgs.Empty);
        }

        public void CreateOnSuccess(string time)
        {
            timeArrayList.Items.Add(time);
        }

        public void EditOnSuccess(string time, int index)
        {
            timeArrayList.Items[index] = time;
        }
    }
}
