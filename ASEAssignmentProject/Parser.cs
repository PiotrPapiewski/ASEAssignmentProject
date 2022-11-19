using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASEAssignmentProject
{
    public class Parser
    {
        Canvass Canvass; //creates an instance of canvass class in parser class
        Bitmap DrawingSurface; //creates an bitmap in parser
    }
    public Parser(Bitmap DrawingSurface, Canvass canvass)
    {
        this.DrawingSurface = DrawingSurface; //assings DrawingSurface to a parameter in parser class
        this.Canvass = canvass; //assings canvass to a parameter in parser class
    }



}
