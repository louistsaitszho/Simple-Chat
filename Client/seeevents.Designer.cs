﻿namespace ClientSide
{
    partial class seeevents
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
            this.cbOrganizers = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOrganizer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPlace = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.r5button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbOrganizers
            // 
            this.cbOrganizers.FormattingEnabled = true;
            this.cbOrganizers.Location = new System.Drawing.Point(15, 25);
            this.cbOrganizers.Name = "cbOrganizers";
            this.cbOrganizers.Size = new System.Drawing.Size(149, 21);
            this.cbOrganizers.TabIndex = 0;
            this.cbOrganizers.SelectedIndexChanged += new System.EventHandler(this.cbOrganizers_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Organizer:";
            // 
            // txtOrganizer
            // 
            this.txtOrganizer.Location = new System.Drawing.Point(15, 182);
            this.txtOrganizer.Name = "txtOrganizer";
            this.txtOrganizer.Size = new System.Drawing.Size(211, 20);
            this.txtOrganizer.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Place";
            // 
            // txtPlace
            // 
            this.txtPlace.Location = new System.Drawing.Point(15, 104);
            this.txtPlace.Name = "txtPlace";
            this.txtPlace.Size = new System.Drawing.Size(211, 20);
            this.txtPlace.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Description:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(15, 143);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(211, 20);
            this.txtDescription.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(12, 247);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 51);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Attending";
            
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(125, 19);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(39, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "No";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(39, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(43, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Yes";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(232, 9);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(144, 251);
            this.listBox1.TabIndex = 14;
            
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Title";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(15, 65);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(211, 20);
            this.txtTitle.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Date:";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(15, 221);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(211, 20);
            this.txtDate.TabIndex = 17;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(232, 266);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(144, 32);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Select an event";
            // 
            // r5button
            // 
            this.r5button.Location = new System.Drawing.Point(170, 25);
            this.r5button.Name = "r5button";
            this.r5button.Size = new System.Drawing.Size(56, 21);
            this.r5button.TabIndex = 21;
            this.r5button.Text = "Refresh";
            this.r5button.UseVisualStyleBackColor = true;
            this.r5button.Click += new System.EventHandler(this.r5button_Click);
            // 
            // seeevents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 310);
            this.Controls.Add(this.r5button);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOrganizer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPlace);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.cbOrganizers);
            this.MaximumSize = new System.Drawing.Size(404, 349);
            this.MinimumSize = new System.Drawing.Size(404, 349);
            this.Name = "seeevents";
            this.Text = "EVENTS";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbOrganizers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOrganizer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPlace;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button r5button;
    }
}