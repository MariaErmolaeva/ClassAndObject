using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassAndObject
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            /*Form1 form = new Form1();
            Model model = new Model(6);
            Presentor presentor = new Presentor(form, model);
            */
            Application.Run(new Form1());
        }
    }
}
