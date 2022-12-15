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
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text File|*.txt";
            if (sfd.ShowDialog() == DialogResult.OK)
                rtb.SaveFile(sfd.FileName);
        }

    }
}
