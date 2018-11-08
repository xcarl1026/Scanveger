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
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Event Publisher
            UIForm gui = new UIForm();
            //Event Subscriber
            Directory directory = new Directory(gui); 
            //Subscriber
            gui.SearchButtonClicked += directory.DisplayUserResult;
            gui.SaveButtonClicked += directory.SaveUserSecGroups;
            Application.Run(gui);

        }

    }
}
