using System;
using System.Windows.Forms;

namespace ClassAndObject
{
    public partial class Form1 : Form, IView
    {

        public event EventHandler CreateObjectClick;
        public event EventHandler IncreaseClick;
        public event EventHandler DicreaseClick;
        public event EventHandler ShowClick;


        public int index { get { if (timeArrayList.SelectedIndex != -1) return timeArrayList.SelectedIndex; else return -1; } }

        public int countList { get { return timeArrayList.Items.Count; } }

        public Form1()
        {
            InitializeComponent();
            Presentor presentor = new Presentor(this, new Model(6));
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

        private void showClick_Click(object sender, EventArgs e)
        {
            if (ShowClick != null)
                ShowClick(this, EventArgs.Empty);
        }
    }
}
