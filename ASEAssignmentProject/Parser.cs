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
        this.DrawingSurface = DrawingSurface;
        this.Canvass = canvass;
    }

    public void MyParser(string CommandLine)
    {
        String Command = CommandLine.ToLower(); //allows commands to be enter using lower case and stores user impunt in command variable
        String[] strArray = Command.Split(' '); //splits user command based on space between arguments and puts it in strarray
        String[] Parameters; //creates empty array for parameters

        Command = strArray[0]; //specifies that position 0 in a array is a command

        int[] ParametersInt; //creates empty integer array for parameters

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
                    ParametersInt[i] = Convert.ToInt32(Parameters[i]); //converts into integer and stores in new array ParametersInt

                } //checks which commands are entered and executes appropriate method
                if (Command.Equals("drawline"))
                {
                    Canvass.DrawLine(ParametersInt[0], ParametersInt[1]); //uses canvass method to draw

                }
                else if (Command.Equals("drawsquare"))
                {
                    Canvass.DrawSquare(ParametersInt[0]);

                }
                else if (Command.Equals("drawrectangle"))
                {
                    Canvass.DrawRectangle(ParametersInt[0], ParametersInt[1]);

                }
                else if (Command.Equals("drawcircle"))
                {
                    Canvass.DrawCircle(ParametersInt[0]);

                }
                else if (Command.Equals("drawtriangle"))
                {
                    Canvass.DrawTriangle(ParametersInt[0], ParametersInt[1]);

                }
                else if (Command.Equals("movepen"))
                {
                    Canvass.MovePen(ParametersInt[0], ParametersInt[1]);

                }
            }

        }
        else
        {
            if (Command.Equals("reset"))
            {
                Canvass.Reset();
            }
            else if (Command.Equals("clear"))
            {
                Canvass.Clear(DrawingSurface);
            }
            else if (Command.Equals("red"))
            {
                Canvass.PenColourRed();
            }
            else if (Command.Equals("blue"))
            {
                Canvass.PenColourBlue();
            }
            else if (Command.Equals("yellow"))
            {
                Canvass.PenColourYellow();
            }
            else if (Command.Equals("black"))
            {
                Canvass.PenColourBlack();
            }
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
