using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASEAssignmentProject
{
    public class Parser
    {
        Canvass Canvass; //creates an instance of canvass class in parser class
        Bitmap DrawingSurface; //creates an bitmap in parser
        Label ErrorDisplay;

        public Parser(Bitmap DrawingSurface, Canvass canvass, Label ErrorDisplay)
        {
            this.DrawingSurface = DrawingSurface; //assings DrawingSurface to a parameter in parser class
            this.Canvass = canvass; //assings canvass to a parameter in parser class
            this.ErrorDisplay = ErrorDisplay; //assings ErrorDisplay to a parameter in parser class
        }

        String Command; //creates string Command variable
        String[] strArray;  //creates a stirng array
        String[] Parameters; //creates empty array for parameter
        int[] ParametersInt; //creates empty integer array for parameters

        public bool ParameterCheck(int ParameterNmb)
        {
            if (ParameterNmb != Parameters.Length)
            {
                ErrorDisplay.Text = "Incorrect number of parameters.";
                return false;
            }   
                return true;
        }

        public void MyParser(string CommandLine)
        {
            Command = CommandLine.ToLower(); //allows commands to be enter using lower case and stores user impunt in command variable
            strArray = CommandLine.Split(' ');//splits user command based on space between arguments and puts it in strarray
            Command = strArray[0]; //specifies that position 0 in a array is a command

            if (ErrorDisplay.Text != "")
                ErrorDisplay.Text = "";

            if (strArray.Length > 1) //check if length of array is more than one
            {   
                if (Command.Equals("fill")) //checks if command fill was entered
                {
                    Canvass.SetFill(strArray[1]); //if command fill was entered executes method setfill from canvass
                }
                else
                {
                    Parameters = strArray[1].Split(','); //Splits user input again this time it splits parameters based on comma,
                    ParametersInt = new int[Parameters.Length]; //creats new array based on how long paratemetrs array is
                    for (int i = 0; i < Parameters.Length; i++) //loops through the Parameter array 
                    {
                        try { 
                        ParametersInt[i] = Convert.ToInt32(Parameters[i]); //converts into integer and stores in new array ParametersInt
                        } 
                        catch(FormatException) 
                        {
                            ErrorDisplay.Text = "Parameter must be integer."; //displays error if parameter is not a integer
                        }

                    } //checks which commands are entered and executes appropriate method
                    if (Command.Equals("drawline"))
                    {
                        if (ParameterCheck(2))
                            Canvass.DrawLine(ParametersInt[0], ParametersInt[1]); //uses canvass method to draw
                    }
                    else if (Command.Equals("drawsquare"))
                    {
                        if (ParameterCheck(1))
                            Canvass.DrawSquare(ParametersInt[0]);
                    }
                    else if (Command.Equals("drawrectangle"))
                    {
                        if (ParameterCheck(2)
                            Canvass.DrawRectangle(ParametersInt[0], ParametersInt[1]);
                    }
                    else if (Command.Equals("drawcircle"))
                    {
                        if (ParameterCheck(1))
                            Canvass.DrawCircle(ParametersInt[0]);
                    }
                    else if (Command.Equals("drawtriangle"))
                    {
                        if (ParameterCheck(2))
                            Canvass.DrawTriangle(ParametersInt[0], ParametersInt[1]);
                    }
                    else if (Command.Equals("movepen"))
                    {
                        if (ParameterCheck(2))
                            Canvass.MovePen(ParametersInt[0], ParametersInt[1]);
                    }
                }
            }
            else
            {
                if (Command.Equals("reset"))
                {
                    if (ParameterCheck(0))
                        Canvass.Reset();
                }
                else if (Command.Equals("clear"))
                {
                    if (ParameterCheck(0))
                        Canvass.Clear(DrawingSurface);
                }
                else if (Command.Equals("red"))
                {
                    if (ParameterCheck(0))
                        Canvass.PenColourRed();
                }
                else if (Command.Equals("blue"))
                {
                    if (ParameterCheck(0))
                        Canvass.PenColourBlue();
                }
                else if (Command.Equals("yellow"))
                {
                    if (ParameterCheck(0))
                        Canvass.PenColourYellow();
                }
                else if (Command.Equals("black"))
                {
                    if (ParameterCheck(0))
                        Canvass.PenColourBlack();
                }
                else
                    ErrorDisplay.Text = "Wrong Command.";
            }
        }

        public void ProgramWindow(string UserInput) //this method allows multiple compands to be written in InputBox
        {
            string[] Commands = UserInput.Split(new string[] { "\n" }, StringSplitOptions.None); //splits commands from inputbox by new line
            foreach (string Command in Commands)
            {
                MyParser(Command); //loops and executs commands from MyParser method so they can be used in ProgramWindow method
            }
        }
    }
}
