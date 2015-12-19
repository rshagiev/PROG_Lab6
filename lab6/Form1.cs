using System;
using System.Windows.Forms;

namespace lab6
{
    public partial class Form1 : Form
    {
        IModel model;
        IController controller;
        public Form1()
        {
            InitializeComponent();
            model = new MModel();

            myView1.SetModel(model);

            controller = new MController();
            controller.SetModel(model);
            controller.SetView(myView1);
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textboxAdd.Text = "";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int t;
            if (int.TryParse(textboxAdd.Text, out t))
                controller.Add(t);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Enter))
            {
                int t;
                if (int.TryParse(textboxAdd.Text, out t))
                    controller.Add(t);
                textboxAdd.Clear();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void myView1_MouseClick(object sender, MouseEventArgs e)
        {
            foreach (ThingElement el in model)
                if (el.ContainsPoint(e.X, e.Y))
                    el.Selected = true;
                else
                    el.Selected = false;
            myView1.UpdateView();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            controller.RemoveSelected();
        }

        private void RemoveMax_Click(object sender, EventArgs e)
        {
            controller.RemoveMax();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            controller.RemoveMin();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            controller.ClaerAll();
        }
    }
}
