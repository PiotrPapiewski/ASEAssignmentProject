using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASEAssignmentProject
{
    public class Load
    {
        public void LoadFile(RichTextBox rtb)
        {
            OpenFileDialog ofd = new OpenFileDialog(); 
            if (ofd.ShowDialog() == DialogResult.OK)
                rtb.LoadFile(ofd.FileName);
        }
    }
}
