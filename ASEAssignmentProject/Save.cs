using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASEAssignmentProject
{
    public class Save
    {
        public void SaveFile(RichTextBox rtb)
        {
            SaveFileDialog sfd = new SaveFileDialog(); //creates new instance of SaveFileDialog class
            sfd.Filter = "Text File|*.txt"; //specifies file type 
            if (sfd.ShowDialog() == DialogResult.OK)
                rtb.SaveFile(sfd.FileName); //executes saving after cliking "OK" in file explorer
        }

    }
}
