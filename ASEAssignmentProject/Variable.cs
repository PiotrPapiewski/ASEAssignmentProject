using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASEAssignmentProject
{
    public class Variable
    {
        String name;
        String value;
        public Variable(String name)
        {
            this.name = name;
        }

        public void SetValue(String value)
        {
            this.value = value;
        }
        public override int GetHashCode()
        {
            return name.GetHashCode();
        }
        public override bool Equals(Object obj)
        {
            var item = obj as Variable;

            if (item == null)
            {
                return false;
            }

            return this.name.Equals(item.name);
        }
        public String GetValue()
        {
            return value;
        }
    }
    
}
