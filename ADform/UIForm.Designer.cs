using System;
using System.Drawing;
using System.Windows.Forms;

namespace Scavenger
{

    partial class UIForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TButton = new System.Windows.Forms.Button();
            this.domainLabel = new System.Windows.Forms.Label();
            this.domainTField = new System.Windows.Forms.TextBox();
            this.dValue = new System.Windows.Forms.Label();
            this.displayOus = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.userLabel = new System.Windows.Forms.Label();
            this.userTField = new System.Windows.Forms.TextBox();
            this.userSearch = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.54546F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.45454F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.tableLayoutPanel1.Controls.Add(this.TButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.domainLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.domainTField, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dValue, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 35);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(373, 79);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // TButton
            // 
            this.TButton.Location = new System.Drawing.Point(276, 3);
            this.TButton.Name = "TButton";
            this.TButton.Size = new System.Drawing.Size(75, 23);
            this.TButton.TabIndex = 1;
            this.TButton.Text = "Submit";
            this.TButton.UseVisualStyleBackColor = true;
            this.TButton.Click += new System.EventHandler(this.TButton_Click);
            // 
            // domainLabel
            // 
            this.domainLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.domainLabel.Location = new System.Drawing.Point(3, 0);
            this.domainLabel.Name = "domainLabel";
            this.domainLabel.Size = new System.Drawing.Size(82, 23);
            this.domainLabel.TabIndex = 0;
            this.domainLabel.Text = "Enter Domain:";
            this.domainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // domainTField
            // 
            this.domainTField.Location = new System.Drawing.Point(111, 3);
            this.domainTField.Name = "domainTField";
            this.domainTField.Size = new System.Drawing.Size(153, 20);
            this.domainTField.TabIndex = 1;
            this.domainTField.KeyDown += new System.Windows.Forms.KeyEventHandler(this.domainTField_KeyDown);
            // 
            // dValue
            // 
            this.dValue.Location = new System.Drawing.Point(111, 39);
            this.dValue.Name = "dValue";
            this.dValue.Size = new System.Drawing.Size(153, 23);
            this.dValue.TabIndex = 2;
            this.dValue.Text = "Domain Name";
            this.dValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // displayOus
            // 
            this.displayOus.Location = new System.Drawing.Point(405, 35);
            this.displayOus.Name = "displayOus";
            this.displayOus.Size = new System.Drawing.Size(349, 325);
            this.displayOus.TabIndex = 1;
            this.displayOus.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.userSearch);
            this.panel1.Controls.Add(this.userTField);
            this.panel1.Controls.Add(this.userLabel);
            this.panel1.Location = new System.Drawing.Point(57, 195);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 154);
            this.panel1.TabIndex = 2;
            // 
            // userLabel
            // 
            this.userLabel.Location = new System.Drawing.Point(24, 31);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(67, 25);
            this.userLabel.TabIndex = 0;
            this.userLabel.Text = "User ";
            // 
            // userTField
            // 
            this.userTField.Location = new System.Drawing.Point(97, 31);
            this.userTField.Name = "userTField";
            this.userTField.Size = new System.Drawing.Size(106, 20);
            this.userTField.TabIndex = 1;
            // 
            // userSearch
            // 
            this.userSearch.Location = new System.Drawing.Point(148, 97);
            this.userSearch.Name = "userSearch";
            this.userSearch.Size = new System.Drawing.Size(75, 23);
            this.userSearch.TabIndex = 2;
            this.userSearch.Text = "Search User";
            this.userSearch.UseVisualStyleBackColor = true;
            this.userSearch.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // UIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.displayOus);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UIForm";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label domainLabel;
        private System.Windows.Forms.TextBox domainTField;
        private Button TButton;
        private Label dValue;
        private RichTextBox displayOus;
        private Panel panel1;
        private Label userLabel;
        private TextBox userTField;
        private Button userSearch;
    }
}

