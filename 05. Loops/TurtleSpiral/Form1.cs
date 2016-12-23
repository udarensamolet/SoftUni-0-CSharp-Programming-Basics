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

namespace TurtleSpiral
{
    public partial class Spiral : Form
    {
        public Spiral()
        {
            InitializeComponent();
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            Turtle.Delay = 200;
            zdravko(1);
        }

        private void zdravko(int length)
        {
            if (length == 21)
            {
                return;
            }
                Turtle.Forward(5 * length);
                Turtle.Rotate(60);
                zdravko(length + 1);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            Turtle.Reset();
        }
    }
}
