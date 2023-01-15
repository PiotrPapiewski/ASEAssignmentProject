using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASEAssignmentProject
{
    public class Canvass : Shapes //canvass class extends shapes class
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

        //methods from shapes class to use on canvass
        public void DrawLine(int toX, int toY)
        {
            DrawLine(g, p, xPosition, yPosition, toX, toY);
            xPosition = toX;
            yPosition = toY;
        }

        public void DrawSquare(int width)
        {
            DrawSquare(g, p, b, xPosition, yPosition, width, fill);
        }
        public void DrawRectangle(int width, int height)
        {
            DrawRectangle(g, p, b, xPosition, yPosition, width, height, fill);
        }

        public void MovePen(int toX, int toY)
        {
            xPosition = toX;
            yPosition = toY;
        }

        public void DrawCircle(int radius)
        {
            DrawCircle(g, p, b, xPosition, yPosition, radius, fill);
        }

        public void DrawTriangle(int height, int width)
        {
            DrawTriangle(g, p, b, xPosition, yPosition, height, width, fill);
        }

        public void DrawOctagon(int size)
        {
            DrawOctagon(g, p, b, xPosition, yPosition, size, fill);
        }

        public void DrawRhombus(int size)
        {
            DrawRhombus(g, p, b, xPosition, yPosition, size, fill);
        }

        public void Reset()
        {
            xPosition = 0;
            yPosition = 0;
        }

        public void Clear(Bitmap img)
        {
            Graphics g = Graphics.FromImage(img);
            g.Clear(Color.Transparent);
        }

        public void PenColourRed()
        {
            p = new Pen(Color.Red, 1);
            b = new SolidBrush(Color.Red);
        }
        public void PenColourBlue()
        {
            p = new Pen(Color.Blue, 1);
            b = new SolidBrush(Color.Blue);
        }
        public void PenColourYellow()
        {
            p = new Pen(Color.Yellow, 1);
            b = new SolidBrush(Color.Yellow);
        }
        public void PenColourBlack()
        {
            p = new Pen(Color.Black, 1);
            b = new SolidBrush(Color.Black);
        }
        public void SetFill(string fill) //fill method for turning fill on and off
        {
            if (fill.Equals("on"))
            {
                this.fill = true;
            }
            else if (fill.Equals("off"))
            {
                this.fill = false;
            }
        }
    }
}
