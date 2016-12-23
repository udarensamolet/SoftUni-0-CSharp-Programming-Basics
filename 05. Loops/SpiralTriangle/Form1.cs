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

namespace SpiralTriangle
{
    public partial class FormDraw : Form
    {
        public FormDraw()
        {
            InitializeComponent();
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            Turtle.Delay = 200;

            for (int i = 1; i <= 22; i++)
            {
                Turtle.Forward(10 * i);
                Turtle.Rotate(120);
            }
            Turtle.Rotate(120);

            Turtle.PenColor = Color.DarkGreen;

            for (int i = 1; i <= 21; i++)
            {
                Turtle.Forward(10 * i);
                Turtle.Rotate(120);
            }

            Turtle.Rotate(120);

            Turtle.PenColor = Color.Red;

            for (int i = 1; i <= 21; i++)
            {
                Turtle.Forward(10 * i);
                Turtle.Rotate(120);
            }
        }
    }
}
