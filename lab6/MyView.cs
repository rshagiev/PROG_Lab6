using System.Drawing;
using System;
using System.Windows.Forms;

namespace lab6
{
    class MyView : Panel, IView
    {
        IModel model;
        public void SetModel(IModel m)
        {
            model = m;
        }

        public void UpdateView()
        {
            Invalidate();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            int levels = 1;
            int c = 1;
            int x0 = this.Size.Width / 2;
            int distance=200;
            int parent = 0;
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            if (model == null)
                return;
            foreach (ThingElement el in model)
            {
                if(c==1)
                {
                    el.X = x0;
                    el.Y = levels * 50;
                    el.Draw(g);
                    c++;
                    continue;
                }
                if (c >= Math.Pow(2, levels))
                    levels++;
                
                parent = (c - 2) / 2;
                if (c % 2 == 0)
                    el.X = model[parent].X - distance / levels;
                else el.X = model[parent].X + distance / levels;

                el.Y = levels * 50;
                el.Draw(g);
                g.DrawLine(Pens.Green, model[parent].X + 20, model[parent].Y + 40, el.X + 20, el.Y);
                Console.WriteLine(el.X);
                c++;
            }
        }
        public MyView()
        {
            DoubleBuffered = true;            
        }

    }
}
