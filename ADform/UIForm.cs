using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scavenger
{   
    //Implement Interface IUIForm
    public partial class UIForm : Form, IUIForm
    {   //Create Delegate for Event Handler
        //public delegate void SubmitButtonClickedEventHandler(object source, EventArgs args);
        public delegate void SearchButtonClickedEventHandler(object source, EventArgs args);
        //Create Event
        //public event SubmitButtonClickedEventHandler TButtonClicked;
        public event SearchButtonClickedEventHandler SearchButtonClicked;
        private bool mouseDown;
        private Point lastLocation;

        public UIForm()
        {
            InitializeComponent();
            menuStrip1.Renderer = new MyRenderer();
        }

        /**Handles Submit button clicked
        private void TButton_Click(object sender, EventArgs e)
        {
            //domainName = domainTField.Text;
            //dValue.Text = "You entered:" + domainField;
            
            OnTButtonClicked();
            
        }*/
        /** protected virtual void OnTButtonClicked()
         {
             //Fire the event - notifying all subscribers
             if (TButtonClicked != null)
                 TButtonClicked(this, null);
         }*/

        //Submits text when enter is detected on text box
        private void domainTField_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(domainField) != false)
                {
                    dValue.Show();
                }
                else
                {
                    dValue.Hide();
                    OnSearchButtonClicked();
                }
                e.Handled = true;
                e.SuppressKeyPress = true;
            }

        }

        private void userTField_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(domainField) != false)
                {
                    dValue.Show();
                }
                else
                {
                    dValue.Hide();
                    OnSearchButtonClicked();
                }
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(domainField) != false)
            {
                dValue.Show();
            }
            else
            {
                dValue.Hide();
                OnSearchButtonClicked();
            }

        }

        //Notifies subscribers that Submit button was clicked
        protected virtual void OnSearchButtonClicked()
        {
            if (SearchButtonClicked != null)
            {
                SearchButtonClicked(this, null);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text File (*.txt)|*.txt";
            saveFileDialog1.DefaultExt = ".txt";
            saveFileDialog1.AddExtension = true;
            saveFileDialog1.FileName = "User's groups";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (Stream s = File.Open(saveFileDialog1.FileName, FileMode.Append))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    for (int i = 0; i < displayInfo.Lines.Length; i++)
                    {
                        sw.Write(displayInfo.Lines[i] + Environment.NewLine);
                    }

                }
            }
        }

        //Sets/Gets 
        public string OUTextBox
        {
            get { return displayInfo.Text; }
            set { displayInfo.Text = value; }
        }

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

        public Label ldapLabel
        {
            get { return ldapStatus; }
            set { ldapStatus = value; }
        }

        private class MyRenderer : ToolStripProfessionalRenderer
        {
            public MyRenderer() : base(new MyColors()) { }
        }

        private class MyColors : ProfessionalColorTable
        {
            Color black = Color.FromArgb(25, 25, 25);
            public override Color MenuItemSelected
            {
                get { return black; }
            }
            public override Color MenuItemSelectedGradientBegin
            {
                get { return black; }
            }
            public override Color MenuItemSelectedGradientEnd
            {
                get { return black; }
            }
            public override Color MenuItemPressedGradientBegin
            {
                get { return black; }
            }
            public override Color MenuItemPressedGradientEnd
            {
                get { return black; }
            }
        }

        private void UIForm_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.Control && e.KeyCode == Keys.S)
            {
                saveToolStripMenuItem_Click(sender, e);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void menuStrip1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void menuStrip1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
