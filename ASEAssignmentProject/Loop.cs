using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASEAssignmentProject
{

    public class Loop
    {
        String Condition;
        List<String> Commands;
        public Loop(String Condition)
        {
            this.Condition = Condition;
            Commands = new List<String>();
        }

        public bool Check()
        {
            int index = 0;
            string o = "";
            string[] p = new string[2] { "", "" };
            for (int i = 0; i < Condition.Length; i++)
            {
                char c = Condition[i];
                if (c == '<' || c == '>' || c == '=')
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
                int p1 = Convert.ToInt32(p[0]);
                int p2 = Convert.ToInt32(p[1]);
                if (o == "==")
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

        public int GetSize()
        {
            return Commands.Count;
        }
    }

}
