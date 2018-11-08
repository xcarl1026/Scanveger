using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scavenger
{
     public interface IUIForm
    {
       string OUTextBox { get; set; }

       string domainField { get; set; }

       string userField { get; set; }

       Label ldapLabel { get; set; }
       
       SaveFileDialog saveDialog { get; set; }
       

     
    }
}
