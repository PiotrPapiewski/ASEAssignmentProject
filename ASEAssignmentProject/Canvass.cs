using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASEAssignmentProject
{
    public class Canvass
    {
        Graphics g; //creates graphics 
        public Pen p; //creates pen used to draw
        SolidBrush b; //creats solid brush used to fill
        public int xPosition, yPosition; //creates x and y coordinates for pen
        public bool fill; //creates fill boolean

        public Canvass(Graphics g) //creats instance with graphic sets position of a pen and changes it colour to black
        {
            this.g = g;
            xPosition = yPosition = 0;
            p = new Pen(Color.Black, 1);
        }



    }
}
