using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASEAssignmentProject
{
    internal class Method
    {
        String Name; //creates new string Name
        List<String> Commands; //creates new list Commands

        public Method(string name)
        {
            this.Name = name; //assings name to parameter
            Commands = new List<String>(); //assings empty list to commands
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

        public void AddCommand(string command) //returns value
        {
            Commands.Add(command);
        }
    }
}
