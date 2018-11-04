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
            this.panel3 = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ldapStatus = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // domainLabel
            // 
            this.domainLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.domainLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.domainLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.domainLabel.Location = new System.Drawing.Point(12, 19);
            this.domainLabel.Name = "domainLabel";
            this.domainLabel.Size = new System.Drawing.Size(84, 40);
            this.domainLabel.TabIndex = 0;
            this.domainLabel.Text = "Domain";
            this.domainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // domainTField
            // 
            this.domainTField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.domainTField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.domainTField.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.domainTField.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.domainTField.Location = new System.Drawing.Point(16, 52);
            this.domainTField.Name = "domainTField";
            this.domainTField.Size = new System.Drawing.Size(162, 24);
            this.domainTField.TabIndex = 1;
            this.domainTField.KeyDown += new System.Windows.Forms.KeyEventHandler(this.domainTField_KeyDown);
            // 
            // dValue
            // 
            this.dValue.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dValue.ForeColor = System.Drawing.Color.Red;
            this.dValue.Location = new System.Drawing.Point(178, 52);
            this.dValue.Name = "dValue";
            this.dValue.Size = new System.Drawing.Size(21, 24);
            this.dValue.TabIndex = 2;
            this.dValue.Text = "*";
            this.dValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dValue.Visible = false;
            // 
            // displayOus
            // 
            this.displayOus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.displayOus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.displayOus.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayOus.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.displayOus.Location = new System.Drawing.Point(13, 179);
            this.displayOus.Name = "displayOus";
            this.displayOus.ReadOnly = true;
            this.displayOus.Size = new System.Drawing.Size(355, 203);
            this.displayOus.TabIndex = 4;
            this.displayOus.Text = "";
            // 
            // userSearch
            // 
            this.userSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(90)))), ((int)(((byte)(25)))));
            this.userSearch.FlatAppearance.BorderSize = 0;
            this.userSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userSearch.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userSearch.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.userSearch.Location = new System.Drawing.Point(184, 103);
            this.userSearch.Name = "userSearch";
            this.userSearch.Size = new System.Drawing.Size(107, 50);
            this.userSearch.TabIndex = 3;
            this.userSearch.Text = "Search User";
            this.userSearch.UseVisualStyleBackColor = false;
            this.userSearch.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // userTField
            // 
            this.userTField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.userTField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userTField.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTField.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.userTField.Location = new System.Drawing.Point(16, 117);
            this.userTField.Name = "userTField";
            this.userTField.Size = new System.Drawing.Size(162, 24);
            this.userTField.TabIndex = 2;
            // 
            // userLabel
            // 
            this.userLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.userLabel.Location = new System.Drawing.Point(12, 79);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(84, 41);
            this.userLabel.TabIndex = 0;
            this.userLabel.Text = "User ";
            this.userLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panel3.Controls.Add(this.ldapStatus);
            this.panel3.Controls.Add(this.userSearch);
            this.panel3.Controls.Add(this.displayOus);
            this.panel3.Controls.Add(this.userTField);
            this.panel3.Controls.Add(this.dValue);
            this.panel3.Controls.Add(this.userLabel);
            this.panel3.Controls.Add(this.domainTField);
            this.panel3.Controls.Add(this.domainLabel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(381, 398);
            this.panel3.TabIndex = 4;
            // 
            // ldapStatus
            // 
            this.ldapStatus.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ldapStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ldapStatus.Location = new System.Drawing.Point(317, 0);
            this.ldapStatus.Name = "ldapStatus";
            this.ldapStatus.Size = new System.Drawing.Size(64, 33);
            this.ldapStatus.TabIndex = 5;
            this.ldapStatus.Text = "LDAP";
            this.ldapStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 395);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "UIForm";
            this.Text = "Form1";
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
        private Panel panel3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label ldapStatus;
    }
}

