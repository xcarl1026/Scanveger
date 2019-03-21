using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scavenger
{
    class Comparison
    {
        private readonly IUIForm form;
        string resultOutput = String.Empty;
        public Comparison(IUIForm form)
        {
            this.form = form;
            
        }

        public void CompareUsers(object source, EventArgs args)
        {
            form.OUTextBox3 = String.Empty;
            form.missingGroupLabelText = "Missing groups for: ";
            Directory directory = new Directory(form);
            User user1 = directory.ProcesUserGroups(form.userField);
            User user2 = directory.ProcesUserGroups(form.userField2);
            form.OUTextBox = directory.FormatList(user1);
            form.OUTextBox2 = directory.FormatList(user2);
            if(user1.Found && user2.Found == true)
            {
                int count = 0;
                var differencesList = user1.UserSecGroups.Except(user2.UserSecGroups);
                int max = differencesList.Count();
                string[] missingGroups = new string[max];
                foreach (string line in differencesList)
                {
                    string[] trimPath = line.Split(',');
                    form.OUTextBox3 += trimPath[0].Substring(3) + Environment.NewLine;
                    missingGroups[count] = trimPath[0].Substring(3);
                    count++;
                    form.missingGroupLabelText = "Groups missing for: " + user2.UserDisplayName  + Environment.NewLine + "In comparison to: " + user1.UserDisplayName ;
                }
                formatResult(user1, user2, missingGroups);
      
            }                   

        }

        public void SaveCompareResult(object source, EventArgs args)
        {
            SaveFileDialog saveDialog = form.saveDialog;
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                using (Stream s = File.Open(saveDialog.FileName, FileMode.Append))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    sw.Write(resultOutput);
                }
            }
        }

        private void formatResult(User user1, User user2, string[] missingGroups)
        {
            Directory directory = new Directory(form);
            var builder = new StringBuilder();
            builder.Append(directory.FormatList(user1));
            builder.Append(Environment.NewLine);
            builder.Append(directory.FormatList(user2));
            builder.Append(Environment.NewLine);
            builder.Append("Missing Groups for: " + user2.UserDisplayName);
            builder.Append(Environment.NewLine);
            foreach(string line in missingGroups)
            {
                builder.Append(line);
                builder.Append(Environment.NewLine);
            }
            resultOutput = builder.ToString();
        }
    }
}
