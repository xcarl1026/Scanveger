using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scavenger
{
    public class User
    {
        public string UserName { get; set; }

        public string UserDisplayName { get; set; }

        public List<string> UserSecGroups { get; set; }
    }
}
