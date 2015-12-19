using System;

namespace lab6
{
    class MController : IController
    {
        IModel model;
        IView view;
        public void Add(int el)
        {
            model.Add(el);
            view.UpdateView();
        }

        public void RemoveMax()
        {
            model.RemoveMax();
            view.UpdateView();
        }

        public void RemoveMin()
        {
            model.RemoveMin();
            view.UpdateView();
        }

        public void ClaerAll()
        {
            model.RemoveAll();
            view.UpdateView();
        }
        public void RemoveSelected()
        {
            int index = -1;
            int count = 0;
            foreach (ThingElement el in model)
            {
                if (el.Selected)
                {
                    index = count;
                    break;
                }
                count++;
            }
            if (index != -1)
                model.DeleteAt(index);
            view.UpdateView();
        }

        public void SetModel(IModel m)
        {
            model = m;
        }

        public void SetView(IView v)
        {
            view = v;
        }
    }
}
