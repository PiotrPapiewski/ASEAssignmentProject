using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASEAssignmentProject
{
    internal class Method
    {
        String Name;
        List<String> Commands;

        public Method(string name)
        {
            this.Name = name;
            Commands = new List<String>();
        }
        public string CommandsToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (string s in Commands)
            {
                sb.Append(s);
                sb.Append('\n');
            }
            return sb.ToString();
        }

        public void AddCommand(string command)
        {
            Commands.Add(command);
        }
    }
}
