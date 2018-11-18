using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scavenger
{
    class Comparison
    {
        private readonly IUIForm form;
        public Comparison(IUIForm form)
        {
            this.form = form;
            
        }

        public void CompareUsers(object source, EventArgs args)
        {
            Directory directory = new Directory(form);
            User user1 = directory.ProcesUserGroups(form.userField);
            User user2 = directory.ProcesUserGroups(form.userField2);
            form.OUTextBox = directory.FormatList(user1);
            form.OUTextBox2 = directory.FormatList(user2);
            


        }


    }
}
