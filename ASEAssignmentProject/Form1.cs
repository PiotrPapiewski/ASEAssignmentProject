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

        private void CommandLine_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void OutputBox_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
