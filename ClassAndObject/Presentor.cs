using System;


namespace ClassAndObject
{
    public class Presentor
    {
        IView view;
        IModel model;

        public Presentor(IView view, IModel model)
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
            try
            {
                if (model.count != 0 && view.countList < model.count)
                {
                    for (int i = 0; i < model.count; i++)
                    {
                        model.index = i;
                        view.CreateOnSuccess(model.element.hoursGetSet + ":" + model.element.minutesGetSet);
                    }
                }
            }
            catch
            {
                view.MessageShow("Весь массив выведен");
            }
        }

        private void View_IncreaseClick(object sender, EventArgs e)
        {
            try
            {
                if (view.index != -1)
                {
                    model.index = view.index;
                    model.element ++;
                    view.EditOnSuccess(model.element.hoursGetSet.ToString() + ":" + model.element.minutesGetSet, view.index);
                }
            }
            catch
            {
                view.MessageShow("Выберите элемент из списка");
            }
        }

        private void View_DicreaseClick(object sender, EventArgs e)
        {
            try
            {
                if (view.index != -1)
                {
                    model.index = view.index;
                    model.element--;
                    view.EditOnSuccess(model.element.hoursGetSet.ToString() + ":" + model.element.minutesGetSet, view.index);
                }
            }
            catch
            {
                view.MessageShow("Выберите элемент из списка");
            }
        }

        private void View_CreateObjectClick(object sender, EventArgs e)
        {
            try
            {
                Random rnd = new Random();
                model.AddElement(new Time(rnd.Next(0, 23), rnd.Next(0, 59)));
                model.index = model.count-1;
                view.CreateOnSuccess(model.element.hoursGetSet + ":" + model.element.minutesGetSet);
            }
            catch
            {

            }
        }
    }
}
