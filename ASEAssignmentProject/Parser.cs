﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.PropertyGridInternal;

namespace ASEAssignmentProject
{
    public class Parser
    {
        Canvass Canvass; //creates an instance of canvass class in parser class
        Bitmap DrawingSurface; //creates an bitmap in parser
        Label ErrorDisplay; //creates label in parser
        RichTextBox rtb; //creates richtextbox in parser
        int LineNumber = 0; //creates int variable in parser
        public Parser(Bitmap DrawingSurface, Canvass canvass, Label ErrorDisplay, RichTextBox rtb)
        {
            this.DrawingSurface = DrawingSurface; //assings DrawingSurface to a parameter in parser class
            this.Canvass = canvass; //assings canvass to a parameter in parser class
            this.ErrorDisplay = ErrorDisplay; //assings ErrorDisplay to a parameter in parser class
            this.rtb = rtb; //assings rtb to a parameter in parser class
        }

        public Parser(Bitmap DrawingSurface, Canvass canvass)
        {
            this.DrawingSurface = DrawingSurface;
            this.Canvass = canvass;
      
        }

        List<Variable>Variables = new List<Variable>(); //creates a list for variables

        List<Method>Methods = new List<Method>();    //creates a list for methods
        
        String[] Commands;
        String Command; //creates string Command variable
        String[] strArray;  //creates a stirng array
        String[] Parameters; //creates empty array for parameter
        int[] ParametersInt; //creates empty integer array for parameters

        public bool ParameterCheck(int ParameterNmb)
        {
            if (ParameterNmb != Parameters.Length) //Checks if ParameterNmb is not equal to Parameters.Length
            {
                ErrorDisplay.Text = "Incorrect number of parameters."; //Displays error message
                return false;                                          //retuns false
            }           
                return true;                                           //returns true
        }

        public void MyParser(string CommandLine)
        {
            Command = CommandLine.ToLower(); //allows commands to be enter using lower case and stores user impunt in command variable
            strArray = CommandLine.Split(' ');//splits user command based on space between arguments and puts it in strarray
            Command = strArray[0]; //specifies that position 0 in a array is a command
            
            Variable var = new Variable(Command); //creates temoprary variable

            if (strArray.Length > 1) //check if length of array is more than one
            {
                Parameters = strArray[1].Split(','); //Splits user input again this time it splits parameters based on comma,
                for (int i = 0; i < Parameters.Length; i++) // loops through parameters
                {
                    if (Variables.Contains(new Variable(Parameters[i]))) //checks if Variable exists
                    {
                        Parameters[i] = Variables[Variables.IndexOf(new Variable(Parameters[i]))].GetValue(); //replaces name of the variable for its value
                    }                 
                }
                if (Methods.Contains(new Method(Command))) //checks if Method exists
                {
                    MyParser(Methods[Methods.IndexOf(new Method(Command))].CommandsToString()); //executes method
                }

                if (Command.Equals("fill")) //checks if command fill was entered
                {
                    Canvass.SetFill(strArray[1]); //if command fill was entered executes method setfill from canvass
                }
                else if (Variables.Contains(var) && Parameters[0].Equals("=")) //checks if variable already exists
                {
                    ErrorDisplay.Text = "Variable Exists"; //displays error message if parameter already exists                    
                }
                else if (!Variables.Contains(var) && Parameters[0].Equals("=")) //checks if variable doesn't exists
                {                                                
                    var.SetValue(Parameters[1]); //sets value to variable
                    Variables.Add(var); //adds variable to the list
                }
                else if (Command.Equals("if")) // checks if commands == "if"
                {
                    IF IF = new IF(Parameters[0]);  // creates new IF statement
                    for (int i = LineNumber; i < Commands.Length; i++) //loops through the all lines from if to endif
                    {
                        if (Commands[i] != "endif") //if command != "endif" 
                        {
                            IF.AddCommand(Commands[i]);  //puts all of the commands to the list                       
                        }
                        else
                        {
                            break; //breaks loop so it doesnt go through lines outside if statement
                        }
                    }
                    
                    if (IF.Check()) //checks if condition for IF is met
                    {
                        MyParser(IF.CommandsToString()); //executes commands from IF
                    }
                    LineNumber += IF.GetSize() + 1; //enables rest of the program outside IF to be executed
                } 
                else if (Command.Equals("Method")) //checks if command == "Method"
                {
                    Method method = new Method(Parameters[0]); //creates new Method
                    for (int i = LineNumber; i < Commands.Length; i++) //loops through the all lines from Method to endMethod
                    {
                        if (Commands[i] != "endMethod") //if command != equal "endMethod"
                        {
                            method.AddCommand(Commands[i]); //puts all of the commands to the list 
                        }
                        else
                        {
                            break; //breaks loop so it doesnt go through lines outside method
                        }
                    }

                }
                else
                {                          
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
                    if (Command.Equals("drawline") && ParameterCheck(2))
                    {                        
                            Canvass.DrawLine(ParametersInt[0], ParametersInt[1]); //uses canvass method to draw
                    }
                    else if (Command.Equals("drawsquare") && ParameterCheck(1))
                    {                     
                            Canvass.DrawSquare(ParametersInt[0]);
                    }
                    else if (Command.Equals("drawrectangle") && ParameterCheck(2))
                    {
                            Canvass.DrawRectangle(ParametersInt[0], ParametersInt[1]);
                    }
                    else if (Command.Equals("drawcircle") && ParameterCheck(1))
                    {                       
                            Canvass.DrawCircle(ParametersInt[0]);
                    }
                    else if (Command.Equals("drawtriangle") && ParameterCheck(2))
                    {
                            Canvass.DrawTriangle(ParametersInt[0], ParametersInt[1]);
                    }
                    else if (Command.Equals("drawoctagon") && ParameterCheck(1))
                    {
                        Canvass.DrawOctagon(ParametersInt[0]);
                    }
                    else if (Command.Equals("drawrhombus") && ParameterCheck(1))
                    {
                        Canvass.DrawRhombus(ParametersInt[0]);
                    }
                    else if (Command.Equals("movepen") && ParameterCheck(2))
                    {                       
                            Canvass.MovePen(ParametersInt[0], ParametersInt[1]);
                    }
                    else if (ParameterCheck(1))
                    {
                       ErrorDisplay.Text = "Wrong Command.";
                    }
                    else if (ParameterCheck(2))
                    {
                        ErrorDisplay.Text = "Wrong Command.";
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
                    ErrorDisplay.Text = "";
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
                else if (Command.Equals("save"))
                {
                    Save save = new Save();
                    save.SaveFile(rtb);
                }
                else if (Command.Equals("load"))
                {
                    Load load = new Load();
                    load.LoadFile(rtb); 
                }
                else 
                    ErrorDisplay.Text = "Wrong command or command requires parameter."; 
            }
        }

        public void ProgramWindow(string UserInput) //this method allows multiple compands to be written in InputBox
        {
            Commands = UserInput.Split(new string[] { "\n" }, StringSplitOptions.None); //splits commands from inputbox by new line
            for (int i = 0; i < Commands.Length; i++)
            {
                MyParser(Commands[i]); //loops and executs commands from MyParser method so they can be used in ProgramWindow method
                LineNumber++;
            }
        }
    }
}
