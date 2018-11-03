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
            this.domainLabel = new System.Windows.Forms.Label();
            this.domainTField = new System.Windows.Forms.TextBox();
            this.dValue = new System.Windows.Forms.Label();
            this.displayOus = new System.Windows.Forms.RichTextBox();
            this.userSearch = new System.Windows.Forms.Button();
            this.userTField = new System.Windows.Forms.TextBox();
            this.userLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.AccountsButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // domainLabel
            // 
            this.domainLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.domainLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.domainLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.domainLabel.Location = new System.Drawing.Point(9, 19);
            this.domainLabel.Name = "domainLabel";
            this.domainLabel.Size = new System.Drawing.Size(122, 40);
            this.domainLabel.TabIndex = 0;
            this.domainLabel.Text = "Enter Domain:";
            this.domainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // domainTField
            // 
            this.domainTField.BackColor = System.Drawing.Color.Gainsboro;
            this.domainTField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.domainTField.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.domainTField.Location = new System.Drawing.Point(137, 28);
            this.domainTField.Name = "domainTField";
            this.domainTField.Size = new System.Drawing.Size(162, 24);
            this.domainTField.TabIndex = 1;
            this.domainTField.KeyDown += new System.Windows.Forms.KeyEventHandler(this.domainTField_KeyDown);
            // 
            // dValue
            // 
            this.dValue.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dValue.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.dValue.Location = new System.Drawing.Point(9, 168);
            this.dValue.Name = "dValue";
            this.dValue.Size = new System.Drawing.Size(199, 73);
            this.dValue.TabIndex = 2;
            this.dValue.Text = "Domain Name";
            this.dValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // displayOus
            // 
            this.displayOus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.displayOus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.displayOus.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayOus.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.displayOus.Location = new System.Drawing.Point(187, 284);
            this.displayOus.Name = "displayOus";
            this.displayOus.ReadOnly = true;
            this.displayOus.Size = new System.Drawing.Size(554, 205);
            this.displayOus.TabIndex = 1;
            this.displayOus.Text = "";
            // 
            // userSearch
            // 
            this.userSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(90)))), ((int)(((byte)(25)))));
            this.userSearch.FlatAppearance.BorderSize = 0;
            this.userSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userSearch.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userSearch.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.userSearch.Location = new System.Drawing.Point(192, 115);
            this.userSearch.Name = "userSearch";
            this.userSearch.Size = new System.Drawing.Size(107, 50);
            this.userSearch.TabIndex = 2;
            this.userSearch.Text = "Search User";
            this.userSearch.UseVisualStyleBackColor = false;
            this.userSearch.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // userTField
            // 
            this.userTField.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTField.Location = new System.Drawing.Point(137, 67);
            this.userTField.Name = "userTField";
            this.userTField.Size = new System.Drawing.Size(162, 24);
            this.userTField.TabIndex = 1;
            // 
            // userLabel
            // 
            this.userLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.userLabel.Location = new System.Drawing.Point(9, 59);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(119, 41);
            this.userLabel.TabIndex = 0;
            this.userLabel.Text = "Enter User :";
            this.userLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.AccountsButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(187, 489);
            this.panel2.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel4.Location = new System.Drawing.Point(3, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 54);
            this.panel4.TabIndex = 5;
            // 
            // AccountsButton
            // 
            this.AccountsButton.FlatAppearance.BorderSize = 0;
            this.AccountsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.AccountsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AccountsButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountsButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.AccountsButton.Location = new System.Drawing.Point(16, 12);
            this.AccountsButton.Name = "AccountsButton";
            this.AccountsButton.Size = new System.Drawing.Size(169, 54);
            this.AccountsButton.TabIndex = 0;
            this.AccountsButton.Text = "Accounts";
            this.AccountsButton.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panel3.Controls.Add(this.userSearch);
            this.panel3.Controls.Add(this.userTField);
            this.panel3.Controls.Add(this.dValue);
            this.panel3.Controls.Add(this.userLabel);
            this.panel3.Controls.Add(this.domainTField);
            this.panel3.Controls.Add(this.domainLabel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(187, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(554, 286);
            this.panel3.TabIndex = 4;
            // 
            // UIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 489);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.displayOus);
            this.Name = "UIForm";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label domainLabel;
        private System.Windows.Forms.TextBox domainTField;
        private Label dValue;
        private RichTextBox displayOus;
        private Label userLabel;
        private TextBox userTField;
        private Button userSearch;
        private Panel panel2;
        private Panel panel4;
        private Button AccountsButton;
        private Panel panel3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

