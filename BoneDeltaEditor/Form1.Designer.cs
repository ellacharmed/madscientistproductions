﻿namespace BoneDeltaEditor
{
    partial class Form1
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectedBoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allBonesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectedBoneToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.allBonesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rCOLHeaderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaxZ = new System.Windows.Forms.TextBox();
            this.txtMaxY = new System.Windows.Forms.TextBox();
            this.txtMaxX = new System.Windows.Forms.TextBox();
            this.txtMinZ = new System.Windows.Forms.TextBox();
            this.txtMinY = new System.Windows.Forms.TextBox();
            this.txtMinX = new System.Windows.Forms.TextBox();
            this.txtQuatZ = new System.Windows.Forms.TextBox();
            this.txtQuatY = new System.Windows.Forms.TextBox();
            this.txtQuatX = new System.Windows.Forms.TextBox();
            this.txtQuatW = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnEntryCopy = new System.Windows.Forms.Button();
            this.txtBoneHash = new System.Windows.Forms.TextBox();
            this.btnEntryCommit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lstEntries = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 245);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(777, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 51;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(762, 17);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Menu;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(777, 24);
            this.menuStrip1.TabIndex = 50;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.importToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.toolStripMenuItem2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Enabled = false;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(122, 6);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectedBoneToolStripMenuItem,
            this.allBonesToolStripMenuItem});
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.importToolStripMenuItem.Text = "Import";
            // 
            // selectedBoneToolStripMenuItem
            // 
            this.selectedBoneToolStripMenuItem.Name = "selectedBoneToolStripMenuItem";
            this.selectedBoneToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.selectedBoneToolStripMenuItem.Text = "Selected Bone";
            this.selectedBoneToolStripMenuItem.Click += new System.EventHandler(this.selectedBoneToolStripMenuItem_Click);
            // 
            // allBonesToolStripMenuItem
            // 
            this.allBonesToolStripMenuItem.Name = "allBonesToolStripMenuItem";
            this.allBonesToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.allBonesToolStripMenuItem.Text = "All Bones";
            this.allBonesToolStripMenuItem.Click += new System.EventHandler(this.allBonesToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectedBoneToolStripMenuItem1,
            this.allBonesToolStripMenuItem1});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // selectedBoneToolStripMenuItem1
            // 
            this.selectedBoneToolStripMenuItem1.Name = "selectedBoneToolStripMenuItem1";
            this.selectedBoneToolStripMenuItem1.Size = new System.Drawing.Size(142, 22);
            this.selectedBoneToolStripMenuItem1.Text = "Selected Bone";
            this.selectedBoneToolStripMenuItem1.Click += new System.EventHandler(this.selectedBoneToolStripMenuItem1_Click);
            // 
            // allBonesToolStripMenuItem1
            // 
            this.allBonesToolStripMenuItem1.Name = "allBonesToolStripMenuItem1";
            this.allBonesToolStripMenuItem1.Size = new System.Drawing.Size(142, 22);
            this.allBonesToolStripMenuItem1.Text = "All Bones";
            this.allBonesToolStripMenuItem1.Click += new System.EventHandler(this.allBonesToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(122, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rCOLHeaderToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // rCOLHeaderToolStripMenuItem
            // 
            this.rCOLHeaderToolStripMenuItem.Name = "rCOLHeaderToolStripMenuItem";
            this.rCOLHeaderToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.rCOLHeaderToolStripMenuItem.Text = "RCOL Header";
            this.rCOLHeaderToolStripMenuItem.Click += new System.EventHandler(this.rCOLHeaderToolStripMenuItem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(262, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 62;
            this.label5.Text = "Z:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 61;
            this.label2.Text = "Y:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 60;
            this.label3.Text = "X:";
            // 
            // txtMaxZ
            // 
            this.txtMaxZ.Location = new System.Drawing.Point(236, 62);
            this.txtMaxZ.Name = "txtMaxZ";
            this.txtMaxZ.Size = new System.Drawing.Size(75, 20);
            this.txtMaxZ.TabIndex = 59;
            this.txtMaxZ.Text = "0";
            // 
            // txtMaxY
            // 
            this.txtMaxY.Location = new System.Drawing.Point(155, 62);
            this.txtMaxY.Name = "txtMaxY";
            this.txtMaxY.Size = new System.Drawing.Size(75, 20);
            this.txtMaxY.TabIndex = 58;
            this.txtMaxY.Text = "0";
            // 
            // txtMaxX
            // 
            this.txtMaxX.Location = new System.Drawing.Point(73, 62);
            this.txtMaxX.Name = "txtMaxX";
            this.txtMaxX.Size = new System.Drawing.Size(76, 20);
            this.txtMaxX.TabIndex = 57;
            this.txtMaxX.Text = "0";
            // 
            // txtMinZ
            // 
            this.txtMinZ.Location = new System.Drawing.Point(236, 36);
            this.txtMinZ.Name = "txtMinZ";
            this.txtMinZ.Size = new System.Drawing.Size(75, 20);
            this.txtMinZ.TabIndex = 56;
            this.txtMinZ.Text = "0";
            // 
            // txtMinY
            // 
            this.txtMinY.Location = new System.Drawing.Point(155, 36);
            this.txtMinY.Name = "txtMinY";
            this.txtMinY.Size = new System.Drawing.Size(75, 20);
            this.txtMinY.TabIndex = 55;
            this.txtMinY.Text = "0";
            // 
            // txtMinX
            // 
            this.txtMinX.Location = new System.Drawing.Point(73, 36);
            this.txtMinX.Name = "txtMinX";
            this.txtMinX.Size = new System.Drawing.Size(76, 20);
            this.txtMinX.TabIndex = 54;
            this.txtMinX.Text = "0";
            // 
            // txtQuatZ
            // 
            this.txtQuatZ.Location = new System.Drawing.Point(236, 88);
            this.txtQuatZ.Name = "txtQuatZ";
            this.txtQuatZ.Size = new System.Drawing.Size(75, 20);
            this.txtQuatZ.TabIndex = 65;
            this.txtQuatZ.Text = "0";
            // 
            // txtQuatY
            // 
            this.txtQuatY.Location = new System.Drawing.Point(155, 88);
            this.txtQuatY.Name = "txtQuatY";
            this.txtQuatY.Size = new System.Drawing.Size(75, 20);
            this.txtQuatY.TabIndex = 64;
            this.txtQuatY.Text = "0";
            // 
            // txtQuatX
            // 
            this.txtQuatX.Location = new System.Drawing.Point(74, 88);
            this.txtQuatX.Name = "txtQuatX";
            this.txtQuatX.Size = new System.Drawing.Size(75, 20);
            this.txtQuatX.TabIndex = 63;
            this.txtQuatX.Text = "0";
            // 
            // txtQuatW
            // 
            this.txtQuatW.Location = new System.Drawing.Point(317, 88);
            this.txtQuatW.Name = "txtQuatW";
            this.txtQuatW.Size = new System.Drawing.Size(75, 20);
            this.txtQuatW.TabIndex = 66;
            this.txtQuatW.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(348, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 67;
            this.label4.Text = "W:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 68;
            this.label6.Text = "Offset:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 69;
            this.label7.Text = "Scale:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 70;
            this.label8.Text = "Quaternion:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.btnEntryCopy);
            this.groupBox1.Controls.Add(this.txtBoneHash);
            this.groupBox1.Controls.Add(this.btnEntryCommit);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtMinX);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtMinY);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtMinZ);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtMaxX);
            this.groupBox1.Controls.Add(this.txtQuatW);
            this.groupBox1.Controls.Add(this.txtMaxY);
            this.groupBox1.Controls.Add(this.txtQuatZ);
            this.groupBox1.Controls.Add(this.txtMaxZ);
            this.groupBox1.Controls.Add(this.txtQuatY);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtQuatX);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(219, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(558, 211);
            this.groupBox1.TabIndex = 71;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entry details:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 78;
            this.label1.Text = "Bone Hash:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(398, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(147, 186);
            this.listBox1.TabIndex = 77;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(201, 181);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 77;
            this.button4.Text = "Invert 1/x";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(120, 181);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 76;
            this.button3.Text = "Invert";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnEntryCopy
            // 
            this.btnEntryCopy.Location = new System.Drawing.Point(8, 181);
            this.btnEntryCopy.Name = "btnEntryCopy";
            this.btnEntryCopy.Size = new System.Drawing.Size(105, 23);
            this.btnEntryCopy.TabIndex = 75;
            this.btnEntryCopy.Text = "Copy to all bones";
            this.btnEntryCopy.UseVisualStyleBackColor = true;
            this.btnEntryCopy.Click += new System.EventHandler(this.btnEntryCopy_Click);
            // 
            // txtBoneHash
            // 
            this.txtBoneHash.Location = new System.Drawing.Point(73, 114);
            this.txtBoneHash.Name = "txtBoneHash";
            this.txtBoneHash.Size = new System.Drawing.Size(93, 20);
            this.txtBoneHash.TabIndex = 73;
            this.txtBoneHash.TextChanged += new System.EventHandler(this.txtBoneHash_TextChanged);
            // 
            // btnEntryCommit
            // 
            this.btnEntryCommit.Location = new System.Drawing.Point(317, 181);
            this.btnEntryCommit.Name = "btnEntryCommit";
            this.btnEntryCommit.Size = new System.Drawing.Size(75, 23);
            this.btnEntryCommit.TabIndex = 71;
            this.btnEntryCommit.Text = "Commit";
            this.btnEntryCommit.UseVisualStyleBackColor = true;
            this.btnEntryCommit.Click += new System.EventHandler(this.btnEntryCommit_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(136, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 74;
            this.button1.Text = "Add Entry";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(12, 212);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 75;
            this.button2.Text = "Delete Entry";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lstEntries
            // 
            this.lstEntries.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lstEntries.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lstEntries.FullRowSelect = true;
            this.lstEntries.GridLines = true;
            this.lstEntries.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstEntries.HideSelection = false;
            this.lstEntries.Location = new System.Drawing.Point(12, 31);
            this.lstEntries.MultiSelect = false;
            this.lstEntries.Name = "lstEntries";
            this.lstEntries.ShowGroups = false;
            this.lstEntries.Size = new System.Drawing.Size(199, 175);
            this.lstEntries.TabIndex = 76;
            this.lstEntries.UseCompatibleStateImageBehavior = false;
            this.lstEntries.View = System.Windows.Forms.View.Details;
            this.lstEntries.SelectedIndexChanged += new System.EventHandler(this.lstEntries_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "#";
            this.columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Bone";
            this.columnHeader2.Width = 130;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 267);
            this.Controls.Add(this.lstEntries);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Bone Delta (Slot) Editor v0.4 by Delphy";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rCOLHeaderToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaxZ;
        private System.Windows.Forms.TextBox txtMaxY;
        private System.Windows.Forms.TextBox txtMaxX;
        private System.Windows.Forms.TextBox txtMinZ;
        private System.Windows.Forms.TextBox txtMinY;
        private System.Windows.Forms.TextBox txtMinX;
        private System.Windows.Forms.TextBox txtQuatZ;
        private System.Windows.Forms.TextBox txtQuatY;
        private System.Windows.Forms.TextBox txtQuatX;
        private System.Windows.Forms.TextBox txtQuatW;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEntryCommit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtBoneHash;
        private System.Windows.Forms.ListView lstEntries;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnEntryCopy;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectedBoneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allBonesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectedBoneToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem allBonesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
    }
}

