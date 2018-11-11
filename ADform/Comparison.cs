using System;
using System.Collections.Generic;
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
            Directory directory = new Directory(form);
        }
    }
}
