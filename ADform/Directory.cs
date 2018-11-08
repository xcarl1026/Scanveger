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
using System.IO;

namespace Scavenger
{
    public class Directory
    {   
        private readonly IUIForm form;
        public Directory(IUIForm form)
        {
            
            this.form = form;           
        }

        public void DisplayUserResult(object sender, EventArgs e)
        {
            form.OUTextBox = ProcesUserGroups();
        }

        private string ProcesUserGroups()
        {
            string secGroupList = String.Empty;
            var builder = new StringBuilder();
            if (IsLdapOk() != false)
            {
                SearchResult result = GetUser();
                if (result != null)
                {
                    DirectoryEntry user = result.GetDirectoryEntry();
  
                    builder.Append("Username: ");
                    builder.Append(user.Properties["samaccountname"].Value.ToString());
                    builder.Append(Environment.NewLine);
                    builder.Append("Display Name: ");
                    builder.Append(user.Properties["displayname"].Value.ToString());
                    builder.Append(Environment.NewLine);

                    for (int counter = 0; counter < user.Properties["memberof"].Count; counter++)
                    {
                        string[] groups = user.Properties["memberof"][counter].ToString().Split(',');
                        builder.Append(groups[0]);
                        builder.Append(Environment.NewLine);
                    }
                    secGroupList = builder.ToString();
                }
            }
            return secGroupList;
        }

        public void SaveUserSecGroups(object source, EventArgs e)
        {
          string secGroupList = ProcesUserGroups();
          SaveFileDialog saveDialog = form.saveDialog;
          if (saveDialog.ShowDialog() == DialogResult.OK)
          {
             using (Stream s = File.Open(saveDialog.FileName, FileMode.Append))
             using (StreamWriter sw = new StreamWriter(s))
             {
                   sw.Write(secGroupList);
             }
          }
        }

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
            if(result == null)
            {
                Form quickDialoge = new QuickDialogue();
                quickDialoge.StartPosition = FormStartPosition.CenterScreen;
                quickDialoge.Show();
            }

            searcher.Dispose();
            ldapConnection.Dispose(); 
            return result;
        }

    }
}   




