using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASEAssignmentProject
{
    public partial class Form1 : Form
    {
        static Bitmap DrawingSurface = new Bitmap(400, 300); //creating a bitmap and assigning it to the picture box 'DrawingSurface'
        static Canvass MyCanvass; //creating an instnace of canvass class inside form1 class
        public Form1()
        {
            InitializeComponent(); //method that creates from
            MyCanvass = new Canvass(Graphics.FromImage(DrawingSurface)); //updates mycanvass to be able to display drawings onto 'DrawingSurface' 
        }

        public void CommandLine_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) //creates an event that once user presses enter key it executes program
            {
                Parser Parser = new Parser(DrawingSurface, MyCanvass); //creates an instance of a parser class
                Parser.MyParser(CommandLine.Text); //takes input from the commandline and runs thorugh commands from parser class and executes MyParser method
                if (CommandLine.Text.Equals("run")) //if command line is run then it executes ProgramWindow method from parser class
                {
                    Parser.ProgramWindow(InputBox.Text);
                }
                Refresh(); //refreshes the canvass to display drawings             
            }
        }

        public void OutputBox_Paint(object sender, PaintEventArgs e)
        {   //draws using Graphisc on to the DrawingSurface
            Graphics g = e.Graphics;
            g.DrawImageUnscaled(DrawingSurface, 0, 0);
        }
    }
}
