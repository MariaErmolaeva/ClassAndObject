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
    public partial class Form1 : Form
    {
        Time time;

        public Form1()
        {
            InitializeComponent();
        }


        private void Create_Click(object sender, EventArgs e)
        {
            time = new Time(2,14);
            Message();          
        }


        public void Message()
        {
            mainText.Text += "Часы: " + time.hoursGetSet.ToString() + "\nМинуты: " + time.minutesGetSet.ToString() + "\n\n";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            time.AddMin(time);
            Message();

            Time.AddMinutes(time);
            Message();
        }
    }
}
