using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.DirectoryServices;



namespace Scavenger
{
    static class Program
    {
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Event Publisher
            UIForm gui = new UIForm();
            //Event Subscriber
            Directory directory = new Directory(gui); 
            //Subscribe
            //gui.TButtonClicked += directory.CallGetOrgsUnits;
            //gui.SearchButtonClicked += directory.CallGetOrgsUnits;
            gui.SearchButtonClicked += directory.DisplayUserResult;
            Application.Run(gui);

        }

    }
}
