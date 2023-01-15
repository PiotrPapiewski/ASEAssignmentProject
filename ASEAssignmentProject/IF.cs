using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ASEAssignmentProject
{
    public class IF
    {
        String Condition; //creates new string Condition
        List<String> Commands; //creates new List Commands
        public IF(String Condition)
        {
            this.Condition = Condition; //assings Condition to a parameter
            Commands = new List<String>(); //assings empty list to Commands
        }

        public bool Check() //splits contidion into three parts 
        {
            int index = 0;                                  //sets index to 0
            string o = "";                                  //creates empty string for operator                
            string[] p = new string[2] {"",""};             //creates new array for values to be checked
            for (int i = 0; i < Condition.Length; i++)      //loops through condition and assings values to array p and operator to o
            {               
                char c = Condition[i];                      //creates new variable c and assings it to codition
                if (c == '<'||c == '>'||c == '=')           
                {
                    o += c;
                    if (o.Length == 1)
                    {
                        index++;
                    }
                }
                else
                {
                    p[index] += c;
                }
            }
            try
            {
                int p1 = Convert.ToInt32(p[0]); //converts value p[0] from p array too integer and assigns it to p1 variable
                int p2 = Convert.ToInt32(p[1]); //converts value p[1] from p array too integer and assigns it to p2 variable

                if (o == "==") // return true or false based on a codition: ==, >, <, >=, <=
                {
                    return p1 == p2;
                }
                else if (o == ">")
                {
                    return p1 > p2;
                }
                else if (o == "<")
                {
                    return p1 < p2;
                }
                else if (o == "<=")
                {
                    return p1 <= p2;
                }
                else if (o == ">=")
                {
                    return p1 >= p2; 
                }
            }
            catch (FormatException) 
            {
                return p[0] == p[1]; 
            }

            return false;

        }

        public string CommandsToString() //Converts all commands and converts it into one string and can be executed
        {   
            StringBuilder sb = new StringBuilder();
            foreach (string s in Commands) //loops thorugh every command collected from after conditon to before end of if statement
            {
                sb.Append(s);
                sb.Append('\n');
            }
            return sb.ToString();
        }

        public void AddCommand(string command) //add commands to the list
        {
            Commands.Add(command);
        }

        public int GetSize() //retuns size of the list
        {
            return Commands.Count;
        }
    }
}
