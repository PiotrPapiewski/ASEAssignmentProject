using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASEAssignmentProject
{
    public abstract class Shapes //class with methods that draw shapes
    {

        public void DrawLine(Graphics g, Pen p, int xPosition, int yPosition, int toX, int toY)
        {
            g.DrawLine(p, xPosition, yPosition, toX, toY);
        }

        public void DrawSquare(Graphics g, Pen p, SolidBrush b, int xPosition, int yPosition, int width, bool fill)
        {
            if (fill)
            {
                g.FillRectangle(b, xPosition, yPosition, width, width);
            }
            else
            {
                g.DrawRectangle(p, xPosition, yPosition, width, width);
            }

        }
        public void DrawRectangle(Graphics g, Pen p, SolidBrush b, int xPosition, int yPosition, int width, int height, bool fill)
        {
            if (fill)
            {
                g.FillRectangle(b, xPosition, yPosition, width, height);
            }
            else
            {
                g.DrawRectangle(p, xPosition, yPosition, width, height);
            }
        }

        public void MovePen(int xPosition, int yPosition, int toX, int toY)
        {
            xPosition = toX;
            yPosition = toY;
        }

        public void DrawCircle(Graphics g, Pen p, SolidBrush b, int xPosition, int yPosition, int radius, bool fill)
        {
            if (fill)
            {
                g.FillEllipse(b, xPosition, yPosition, radius, radius);
            }
            else
            {
                g.DrawEllipse(p, xPosition, yPosition, radius, radius);
            }
        }

        public void DrawTriangle(Graphics g, Pen p, SolidBrush b, int xPosition, int yPosition, int height, int width, bool fill)
        {
            Point A = new Point(xPosition, yPosition);
            Point B = new Point(xPosition + width, yPosition);
            Point C = new Point(xPosition + width / 2, yPosition - height);
            Point[] Triangle = { A, B, C };

            if (fill)
            {
                g.FillPolygon(b, Triangle);
            }
            else
            {
                g.DrawPolygon(p, Triangle);
            }
        }
        public void Reset(int xPositon, int yPosition)
        {
            xPositon = 0;
            yPosition = 0;
        }
    }
}
