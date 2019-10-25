using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObject
{
    public class Presentor
    {
        IView view;
        IModel model;

        public Presentor (IView view, IModel model)
        {
            this.view = view;
            this.model = model;


            view.CreateObjectClick += View_CreateObjectClick;
            view.DicreaseClick += View_DicreaseClick;
            view.IncreaseClick += View_IncreaseClick;
            view.ShowClick += View_ShowClick;
        }

        private void View_ShowClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void View_IncreaseClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void View_DicreaseClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void View_CreateObjectClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
