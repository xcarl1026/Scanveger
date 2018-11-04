using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.DirectoryServices;
using System.Security;
using System.Runtime.InteropServices;
using System.DirectoryServices.Protocols;
using System.Windows.Forms;

namespace Scavenger
{
    public class Directory
    {   
        //Declare IUIForm to use interface
        private readonly IUIForm form;
        //private List<string> lOrgUnits;

        public Directory(IUIForm form)
        {
            this.form = form;           
        }

        public void DisplayUserResult(object sender, EventArgs e)
        {
            form.OUTextBox = null;
            if (IsLdapOk() != false)
            {
                SearchResult result = GetUser();
                if (result != null)
                {                  
                    DirectoryEntry user = result.GetDirectoryEntry();                  
                    form.OUTextBox = "Username: " + user.Properties["samaccountname"].Value.ToString() + Environment.NewLine;
                    form.OUTextBox += "Display Name: " + user.Properties["displayname"].Value.ToString();
                    for (int counter = 0; counter < user.Properties["memberof"].Count; counter++)
                    {
                        form.OUTextBox += Environment.NewLine + user.Properties["memberof"][counter].ToString()/*.Split(',')*/;

                    }
                }
                else
                {

                    Form quickDialoge = new QuickDialogue();
                    quickDialoge.StartPosition = FormStartPosition.CenterScreen;
                    quickDialoge.Show();
                }
                
            }
            /**ResultPropertyCollection fields = result.Properties;
            form.OUTextBox = user.Properties["sn"].Value.ToString();
            foreach(string propField in fields.PropertyNames)
            {
                foreach(Object name in fields[propField])
                {
                    form.OUTextBox = propField + " : " + name + Environment.NewLine + form.OUTextBox;
                }
            }*/
        }


        /** public void CallGetOrgsUnits(object sender, EventArgs e)
         {
             if(IsLdapOk() == true)
             {
                 lOrgUnits = GetOrgUnits();
                 form.OUTextBox = String.Join(Environment.NewLine, lOrgUnits);
             }
             //lOrgUnits = getOrgUnits();
             //form.OUTextBox = String.Join(Environment.NewLine, lOrgUnits);

         }*/

        // This function requires Imports System.Net and Imports System.DirectoryServices.Protocols
        bool IsLdapOk()
        {
            string ldapServer = form.domainField;
            bool ldapOK = false;
            if (string.IsNullOrEmpty(ldapServer) == false)
            {
                LdapConnection ldapConnection = new LdapConnection(new LdapDirectoryIdentifier(ldapServer));
                TimeSpan mytimeout = new TimeSpan(0, 0, 3);
                try
                {
                    /**ldapConnection.AuthType = AuthType.Negotiate;
                    ldapConnection.AutoBind = false;*/
                    ldapConnection.Timeout = mytimeout;
                    ldapConnection.Bind();
                    form.ldapLabel.ForeColor = System.Drawing.Color.FromArgb(40, 135, 25);
                    ldapOK = true;
                    ldapConnection.Dispose();
                }
                catch (LdapException e)
                {
                    form.ldapLabel.ForeColor = System.Drawing.Color.FromArgb(179, 0, 0);
                    ldapOK = false;
                }
            }
            return ldapOK;
        }


        private DirectoryEntry GetLdapConnection()
        {
            DirectoryEntry ldapConnection = null;
            ldapConnection = new DirectoryEntry("LDAP://" + form.domainField);

            return ldapConnection;

         }

       /** private List<string> GetOrgUnits()
        {
            List<string> orgUnits = new List<string>();
            DirectoryEntry ldapConnection = GetLdapConnection();
            DirectorySearcher searcher = new DirectorySearcher(ldapConnection);
            searcher.Filter = "(objectCategory=organizationalUnit)";
            foreach (SearchResult res in searcher.FindAll())
            {
                orgUnits.Add(res.Path);
            }

            searcher.Dispose();
            ldapConnection.Dispose();
            return orgUnits;
        }*/

        private SearchResult GetUser()
        {
            DirectoryEntry ldapConnection = GetLdapConnection();
            DirectorySearcher searcher = new DirectorySearcher(ldapConnection);
            searcher.PropertiesToLoad.Add("displayname");
            searcher.PropertiesToLoad.Add("sammaccountname");
            searcher.PropertiesToLoad.Add("sn");
            searcher.PropertiesToLoad.Add("memberof");
            searcher.Filter = "(|(cn=" + form.userField + ")(samaccountname=" + form.userField + ")(displayname=" + form.userField + ")(sn=" + form.userField + "))";
            SearchResult result;

            try
            {
                result = searcher.FindOne();
            }
            catch(Exception e)
            {
                result = null;
            }
            searcher.Dispose();
            
            ldapConnection.Dispose(); 
            return result;
        }

    }
}   




