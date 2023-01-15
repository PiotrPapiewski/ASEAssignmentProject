using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASEAssignmentProject
{
    public class Variable
    {
        String name; //creates new string name
        String value; //creates new string value
        public Variable(String name)
        {
            this.name = name; //assings name to parameter 
        }

        public void SetValue(String value) //Method used to set value to variable
        {
            this.value = value; 
        }
        public override int GetHashCode() //returns hash code of the name
        {
            return name.GetHashCode();
        }
        public override bool Equals(Object obj) //overrides method Equals to make sure that method Contains works properly
        {
            var item = obj as Variable; 

            if (item == null)
            {
                return false;
            }

            return this.name.Equals(item.name);
        }
        public String GetValue() //returns value
        {
            return value;
        }
    }
    
}
