using System.Drawing;


namespace lab6
{
    public class ThingElement
    {
        Pen normal = new Pen(Color.DarkViolet, 2);
        Pen sel = new Pen(Color.Blue, 2);
        Font font = new Font("Impact", 16F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
        SizeF stringSize = new SizeF();
        int side = 40;
        public float X
        {
            get; set;
        }
        public float Y
        {
            get; set;
        }
        public bool Selected
        {
            get; set;
        }
        public int Value
        {
            get; set;
        }
        public bool ContainsPoint(int xCoord, int yCoord)
        {
            if (xCoord >= X && xCoord <= X + side && yCoord >= Y && yCoord <= Y + side)
                return true;
            return false;
        }
        public void Draw(Graphics g)
        {
            if (Selected)
                g.DrawEllipse(sel, X, Y, side, side);
            else g.DrawEllipse(normal, X, Y, side, side);

            stringSize = g.MeasureString(Value.ToString(), font);
            g.DrawString(Value.ToString(), font, Brushes.Red, X + side / 2 - stringSize.Width / 2, Y + side / 2 - stringSize.Height / 2);
        }
        public ThingElement(int value)
        {
            Value = value;
            Selected = false;
            Dragging = false;
        }

        public bool Dragging
        {
            set;
            get;
        }
    }
}
