using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scavenger
{   
    //Implement Interface IUIForm
    public partial class UIForm : Form, IUIForm
    {   //Create Delegate for Event Handler
        public delegate void SubmitButtonClickedEventHandler(object source, EventArgs args);
        public delegate void SearchButtonClickedEventHandler(object source, EventArgs args);
        //Create Event
        public event SubmitButtonClickedEventHandler TButtonClicked;
        public event SearchButtonClickedEventHandler SearchButtonClicked;

        public UIForm()
        {
            InitializeComponent();
        }

        //Handles Submit button clicked
        private void TButton_Click(object sender, EventArgs e)
        {
            //domainName = domainTField.Text;
            dValue.Text = "You entered:" + domainField;
            
            OnTButtonClicked();
            
        }
      
        //Submits text when enter is detected on text box
        private void domainTField_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                //domainName = domainTField.Text;
                dValue.Text = "You entered:" + domainField;

                //e.Handled = true;
                e.SuppressKeyPress = true;
            }
            
        }

        //Notifies subscribers that Submit button was clicked
        protected virtual void OnTButtonClicked()
        {
            //Fire the event - notifying all subscribers
            if (TButtonClicked != null)
                TButtonClicked(this, null);
        }

   
        private void SearchButton_Click(object sender, EventArgs e)
        {
            OnSearchButtonClicked();
        }

        protected virtual void OnSearchButtonClicked()
        {
            if(SearchButtonClicked != null)
            {
                SearchButtonClicked(this, null);
                SearchButtonClicked(this, null);
            }
        }


        //Sets/Gets the large text box
        public string OUTextBox
        {
            get { return displayOus.Text; }
            set { displayOus.Text = value; }
        }

        //Sets/Gets the domain field text box
        public string domainField
        {
            get { return domainTField.Text; }
            set { domainTField.Text = value; }
        }

        public string userField
        {
            get { return userTField.Text; }
            set { userTField.Text = value; }

        }
    }
}
