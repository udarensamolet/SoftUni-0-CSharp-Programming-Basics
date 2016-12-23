using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nakov.TurtleGraphics;

namespace TurtleSun
{
    public partial class FormSun : Form
    {
        public FormSun()
        {
            InitializeComponent();
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 36; i++)
            {
                Turtle.Forward(60);
                Turtle.Rotate(10);
                Turtle.Forward(60);
                Turtle.Rotate(170);
                Turtle.Forward(60);
                Turtle.Rotate(10);
                Turtle.Forward(60);
                Turtle.Rotate(180);
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            Turtle.Reset();
        }
    }
}
