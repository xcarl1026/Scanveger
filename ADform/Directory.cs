using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.DirectoryServices;
using System.Security;
using System.Runtime.InteropServices;
using System.DirectoryServices.Protocols;

namespace Scavenger
{
    public class Directory
    {   
        //Declare IUIForm to use interface
        private readonly IUIForm form;
        private List<string> lOrgUnits;

        public Directory(IUIForm form)
        {
            this.form = form;           
        }

        public void DisplayUserResult(object sender, EventArgs e)
        {
            //form.OUTextBox = null;
            SearchResult result = GetUser();
            //ResultPropertyCollection fields = result.Properties;
            DirectoryEntry user = result.GetDirectoryEntry();
            //form.OUTextBox = user.Properties["sn"].Value.ToString();
            form.OUTextBox += user.Properties["samaccountname"].Value.ToString();
            for (int counter = 0; counter < user.Properties["memberof"].Count; counter++)
            {
                form.OUTextBox += Environment.NewLine + user.Properties["memberof"][counter].ToString()/*.Split(',')*/; //+ Environment.NewLine + form.OUTextBox;

            }

            /* foreach(string propField in fields.PropertyNames)
            {
                foreach(Object name in fields[propField])
                {
                    form.OUTextBox = propField + " : " + name + Environment.NewLine + form.OUTextBox;
                }
            }*/
        }
        public void CallGetOrgsUnits(object sender, EventArgs e)
        {
            if(IsLdapOk() == true)
            {
                lOrgUnits = GetOrgUnits();
                form.OUTextBox = String.Join(Environment.NewLine, lOrgUnits);
            }
            //lOrgUnits = getOrgUnits();
            //form.OUTextBox = String.Join(Environment.NewLine, lOrgUnits);

        }

        bool IsLdapOk()
        {
            string ldapServer = form.domainField;
            // This function requires Imports System.Net and Imports System.DirectoryServices.Protocols
            LdapConnection ldapConnection = new LdapConnection(new LdapDirectoryIdentifier(ldapServer));
            //Specify LDAP timeout
            TimeSpan mytimeout = new TimeSpan(0, 0, 1);
            bool ldapOK = false;
            try
            {
                //ldapConnection.AuthType = AuthType.Negotiate;
                //ldapConnection.AutoBind = false;
                ldapConnection.Timeout = mytimeout;
                ldapConnection.Bind();
                form.OUTextBox = "Successfully authenticated to LDAP server " + ldapServer;
                ldapOK = true;
                ldapConnection.Dispose();
            }
            catch (LdapException e)
            {
                form.OUTextBox = "Looks like I couldn't reach the LDAP server: " + ldapServer + "\n" + e.Message;
                ldapOK = false;
            }
            return ldapOK;
        }


        private DirectoryEntry GetLdapConnection()
        {
            DirectoryEntry ldapConnection = null;
            ldapConnection = new DirectoryEntry("LDAP://" + form.domainField);
            return ldapConnection;

         }

        private List<string> GetOrgUnits()
        {
            //Declare List 
            List<string> orgUnits = new List<string>();
            //Declare starting path
            DirectoryEntry ldapConnection = GetLdapConnection();
            //Search for all organizational units
            DirectorySearcher searcher = new DirectorySearcher(ldapConnection);
            searcher.Filter = "(objectCategory=organizationalUnit)";
            //Add each organizational path to the list
            foreach (SearchResult res in searcher.FindAll())
            {
                orgUnits.Add(res.Path);
            }
            searcher.Dispose();
            ldapConnection.Dispose();
            return orgUnits;
        }

        private SearchResult GetUser()
        {
            DirectoryEntry ldapConnection = GetLdapConnection();
            DirectorySearcher searcher = new DirectorySearcher(ldapConnection);
            searcher.PropertiesToLoad.Add("sammaccountname");
            searcher.PropertiesToLoad.Add("sn");
            searcher.PropertiesToLoad.Add("memberof");

            searcher.Filter = "(|(cn=" + form.userField + ")(samaccountname=" + form.userField + "))";
            SearchResult result = searcher.FindOne();
            searcher.Dispose();
            ldapConnection.Dispose(); 
            return result;
        }

    }
}   




