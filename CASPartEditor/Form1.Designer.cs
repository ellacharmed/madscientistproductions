﻿namespace CASPartEditor
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.findKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.generateThumbnailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.useAlternativeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.debugModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.label8 = new System.Windows.Forms.Label();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
			this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.tabControl3 = new System.Windows.Forms.TabControl();
			this.tabPage7 = new System.Windows.Forms.TabPage();
			this.groupBox11 = new System.Windows.Forms.GroupBox();
			this.panelMeshThumbs = new System.Windows.Forms.Panel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button1 = new System.Windows.Forms.Button();
			this.btnExtractMeshes = new System.Windows.Forms.Button();
			this.picMeshPreview = new System.Windows.Forms.PictureBox();
			this.btnDumpFromFullbuild2 = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtCasPartInstance = new System.Windows.Forms.TextBox();
			this.txtCasPartName = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.cmbMeshName = new System.Windows.Forms.ComboBox();
			this.cmbSimGender = new System.Windows.Forms.ComboBox();
			this.cmbSimAge = new System.Windows.Forms.ComboBox();
			this.cmbPartTypes = new System.Windows.Forms.ComboBox();
			this.label110 = new System.Windows.Forms.Label();
			this.label70 = new System.Windows.Forms.Label();
			this.tabPage9 = new System.Windows.Forms.TabPage();
			this.btnCasPartDetailsCommit = new System.Windows.Forms.Button();
			this.label87 = new System.Windows.Forms.Label();
			this.lstCasPartDetails = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.tabPage10 = new System.Windows.Forms.TabPage();
			this.checkedListClothingType = new System.Windows.Forms.CheckedListBox();
			this.label109 = new System.Windows.Forms.Label();
			this.btnCategoryDetailsCommit = new System.Windows.Forms.Button();
			this.checkedListCategoryExtended = new System.Windows.Forms.CheckedListBox();
			this.label95 = new System.Windows.Forms.Label();
			this.checkedListCategory = new System.Windows.Forms.CheckedListBox();
			this.checkedListOther = new System.Windows.Forms.CheckedListBox();
			this.label94 = new System.Windows.Forms.Label();
			this.checkedListGender = new System.Windows.Forms.CheckedListBox();
			this.checkedListAge = new System.Windows.Forms.CheckedListBox();
			this.checkedListType = new System.Windows.Forms.CheckedListBox();
			this.label93 = new System.Windows.Forms.Label();
			this.label90 = new System.Windows.Forms.Label();
			this.label89 = new System.Windows.Forms.Label();
			this.label88 = new System.Windows.Forms.Label();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.button13 = new System.Windows.Forms.Button();
			this.lstStencilPool = new System.Windows.Forms.ListView();
			this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
			this.button7 = new System.Windows.Forms.Button();
			this.button12 = new System.Windows.Forms.Button();
			this.tabPage8 = new System.Windows.Forms.TabPage();
			this.btnGetNewXML = new System.Windows.Forms.Button();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.btnDesignStencilCommit = new System.Windows.Forms.Button();
			this.btnPatternStencil6Preview = new System.Windows.Forms.Button();
			this.cmbPatternStencil6 = new System.Windows.Forms.ComboBox();
			this.label106 = new System.Windows.Forms.Label();
			this.btnPatternStencil5Preview = new System.Windows.Forms.Button();
			this.label107 = new System.Windows.Forms.Label();
			this.cmbPatternStencil5 = new System.Windows.Forms.ComboBox();
			this.btnPatternStencil4Preview = new System.Windows.Forms.Button();
			this.cmbPatternStencil4 = new System.Windows.Forms.ComboBox();
			this.label104 = new System.Windows.Forms.Label();
			this.btnPatternStencil3Preview = new System.Windows.Forms.Button();
			this.label105 = new System.Windows.Forms.Label();
			this.cmbPatternStencil3 = new System.Windows.Forms.ComboBox();
			this.btnPatternStencil2Preview = new System.Windows.Forms.Button();
			this.cmbPatternStencil2 = new System.Windows.Forms.ComboBox();
			this.label43 = new System.Windows.Forms.Label();
			this.label58 = new System.Windows.Forms.Label();
			this.btnPatternStencil1Preview = new System.Windows.Forms.Button();
			this.label15 = new System.Windows.Forms.Label();
			this.cmbPatternStencil1 = new System.Windows.Forms.ComboBox();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.cmbPatternSelect = new System.Windows.Forms.ComboBox();
			this.grpPatternA = new System.Windows.Forms.GroupBox();
			this.picPatternThumb = new System.Windows.Forms.PictureBox();
			this.btnBrowsePatterns = new System.Windows.Forms.Button();
			this.label40 = new System.Windows.Forms.Label();
			this.txtPatternAFilename = new System.Windows.Forms.TextBox();
			this.label39 = new System.Windows.Forms.Label();
			this.cmbPatternAType = new System.Windows.Forms.ComboBox();
			this.txtPatternAName = new System.Windows.Forms.TextBox();
			this.label55 = new System.Windows.Forms.Label();
			this.btnPatternAReplaceSpec = new System.Windows.Forms.Button();
			this.btnPatternAReplaceRGBMask = new System.Windows.Forms.Button();
			this.chkPatternAEnabled = new System.Windows.Forms.CheckBox();
			this.btnPatternAFindSpec = new System.Windows.Forms.Button();
			this.txtPatternASpecular = new System.Windows.Forms.TextBox();
			this.label54 = new System.Windows.Forms.Label();
			this.btnPatternAFindRGBMask = new System.Windows.Forms.Button();
			this.txtPatternARGBMask = new System.Windows.Forms.TextBox();
			this.label52 = new System.Windows.Forms.Label();
			this.label41 = new System.Windows.Forms.Label();
			this.txtPatternAKey = new System.Windows.Forms.TextBox();
			this.chkPatternALinked = new System.Windows.Forms.CheckBox();
			this.label38 = new System.Windows.Forms.Label();
			this.txtPatternATiling = new System.Windows.Forms.TextBox();
			this.groupBox7 = new System.Windows.Forms.GroupBox();
			this.label68 = new System.Windows.Forms.Label();
			this.picPatternColour4 = new System.Windows.Forms.PictureBox();
			this.label67 = new System.Windows.Forms.Label();
			this.picPatternColour2 = new System.Windows.Forms.PictureBox();
			this.label66 = new System.Windows.Forms.Label();
			this.picPatternColour3 = new System.Windows.Forms.PictureBox();
			this.label65 = new System.Windows.Forms.Label();
			this.picPatternColourBg = new System.Windows.Forms.PictureBox();
			this.label64 = new System.Windows.Forms.Label();
			this.picPatternColour1 = new System.Windows.Forms.PictureBox();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.label25 = new System.Windows.Forms.Label();
			this.label24 = new System.Windows.Forms.Label();
			this.label23 = new System.Windows.Forms.Label();
			this.picHSVColorChannel3 = new System.Windows.Forms.PictureBox();
			this.picHSVColorChannel2 = new System.Windows.Forms.PictureBox();
			this.picHSVColorChannel1 = new System.Windows.Forms.PictureBox();
			this.label19 = new System.Windows.Forms.Label();
			this.picHSVColorBG = new System.Windows.Forms.PictureBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.label42 = new System.Windows.Forms.Label();
			this.picPatternSolidColour = new System.Windows.Forms.PictureBox();
			this.label37 = new System.Windows.Forms.Label();
			this.btnPatternACommit = new System.Windows.Forms.Button();
			this.tabPage13 = new System.Windows.Forms.TabPage();
			this.label114 = new System.Windows.Forms.Label();
			this.picLstTextureColour = new System.Windows.Forms.PictureBox();
			this.btnCommitLstTexture = new System.Windows.Forms.Button();
			this.btnListTextureReplace = new System.Windows.Forms.Button();
			this.btnListTextureFind = new System.Windows.Forms.Button();
			this.lstTextureDetails = new System.Windows.Forms.ListView();
			this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.label11 = new System.Windows.Forms.Label();
			this.picLstOtherColour = new System.Windows.Forms.PictureBox();
			this.btnCommitLstOther = new System.Windows.Forms.Button();
			this.btnLstOtherReplace = new System.Windows.Forms.Button();
			this.btnListOtherFind = new System.Windows.Forms.Button();
			this.lstOtherDetails = new System.Windows.Forms.ListView();
			this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
			this.tabPage5 = new System.Windows.Forms.TabPage();
			this.btnLogoCommit = new System.Windows.Forms.Button();
			this.grpLogo = new System.Windows.Forms.GroupBox();
			this.label91 = new System.Windows.Forms.Label();
			this.label92 = new System.Windows.Forms.Label();
			this.txtLogoLowerRight = new System.Windows.Forms.TextBox();
			this.txtLogoUpperLeft = new System.Windows.Forms.TextBox();
			this.picLogoColour = new System.Windows.Forms.PictureBox();
			this.label97 = new System.Windows.Forms.Label();
			this.label98 = new System.Windows.Forms.Label();
			this.txtLogoKey = new System.Windows.Forms.TextBox();
			this.label99 = new System.Windows.Forms.Label();
			this.txtLogoName = new System.Windows.Forms.TextBox();
			this.label100 = new System.Windows.Forms.Label();
			this.txtLogoFilename = new System.Windows.Forms.TextBox();
			this.chkLogoEnabled = new System.Windows.Forms.CheckBox();
			this.label102 = new System.Windows.Forms.Label();
			this.tabPage6 = new System.Windows.Forms.TabPage();
			this.picCustomThumbnail = new System.Windows.Forms.PictureBox();
			this.label108 = new System.Windows.Forms.Label();
			this.button11 = new System.Windows.Forms.Button();
			this.txtCustomThumbnailPath = new System.Windows.Forms.TextBox();
			this.btnCustomThumbnail = new System.Windows.Forms.Button();
			this.chkUseCustomThumbnail = new System.Windows.Forms.CheckBox();
			this.listView1 = new System.Windows.Forms.ListView();
			this.btnAddNewDesign = new System.Windows.Forms.Button();
			this.btnDeleteDesign = new System.Windows.Forms.Button();
			this.btnGetOrigXML = new System.Windows.Forms.Button();
			this.label69 = new System.Windows.Forms.Label();
			this.tabPage11 = new System.Windows.Forms.TabPage();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.lstMeshTGILinks = new System.Windows.Forms.ListView();
			this.columnHeader11 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader12 = new System.Windows.Forms.ColumnHeader();
			this.btnMeshTGILinksFind = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.button22 = new System.Windows.Forms.Button();
			this.txtMeshLod3_1 = new System.Windows.Forms.TextBox();
			this.label36 = new System.Windows.Forms.Label();
			this.button19 = new System.Windows.Forms.Button();
			this.button21 = new System.Windows.Forms.Button();
			this.txtMeshLod2_2 = new System.Windows.Forms.TextBox();
			this.label34 = new System.Windows.Forms.Label();
			this.txtMeshLod2_1 = new System.Windows.Forms.TextBox();
			this.label35 = new System.Windows.Forms.Label();
			this.label33 = new System.Windows.Forms.Label();
			this.label29 = new System.Windows.Forms.Label();
			this.button9 = new System.Windows.Forms.Button();
			this.txtMeshLod0 = new System.Windows.Forms.TextBox();
			this.button10 = new System.Windows.Forms.Button();
			this.button14 = new System.Windows.Forms.Button();
			this.txtMeshLod0_3 = new System.Windows.Forms.TextBox();
			this.label30 = new System.Windows.Forms.Label();
			this.txtMeshLod0_2 = new System.Windows.Forms.TextBox();
			this.button15 = new System.Windows.Forms.Button();
			this.label31 = new System.Windows.Forms.Label();
			this.txtMeshLod0_1 = new System.Windows.Forms.TextBox();
			this.label32 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.button8 = new System.Windows.Forms.Button();
			this.txtMeshLod1 = new System.Windows.Forms.TextBox();
			this.button3 = new System.Windows.Forms.Button();
			this.txtMeshLod2 = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.txtMeshLod3 = new System.Windows.Forms.TextBox();
			this.txtMeshLod1_3 = new System.Windows.Forms.TextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.label28 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.txtMeshLod1_2 = new System.Windows.Forms.TextBox();
			this.button18 = new System.Windows.Forms.Button();
			this.label27 = new System.Windows.Forms.Label();
			this.button17 = new System.Windows.Forms.Button();
			this.txtMeshLod1_1 = new System.Windows.Forms.TextBox();
			this.button16 = new System.Windows.Forms.Button();
			this.label26 = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.button33 = new System.Windows.Forms.Button();
			this.txtOtherBumpMap = new System.Windows.Forms.TextBox();
			this.button20 = new System.Windows.Forms.Button();
			this.txtMeshNameCommit = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.txtMeshName = new System.Windows.Forms.TextBox();
			this.label20 = new System.Windows.Forms.Label();
			this.tabPage14 = new System.Windows.Forms.TabPage();
			this.btnDesignTypeCommit = new System.Windows.Forms.Button();
			this.label22 = new System.Windows.Forms.Label();
			this.chkDesignType = new System.Windows.Forms.CheckedListBox();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.addNewBlankToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.copyDefaultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addNewCopyLastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label113 = new System.Windows.Forms.Label();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.listView2 = new System.Windows.Forms.ListView();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.bwGenTexture = new System.ComponentModel.BackgroundWorker();
			this.btnStart3D = new System.Windows.Forms.Button();
			this.btnReloadTextures = new System.Windows.Forms.Button();
			this.cEnable3DPreview = new System.Windows.Forms.CheckBox();
			this.btnResetView = new System.Windows.Forms.Button();
			this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
			this.findImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.replaceImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
			this.editColourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.renderWindow1 = new MadScience.Render.RenderWindow();
			this.button23 = new System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.tabControl3.SuspendLayout();
			this.tabPage7.SuspendLayout();
			this.groupBox11.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picMeshPreview)).BeginInit();
			this.tabPage9.SuspendLayout();
			this.tabPage10.SuspendLayout();
			this.tabPage4.SuspendLayout();
			this.tabPage8.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.grpPatternA.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picPatternThumb)).BeginInit();
			this.groupBox7.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picPatternColour4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picPatternColour2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picPatternColour3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picPatternColourBg)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picPatternColour1)).BeginInit();
			this.groupBox5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picHSVColorChannel3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picHSVColorChannel2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picHSVColorChannel1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picHSVColorBG)).BeginInit();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picPatternSolidColour)).BeginInit();
			this.tabPage13.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picLstTextureColour)).BeginInit();
			this.tabPage3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picLstOtherColour)).BeginInit();
			this.tabPage5.SuspendLayout();
			this.grpLogo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picLogoColour)).BeginInit();
			this.tabPage6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picCustomThumbnail)).BeginInit();
			this.tabPage11.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.tabPage14.SuspendLayout();
			this.contextMenuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.contextMenuStrip2.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.SystemColors.Menu;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
			this.menuStrip1.Size = new System.Drawing.Size(992, 24);
			this.menuStrip1.TabIndex = 3;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripMenuItem2,
            this.findKeyToolStripMenuItem,
            this.generateThumbnailsToolStripMenuItem,
            this.useAlternativeToolStripMenuItem,
            this.debugModeToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// newToolStripMenuItem
			// 
			this.newToolStripMenuItem.Name = "newToolStripMenuItem";
			this.newToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
			this.newToolStripMenuItem.Text = "New";
			this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
			// 
			// loadToolStripMenuItem
			// 
			this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
			this.loadToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
			this.loadToolStripMenuItem.Text = "Open";
			this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Enabled = false;
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
			this.saveToolStripMenuItem.Text = "Save";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
			// 
			// saveAsToolStripMenuItem
			// 
			this.saveAsToolStripMenuItem.Enabled = false;
			this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
			this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
			this.saveAsToolStripMenuItem.Text = "Save As...";
			this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(192, 6);
			// 
			// findKeyToolStripMenuItem
			// 
			this.findKeyToolStripMenuItem.Name = "findKeyToolStripMenuItem";
			this.findKeyToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
			this.findKeyToolStripMenuItem.Text = "Find Key";
			this.findKeyToolStripMenuItem.Click += new System.EventHandler(this.findKeyToolStripMenuItem_Click);
			// 
			// generateThumbnailsToolStripMenuItem
			// 
			this.generateThumbnailsToolStripMenuItem.Name = "generateThumbnailsToolStripMenuItem";
			this.generateThumbnailsToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
			this.generateThumbnailsToolStripMenuItem.Text = "Generate Thumbnails";
			this.generateThumbnailsToolStripMenuItem.Click += new System.EventHandler(this.generateThumbnailsToolStripMenuItem_Click);
			// 
			// useAlternativeToolStripMenuItem
			// 
			this.useAlternativeToolStripMenuItem.Name = "useAlternativeToolStripMenuItem";
			this.useAlternativeToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
			this.useAlternativeToolStripMenuItem.Text = "Use Alternative Thumb";
			this.useAlternativeToolStripMenuItem.Click += new System.EventHandler(this.useAlternativeToolStripMenuItem_Click);
			// 
			// debugModeToolStripMenuItem
			// 
			this.debugModeToolStripMenuItem.Name = "debugModeToolStripMenuItem";
			this.debugModeToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
			this.debugModeToolStripMenuItem.Text = "Debug Mode";
			this.debugModeToolStripMenuItem.CheckedChanged += new System.EventHandler(this.debugModeToolStripMenuItem_CheckedChanged);
			this.debugModeToolStripMenuItem.Click += new System.EventHandler(this.debugModeToolStripMenuItem_Click);
			// 
			// optionsToolStripMenuItem
			// 
			this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
			this.optionsToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
			this.optionsToolStripMenuItem.Text = "Options";
			this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(192, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(43, 162);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(499, 20);
			this.label8.TabIndex = 17;
			this.label8.Text = "Sorry, this mesh may not have extra designs added right now.";
			this.label8.Visible = false;
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1,
            this.toolStripStatusLabel2});
			this.statusStrip1.Location = new System.Drawing.Point(0, 601);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(992, 22);
			this.statusStrip1.TabIndex = 20;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(977, 17);
			this.toolStripStatusLabel1.Spring = true;
			this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// toolStripProgressBar1
			// 
			this.toolStripProgressBar1.Name = "toolStripProgressBar1";
			this.toolStripProgressBar1.Size = new System.Drawing.Size(200, 16);
			this.toolStripProgressBar1.Visible = false;
			// 
			// toolStripStatusLabel2
			// 
			this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
			this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
			// 
			// tabControl3
			// 
			this.tabControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)));
			this.tabControl3.Controls.Add(this.tabPage7);
			this.tabControl3.Controls.Add(this.tabPage9);
			this.tabControl3.Controls.Add(this.tabPage10);
			this.tabControl3.Controls.Add(this.tabPage4);
			this.tabControl3.Controls.Add(this.tabPage8);
			this.tabControl3.Controls.Add(this.tabPage11);
			this.tabControl3.Controls.Add(this.tabPage14);
			this.tabControl3.Location = new System.Drawing.Point(0, 27);
			this.tabControl3.Name = "tabControl3";
			this.tabControl3.SelectedIndex = 0;
			this.tabControl3.Size = new System.Drawing.Size(578, 570);
			this.tabControl3.TabIndex = 23;
			this.tabControl3.SelectedIndexChanged += new System.EventHandler(this.tabControl3_SelectedIndexChanged);
			// 
			// tabPage7
			// 
			this.tabPage7.Controls.Add(this.groupBox11);
			this.tabPage7.Controls.Add(this.groupBox1);
			this.tabPage7.Location = new System.Drawing.Point(4, 22);
			this.tabPage7.Name = "tabPage7";
			this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage7.Size = new System.Drawing.Size(570, 544);
			this.tabPage7.TabIndex = 0;
			this.tabPage7.Text = "Find a CAS Part";
			this.tabPage7.UseVisualStyleBackColor = true;
			// 
			// groupBox11
			// 
			this.groupBox11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)));
			this.groupBox11.Controls.Add(this.panelMeshThumbs);
			this.groupBox11.Location = new System.Drawing.Point(8, 201);
			this.groupBox11.Name = "groupBox11";
			this.groupBox11.Size = new System.Drawing.Size(555, 337);
			this.groupBox11.TabIndex = 20;
			this.groupBox11.TabStop = false;
			this.groupBox11.Text = "Quick Find";
			this.groupBox11.Visible = false;
			// 
			// panelMeshThumbs
			// 
			this.panelMeshThumbs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)));
			this.panelMeshThumbs.AutoScroll = true;
			this.panelMeshThumbs.Location = new System.Drawing.Point(2, 14);
			this.panelMeshThumbs.Name = "panelMeshThumbs";
			this.panelMeshThumbs.Size = new System.Drawing.Size(551, 321);
			this.panelMeshThumbs.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.btnExtractMeshes);
			this.groupBox1.Controls.Add(this.picMeshPreview);
			this.groupBox1.Controls.Add(this.btnDumpFromFullbuild2);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.txtCasPartInstance);
			this.groupBox1.Controls.Add(this.txtCasPartName);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.cmbMeshName);
			this.groupBox1.Controls.Add(this.cmbSimGender);
			this.groupBox1.Controls.Add(this.cmbSimAge);
			this.groupBox1.Controls.Add(this.cmbPartTypes);
			this.groupBox1.Controls.Add(this.label110);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.label70);
			this.groupBox1.Location = new System.Drawing.Point(8, 6);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(555, 189);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Find a CAS part";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(509, 162);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(39, 23);
			this.button1.TabIndex = 21;
			this.button1.Text = "Try";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Visible = false;
			this.button1.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// btnExtractMeshes
			// 
			this.btnExtractMeshes.Enabled = false;
			this.btnExtractMeshes.Location = new System.Drawing.Point(292, 85);
			this.btnExtractMeshes.Name = "btnExtractMeshes";
			this.btnExtractMeshes.Size = new System.Drawing.Size(122, 23);
			this.btnExtractMeshes.TabIndex = 19;
			this.btnExtractMeshes.Text = "Extract Meshes";
			this.btnExtractMeshes.UseVisualStyleBackColor = true;
			this.btnExtractMeshes.Click += new System.EventHandler(this.button9_Click);
			// 
			// picMeshPreview
			// 
			this.picMeshPreview.Location = new System.Drawing.Point(420, 9);
			this.picMeshPreview.Name = "picMeshPreview";
			this.picMeshPreview.Size = new System.Drawing.Size(128, 128);
			this.picMeshPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picMeshPreview.TabIndex = 18;
			this.picMeshPreview.TabStop = false;
			// 
			// btnDumpFromFullbuild2
			// 
			this.btnDumpFromFullbuild2.Enabled = false;
			this.btnDumpFromFullbuild2.Location = new System.Drawing.Point(292, 114);
			this.btnDumpFromFullbuild2.Name = "btnDumpFromFullbuild2";
			this.btnDumpFromFullbuild2.Size = new System.Drawing.Size(122, 23);
			this.btnDumpFromFullbuild2.TabIndex = 17;
			this.btnDumpFromFullbuild2.Text = "Extract Textures";
			this.btnDumpFromFullbuild2.UseVisualStyleBackColor = true;
			this.btnDumpFromFullbuild2.Click += new System.EventHandler(this.btnDumpFromFullbuild2_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(10, 118);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(65, 13);
			this.label6.TabIndex = 16;
			this.label6.Text = "Instance ID:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(8, 91);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(67, 13);
			this.label5.TabIndex = 15;
			this.label5.Text = "Mesh Name:";
			// 
			// txtCasPartInstance
			// 
			this.txtCasPartInstance.Location = new System.Drawing.Point(81, 115);
			this.txtCasPartInstance.Name = "txtCasPartInstance";
			this.txtCasPartInstance.ReadOnly = true;
			this.txtCasPartInstance.Size = new System.Drawing.Size(205, 20);
			this.txtCasPartInstance.TabIndex = 14;
			// 
			// txtCasPartName
			// 
			this.txtCasPartName.Location = new System.Drawing.Point(81, 88);
			this.txtCasPartName.Name = "txtCasPartName";
			this.txtCasPartName.ReadOnly = true;
			this.txtCasPartName.Size = new System.Drawing.Size(205, 20);
			this.txtCasPartName.TabIndex = 13;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(44, 65);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(36, 13);
			this.label4.TabIndex = 12;
			this.label4.Text = "Mesh:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(266, 16);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(34, 13);
			this.label3.TabIndex = 11;
			this.label3.Text = "Type:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(19, 18);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(29, 13);
			this.label2.TabIndex = 10;
			this.label2.Text = "Age:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(146, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(45, 13);
			this.label1.TabIndex = 9;
			this.label1.Text = "Gender:";
			// 
			// cmbMeshName
			// 
			this.cmbMeshName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbMeshName.Enabled = false;
			this.cmbMeshName.FormattingEnabled = true;
			this.cmbMeshName.Location = new System.Drawing.Point(81, 61);
			this.cmbMeshName.Name = "cmbMeshName";
			this.cmbMeshName.Size = new System.Drawing.Size(333, 21);
			this.cmbMeshName.TabIndex = 8;
			this.cmbMeshName.SelectionChangeCommitted += new System.EventHandler(this.cmbMeshName_SelectionChangeCommitted);
			this.cmbMeshName.SelectedIndexChanged += new System.EventHandler(this.cmbMeshName_SelectedIndexChanged);
			// 
			// cmbSimGender
			// 
			this.cmbSimGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbSimGender.Enabled = false;
			this.cmbSimGender.FormattingEnabled = true;
			this.cmbSimGender.Items.AddRange(new object[] {
            "Female",
            "Male",
            "Unisex"});
			this.cmbSimGender.Location = new System.Drawing.Point(149, 34);
			this.cmbSimGender.Name = "cmbSimGender";
			this.cmbSimGender.Size = new System.Drawing.Size(114, 21);
			this.cmbSimGender.TabIndex = 7;
			this.cmbSimGender.SelectedIndexChanged += new System.EventHandler(this.cmbSimGender_SelectedIndexChanged);
			// 
			// cmbSimAge
			// 
			this.cmbSimAge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbSimAge.Enabled = false;
			this.cmbSimAge.FormattingEnabled = true;
			this.cmbSimAge.Items.AddRange(new object[] {
            "Baby",
            "Toddler",
            "Child",
            "Teen",
            "Young Adult",
            "Adult",
            "Elder",
            "All Ages"});
			this.cmbSimAge.Location = new System.Drawing.Point(22, 34);
			this.cmbSimAge.Name = "cmbSimAge";
			this.cmbSimAge.Size = new System.Drawing.Size(121, 21);
			this.cmbSimAge.TabIndex = 6;
			this.cmbSimAge.SelectedIndexChanged += new System.EventHandler(this.cmbSimAge_SelectedIndexChanged);
			// 
			// cmbPartTypes
			// 
			this.cmbPartTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbPartTypes.Enabled = false;
			this.cmbPartTypes.FormattingEnabled = true;
			this.cmbPartTypes.Location = new System.Drawing.Point(269, 34);
			this.cmbPartTypes.Name = "cmbPartTypes";
			this.cmbPartTypes.Size = new System.Drawing.Size(145, 21);
			this.cmbPartTypes.TabIndex = 5;
			this.cmbPartTypes.SelectedIndexChanged += new System.EventHandler(this.cmbPartTypes_SelectedIndexChanged);
			// 
			// label110
			// 
			this.label110.AutoSize = true;
			this.label110.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label110.Location = new System.Drawing.Point(115, 162);
			this.label110.Name = "label110";
			this.label110.Size = new System.Drawing.Size(332, 20);
			this.label110.TabIndex = 20;
			this.label110.Text = "Getting CAS Thumbnails... Please wait...";
			this.label110.Visible = false;
			// 
			// label70
			// 
			this.label70.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label70.Location = new System.Drawing.Point(6, 148);
			this.label70.Name = "label70";
			this.label70.Size = new System.Drawing.Size(542, 34);
			this.label70.TabIndex = 19;
			this.label70.Text = "No specific meshes could be found using this particular filter.  If you want YA s" +
				"tuff, try under Adult instead.";
			this.label70.Visible = false;
			// 
			// tabPage9
			// 
			this.tabPage9.Controls.Add(this.btnCasPartDetailsCommit);
			this.tabPage9.Controls.Add(this.label87);
			this.tabPage9.Controls.Add(this.lstCasPartDetails);
			this.tabPage9.Location = new System.Drawing.Point(4, 22);
			this.tabPage9.Name = "tabPage9";
			this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage9.Size = new System.Drawing.Size(570, 544);
			this.tabPage9.TabIndex = 5;
			this.tabPage9.Text = "Part Details";
			this.tabPage9.UseVisualStyleBackColor = true;
			// 
			// btnCasPartDetailsCommit
			// 
			this.btnCasPartDetailsCommit.Location = new System.Drawing.Point(489, 12);
			this.btnCasPartDetailsCommit.Name = "btnCasPartDetailsCommit";
			this.btnCasPartDetailsCommit.Size = new System.Drawing.Size(75, 23);
			this.btnCasPartDetailsCommit.TabIndex = 20;
			this.btnCasPartDetailsCommit.Text = "Commit";
			this.btnCasPartDetailsCommit.UseVisualStyleBackColor = true;
			this.btnCasPartDetailsCommit.Visible = false;
			this.btnCasPartDetailsCommit.Click += new System.EventHandler(this.btnCasPartDetailsCommit_Click);
			// 
			// label87
			// 
			this.label87.Location = new System.Drawing.Point(8, 3);
			this.label87.Name = "label87";
			this.label87.Size = new System.Drawing.Size(475, 32);
			this.label87.TabIndex = 3;
			this.label87.Text = "Note: This list is purely for informational purposes only.  Changes here have no " +
				"effect on the resulting file.";
			// 
			// lstCasPartDetails
			// 
			this.lstCasPartDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)));
			this.lstCasPartDetails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
			this.lstCasPartDetails.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lstCasPartDetails.FullRowSelect = true;
			this.lstCasPartDetails.GridLines = true;
			this.lstCasPartDetails.HideSelection = false;
			this.lstCasPartDetails.LabelEdit = true;
			this.lstCasPartDetails.Location = new System.Drawing.Point(10, 41);
			this.lstCasPartDetails.Name = "lstCasPartDetails";
			this.lstCasPartDetails.Size = new System.Drawing.Size(554, 499);
			this.lstCasPartDetails.TabIndex = 2;
			this.lstCasPartDetails.UseCompatibleStateImageBehavior = false;
			this.lstCasPartDetails.View = System.Windows.Forms.View.Details;
			this.lstCasPartDetails.SelectedIndexChanged += new System.EventHandler(this.lstCasPartDetails_SelectedIndexChanged);
			// 
			// columnHeader1
			// 
			this.columnHeader1.DisplayIndex = 1;
			this.columnHeader1.Text = "Value";
			this.columnHeader1.Width = 310;
			// 
			// columnHeader2
			// 
			this.columnHeader2.DisplayIndex = 0;
			this.columnHeader2.Text = "Name";
			this.columnHeader2.Width = 230;
			// 
			// tabPage10
			// 
			this.tabPage10.Controls.Add(this.checkedListClothingType);
			this.tabPage10.Controls.Add(this.label109);
			this.tabPage10.Controls.Add(this.btnCategoryDetailsCommit);
			this.tabPage10.Controls.Add(this.checkedListCategoryExtended);
			this.tabPage10.Controls.Add(this.label95);
			this.tabPage10.Controls.Add(this.checkedListCategory);
			this.tabPage10.Controls.Add(this.checkedListOther);
			this.tabPage10.Controls.Add(this.label94);
			this.tabPage10.Controls.Add(this.checkedListGender);
			this.tabPage10.Controls.Add(this.checkedListAge);
			this.tabPage10.Controls.Add(this.checkedListType);
			this.tabPage10.Controls.Add(this.label93);
			this.tabPage10.Controls.Add(this.label90);
			this.tabPage10.Controls.Add(this.label89);
			this.tabPage10.Controls.Add(this.label88);
			this.tabPage10.Location = new System.Drawing.Point(4, 22);
			this.tabPage10.Name = "tabPage10";
			this.tabPage10.Size = new System.Drawing.Size(570, 544);
			this.tabPage10.TabIndex = 3;
			this.tabPage10.Text = "Part Category";
			this.tabPage10.UseVisualStyleBackColor = true;
			// 
			// checkedListClothingType
			// 
			this.checkedListClothingType.FormattingEnabled = true;
			this.checkedListClothingType.Items.AddRange(new object[] {
            "Hair",
            "Scalp",
            "Face",
            "Body",
            "Top",
            "Bottom",
            "Shoes",
            "Earrings",
            "Glasses (F)",
            "Bracelets",
            "Ring (Left)",
            "Ring (Right)",
            "Beard",
            "Lipstick",
            "Eyeshadow",
            "Eyeliner",
            "Blush",
            "Makeup",
            "Eyebrow",
            "Glove",
            "Socks",
            "Mascara",
            "Weathering",
            "Earring (Left)",
            "Earring (Right)"});
			this.checkedListClothingType.Location = new System.Drawing.Point(171, 27);
			this.checkedListClothingType.Name = "checkedListClothingType";
			this.checkedListClothingType.Size = new System.Drawing.Size(157, 139);
			this.checkedListClothingType.TabIndex = 27;
			this.checkedListClothingType.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListClothingType_ItemCheck);
			// 
			// label109
			// 
			this.label109.AutoSize = true;
			this.label109.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label109.Location = new System.Drawing.Point(167, 11);
			this.label109.Name = "label109";
			this.label109.Size = new System.Drawing.Size(94, 13);
			this.label109.TabIndex = 26;
			this.label109.Text = "CAS Part Type:";
			// 
			// btnCategoryDetailsCommit
			// 
			this.btnCategoryDetailsCommit.Location = new System.Drawing.Point(484, 354);
			this.btnCategoryDetailsCommit.Name = "btnCategoryDetailsCommit";
			this.btnCategoryDetailsCommit.Size = new System.Drawing.Size(75, 23);
			this.btnCategoryDetailsCommit.TabIndex = 25;
			this.btnCategoryDetailsCommit.Text = "Commit";
			this.btnCategoryDetailsCommit.UseVisualStyleBackColor = true;
			this.btnCategoryDetailsCommit.Click += new System.EventHandler(this.btnCategoryDetailsCommit_Click);
			// 
			// checkedListCategoryExtended
			// 
			this.checkedListCategoryExtended.FormattingEnabled = true;
			this.checkedListCategoryExtended.Items.AddRange(new object[] {
            "Valid for Maternity",
            "Valid for Random",
            "Is Hat",
            "Is Revealing",
            "Hidden in CAS"});
			this.checkedListCategoryExtended.Location = new System.Drawing.Point(215, 193);
			this.checkedListCategoryExtended.Name = "checkedListCategoryExtended";
			this.checkedListCategoryExtended.Size = new System.Drawing.Size(126, 184);
			this.checkedListCategoryExtended.TabIndex = 24;
			// 
			// label95
			// 
			this.label95.AutoSize = true;
			this.label95.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label95.Location = new System.Drawing.Point(212, 177);
			this.label95.Name = "label95";
			this.label95.Size = new System.Drawing.Size(118, 13);
			this.label95.TabIndex = 23;
			this.label95.Text = "Extended Category:";
			// 
			// checkedListCategory
			// 
			this.checkedListCategory.FormattingEnabled = true;
			this.checkedListCategory.Items.AddRange(new object[] {
            "Naked",
            "Everyday",
            "Formal",
            "Sleepwear",
            "Swimwear",
            "Athletic",
            "Singed",
            "Career",
            "All"});
			this.checkedListCategory.Location = new System.Drawing.Point(56, 193);
			this.checkedListCategory.Name = "checkedListCategory";
			this.checkedListCategory.Size = new System.Drawing.Size(150, 184);
			this.checkedListCategory.TabIndex = 22;
			// 
			// checkedListOther
			// 
			this.checkedListOther.FormattingEnabled = true;
			this.checkedListOther.Items.AddRange(new object[] {
            "Left Handed",
            "Right Handed",
            "Human"});
			this.checkedListOther.Location = new System.Drawing.Point(350, 193);
			this.checkedListOther.Name = "checkedListOther";
			this.checkedListOther.Size = new System.Drawing.Size(126, 184);
			this.checkedListOther.TabIndex = 21;
			// 
			// label94
			// 
			this.label94.AutoSize = true;
			this.label94.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label94.Location = new System.Drawing.Point(347, 177);
			this.label94.Name = "label94";
			this.label94.Size = new System.Drawing.Size(42, 13);
			this.label94.TabIndex = 20;
			this.label94.Text = "Other:";
			// 
			// checkedListGender
			// 
			this.checkedListGender.FormattingEnabled = true;
			this.checkedListGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
			this.checkedListGender.Location = new System.Drawing.Point(454, 27);
			this.checkedListGender.Name = "checkedListGender";
			this.checkedListGender.Size = new System.Drawing.Size(105, 139);
			this.checkedListGender.TabIndex = 19;
			// 
			// checkedListAge
			// 
			this.checkedListAge.FormattingEnabled = true;
			this.checkedListAge.Items.AddRange(new object[] {
            "Baby",
            "Toddler",
            "Child",
            "Teen",
            "Young Adult",
            "Adult",
            "Elder"});
			this.checkedListAge.Location = new System.Drawing.Point(333, 27);
			this.checkedListAge.Name = "checkedListAge";
			this.checkedListAge.Size = new System.Drawing.Size(115, 139);
			this.checkedListAge.TabIndex = 18;
			// 
			// checkedListType
			// 
			this.checkedListType.FormattingEnabled = true;
			this.checkedListType.Items.AddRange(new object[] {
            "Hair",
            "Scalp",
            "Face Overlay",
            "Body",
            "Accessory"});
			this.checkedListType.Location = new System.Drawing.Point(56, 27);
			this.checkedListType.Name = "checkedListType";
			this.checkedListType.Size = new System.Drawing.Size(109, 139);
			this.checkedListType.TabIndex = 17;
			this.checkedListType.SelectedIndexChanged += new System.EventHandler(this.checkedListType_SelectedIndexChanged);
			this.checkedListType.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListType_ItemCheck);
			// 
			// label93
			// 
			this.label93.AutoSize = true;
			this.label93.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label93.Location = new System.Drawing.Point(53, 177);
			this.label93.Name = "label93";
			this.label93.Size = new System.Drawing.Size(61, 13);
			this.label93.TabIndex = 16;
			this.label93.Text = "Category:";
			// 
			// label90
			// 
			this.label90.AutoSize = true;
			this.label90.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label90.Location = new System.Drawing.Point(451, 11);
			this.label90.Name = "label90";
			this.label90.Size = new System.Drawing.Size(52, 13);
			this.label90.TabIndex = 15;
			this.label90.Text = "Gender:";
			// 
			// label89
			// 
			this.label89.AutoSize = true;
			this.label89.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label89.Location = new System.Drawing.Point(330, 11);
			this.label89.Name = "label89";
			this.label89.Size = new System.Drawing.Size(33, 13);
			this.label89.TabIndex = 14;
			this.label89.Text = "Age:";
			// 
			// label88
			// 
			this.label88.AutoSize = true;
			this.label88.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label88.Location = new System.Drawing.Point(53, 11);
			this.label88.Name = "label88";
			this.label88.Size = new System.Drawing.Size(39, 13);
			this.label88.TabIndex = 13;
			this.label88.Text = "Type:";
			// 
			// tabPage4
			// 
			this.tabPage4.AutoScroll = true;
			this.tabPage4.Controls.Add(this.button13);
			this.tabPage4.Controls.Add(this.lstStencilPool);
			this.tabPage4.Controls.Add(this.button7);
			this.tabPage4.Controls.Add(this.button12);
			this.tabPage4.Location = new System.Drawing.Point(4, 22);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage4.Size = new System.Drawing.Size(570, 544);
			this.tabPage4.TabIndex = 4;
			this.tabPage4.Text = "Stencil Pool";
			this.tabPage4.UseVisualStyleBackColor = true;
			// 
			// button13
			// 
			this.button13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button13.Location = new System.Drawing.Point(489, 518);
			this.button13.Name = "button13";
			this.button13.Size = new System.Drawing.Size(75, 23);
			this.button13.TabIndex = 27;
			this.button13.Text = "Commit";
			this.button13.UseVisualStyleBackColor = true;
			this.button13.Click += new System.EventHandler(this.button13_Click);
			// 
			// lstStencilPool
			// 
			this.lstStencilPool.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)));
			this.lstStencilPool.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader10});
			this.lstStencilPool.GridLines = true;
			this.lstStencilPool.LabelEdit = true;
			this.lstStencilPool.Location = new System.Drawing.Point(8, 6);
			this.lstStencilPool.MultiSelect = false;
			this.lstStencilPool.Name = "lstStencilPool";
			this.lstStencilPool.ShowGroups = false;
			this.lstStencilPool.Size = new System.Drawing.Size(556, 506);
			this.lstStencilPool.TabIndex = 24;
			this.lstStencilPool.UseCompatibleStateImageBehavior = false;
			this.lstStencilPool.View = System.Windows.Forms.View.Details;
			this.lstStencilPool.SelectedIndexChanged += new System.EventHandler(this.listView3_SelectedIndexChanged);
			this.lstStencilPool.Enter += new System.EventHandler(this.listView3_Enter);
			this.lstStencilPool.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView3_ItemSelectionChanged);
			// 
			// columnHeader9
			// 
			this.columnHeader9.DisplayIndex = 1;
			this.columnHeader9.Text = "Value";
			this.columnHeader9.Width = 270;
			// 
			// columnHeader10
			// 
			this.columnHeader10.DisplayIndex = 0;
			this.columnHeader10.Text = "Name";
			this.columnHeader10.Width = 160;
			// 
			// button7
			// 
			this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button7.Enabled = false;
			this.button7.Location = new System.Drawing.Point(50, 518);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(51, 23);
			this.button7.TabIndex = 26;
			this.button7.Text = "replace";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.button7_Click_1);
			// 
			// button12
			// 
			this.button12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button12.Enabled = false;
			this.button12.Location = new System.Drawing.Point(8, 518);
			this.button12.Name = "button12";
			this.button12.Size = new System.Drawing.Size(36, 23);
			this.button12.TabIndex = 25;
			this.button12.Text = "find";
			this.button12.UseVisualStyleBackColor = true;
			this.button12.Click += new System.EventHandler(this.button12_Click);
			// 
			// tabPage8
			// 
			this.tabPage8.Controls.Add(this.btnGetNewXML);
			this.tabPage8.Controls.Add(this.tabControl1);
			this.tabPage8.Controls.Add(this.listView1);
			this.tabPage8.Controls.Add(this.btnAddNewDesign);
			this.tabPage8.Controls.Add(this.btnDeleteDesign);
			this.tabPage8.Controls.Add(this.btnGetOrigXML);
			this.tabPage8.Controls.Add(this.label69);
			this.tabPage8.Location = new System.Drawing.Point(4, 22);
			this.tabPage8.Name = "tabPage8";
			this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage8.Size = new System.Drawing.Size(570, 544);
			this.tabPage8.TabIndex = 1;
			this.tabPage8.Text = "Designs";
			this.tabPage8.UseVisualStyleBackColor = true;
			// 
			// btnGetNewXML
			// 
			this.btnGetNewXML.Location = new System.Drawing.Point(198, 67);
			this.btnGetNewXML.Name = "btnGetNewXML";
			this.btnGetNewXML.Size = new System.Drawing.Size(90, 23);
			this.btnGetNewXML.TabIndex = 5;
			this.btnGetNewXML.Text = "Get New XML";
			this.btnGetNewXML.UseVisualStyleBackColor = true;
			this.btnGetNewXML.Visible = false;
			this.btnGetNewXML.Click += new System.EventHandler(this.btnGetNewXML_Click);
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)));
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage13);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Controls.Add(this.tabPage5);
			this.tabControl1.Controls.Add(this.tabPage6);
			this.tabControl1.Location = new System.Drawing.Point(6, 99);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(558, 444);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.AutoScroll = true;
			this.tabPage1.Controls.Add(this.btnDesignStencilCommit);
			this.tabPage1.Controls.Add(this.btnPatternStencil6Preview);
			this.tabPage1.Controls.Add(this.cmbPatternStencil6);
			this.tabPage1.Controls.Add(this.label106);
			this.tabPage1.Controls.Add(this.btnPatternStencil5Preview);
			this.tabPage1.Controls.Add(this.label107);
			this.tabPage1.Controls.Add(this.cmbPatternStencil5);
			this.tabPage1.Controls.Add(this.btnPatternStencil4Preview);
			this.tabPage1.Controls.Add(this.cmbPatternStencil4);
			this.tabPage1.Controls.Add(this.label104);
			this.tabPage1.Controls.Add(this.btnPatternStencil3Preview);
			this.tabPage1.Controls.Add(this.label105);
			this.tabPage1.Controls.Add(this.cmbPatternStencil3);
			this.tabPage1.Controls.Add(this.btnPatternStencil2Preview);
			this.tabPage1.Controls.Add(this.cmbPatternStencil2);
			this.tabPage1.Controls.Add(this.label43);
			this.tabPage1.Controls.Add(this.label58);
			this.tabPage1.Controls.Add(this.btnPatternStencil1Preview);
			this.tabPage1.Controls.Add(this.label15);
			this.tabPage1.Controls.Add(this.cmbPatternStencil1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(550, 418);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Stencils";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// btnDesignStencilCommit
			// 
			this.btnDesignStencilCommit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnDesignStencilCommit.Location = new System.Drawing.Point(472, 386);
			this.btnDesignStencilCommit.Name = "btnDesignStencilCommit";
			this.btnDesignStencilCommit.Size = new System.Drawing.Size(75, 23);
			this.btnDesignStencilCommit.TabIndex = 41;
			this.btnDesignStencilCommit.Text = "Commit";
			this.btnDesignStencilCommit.UseVisualStyleBackColor = true;
			this.btnDesignStencilCommit.Click += new System.EventHandler(this.btnDesignStencilCommit_Click);
			// 
			// btnPatternStencil6Preview
			// 
			this.btnPatternStencil6Preview.Enabled = false;
			this.btnPatternStencil6Preview.Location = new System.Drawing.Point(372, 238);
			this.btnPatternStencil6Preview.Name = "btnPatternStencil6Preview";
			this.btnPatternStencil6Preview.Size = new System.Drawing.Size(75, 23);
			this.btnPatternStencil6Preview.TabIndex = 40;
			this.btnPatternStencil6Preview.Text = "Preview";
			this.btnPatternStencil6Preview.UseVisualStyleBackColor = true;
			this.btnPatternStencil6Preview.Click += new System.EventHandler(this.button6_Click);
			// 
			// cmbPatternStencil6
			// 
			this.cmbPatternStencil6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbPatternStencil6.Enabled = false;
			this.cmbPatternStencil6.FormattingEnabled = true;
			this.cmbPatternStencil6.Items.AddRange(new object[] {
            "(None)",
            "Stencil 1",
            "Stencil 2",
            "Stencil 3",
            "Stencil 4",
            "Stencil 5",
            "Stencil 6",
            "Stencil 7",
            "Stencil 8",
            "Stencil 9",
            "Stencil 10",
            "Stencil 11",
            "Stencil 12",
            "Stencil 13",
            "Stencil 14",
            "Stencil 15"});
			this.cmbPatternStencil6.Location = new System.Drawing.Point(235, 240);
			this.cmbPatternStencil6.Name = "cmbPatternStencil6";
			this.cmbPatternStencil6.Size = new System.Drawing.Size(131, 21);
			this.cmbPatternStencil6.TabIndex = 39;
			this.cmbPatternStencil6.SelectedIndexChanged += new System.EventHandler(this.cmbPatternStencil6_SelectedIndexChanged);
			// 
			// label106
			// 
			this.label106.AutoSize = true;
			this.label106.Location = new System.Drawing.Point(51, 243);
			this.label106.Name = "label106";
			this.label106.Size = new System.Drawing.Size(165, 13);
			this.label106.TabIndex = 38;
			this.label106.Text = "Choose 6th stencil for this design:";
			// 
			// btnPatternStencil5Preview
			// 
			this.btnPatternStencil5Preview.Enabled = false;
			this.btnPatternStencil5Preview.Location = new System.Drawing.Point(372, 202);
			this.btnPatternStencil5Preview.Name = "btnPatternStencil5Preview";
			this.btnPatternStencil5Preview.Size = new System.Drawing.Size(75, 23);
			this.btnPatternStencil5Preview.TabIndex = 37;
			this.btnPatternStencil5Preview.Text = "Preview";
			this.btnPatternStencil5Preview.UseVisualStyleBackColor = true;
			this.btnPatternStencil5Preview.Click += new System.EventHandler(this.button7_Click);
			// 
			// label107
			// 
			this.label107.AutoSize = true;
			this.label107.Location = new System.Drawing.Point(51, 207);
			this.label107.Name = "label107";
			this.label107.Size = new System.Drawing.Size(165, 13);
			this.label107.TabIndex = 36;
			this.label107.Text = "Choose 5th stencil for this design:";
			// 
			// cmbPatternStencil5
			// 
			this.cmbPatternStencil5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbPatternStencil5.Enabled = false;
			this.cmbPatternStencil5.FormattingEnabled = true;
			this.cmbPatternStencil5.Items.AddRange(new object[] {
            "(None)",
            "Stencil 1",
            "Stencil 2",
            "Stencil 3",
            "Stencil 4",
            "Stencil 5",
            "Stencil 6",
            "Stencil 7",
            "Stencil 8",
            "Stencil 9",
            "Stencil 10",
            "Stencil 11",
            "Stencil 12",
            "Stencil 13",
            "Stencil 14",
            "Stencil 15"});
			this.cmbPatternStencil5.Location = new System.Drawing.Point(235, 204);
			this.cmbPatternStencil5.Name = "cmbPatternStencil5";
			this.cmbPatternStencil5.Size = new System.Drawing.Size(131, 21);
			this.cmbPatternStencil5.TabIndex = 35;
			this.cmbPatternStencil5.SelectedIndexChanged += new System.EventHandler(this.cmbPatternStencil5_SelectedIndexChanged);
			// 
			// btnPatternStencil4Preview
			// 
			this.btnPatternStencil4Preview.Enabled = false;
			this.btnPatternStencil4Preview.Location = new System.Drawing.Point(372, 165);
			this.btnPatternStencil4Preview.Name = "btnPatternStencil4Preview";
			this.btnPatternStencil4Preview.Size = new System.Drawing.Size(75, 23);
			this.btnPatternStencil4Preview.TabIndex = 34;
			this.btnPatternStencil4Preview.Text = "Preview";
			this.btnPatternStencil4Preview.UseVisualStyleBackColor = true;
			this.btnPatternStencil4Preview.Click += new System.EventHandler(this.button4_Click);
			// 
			// cmbPatternStencil4
			// 
			this.cmbPatternStencil4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbPatternStencil4.Enabled = false;
			this.cmbPatternStencil4.FormattingEnabled = true;
			this.cmbPatternStencil4.Items.AddRange(new object[] {
            "(None)",
            "Stencil 1",
            "Stencil 2",
            "Stencil 3",
            "Stencil 4",
            "Stencil 5",
            "Stencil 6",
            "Stencil 7",
            "Stencil 8",
            "Stencil 9",
            "Stencil 10",
            "Stencil 11",
            "Stencil 12",
            "Stencil 13",
            "Stencil 14",
            "Stencil 15"});
			this.cmbPatternStencil4.Location = new System.Drawing.Point(235, 167);
			this.cmbPatternStencil4.Name = "cmbPatternStencil4";
			this.cmbPatternStencil4.Size = new System.Drawing.Size(131, 21);
			this.cmbPatternStencil4.TabIndex = 33;
			this.cmbPatternStencil4.SelectedIndexChanged += new System.EventHandler(this.cmbPatternStencil4_SelectedIndexChanged);
			// 
			// label104
			// 
			this.label104.AutoSize = true;
			this.label104.Location = new System.Drawing.Point(51, 170);
			this.label104.Name = "label104";
			this.label104.Size = new System.Drawing.Size(165, 13);
			this.label104.TabIndex = 32;
			this.label104.Text = "Choose 4th stencil for this design:";
			// 
			// btnPatternStencil3Preview
			// 
			this.btnPatternStencil3Preview.Enabled = false;
			this.btnPatternStencil3Preview.Location = new System.Drawing.Point(372, 129);
			this.btnPatternStencil3Preview.Name = "btnPatternStencil3Preview";
			this.btnPatternStencil3Preview.Size = new System.Drawing.Size(75, 23);
			this.btnPatternStencil3Preview.TabIndex = 31;
			this.btnPatternStencil3Preview.Text = "Preview";
			this.btnPatternStencil3Preview.UseVisualStyleBackColor = true;
			this.btnPatternStencil3Preview.Click += new System.EventHandler(this.button5_Click);
			// 
			// label105
			// 
			this.label105.AutoSize = true;
			this.label105.Location = new System.Drawing.Point(51, 134);
			this.label105.Name = "label105";
			this.label105.Size = new System.Drawing.Size(165, 13);
			this.label105.TabIndex = 30;
			this.label105.Text = "Choose 3rd stencil for this design:";
			// 
			// cmbPatternStencil3
			// 
			this.cmbPatternStencil3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbPatternStencil3.Enabled = false;
			this.cmbPatternStencil3.FormattingEnabled = true;
			this.cmbPatternStencil3.Items.AddRange(new object[] {
            "(None)",
            "Stencil 1",
            "Stencil 2",
            "Stencil 3",
            "Stencil 4",
            "Stencil 5",
            "Stencil 6",
            "Stencil 7",
            "Stencil 8",
            "Stencil 9",
            "Stencil 10",
            "Stencil 11",
            "Stencil 12",
            "Stencil 13",
            "Stencil 14",
            "Stencil 15"});
			this.cmbPatternStencil3.Location = new System.Drawing.Point(235, 131);
			this.cmbPatternStencil3.Name = "cmbPatternStencil3";
			this.cmbPatternStencil3.Size = new System.Drawing.Size(131, 21);
			this.cmbPatternStencil3.TabIndex = 29;
			this.cmbPatternStencil3.SelectedIndexChanged += new System.EventHandler(this.cmbPatternStencil3_SelectedIndexChanged);
			// 
			// btnPatternStencil2Preview
			// 
			this.btnPatternStencil2Preview.Enabled = false;
			this.btnPatternStencil2Preview.Location = new System.Drawing.Point(372, 93);
			this.btnPatternStencil2Preview.Name = "btnPatternStencil2Preview";
			this.btnPatternStencil2Preview.Size = new System.Drawing.Size(75, 23);
			this.btnPatternStencil2Preview.TabIndex = 28;
			this.btnPatternStencil2Preview.Text = "Preview";
			this.btnPatternStencil2Preview.UseVisualStyleBackColor = true;
			this.btnPatternStencil2Preview.Click += new System.EventHandler(this.button1_Click);
			// 
			// cmbPatternStencil2
			// 
			this.cmbPatternStencil2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbPatternStencil2.Enabled = false;
			this.cmbPatternStencil2.FormattingEnabled = true;
			this.cmbPatternStencil2.Items.AddRange(new object[] {
            "(None)",
            "Stencil 1",
            "Stencil 2",
            "Stencil 3",
            "Stencil 4",
            "Stencil 5",
            "Stencil 6",
            "Stencil 7",
            "Stencil 8",
            "Stencil 9",
            "Stencil 10",
            "Stencil 11",
            "Stencil 12",
            "Stencil 13",
            "Stencil 14",
            "Stencil 15"});
			this.cmbPatternStencil2.Location = new System.Drawing.Point(235, 95);
			this.cmbPatternStencil2.Name = "cmbPatternStencil2";
			this.cmbPatternStencil2.Size = new System.Drawing.Size(131, 21);
			this.cmbPatternStencil2.TabIndex = 27;
			this.cmbPatternStencil2.SelectedIndexChanged += new System.EventHandler(this.cmbPatternStencil2_SelectedIndexChanged);
			// 
			// label43
			// 
			this.label43.AutoSize = true;
			this.label43.Location = new System.Drawing.Point(48, 98);
			this.label43.Name = "label43";
			this.label43.Size = new System.Drawing.Size(168, 13);
			this.label43.TabIndex = 26;
			this.label43.Text = "Choose 2nd stencil for this design:";
			// 
			// label58
			// 
			this.label58.Location = new System.Drawing.Point(6, 9);
			this.label58.Name = "label58";
			this.label58.Size = new System.Drawing.Size(469, 45);
			this.label58.TabIndex = 25;
			this.label58.Text = resources.GetString("label58.Text");
			// 
			// btnPatternStencil1Preview
			// 
			this.btnPatternStencil1Preview.Enabled = false;
			this.btnPatternStencil1Preview.Location = new System.Drawing.Point(372, 57);
			this.btnPatternStencil1Preview.Name = "btnPatternStencil1Preview";
			this.btnPatternStencil1Preview.Size = new System.Drawing.Size(75, 23);
			this.btnPatternStencil1Preview.TabIndex = 24;
			this.btnPatternStencil1Preview.Text = "Preview";
			this.btnPatternStencil1Preview.UseVisualStyleBackColor = true;
			this.btnPatternStencil1Preview.Click += new System.EventHandler(this.button3_Click);
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(52, 62);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(164, 13);
			this.label15.TabIndex = 23;
			this.label15.Text = "Choose 1st stencil for this design:";
			// 
			// cmbPatternStencil1
			// 
			this.cmbPatternStencil1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbPatternStencil1.Enabled = false;
			this.cmbPatternStencil1.FormattingEnabled = true;
			this.cmbPatternStencil1.Items.AddRange(new object[] {
            "(None)",
            "Stencil 1",
            "Stencil 2",
            "Stencil 3",
            "Stencil 4",
            "Stencil 5",
            "Stencil 6",
            "Stencil 7",
            "Stencil 8",
            "Stencil 9",
            "Stencil 10",
            "Stencil 11",
            "Stencil 12",
            "Stencil 13",
            "Stencil 14",
            "Stencil 15"});
			this.cmbPatternStencil1.Location = new System.Drawing.Point(235, 59);
			this.cmbPatternStencil1.Name = "cmbPatternStencil1";
			this.cmbPatternStencil1.Size = new System.Drawing.Size(131, 21);
			this.cmbPatternStencil1.TabIndex = 22;
			this.cmbPatternStencil1.SelectedIndexChanged += new System.EventHandler(this.cmbPatternStencil1_SelectedIndexChanged);
			// 
			// tabPage2
			// 
			this.tabPage2.AutoScroll = true;
			this.tabPage2.Controls.Add(this.cmbPatternSelect);
			this.tabPage2.Controls.Add(this.grpPatternA);
			this.tabPage2.Controls.Add(this.label37);
			this.tabPage2.Controls.Add(this.btnPatternACommit);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(550, 418);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Patterns";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// cmbPatternSelect
			// 
			this.cmbPatternSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbPatternSelect.FormattingEnabled = true;
			this.cmbPatternSelect.Items.AddRange(new object[] {
            "Pattern A",
            "Pattern B",
            "Pattern C",
            "Pattern D"});
			this.cmbPatternSelect.Location = new System.Drawing.Point(70, 11);
			this.cmbPatternSelect.Name = "cmbPatternSelect";
			this.cmbPatternSelect.Size = new System.Drawing.Size(139, 21);
			this.cmbPatternSelect.TabIndex = 31;
			this.cmbPatternSelect.SelectedIndexChanged += new System.EventHandler(this.cmbPatternSelect_SelectedIndexChanged);
			// 
			// grpPatternA
			// 
			this.grpPatternA.Controls.Add(this.picPatternThumb);
			this.grpPatternA.Controls.Add(this.btnBrowsePatterns);
			this.grpPatternA.Controls.Add(this.label40);
			this.grpPatternA.Controls.Add(this.txtPatternAFilename);
			this.grpPatternA.Controls.Add(this.label39);
			this.grpPatternA.Controls.Add(this.cmbPatternAType);
			this.grpPatternA.Controls.Add(this.txtPatternAName);
			this.grpPatternA.Controls.Add(this.label55);
			this.grpPatternA.Controls.Add(this.btnPatternAReplaceSpec);
			this.grpPatternA.Controls.Add(this.btnPatternAReplaceRGBMask);
			this.grpPatternA.Controls.Add(this.chkPatternAEnabled);
			this.grpPatternA.Controls.Add(this.btnPatternAFindSpec);
			this.grpPatternA.Controls.Add(this.txtPatternASpecular);
			this.grpPatternA.Controls.Add(this.label54);
			this.grpPatternA.Controls.Add(this.btnPatternAFindRGBMask);
			this.grpPatternA.Controls.Add(this.txtPatternARGBMask);
			this.grpPatternA.Controls.Add(this.label52);
			this.grpPatternA.Controls.Add(this.label41);
			this.grpPatternA.Controls.Add(this.txtPatternAKey);
			this.grpPatternA.Controls.Add(this.chkPatternALinked);
			this.grpPatternA.Controls.Add(this.label38);
			this.grpPatternA.Controls.Add(this.txtPatternATiling);
			this.grpPatternA.Controls.Add(this.groupBox7);
			this.grpPatternA.Controls.Add(this.groupBox5);
			this.grpPatternA.Controls.Add(this.groupBox3);
			this.grpPatternA.Enabled = false;
			this.grpPatternA.Location = new System.Drawing.Point(5, 38);
			this.grpPatternA.Name = "grpPatternA";
			this.grpPatternA.Size = new System.Drawing.Size(523, 346);
			this.grpPatternA.TabIndex = 2;
			this.grpPatternA.TabStop = false;
			// 
			// picPatternThumb
			// 
			this.picPatternThumb.Location = new System.Drawing.Point(389, 41);
			this.picPatternThumb.Name = "picPatternThumb";
			this.picPatternThumb.Size = new System.Drawing.Size(128, 128);
			this.picPatternThumb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picPatternThumb.TabIndex = 44;
			this.picPatternThumb.TabStop = false;
			// 
			// btnBrowsePatterns
			// 
			this.btnBrowsePatterns.Location = new System.Drawing.Point(424, 12);
			this.btnBrowsePatterns.Name = "btnBrowsePatterns";
			this.btnBrowsePatterns.Size = new System.Drawing.Size(93, 23);
			this.btnBrowsePatterns.TabIndex = 43;
			this.btnBrowsePatterns.Text = "Browse Patterns";
			this.btnBrowsePatterns.UseVisualStyleBackColor = true;
			this.btnBrowsePatterns.Click += new System.EventHandler(this.btnBrowsePatterns_Click);
			// 
			// label40
			// 
			this.label40.AutoSize = true;
			this.label40.Location = new System.Drawing.Point(17, 89);
			this.label40.Name = "label40";
			this.label40.Size = new System.Drawing.Size(38, 13);
			this.label40.TabIndex = 6;
			this.label40.Text = "Name:";
			// 
			// txtPatternAFilename
			// 
			this.txtPatternAFilename.Location = new System.Drawing.Point(61, 113);
			this.txtPatternAFilename.Name = "txtPatternAFilename";
			this.txtPatternAFilename.Size = new System.Drawing.Size(322, 20);
			this.txtPatternAFilename.TabIndex = 3;
			this.txtPatternAFilename.TextChanged += new System.EventHandler(this.txtPatternAFilename_TextChanged);
			// 
			// label39
			// 
			this.label39.AutoSize = true;
			this.label39.Location = new System.Drawing.Point(3, 117);
			this.label39.Name = "label39";
			this.label39.Size = new System.Drawing.Size(52, 13);
			this.label39.TabIndex = 4;
			this.label39.Text = "Filename:";
			// 
			// cmbPatternAType
			// 
			this.cmbPatternAType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbPatternAType.FormattingEnabled = true;
			this.cmbPatternAType.Items.AddRange(new object[] {
            "Solid Colour",
            "Pattern (Coloured)",
            "Pattern (HSV)"});
			this.cmbPatternAType.Location = new System.Drawing.Point(61, 57);
			this.cmbPatternAType.Name = "cmbPatternAType";
			this.cmbPatternAType.Size = new System.Drawing.Size(121, 21);
			this.cmbPatternAType.TabIndex = 39;
			this.cmbPatternAType.SelectedIndexChanged += new System.EventHandler(this.cmbPatternAType_SelectedIndexChanged);
			// 
			// txtPatternAName
			// 
			this.txtPatternAName.Location = new System.Drawing.Point(61, 85);
			this.txtPatternAName.Name = "txtPatternAName";
			this.txtPatternAName.Size = new System.Drawing.Size(321, 20);
			this.txtPatternAName.TabIndex = 5;
			this.txtPatternAName.TextChanged += new System.EventHandler(this.txtPatternAName_TextChanged);
			// 
			// label55
			// 
			this.label55.AutoSize = true;
			this.label55.Location = new System.Drawing.Point(21, 61);
			this.label55.Name = "label55";
			this.label55.Size = new System.Drawing.Size(34, 13);
			this.label55.TabIndex = 38;
			this.label55.Text = "Type:";
			// 
			// btnPatternAReplaceSpec
			// 
			this.btnPatternAReplaceSpec.Location = new System.Drawing.Point(443, 200);
			this.btnPatternAReplaceSpec.Name = "btnPatternAReplaceSpec";
			this.btnPatternAReplaceSpec.Size = new System.Drawing.Size(51, 23);
			this.btnPatternAReplaceSpec.TabIndex = 37;
			this.btnPatternAReplaceSpec.Text = "replace";
			this.btnPatternAReplaceSpec.UseVisualStyleBackColor = true;
			this.btnPatternAReplaceSpec.Click += new System.EventHandler(this.btnPatternAReplaceSpec_Click);
			// 
			// btnPatternAReplaceRGBMask
			// 
			this.btnPatternAReplaceRGBMask.Location = new System.Drawing.Point(443, 171);
			this.btnPatternAReplaceRGBMask.Name = "btnPatternAReplaceRGBMask";
			this.btnPatternAReplaceRGBMask.Size = new System.Drawing.Size(51, 23);
			this.btnPatternAReplaceRGBMask.TabIndex = 36;
			this.btnPatternAReplaceRGBMask.Text = "replace";
			this.btnPatternAReplaceRGBMask.UseVisualStyleBackColor = true;
			this.btnPatternAReplaceRGBMask.Click += new System.EventHandler(this.btnPatternAReplaceRGBMask_Click);
			// 
			// chkPatternAEnabled
			// 
			this.chkPatternAEnabled.AutoSize = true;
			this.chkPatternAEnabled.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.chkPatternAEnabled.Enabled = false;
			this.chkPatternAEnabled.Location = new System.Drawing.Point(9, 12);
			this.chkPatternAEnabled.Name = "chkPatternAEnabled";
			this.chkPatternAEnabled.Size = new System.Drawing.Size(65, 17);
			this.chkPatternAEnabled.TabIndex = 1;
			this.chkPatternAEnabled.Text = "Enabled";
			this.chkPatternAEnabled.UseVisualStyleBackColor = true;
			this.chkPatternAEnabled.CheckedChanged += new System.EventHandler(this.chkPatternAEnabled_CheckedChanged);
			// 
			// btnPatternAFindSpec
			// 
			this.btnPatternAFindSpec.Location = new System.Drawing.Point(401, 200);
			this.btnPatternAFindSpec.Name = "btnPatternAFindSpec";
			this.btnPatternAFindSpec.Size = new System.Drawing.Size(36, 23);
			this.btnPatternAFindSpec.TabIndex = 33;
			this.btnPatternAFindSpec.Text = "find";
			this.btnPatternAFindSpec.UseVisualStyleBackColor = true;
			this.btnPatternAFindSpec.Click += new System.EventHandler(this.btnPatternAFindSpec_Click);
			// 
			// txtPatternASpecular
			// 
			this.txtPatternASpecular.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPatternASpecular.Location = new System.Drawing.Point(62, 200);
			this.txtPatternASpecular.Name = "txtPatternASpecular";
			this.txtPatternASpecular.Size = new System.Drawing.Size(321, 20);
			this.txtPatternASpecular.TabIndex = 32;
			this.txtPatternASpecular.TextChanged += new System.EventHandler(this.txtPatternASpecular_TextChanged);
			// 
			// label54
			// 
			this.label54.AutoSize = true;
			this.label54.Location = new System.Drawing.Point(4, 202);
			this.label54.Name = "label54";
			this.label54.Size = new System.Drawing.Size(52, 13);
			this.label54.TabIndex = 31;
			this.label54.Text = "Specular:";
			// 
			// btnPatternAFindRGBMask
			// 
			this.btnPatternAFindRGBMask.Location = new System.Drawing.Point(401, 171);
			this.btnPatternAFindRGBMask.Name = "btnPatternAFindRGBMask";
			this.btnPatternAFindRGBMask.Size = new System.Drawing.Size(36, 23);
			this.btnPatternAFindRGBMask.TabIndex = 28;
			this.btnPatternAFindRGBMask.Text = "find";
			this.btnPatternAFindRGBMask.UseVisualStyleBackColor = true;
			this.btnPatternAFindRGBMask.Click += new System.EventHandler(this.btnPatternAFindRGBMask_Click);
			// 
			// txtPatternARGBMask
			// 
			this.txtPatternARGBMask.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPatternARGBMask.Location = new System.Drawing.Point(62, 171);
			this.txtPatternARGBMask.Name = "txtPatternARGBMask";
			this.txtPatternARGBMask.Size = new System.Drawing.Size(321, 20);
			this.txtPatternARGBMask.TabIndex = 27;
			this.txtPatternARGBMask.TextChanged += new System.EventHandler(this.txtPatternARGBMask_TextChanged);
			// 
			// label52
			// 
			this.label52.AutoSize = true;
			this.label52.Location = new System.Drawing.Point(4, 175);
			this.label52.Name = "label52";
			this.label52.Size = new System.Drawing.Size(59, 13);
			this.label52.TabIndex = 26;
			this.label52.Text = "RGBMask:";
			// 
			// label41
			// 
			this.label41.AutoSize = true;
			this.label41.Location = new System.Drawing.Point(27, 33);
			this.label41.Name = "label41";
			this.label41.Size = new System.Drawing.Size(28, 13);
			this.label41.TabIndex = 8;
			this.label41.Text = "Key:";
			// 
			// txtPatternAKey
			// 
			this.txtPatternAKey.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPatternAKey.Location = new System.Drawing.Point(61, 32);
			this.txtPatternAKey.Name = "txtPatternAKey";
			this.txtPatternAKey.Size = new System.Drawing.Size(322, 20);
			this.txtPatternAKey.TabIndex = 7;
			this.txtPatternAKey.TextChanged += new System.EventHandler(this.txtPatternAKey_TextChanged);
			// 
			// chkPatternALinked
			// 
			this.chkPatternALinked.AutoSize = true;
			this.chkPatternALinked.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.chkPatternALinked.Location = new System.Drawing.Point(87, 12);
			this.chkPatternALinked.Name = "chkPatternALinked";
			this.chkPatternALinked.Size = new System.Drawing.Size(58, 17);
			this.chkPatternALinked.TabIndex = 2;
			this.chkPatternALinked.Text = "Linked";
			this.chkPatternALinked.UseVisualStyleBackColor = true;
			this.chkPatternALinked.CheckedChanged += new System.EventHandler(this.chkPatternALinked_CheckedChanged);
			// 
			// label38
			// 
			this.label38.AutoSize = true;
			this.label38.Location = new System.Drawing.Point(20, 146);
			this.label38.Name = "label38";
			this.label38.Size = new System.Drawing.Size(35, 13);
			this.label38.TabIndex = 1;
			this.label38.Text = "Tiling:";
			// 
			// txtPatternATiling
			// 
			this.txtPatternATiling.Location = new System.Drawing.Point(61, 142);
			this.txtPatternATiling.Name = "txtPatternATiling";
			this.txtPatternATiling.Size = new System.Drawing.Size(192, 20);
			this.txtPatternATiling.TabIndex = 0;
			this.txtPatternATiling.TextChanged += new System.EventHandler(this.txtPatternATiling_TextChanged);
			// 
			// groupBox7
			// 
			this.groupBox7.Controls.Add(this.label68);
			this.groupBox7.Controls.Add(this.picPatternColour4);
			this.groupBox7.Controls.Add(this.label67);
			this.groupBox7.Controls.Add(this.picPatternColour2);
			this.groupBox7.Controls.Add(this.label66);
			this.groupBox7.Controls.Add(this.picPatternColour3);
			this.groupBox7.Controls.Add(this.label65);
			this.groupBox7.Controls.Add(this.picPatternColourBg);
			this.groupBox7.Controls.Add(this.label64);
			this.groupBox7.Controls.Add(this.picPatternColour1);
			this.groupBox7.Location = new System.Drawing.Point(5, 232);
			this.groupBox7.Name = "groupBox7";
			this.groupBox7.Size = new System.Drawing.Size(512, 105);
			this.groupBox7.TabIndex = 42;
			this.groupBox7.TabStop = false;
			this.groupBox7.Text = "Pattern (Coloured) Options";
			this.groupBox7.Visible = false;
			// 
			// label68
			// 
			this.label68.AutoSize = true;
			this.label68.Location = new System.Drawing.Point(224, 22);
			this.label68.Name = "label68";
			this.label68.Size = new System.Drawing.Size(52, 13);
			this.label68.TabIndex = 24;
			this.label68.Text = "Palette 4:";
			// 
			// picPatternColour4
			// 
			this.picPatternColour4.BackColor = System.Drawing.Color.Transparent;
			this.picPatternColour4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.picPatternColour4.Location = new System.Drawing.Point(227, 39);
			this.picPatternColour4.Name = "picPatternColour4";
			this.picPatternColour4.Size = new System.Drawing.Size(42, 42);
			this.picPatternColour4.TabIndex = 25;
			this.picPatternColour4.TabStop = false;
			this.picPatternColour4.Click += new System.EventHandler(this.picPatternColour4_Click);
			// 
			// label67
			// 
			this.label67.AutoSize = true;
			this.label67.Location = new System.Drawing.Point(90, 22);
			this.label67.Name = "label67";
			this.label67.Size = new System.Drawing.Size(52, 13);
			this.label67.TabIndex = 21;
			this.label67.Text = "Palette 2:";
			// 
			// picPatternColour2
			// 
			this.picPatternColour2.BackColor = System.Drawing.Color.Transparent;
			this.picPatternColour2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.picPatternColour2.Location = new System.Drawing.Point(93, 39);
			this.picPatternColour2.Name = "picPatternColour2";
			this.picPatternColour2.Size = new System.Drawing.Size(42, 42);
			this.picPatternColour2.TabIndex = 22;
			this.picPatternColour2.TabStop = false;
			this.picPatternColour2.Click += new System.EventHandler(this.picPatternColour2_Click);
			// 
			// label66
			// 
			this.label66.AutoSize = true;
			this.label66.Location = new System.Drawing.Point(157, 22);
			this.label66.Name = "label66";
			this.label66.Size = new System.Drawing.Size(52, 13);
			this.label66.TabIndex = 18;
			this.label66.Text = "Palette 3:";
			// 
			// picPatternColour3
			// 
			this.picPatternColour3.BackColor = System.Drawing.Color.Transparent;
			this.picPatternColour3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.picPatternColour3.Location = new System.Drawing.Point(160, 39);
			this.picPatternColour3.Name = "picPatternColour3";
			this.picPatternColour3.Size = new System.Drawing.Size(42, 42);
			this.picPatternColour3.TabIndex = 19;
			this.picPatternColour3.TabStop = false;
			this.picPatternColour3.Click += new System.EventHandler(this.picPatternColour3_Click);
			// 
			// label65
			// 
			this.label65.AutoSize = true;
			this.label65.Location = new System.Drawing.Point(293, 22);
			this.label65.Name = "label65";
			this.label65.Size = new System.Drawing.Size(56, 13);
			this.label65.TabIndex = 15;
			this.label65.Text = "Colour Bg:";
			// 
			// picPatternColourBg
			// 
			this.picPatternColourBg.BackColor = System.Drawing.Color.Transparent;
			this.picPatternColourBg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.picPatternColourBg.Location = new System.Drawing.Point(296, 39);
			this.picPatternColourBg.Name = "picPatternColourBg";
			this.picPatternColourBg.Size = new System.Drawing.Size(42, 42);
			this.picPatternColourBg.TabIndex = 16;
			this.picPatternColourBg.TabStop = false;
			this.picPatternColourBg.Click += new System.EventHandler(this.picPatternColourBg_Click);
			// 
			// label64
			// 
			this.label64.AutoSize = true;
			this.label64.Location = new System.Drawing.Point(22, 22);
			this.label64.Name = "label64";
			this.label64.Size = new System.Drawing.Size(52, 13);
			this.label64.TabIndex = 12;
			this.label64.Text = "Palette 1:";
			// 
			// picPatternColour1
			// 
			this.picPatternColour1.BackColor = System.Drawing.Color.Transparent;
			this.picPatternColour1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.picPatternColour1.Location = new System.Drawing.Point(25, 39);
			this.picPatternColour1.Name = "picPatternColour1";
			this.picPatternColour1.Size = new System.Drawing.Size(42, 42);
			this.picPatternColour1.TabIndex = 13;
			this.picPatternColour1.TabStop = false;
			this.picPatternColour1.Click += new System.EventHandler(this.picPatternColour1_Click);
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.label25);
			this.groupBox5.Controls.Add(this.label24);
			this.groupBox5.Controls.Add(this.label23);
			this.groupBox5.Controls.Add(this.picHSVColorChannel3);
			this.groupBox5.Controls.Add(this.picHSVColorChannel2);
			this.groupBox5.Controls.Add(this.picHSVColorChannel1);
			this.groupBox5.Controls.Add(this.label19);
			this.groupBox5.Controls.Add(this.picHSVColorBG);
			this.groupBox5.Location = new System.Drawing.Point(5, 232);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(512, 105);
			this.groupBox5.TabIndex = 41;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Pattern (HSV) Options";
			this.groupBox5.Visible = false;
			// 
			// label25
			// 
			this.label25.AutoSize = true;
			this.label25.Location = new System.Drawing.Point(224, 22);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(52, 13);
			this.label25.TabIndex = 64;
			this.label25.Text = "Palette 4:";
			// 
			// label24
			// 
			this.label24.AutoSize = true;
			this.label24.Location = new System.Drawing.Point(157, 22);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(52, 13);
			this.label24.TabIndex = 63;
			this.label24.Text = "Palette 3:";
			// 
			// label23
			// 
			this.label23.AutoSize = true;
			this.label23.Location = new System.Drawing.Point(90, 22);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(52, 13);
			this.label23.TabIndex = 62;
			this.label23.Text = "Palette 2:";
			// 
			// picHSVColorChannel3
			// 
			this.picHSVColorChannel3.BackColor = System.Drawing.Color.Transparent;
			this.picHSVColorChannel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.picHSVColorChannel3.Location = new System.Drawing.Point(227, 39);
			this.picHSVColorChannel3.Name = "picHSVColorChannel3";
			this.picHSVColorChannel3.Size = new System.Drawing.Size(42, 42);
			this.picHSVColorChannel3.TabIndex = 61;
			this.picHSVColorChannel3.TabStop = false;
			this.picHSVColorChannel3.Click += new System.EventHandler(this.picHSVColorChannel3_Click);
			// 
			// picHSVColorChannel2
			// 
			this.picHSVColorChannel2.BackColor = System.Drawing.Color.Transparent;
			this.picHSVColorChannel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.picHSVColorChannel2.Location = new System.Drawing.Point(160, 39);
			this.picHSVColorChannel2.Name = "picHSVColorChannel2";
			this.picHSVColorChannel2.Size = new System.Drawing.Size(42, 42);
			this.picHSVColorChannel2.TabIndex = 60;
			this.picHSVColorChannel2.TabStop = false;
			this.picHSVColorChannel2.Click += new System.EventHandler(this.picHSVColorChannel2_Click);
			// 
			// picHSVColorChannel1
			// 
			this.picHSVColorChannel1.BackColor = System.Drawing.Color.Transparent;
			this.picHSVColorChannel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.picHSVColorChannel1.Location = new System.Drawing.Point(93, 39);
			this.picHSVColorChannel1.Name = "picHSVColorChannel1";
			this.picHSVColorChannel1.Size = new System.Drawing.Size(42, 42);
			this.picHSVColorChannel1.TabIndex = 59;
			this.picHSVColorChannel1.TabStop = false;
			this.picHSVColorChannel1.Click += new System.EventHandler(this.picHSVColorChannel1_Click);
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Location = new System.Drawing.Point(22, 22);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(52, 13);
			this.label19.TabIndex = 58;
			this.label19.Text = "Palette 1:";
			// 
			// picHSVColorBG
			// 
			this.picHSVColorBG.BackColor = System.Drawing.Color.Transparent;
			this.picHSVColorBG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.picHSVColorBG.Location = new System.Drawing.Point(25, 39);
			this.picHSVColorBG.Name = "picHSVColorBG";
			this.picHSVColorBG.Size = new System.Drawing.Size(42, 42);
			this.picHSVColorBG.TabIndex = 57;
			this.picHSVColorBG.TabStop = false;
			this.picHSVColorBG.Click += new System.EventHandler(this.picHSVColorBG_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.label42);
			this.groupBox3.Controls.Add(this.picPatternSolidColour);
			this.groupBox3.Location = new System.Drawing.Point(5, 232);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(512, 105);
			this.groupBox3.TabIndex = 40;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Solid Colour Options";
			// 
			// label42
			// 
			this.label42.AutoSize = true;
			this.label42.Location = new System.Drawing.Point(22, 22);
			this.label42.Name = "label42";
			this.label42.Size = new System.Drawing.Size(40, 13);
			this.label42.TabIndex = 9;
			this.label42.Text = "Colour:";
			// 
			// picPatternSolidColour
			// 
			this.picPatternSolidColour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.picPatternSolidColour.Location = new System.Drawing.Point(25, 39);
			this.picPatternSolidColour.Name = "picPatternSolidColour";
			this.picPatternSolidColour.Size = new System.Drawing.Size(42, 42);
			this.picPatternSolidColour.TabIndex = 10;
			this.picPatternSolidColour.TabStop = false;
			this.picPatternSolidColour.Click += new System.EventHandler(this.picPatternAColor_Click);
			// 
			// label37
			// 
			this.label37.AutoSize = true;
			this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label37.Location = new System.Drawing.Point(7, 14);
			this.label37.Name = "label37";
			this.label37.Size = new System.Drawing.Size(58, 13);
			this.label37.TabIndex = 0;
			this.label37.Text = "Patterns:";
			// 
			// btnPatternACommit
			// 
			this.btnPatternACommit.Location = new System.Drawing.Point(415, 9);
			this.btnPatternACommit.Name = "btnPatternACommit";
			this.btnPatternACommit.Size = new System.Drawing.Size(111, 23);
			this.btnPatternACommit.TabIndex = 34;
			this.btnPatternACommit.Text = "Commit Changes";
			this.btnPatternACommit.UseVisualStyleBackColor = true;
			this.btnPatternACommit.Visible = false;
			this.btnPatternACommit.Click += new System.EventHandler(this.btnPatternACommit_Click);
			// 
			// tabPage13
			// 
			this.tabPage13.Controls.Add(this.label114);
			this.tabPage13.Controls.Add(this.picLstTextureColour);
			this.tabPage13.Controls.Add(this.btnCommitLstTexture);
			this.tabPage13.Controls.Add(this.btnListTextureReplace);
			this.tabPage13.Controls.Add(this.btnListTextureFind);
			this.tabPage13.Controls.Add(this.lstTextureDetails);
			this.tabPage13.Location = new System.Drawing.Point(4, 22);
			this.tabPage13.Name = "tabPage13";
			this.tabPage13.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage13.Size = new System.Drawing.Size(550, 418);
			this.tabPage13.TabIndex = 6;
			this.tabPage13.Text = "Textures";
			this.tabPage13.UseVisualStyleBackColor = true;
			// 
			// label114
			// 
			this.label114.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label114.AutoSize = true;
			this.label114.Location = new System.Drawing.Point(113, 391);
			this.label114.Name = "label114";
			this.label114.Size = new System.Drawing.Size(40, 13);
			this.label114.TabIndex = 11;
			this.label114.Text = "Colour:";
			// 
			// picLstTextureColour
			// 
			this.picLstTextureColour.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.picLstTextureColour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.picLstTextureColour.Location = new System.Drawing.Point(159, 386);
			this.picLstTextureColour.Name = "picLstTextureColour";
			this.picLstTextureColour.Size = new System.Drawing.Size(25, 23);
			this.picLstTextureColour.TabIndex = 10;
			this.picLstTextureColour.TabStop = false;
			this.picLstTextureColour.Click += new System.EventHandler(this.picListTextureColour_Click);
			// 
			// btnCommitLstTexture
			// 
			this.btnCommitLstTexture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnCommitLstTexture.Location = new System.Drawing.Point(472, 386);
			this.btnCommitLstTexture.Name = "btnCommitLstTexture";
			this.btnCommitLstTexture.Size = new System.Drawing.Size(75, 23);
			this.btnCommitLstTexture.TabIndex = 9;
			this.btnCommitLstTexture.Text = "Commit";
			this.btnCommitLstTexture.UseVisualStyleBackColor = true;
			this.btnCommitLstTexture.Click += new System.EventHandler(this.btnCommitLstTexture_Click);
			// 
			// btnListTextureReplace
			// 
			this.btnListTextureReplace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnListTextureReplace.Enabled = false;
			this.btnListTextureReplace.Location = new System.Drawing.Point(45, 386);
			this.btnListTextureReplace.Name = "btnListTextureReplace";
			this.btnListTextureReplace.Size = new System.Drawing.Size(51, 23);
			this.btnListTextureReplace.TabIndex = 8;
			this.btnListTextureReplace.Text = "replace";
			this.btnListTextureReplace.UseVisualStyleBackColor = true;
			this.btnListTextureReplace.Click += new System.EventHandler(this.btnListTextureReplace_Click);
			// 
			// btnListTextureFind
			// 
			this.btnListTextureFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnListTextureFind.Enabled = false;
			this.btnListTextureFind.Location = new System.Drawing.Point(3, 386);
			this.btnListTextureFind.Name = "btnListTextureFind";
			this.btnListTextureFind.Size = new System.Drawing.Size(36, 23);
			this.btnListTextureFind.TabIndex = 7;
			this.btnListTextureFind.Text = "find";
			this.btnListTextureFind.UseVisualStyleBackColor = true;
			this.btnListTextureFind.Click += new System.EventHandler(this.btnListTextureFind_Click);
			// 
			// lstTextureDetails
			// 
			this.lstTextureDetails.Activation = System.Windows.Forms.ItemActivation.TwoClick;
			this.lstTextureDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)));
			this.lstTextureDetails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8});
			this.lstTextureDetails.GridLines = true;
			this.lstTextureDetails.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lstTextureDetails.LabelEdit = true;
			this.lstTextureDetails.Location = new System.Drawing.Point(3, 8);
			this.lstTextureDetails.MultiSelect = false;
			this.lstTextureDetails.Name = "lstTextureDetails";
			this.lstTextureDetails.ShowGroups = false;
			this.lstTextureDetails.Size = new System.Drawing.Size(544, 372);
			this.lstTextureDetails.TabIndex = 6;
			this.lstTextureDetails.UseCompatibleStateImageBehavior = false;
			this.lstTextureDetails.View = System.Windows.Forms.View.Details;
			this.lstTextureDetails.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstTextureDetails_MouseDoubleClick);
			this.lstTextureDetails.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstTextureDetails_MouseClick);
			this.lstTextureDetails.SelectedIndexChanged += new System.EventHandler(this.lstTextureDetails_SelectedIndexChanged);
			this.lstTextureDetails.Enter += new System.EventHandler(this.lstTextureDetails_Enter);
			this.lstTextureDetails.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lstTextureDetails_ItemSelectionChanged);
			// 
			// columnHeader7
			// 
			this.columnHeader7.DisplayIndex = 1;
			this.columnHeader7.Text = "Value";
			this.columnHeader7.Width = 330;
			// 
			// columnHeader8
			// 
			this.columnHeader8.DisplayIndex = 0;
			this.columnHeader8.Text = "Name";
			this.columnHeader8.Width = 190;
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.label11);
			this.tabPage3.Controls.Add(this.picLstOtherColour);
			this.tabPage3.Controls.Add(this.btnCommitLstOther);
			this.tabPage3.Controls.Add(this.btnLstOtherReplace);
			this.tabPage3.Controls.Add(this.btnListOtherFind);
			this.tabPage3.Controls.Add(this.lstOtherDetails);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(550, 418);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Other Details";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// label11
			// 
			this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(113, 391);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(40, 13);
			this.label11.TabIndex = 5;
			this.label11.Text = "Colour:";
			// 
			// picLstOtherColour
			// 
			this.picLstOtherColour.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.picLstOtherColour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.picLstOtherColour.Location = new System.Drawing.Point(159, 386);
			this.picLstOtherColour.Name = "picLstOtherColour";
			this.picLstOtherColour.Size = new System.Drawing.Size(25, 23);
			this.picLstOtherColour.TabIndex = 4;
			this.picLstOtherColour.TabStop = false;
			this.picLstOtherColour.Click += new System.EventHandler(this.picLstOtherColour_Click);
			// 
			// btnCommitLstOther
			// 
			this.btnCommitLstOther.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnCommitLstOther.Location = new System.Drawing.Point(472, 386);
			this.btnCommitLstOther.Name = "btnCommitLstOther";
			this.btnCommitLstOther.Size = new System.Drawing.Size(75, 23);
			this.btnCommitLstOther.TabIndex = 3;
			this.btnCommitLstOther.Text = "Commit";
			this.btnCommitLstOther.UseVisualStyleBackColor = true;
			this.btnCommitLstOther.Click += new System.EventHandler(this.btnCommitLstOther_Click);
			// 
			// btnLstOtherReplace
			// 
			this.btnLstOtherReplace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnLstOtherReplace.Enabled = false;
			this.btnLstOtherReplace.Location = new System.Drawing.Point(45, 386);
			this.btnLstOtherReplace.Name = "btnLstOtherReplace";
			this.btnLstOtherReplace.Size = new System.Drawing.Size(51, 23);
			this.btnLstOtherReplace.TabIndex = 2;
			this.btnLstOtherReplace.Text = "replace";
			this.btnLstOtherReplace.UseVisualStyleBackColor = true;
			this.btnLstOtherReplace.Click += new System.EventHandler(this.btnLstOtherReplace_Click);
			// 
			// btnListOtherFind
			// 
			this.btnListOtherFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnListOtherFind.Enabled = false;
			this.btnListOtherFind.Location = new System.Drawing.Point(3, 386);
			this.btnListOtherFind.Name = "btnListOtherFind";
			this.btnListOtherFind.Size = new System.Drawing.Size(36, 23);
			this.btnListOtherFind.TabIndex = 1;
			this.btnListOtherFind.Text = "find";
			this.btnListOtherFind.UseVisualStyleBackColor = true;
			this.btnListOtherFind.Click += new System.EventHandler(this.btnListOtherFind_Click);
			// 
			// lstOtherDetails
			// 
			this.lstOtherDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)));
			this.lstOtherDetails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6});
			this.lstOtherDetails.GridLines = true;
			this.lstOtherDetails.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lstOtherDetails.LabelEdit = true;
			this.lstOtherDetails.Location = new System.Drawing.Point(3, 8);
			this.lstOtherDetails.MultiSelect = false;
			this.lstOtherDetails.Name = "lstOtherDetails";
			this.lstOtherDetails.ShowGroups = false;
			this.lstOtherDetails.Size = new System.Drawing.Size(544, 372);
			this.lstOtherDetails.TabIndex = 0;
			this.lstOtherDetails.UseCompatibleStateImageBehavior = false;
			this.lstOtherDetails.View = System.Windows.Forms.View.Details;
			this.lstOtherDetails.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstOtherDetails_MouseDoubleClick);
			this.lstOtherDetails.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstOtherDetails_MouseClick);
			this.lstOtherDetails.SelectedIndexChanged += new System.EventHandler(this.lstOtherDetails_SelectedIndexChanged);
			this.lstOtherDetails.Enter += new System.EventHandler(this.lstOtherDetails_Enter);
			this.lstOtherDetails.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lstOtherDetails_ItemSelectionChanged);
			// 
			// columnHeader5
			// 
			this.columnHeader5.DisplayIndex = 1;
			this.columnHeader5.Text = "Value";
			this.columnHeader5.Width = 330;
			// 
			// columnHeader6
			// 
			this.columnHeader6.DisplayIndex = 0;
			this.columnHeader6.Text = "Name";
			this.columnHeader6.Width = 190;
			// 
			// tabPage5
			// 
			this.tabPage5.Controls.Add(this.btnLogoCommit);
			this.tabPage5.Controls.Add(this.grpLogo);
			this.tabPage5.Controls.Add(this.chkLogoEnabled);
			this.tabPage5.Controls.Add(this.label102);
			this.tabPage5.Location = new System.Drawing.Point(4, 22);
			this.tabPage5.Name = "tabPage5";
			this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage5.Size = new System.Drawing.Size(550, 418);
			this.tabPage5.TabIndex = 3;
			this.tabPage5.Text = "Logo";
			this.tabPage5.UseVisualStyleBackColor = true;
			// 
			// btnLogoCommit
			// 
			this.btnLogoCommit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnLogoCommit.Location = new System.Drawing.Point(472, 386);
			this.btnLogoCommit.Name = "btnLogoCommit";
			this.btnLogoCommit.Size = new System.Drawing.Size(75, 23);
			this.btnLogoCommit.TabIndex = 34;
			this.btnLogoCommit.Text = "Commit";
			this.btnLogoCommit.UseVisualStyleBackColor = true;
			this.btnLogoCommit.Click += new System.EventHandler(this.txtLogoCommit_Click);
			// 
			// grpLogo
			// 
			this.grpLogo.Controls.Add(this.label91);
			this.grpLogo.Controls.Add(this.label92);
			this.grpLogo.Controls.Add(this.txtLogoLowerRight);
			this.grpLogo.Controls.Add(this.txtLogoUpperLeft);
			this.grpLogo.Controls.Add(this.picLogoColour);
			this.grpLogo.Controls.Add(this.label97);
			this.grpLogo.Controls.Add(this.label98);
			this.grpLogo.Controls.Add(this.txtLogoKey);
			this.grpLogo.Controls.Add(this.label99);
			this.grpLogo.Controls.Add(this.txtLogoName);
			this.grpLogo.Controls.Add(this.label100);
			this.grpLogo.Controls.Add(this.txtLogoFilename);
			this.grpLogo.Enabled = false;
			this.grpLogo.Location = new System.Drawing.Point(6, 22);
			this.grpLogo.Name = "grpLogo";
			this.grpLogo.Size = new System.Drawing.Size(462, 161);
			this.grpLogo.TabIndex = 33;
			this.grpLogo.TabStop = false;
			// 
			// label91
			// 
			this.label91.AutoSize = true;
			this.label91.Location = new System.Drawing.Point(17, 96);
			this.label91.Name = "label91";
			this.label91.Size = new System.Drawing.Size(67, 13);
			this.label91.TabIndex = 22;
			this.label91.Text = "Lower Right:";
			// 
			// label92
			// 
			this.label92.AutoSize = true;
			this.label92.Location = new System.Drawing.Point(196, 96);
			this.label92.Name = "label92";
			this.label92.Size = new System.Drawing.Size(60, 13);
			this.label92.TabIndex = 21;
			this.label92.Text = "Upper Left:";
			// 
			// txtLogoLowerRight
			// 
			this.txtLogoLowerRight.Location = new System.Drawing.Point(90, 93);
			this.txtLogoLowerRight.Name = "txtLogoLowerRight";
			this.txtLogoLowerRight.Size = new System.Drawing.Size(100, 20);
			this.txtLogoLowerRight.TabIndex = 16;
			// 
			// txtLogoUpperLeft
			// 
			this.txtLogoUpperLeft.Location = new System.Drawing.Point(262, 93);
			this.txtLogoUpperLeft.Name = "txtLogoUpperLeft";
			this.txtLogoUpperLeft.Size = new System.Drawing.Size(100, 20);
			this.txtLogoUpperLeft.TabIndex = 15;
			// 
			// picLogoColour
			// 
			this.picLogoColour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.picLogoColour.Location = new System.Drawing.Point(412, 71);
			this.picLogoColour.Name = "picLogoColour";
			this.picLogoColour.Size = new System.Drawing.Size(22, 20);
			this.picLogoColour.TabIndex = 10;
			this.picLogoColour.TabStop = false;
			// 
			// label97
			// 
			this.label97.AutoSize = true;
			this.label97.Location = new System.Drawing.Point(369, 74);
			this.label97.Name = "label97";
			this.label97.Size = new System.Drawing.Size(40, 13);
			this.label97.TabIndex = 9;
			this.label97.Text = "Colour:";
			// 
			// label98
			// 
			this.label98.AutoSize = true;
			this.label98.Location = new System.Drawing.Point(33, 70);
			this.label98.Name = "label98";
			this.label98.Size = new System.Drawing.Size(28, 13);
			this.label98.TabIndex = 8;
			this.label98.Text = "Key:";
			// 
			// txtLogoKey
			// 
			this.txtLogoKey.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtLogoKey.Location = new System.Drawing.Point(67, 67);
			this.txtLogoKey.Name = "txtLogoKey";
			this.txtLogoKey.Size = new System.Drawing.Size(273, 20);
			this.txtLogoKey.TabIndex = 7;
			// 
			// label99
			// 
			this.label99.AutoSize = true;
			this.label99.Location = new System.Drawing.Point(23, 18);
			this.label99.Name = "label99";
			this.label99.Size = new System.Drawing.Size(38, 13);
			this.label99.TabIndex = 6;
			this.label99.Text = "Name:";
			// 
			// txtLogoName
			// 
			this.txtLogoName.Location = new System.Drawing.Point(67, 15);
			this.txtLogoName.Name = "txtLogoName";
			this.txtLogoName.Size = new System.Drawing.Size(366, 20);
			this.txtLogoName.TabIndex = 5;
			// 
			// label100
			// 
			this.label100.AutoSize = true;
			this.label100.Location = new System.Drawing.Point(9, 44);
			this.label100.Name = "label100";
			this.label100.Size = new System.Drawing.Size(52, 13);
			this.label100.TabIndex = 4;
			this.label100.Text = "Filename:";
			// 
			// txtLogoFilename
			// 
			this.txtLogoFilename.Location = new System.Drawing.Point(67, 41);
			this.txtLogoFilename.Name = "txtLogoFilename";
			this.txtLogoFilename.Size = new System.Drawing.Size(366, 20);
			this.txtLogoFilename.TabIndex = 3;
			// 
			// chkLogoEnabled
			// 
			this.chkLogoEnabled.AutoSize = true;
			this.chkLogoEnabled.Enabled = false;
			this.chkLogoEnabled.Location = new System.Drawing.Point(79, 6);
			this.chkLogoEnabled.Name = "chkLogoEnabled";
			this.chkLogoEnabled.Size = new System.Drawing.Size(65, 17);
			this.chkLogoEnabled.TabIndex = 32;
			this.chkLogoEnabled.Text = "Enabled";
			this.chkLogoEnabled.UseVisualStyleBackColor = true;
			this.chkLogoEnabled.CheckedChanged += new System.EventHandler(this.chkLogoEnabled_CheckedChanged);
			// 
			// label102
			// 
			this.label102.AutoSize = true;
			this.label102.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label102.Location = new System.Drawing.Point(32, 6);
			this.label102.Name = "label102";
			this.label102.Size = new System.Drawing.Size(39, 13);
			this.label102.TabIndex = 31;
			this.label102.Text = "Logo:";
			// 
			// tabPage6
			// 
			this.tabPage6.Controls.Add(this.picCustomThumbnail);
			this.tabPage6.Controls.Add(this.label108);
			this.tabPage6.Controls.Add(this.button11);
			this.tabPage6.Controls.Add(this.txtCustomThumbnailPath);
			this.tabPage6.Controls.Add(this.btnCustomThumbnail);
			this.tabPage6.Controls.Add(this.chkUseCustomThumbnail);
			this.tabPage6.Location = new System.Drawing.Point(4, 22);
			this.tabPage6.Name = "tabPage6";
			this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage6.Size = new System.Drawing.Size(550, 418);
			this.tabPage6.TabIndex = 4;
			this.tabPage6.Text = "Thumbnail";
			this.tabPage6.UseVisualStyleBackColor = true;
			// 
			// picCustomThumbnail
			// 
			this.picCustomThumbnail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.picCustomThumbnail.Location = new System.Drawing.Point(22, 101);
			this.picCustomThumbnail.Name = "picCustomThumbnail";
			this.picCustomThumbnail.Size = new System.Drawing.Size(256, 256);
			this.picCustomThumbnail.TabIndex = 5;
			this.picCustomThumbnail.TabStop = false;
			// 
			// label108
			// 
			this.label108.Location = new System.Drawing.Point(14, 78);
			this.label108.Name = "label108";
			this.label108.Size = new System.Drawing.Size(410, 23);
			this.label108.TabIndex = 4;
			this.label108.Text = "Custom Thumbnails must be 256x256, and in PNG format.";
			// 
			// button11
			// 
			this.button11.Location = new System.Drawing.Point(396, 39);
			this.button11.Name = "button11";
			this.button11.Size = new System.Drawing.Size(28, 23);
			this.button11.TabIndex = 3;
			this.button11.Text = "...";
			this.button11.UseVisualStyleBackColor = true;
			this.button11.Click += new System.EventHandler(this.button11_Click_1);
			// 
			// txtCustomThumbnailPath
			// 
			this.txtCustomThumbnailPath.Location = new System.Drawing.Point(17, 41);
			this.txtCustomThumbnailPath.Name = "txtCustomThumbnailPath";
			this.txtCustomThumbnailPath.Size = new System.Drawing.Size(373, 20);
			this.txtCustomThumbnailPath.TabIndex = 2;
			// 
			// btnCustomThumbnail
			// 
			this.btnCustomThumbnail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnCustomThumbnail.Location = new System.Drawing.Point(472, 386);
			this.btnCustomThumbnail.Name = "btnCustomThumbnail";
			this.btnCustomThumbnail.Size = new System.Drawing.Size(75, 23);
			this.btnCustomThumbnail.TabIndex = 1;
			this.btnCustomThumbnail.Text = "Commit";
			this.btnCustomThumbnail.UseVisualStyleBackColor = true;
			this.btnCustomThumbnail.Click += new System.EventHandler(this.btnCustomThumbnail_Click);
			// 
			// chkUseCustomThumbnail
			// 
			this.chkUseCustomThumbnail.AutoSize = true;
			this.chkUseCustomThumbnail.Location = new System.Drawing.Point(17, 18);
			this.chkUseCustomThumbnail.Name = "chkUseCustomThumbnail";
			this.chkUseCustomThumbnail.Size = new System.Drawing.Size(135, 17);
			this.chkUseCustomThumbnail.TabIndex = 0;
			this.chkUseCustomThumbnail.Text = "Has Custom Thumbnail";
			this.chkUseCustomThumbnail.UseVisualStyleBackColor = true;
			// 
			// listView1
			// 
			this.listView1.Enabled = false;
			this.listView1.FullRowSelect = true;
			this.listView1.GridLines = true;
			this.listView1.HideSelection = false;
			this.listView1.Location = new System.Drawing.Point(8, 6);
			this.listView1.MultiSelect = false;
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(393, 55);
			this.listView1.TabIndex = 0;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
			// 
			// btnAddNewDesign
			// 
			this.btnAddNewDesign.Enabled = false;
			this.btnAddNewDesign.Location = new System.Drawing.Point(294, 67);
			this.btnAddNewDesign.Name = "btnAddNewDesign";
			this.btnAddNewDesign.Size = new System.Drawing.Size(107, 23);
			this.btnAddNewDesign.TabIndex = 1;
			this.btnAddNewDesign.Text = "Add New Design";
			this.btnAddNewDesign.UseVisualStyleBackColor = true;
			this.btnAddNewDesign.Click += new System.EventHandler(this.btnAddNewDesign_Click);
			// 
			// btnDeleteDesign
			// 
			this.btnDeleteDesign.Enabled = false;
			this.btnDeleteDesign.Location = new System.Drawing.Point(9, 67);
			this.btnDeleteDesign.Name = "btnDeleteDesign";
			this.btnDeleteDesign.Size = new System.Drawing.Size(94, 23);
			this.btnDeleteDesign.TabIndex = 2;
			this.btnDeleteDesign.Text = "Delete Design";
			this.btnDeleteDesign.UseVisualStyleBackColor = true;
			this.btnDeleteDesign.Click += new System.EventHandler(this.btnDeleteDesign_Click);
			// 
			// btnGetOrigXML
			// 
			this.btnGetOrigXML.Location = new System.Drawing.Point(109, 67);
			this.btnGetOrigXML.Name = "btnGetOrigXML";
			this.btnGetOrigXML.Size = new System.Drawing.Size(83, 23);
			this.btnGetOrigXML.TabIndex = 3;
			this.btnGetOrigXML.Text = "Get Orig XML";
			this.btnGetOrigXML.UseVisualStyleBackColor = true;
			this.btnGetOrigXML.Visible = false;
			this.btnGetOrigXML.Click += new System.EventHandler(this.btnGetOrigXML_Click);
			// 
			// label69
			// 
			this.label69.Location = new System.Drawing.Point(407, 6);
			this.label69.Name = "label69";
			this.label69.Size = new System.Drawing.Size(157, 90);
			this.label69.TabIndex = 4;
			this.label69.Text = "\"Designs\" are a collection of Stencil, Pattern information and the textures that " +
				"make them up, grouped together.  Each \"Design\" will appear as a new thumbnail in" +
				" a row in CAS.";
			// 
			// tabPage11
			// 
			this.tabPage11.Controls.Add(this.groupBox4);
			this.tabPage11.Controls.Add(this.groupBox2);
			this.tabPage11.Location = new System.Drawing.Point(4, 22);
			this.tabPage11.Name = "tabPage11";
			this.tabPage11.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage11.Size = new System.Drawing.Size(570, 544);
			this.tabPage11.TabIndex = 6;
			this.tabPage11.Text = "Meshes";
			this.tabPage11.UseVisualStyleBackColor = true;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.lstMeshTGILinks);
			this.groupBox4.Controls.Add(this.btnMeshTGILinksFind);
			this.groupBox4.Location = new System.Drawing.Point(8, 6);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(556, 172);
			this.groupBox4.TabIndex = 26;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Mesh TGI Links:";
			// 
			// lstMeshTGILinks
			// 
			this.lstMeshTGILinks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)));
			this.lstMeshTGILinks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader11,
            this.columnHeader12});
			this.lstMeshTGILinks.FullRowSelect = true;
			this.lstMeshTGILinks.GridLines = true;
			this.lstMeshTGILinks.HideSelection = false;
			this.lstMeshTGILinks.Location = new System.Drawing.Point(9, 19);
			this.lstMeshTGILinks.MultiSelect = false;
			this.lstMeshTGILinks.Name = "lstMeshTGILinks";
			this.lstMeshTGILinks.ShowGroups = false;
			this.lstMeshTGILinks.Size = new System.Drawing.Size(442, 123);
			this.lstMeshTGILinks.TabIndex = 7;
			this.lstMeshTGILinks.UseCompatibleStateImageBehavior = false;
			this.lstMeshTGILinks.View = System.Windows.Forms.View.Details;
			this.lstMeshTGILinks.SelectedIndexChanged += new System.EventHandler(this.lstMeshTGILinks_SelectedIndexChanged);
			// 
			// columnHeader11
			// 
			this.columnHeader11.DisplayIndex = 1;
			this.columnHeader11.Text = "Value";
			this.columnHeader11.Width = 330;
			// 
			// columnHeader12
			// 
			this.columnHeader12.DisplayIndex = 0;
			this.columnHeader12.Text = "Name";
			this.columnHeader12.Width = 100;
			// 
			// btnMeshTGILinksFind
			// 
			this.btnMeshTGILinksFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnMeshTGILinksFind.Enabled = false;
			this.btnMeshTGILinksFind.Location = new System.Drawing.Point(9, 143);
			this.btnMeshTGILinksFind.Name = "btnMeshTGILinksFind";
			this.btnMeshTGILinksFind.Size = new System.Drawing.Size(36, 23);
			this.btnMeshTGILinksFind.TabIndex = 8;
			this.btnMeshTGILinksFind.Text = "find";
			this.btnMeshTGILinksFind.UseVisualStyleBackColor = true;
			this.btnMeshTGILinksFind.Click += new System.EventHandler(this.btnMeshTGILinksFind_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.panel1);
			this.groupBox2.Controls.Add(this.txtMeshNameCommit);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.txtMeshName);
			this.groupBox2.Controls.Add(this.label20);
			this.groupBox2.Location = new System.Drawing.Point(8, 184);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(556, 354);
			this.groupBox2.TabIndex = 25;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "New Mesh";
			// 
			// panel1
			// 
			this.panel1.AutoScroll = true;
			this.panel1.Controls.Add(this.button22);
			this.panel1.Controls.Add(this.txtMeshLod3_1);
			this.panel1.Controls.Add(this.label36);
			this.panel1.Controls.Add(this.button19);
			this.panel1.Controls.Add(this.button21);
			this.panel1.Controls.Add(this.txtMeshLod2_2);
			this.panel1.Controls.Add(this.label34);
			this.panel1.Controls.Add(this.txtMeshLod2_1);
			this.panel1.Controls.Add(this.label35);
			this.panel1.Controls.Add(this.label33);
			this.panel1.Controls.Add(this.label29);
			this.panel1.Controls.Add(this.button9);
			this.panel1.Controls.Add(this.txtMeshLod0);
			this.panel1.Controls.Add(this.button10);
			this.panel1.Controls.Add(this.button14);
			this.panel1.Controls.Add(this.txtMeshLod0_3);
			this.panel1.Controls.Add(this.label30);
			this.panel1.Controls.Add(this.txtMeshLod0_2);
			this.panel1.Controls.Add(this.button15);
			this.panel1.Controls.Add(this.label31);
			this.panel1.Controls.Add(this.txtMeshLod0_1);
			this.panel1.Controls.Add(this.label32);
			this.panel1.Controls.Add(this.label18);
			this.panel1.Controls.Add(this.button8);
			this.panel1.Controls.Add(this.txtMeshLod1);
			this.panel1.Controls.Add(this.button3);
			this.panel1.Controls.Add(this.txtMeshLod2);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.txtMeshLod3);
			this.panel1.Controls.Add(this.txtMeshLod1_3);
			this.panel1.Controls.Add(this.label16);
			this.panel1.Controls.Add(this.label28);
			this.panel1.Controls.Add(this.label17);
			this.panel1.Controls.Add(this.txtMeshLod1_2);
			this.panel1.Controls.Add(this.button18);
			this.panel1.Controls.Add(this.label27);
			this.panel1.Controls.Add(this.button17);
			this.panel1.Controls.Add(this.txtMeshLod1_1);
			this.panel1.Controls.Add(this.button16);
			this.panel1.Controls.Add(this.label26);
			this.panel1.Controls.Add(this.label21);
			this.panel1.Controls.Add(this.button33);
			this.panel1.Controls.Add(this.txtOtherBumpMap);
			this.panel1.Controls.Add(this.button20);
			this.panel1.Location = new System.Drawing.Point(9, 75);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(541, 273);
			this.panel1.TabIndex = 50;
			// 
			// button22
			// 
			this.button22.Location = new System.Drawing.Point(367, 384);
			this.button22.Name = "button22";
			this.button22.Size = new System.Drawing.Size(26, 23);
			this.button22.TabIndex = 71;
			this.button22.Text = "...";
			this.button22.UseVisualStyleBackColor = true;
			this.button22.Click += new System.EventHandler(this.button22_Click);
			// 
			// txtMeshLod3_1
			// 
			this.txtMeshLod3_1.Location = new System.Drawing.Point(126, 384);
			this.txtMeshLod3_1.Name = "txtMeshLod3_1";
			this.txtMeshLod3_1.Size = new System.Drawing.Size(236, 20);
			this.txtMeshLod3_1.TabIndex = 70;
			// 
			// label36
			// 
			this.label36.AutoSize = true;
			this.label36.Location = new System.Drawing.Point(69, 389);
			this.label36.Name = "label36";
			this.label36.Size = new System.Drawing.Size(50, 13);
			this.label36.TabIndex = 69;
			this.label36.Text = "LOD3_1:";
			// 
			// button19
			// 
			this.button19.Location = new System.Drawing.Point(367, 328);
			this.button19.Name = "button19";
			this.button19.Size = new System.Drawing.Size(26, 23);
			this.button19.TabIndex = 68;
			this.button19.Text = "...";
			this.button19.UseVisualStyleBackColor = true;
			this.button19.Click += new System.EventHandler(this.button19_Click);
			// 
			// button21
			// 
			this.button21.Location = new System.Drawing.Point(367, 300);
			this.button21.Name = "button21";
			this.button21.Size = new System.Drawing.Size(26, 23);
			this.button21.TabIndex = 67;
			this.button21.Text = "...";
			this.button21.UseVisualStyleBackColor = true;
			this.button21.Click += new System.EventHandler(this.button21_Click);
			// 
			// txtMeshLod2_2
			// 
			this.txtMeshLod2_2.Location = new System.Drawing.Point(126, 328);
			this.txtMeshLod2_2.Name = "txtMeshLod2_2";
			this.txtMeshLod2_2.Size = new System.Drawing.Size(236, 20);
			this.txtMeshLod2_2.TabIndex = 66;
			this.txtMeshLod2_2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// label34
			// 
			this.label34.AutoSize = true;
			this.label34.Location = new System.Drawing.Point(69, 333);
			this.label34.Name = "label34";
			this.label34.Size = new System.Drawing.Size(50, 13);
			this.label34.TabIndex = 65;
			this.label34.Text = "LOD2_2:";
			// 
			// txtMeshLod2_1
			// 
			this.txtMeshLod2_1.Location = new System.Drawing.Point(125, 302);
			this.txtMeshLod2_1.Name = "txtMeshLod2_1";
			this.txtMeshLod2_1.Size = new System.Drawing.Size(236, 20);
			this.txtMeshLod2_1.TabIndex = 64;
			// 
			// label35
			// 
			this.label35.AutoSize = true;
			this.label35.Location = new System.Drawing.Point(69, 305);
			this.label35.Name = "label35";
			this.label35.Size = new System.Drawing.Size(50, 13);
			this.label35.TabIndex = 63;
			this.label35.Text = "LOD2_1:";
			// 
			// label33
			// 
			this.label33.AutoSize = true;
			this.label33.Location = new System.Drawing.Point(69, 14);
			this.label33.Name = "label33";
			this.label33.Size = new System.Drawing.Size(307, 13);
			this.label33.TabIndex = 62;
			this.label33.Text = "Note: You only need LOD0 if you are doing Hair or Accessories!";
			// 
			// label29
			// 
			this.label29.AutoSize = true;
			this.label29.Location = new System.Drawing.Point(29, 47);
			this.label29.Name = "label29";
			this.label29.Size = new System.Drawing.Size(38, 13);
			this.label29.TabIndex = 50;
			this.label29.Text = "LOD0:";
			// 
			// button9
			// 
			this.button9.Location = new System.Drawing.Point(368, 129);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(26, 23);
			this.button9.TabIndex = 61;
			this.button9.Text = "...";
			this.button9.UseVisualStyleBackColor = true;
			this.button9.Click += new System.EventHandler(this.button9_Click_1);
			// 
			// txtMeshLod0
			// 
			this.txtMeshLod0.Location = new System.Drawing.Point(73, 44);
			this.txtMeshLod0.Name = "txtMeshLod0";
			this.txtMeshLod0.Size = new System.Drawing.Size(289, 20);
			this.txtMeshLod0.TabIndex = 51;
			// 
			// button10
			// 
			this.button10.Location = new System.Drawing.Point(368, 100);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(26, 23);
			this.button10.TabIndex = 60;
			this.button10.Text = "...";
			this.button10.UseVisualStyleBackColor = true;
			this.button10.Click += new System.EventHandler(this.button10_Click);
			// 
			// button14
			// 
			this.button14.Location = new System.Drawing.Point(368, 71);
			this.button14.Name = "button14";
			this.button14.Size = new System.Drawing.Size(26, 23);
			this.button14.TabIndex = 59;
			this.button14.Text = "...";
			this.button14.UseVisualStyleBackColor = true;
			this.button14.Click += new System.EventHandler(this.button14_Click);
			// 
			// txtMeshLod0_3
			// 
			this.txtMeshLod0_3.Location = new System.Drawing.Point(126, 129);
			this.txtMeshLod0_3.Name = "txtMeshLod0_3";
			this.txtMeshLod0_3.Size = new System.Drawing.Size(236, 20);
			this.txtMeshLod0_3.TabIndex = 58;
			// 
			// label30
			// 
			this.label30.AutoSize = true;
			this.label30.Location = new System.Drawing.Point(70, 132);
			this.label30.Name = "label30";
			this.label30.Size = new System.Drawing.Size(50, 13);
			this.label30.TabIndex = 57;
			this.label30.Text = "LOD0_3:";
			// 
			// txtMeshLod0_2
			// 
			this.txtMeshLod0_2.Location = new System.Drawing.Point(126, 101);
			this.txtMeshLod0_2.Name = "txtMeshLod0_2";
			this.txtMeshLod0_2.Size = new System.Drawing.Size(236, 20);
			this.txtMeshLod0_2.TabIndex = 56;
			this.txtMeshLod0_2.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
			// 
			// button15
			// 
			this.button15.Location = new System.Drawing.Point(368, 42);
			this.button15.Name = "button15";
			this.button15.Size = new System.Drawing.Size(26, 23);
			this.button15.TabIndex = 52;
			this.button15.Text = "...";
			this.button15.UseVisualStyleBackColor = true;
			this.button15.Click += new System.EventHandler(this.button15_Click);
			// 
			// label31
			// 
			this.label31.AutoSize = true;
			this.label31.Location = new System.Drawing.Point(70, 104);
			this.label31.Name = "label31";
			this.label31.Size = new System.Drawing.Size(50, 13);
			this.label31.TabIndex = 55;
			this.label31.Text = "LOD0_2:";
			// 
			// txtMeshLod0_1
			// 
			this.txtMeshLod0_1.Location = new System.Drawing.Point(126, 73);
			this.txtMeshLod0_1.Name = "txtMeshLod0_1";
			this.txtMeshLod0_1.Size = new System.Drawing.Size(236, 20);
			this.txtMeshLod0_1.TabIndex = 54;
			this.txtMeshLod0_1.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
			// 
			// label32
			// 
			this.label32.AutoSize = true;
			this.label32.Location = new System.Drawing.Point(70, 76);
			this.label32.Name = "label32";
			this.label32.Size = new System.Drawing.Size(50, 13);
			this.label32.TabIndex = 53;
			this.label32.Text = "LOD0_1:";
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(29, 163);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(38, 13);
			this.label18.TabIndex = 14;
			this.label18.Text = "LOD1:";
			// 
			// button8
			// 
			this.button8.Location = new System.Drawing.Point(368, 242);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(26, 23);
			this.button8.TabIndex = 49;
			this.button8.Text = "...";
			this.button8.UseVisualStyleBackColor = true;
			this.button8.Click += new System.EventHandler(this.button8_Click_1);
			// 
			// txtMeshLod1
			// 
			this.txtMeshLod1.Location = new System.Drawing.Point(73, 160);
			this.txtMeshLod1.Name = "txtMeshLod1";
			this.txtMeshLod1.Size = new System.Drawing.Size(289, 20);
			this.txtMeshLod1.TabIndex = 18;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(368, 215);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(26, 23);
			this.button3.TabIndex = 48;
			this.button3.Text = "...";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click_1);
			// 
			// txtMeshLod2
			// 
			this.txtMeshLod2.Location = new System.Drawing.Point(72, 273);
			this.txtMeshLod2.Name = "txtMeshLod2";
			this.txtMeshLod2.Size = new System.Drawing.Size(290, 20);
			this.txtMeshLod2.TabIndex = 19;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(368, 186);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(26, 23);
			this.button2.TabIndex = 47;
			this.button2.Text = "...";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// txtMeshLod3
			// 
			this.txtMeshLod3.Location = new System.Drawing.Point(72, 358);
			this.txtMeshLod3.Name = "txtMeshLod3";
			this.txtMeshLod3.Size = new System.Drawing.Size(290, 20);
			this.txtMeshLod3.TabIndex = 20;
			// 
			// txtMeshLod1_3
			// 
			this.txtMeshLod1_3.Location = new System.Drawing.Point(126, 244);
			this.txtMeshLod1_3.Name = "txtMeshLod1_3";
			this.txtMeshLod1_3.Size = new System.Drawing.Size(236, 20);
			this.txtMeshLod1_3.TabIndex = 46;
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(29, 361);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(38, 13);
			this.label16.TabIndex = 16;
			this.label16.Text = "LOD3:";
			// 
			// label28
			// 
			this.label28.AutoSize = true;
			this.label28.Location = new System.Drawing.Point(70, 247);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(50, 13);
			this.label28.TabIndex = 45;
			this.label28.Text = "LOD1_3:";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(29, 276);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(38, 13);
			this.label17.TabIndex = 15;
			this.label17.Text = "LOD2:";
			// 
			// txtMeshLod1_2
			// 
			this.txtMeshLod1_2.Location = new System.Drawing.Point(126, 216);
			this.txtMeshLod1_2.Name = "txtMeshLod1_2";
			this.txtMeshLod1_2.Size = new System.Drawing.Size(236, 20);
			this.txtMeshLod1_2.TabIndex = 44;
			// 
			// button18
			// 
			this.button18.Location = new System.Drawing.Point(368, 158);
			this.button18.Name = "button18";
			this.button18.Size = new System.Drawing.Size(26, 23);
			this.button18.TabIndex = 22;
			this.button18.Text = "...";
			this.button18.UseVisualStyleBackColor = true;
			this.button18.Click += new System.EventHandler(this.button18_Click);
			// 
			// label27
			// 
			this.label27.AutoSize = true;
			this.label27.Location = new System.Drawing.Point(70, 219);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(50, 13);
			this.label27.TabIndex = 43;
			this.label27.Text = "LOD1_2:";
			// 
			// button17
			// 
			this.button17.Location = new System.Drawing.Point(368, 271);
			this.button17.Name = "button17";
			this.button17.Size = new System.Drawing.Size(26, 23);
			this.button17.TabIndex = 23;
			this.button17.Text = "...";
			this.button17.UseVisualStyleBackColor = true;
			this.button17.Click += new System.EventHandler(this.button17_Click);
			// 
			// txtMeshLod1_1
			// 
			this.txtMeshLod1_1.Location = new System.Drawing.Point(126, 188);
			this.txtMeshLod1_1.Name = "txtMeshLod1_1";
			this.txtMeshLod1_1.Size = new System.Drawing.Size(236, 20);
			this.txtMeshLod1_1.TabIndex = 42;
			// 
			// button16
			// 
			this.button16.Location = new System.Drawing.Point(368, 356);
			this.button16.Name = "button16";
			this.button16.Size = new System.Drawing.Size(26, 23);
			this.button16.TabIndex = 24;
			this.button16.Text = "...";
			this.button16.UseVisualStyleBackColor = true;
			this.button16.Click += new System.EventHandler(this.button16_Click);
			// 
			// label26
			// 
			this.label26.AutoSize = true;
			this.label26.Location = new System.Drawing.Point(70, 191);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(50, 13);
			this.label26.TabIndex = 41;
			this.label26.Text = "LOD1_1:";
			// 
			// label21
			// 
			this.label21.AutoSize = true;
			this.label21.Location = new System.Drawing.Point(6, 418);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(61, 13);
			this.label21.TabIndex = 37;
			this.label21.Text = "Bump Map:";
			// 
			// button33
			// 
			this.button33.Location = new System.Drawing.Point(400, 411);
			this.button33.Name = "button33";
			this.button33.Size = new System.Drawing.Size(43, 23);
			this.button33.TabIndex = 40;
			this.button33.Text = "find";
			this.button33.UseVisualStyleBackColor = true;
			this.button33.Click += new System.EventHandler(this.button33_Click);
			// 
			// txtOtherBumpMap
			// 
			this.txtOtherBumpMap.Location = new System.Drawing.Point(72, 415);
			this.txtOtherBumpMap.Name = "txtOtherBumpMap";
			this.txtOtherBumpMap.Size = new System.Drawing.Size(290, 20);
			this.txtOtherBumpMap.TabIndex = 38;
			// 
			// button20
			// 
			this.button20.Location = new System.Drawing.Point(368, 411);
			this.button20.Name = "button20";
			this.button20.Size = new System.Drawing.Size(26, 23);
			this.button20.TabIndex = 39;
			this.button20.Text = "...";
			this.button20.UseVisualStyleBackColor = true;
			this.button20.Click += new System.EventHandler(this.button20_Click);
			// 
			// txtMeshNameCommit
			// 
			this.txtMeshNameCommit.Location = new System.Drawing.Point(360, 47);
			this.txtMeshNameCommit.Name = "txtMeshNameCommit";
			this.txtMeshNameCommit.Size = new System.Drawing.Size(75, 23);
			this.txtMeshNameCommit.TabIndex = 5;
			this.txtMeshNameCommit.Text = "Commit";
			this.txtMeshNameCommit.UseVisualStyleBackColor = true;
			this.txtMeshNameCommit.Click += new System.EventHandler(this.txtMeshNameCommit_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(20, 52);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(67, 13);
			this.label7.TabIndex = 4;
			this.label7.Text = "Mesh Name:";
			// 
			// txtMeshName
			// 
			this.txtMeshName.Location = new System.Drawing.Point(93, 49);
			this.txtMeshName.Name = "txtMeshName";
			this.txtMeshName.Size = new System.Drawing.Size(261, 20);
			this.txtMeshName.TabIndex = 3;
			// 
			// label20
			// 
			this.label20.Location = new System.Drawing.Point(6, 17);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(445, 33);
			this.label20.TabIndex = 0;
			this.label20.Text = "If you want this CAS Part to have a new mesh, please CHANGE the name and find you" +
				"r mesh LODs using the boxes below.";
			// 
			// tabPage14
			// 
			this.tabPage14.Controls.Add(this.btnDesignTypeCommit);
			this.tabPage14.Controls.Add(this.label22);
			this.tabPage14.Controls.Add(this.chkDesignType);
			this.tabPage14.Location = new System.Drawing.Point(4, 22);
			this.tabPage14.Name = "tabPage14";
			this.tabPage14.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage14.Size = new System.Drawing.Size(570, 544);
			this.tabPage14.TabIndex = 7;
			this.tabPage14.Text = "Other";
			this.tabPage14.UseVisualStyleBackColor = true;
			// 
			// btnDesignTypeCommit
			// 
			this.btnDesignTypeCommit.Location = new System.Drawing.Point(133, 117);
			this.btnDesignTypeCommit.Name = "btnDesignTypeCommit";
			this.btnDesignTypeCommit.Size = new System.Drawing.Size(75, 23);
			this.btnDesignTypeCommit.TabIndex = 2;
			this.btnDesignTypeCommit.Text = "Commit";
			this.btnDesignTypeCommit.UseVisualStyleBackColor = true;
			this.btnDesignTypeCommit.Click += new System.EventHandler(this.btnDesignTypeCommit_Click);
			// 
			// label22
			// 
			this.label22.AutoSize = true;
			this.label22.Location = new System.Drawing.Point(16, 17);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(66, 13);
			this.label22.TabIndex = 1;
			this.label22.Text = "Design type:";
			// 
			// chkDesignType
			// 
			this.chkDesignType.FormattingEnabled = true;
			this.chkDesignType.Items.AddRange(new object[] {
            "3 channel RGB",
            "4 channel RGBA",
            "Tintable Overlay"});
			this.chkDesignType.Location = new System.Drawing.Point(88, 17);
			this.chkDesignType.Name = "chkDesignType";
			this.chkDesignType.Size = new System.Drawing.Size(120, 94);
			this.chkDesignType.TabIndex = 0;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.BackColor = System.Drawing.SystemColors.Menu;
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewBlankToolStripMenuItem,
            this.copyDefaultsToolStripMenuItem,
            this.addNewCopyLastToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
			this.contextMenuStrip1.Size = new System.Drawing.Size(187, 70);
			// 
			// addNewBlankToolStripMenuItem
			// 
			this.addNewBlankToolStripMenuItem.Name = "addNewBlankToolStripMenuItem";
			this.addNewBlankToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
			this.addNewBlankToolStripMenuItem.Text = "Add New Blank";
			this.addNewBlankToolStripMenuItem.Click += new System.EventHandler(this.addNewBlankToolStripMenuItem_Click);
			// 
			// copyDefaultsToolStripMenuItem
			// 
			this.copyDefaultsToolStripMenuItem.Name = "copyDefaultsToolStripMenuItem";
			this.copyDefaultsToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
			this.copyDefaultsToolStripMenuItem.Text = "Copy All From Base";
			this.copyDefaultsToolStripMenuItem.Click += new System.EventHandler(this.copyDefaultsToolStripMenuItem_Click);
			// 
			// addNewCopyLastToolStripMenuItem
			// 
			this.addNewCopyLastToolStripMenuItem.Name = "addNewCopyLastToolStripMenuItem";
			this.addNewCopyLastToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
			this.addNewCopyLastToolStripMenuItem.Text = "Add New (Copy Last)";
			this.addNewCopyLastToolStripMenuItem.Click += new System.EventHandler(this.addNewCopyLastToolStripMenuItem_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Location = new System.Drawing.Point(159, 356);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(25, 23);
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			// 
			// label113
			// 
			this.label113.AutoSize = true;
			this.label113.Location = new System.Drawing.Point(113, 361);
			this.label113.Name = "label113";
			this.label113.Size = new System.Drawing.Size(40, 13);
			this.label113.TabIndex = 5;
			this.label113.Text = "Colour:";
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(501, 356);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 23);
			this.button4.TabIndex = 3;
			this.button4.Text = "Commit";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// button5
			// 
			this.button5.Enabled = false;
			this.button5.Location = new System.Drawing.Point(45, 356);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(51, 23);
			this.button5.TabIndex = 2;
			this.button5.Text = "replace";
			this.button5.UseVisualStyleBackColor = true;
			// 
			// button6
			// 
			this.button6.Enabled = false;
			this.button6.Location = new System.Drawing.Point(3, 356);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(36, 23);
			this.button6.TabIndex = 1;
			this.button6.Text = "find";
			this.button6.UseVisualStyleBackColor = true;
			// 
			// listView2
			// 
			this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
			this.listView2.GridLines = true;
			this.listView2.LabelEdit = true;
			this.listView2.Location = new System.Drawing.Point(3, 8);
			this.listView2.MultiSelect = false;
			this.listView2.Name = "listView2";
			this.listView2.Size = new System.Drawing.Size(586, 342);
			this.listView2.TabIndex = 0;
			this.listView2.UseCompatibleStateImageBehavior = false;
			this.listView2.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader3
			// 
			this.columnHeader3.DisplayIndex = 1;
			this.columnHeader3.Text = "Value";
			this.columnHeader3.Width = 350;
			// 
			// columnHeader4
			// 
			this.columnHeader4.DisplayIndex = 0;
			this.columnHeader4.Text = "Name";
			this.columnHeader4.Width = 160;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(0, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 23);
			this.label9.TabIndex = 0;
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(0, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(100, 23);
			this.label10.TabIndex = 0;
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(0, 0);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(100, 23);
			this.label12.TabIndex = 0;
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(0, 0);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(100, 23);
			this.label13.TabIndex = 0;
			// 
			// label14
			// 
			this.label14.Location = new System.Drawing.Point(0, 0);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(100, 23);
			this.label14.TabIndex = 0;
			// 
			// bwGenTexture
			// 
			this.bwGenTexture.WorkerSupportsCancellation = true;
			this.bwGenTexture.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwGenTexture_DoWork);
			this.bwGenTexture.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwGenTexture_RunWorkerCompleted);
			// 
			// btnStart3D
			// 
			this.btnStart3D.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnStart3D.Location = new System.Drawing.Point(794, 24);
			this.btnStart3D.Name = "btnStart3D";
			this.btnStart3D.Size = new System.Drawing.Size(75, 23);
			this.btnStart3D.TabIndex = 26;
			this.btnStart3D.Text = "Reload 3D";
			this.btnStart3D.UseVisualStyleBackColor = true;
			this.btnStart3D.Visible = false;
			this.btnStart3D.Click += new System.EventHandler(this.btnStart3D_Click);
			// 
			// btnReloadTextures
			// 
			this.btnReloadTextures.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnReloadTextures.Location = new System.Drawing.Point(875, 24);
			this.btnReloadTextures.Name = "btnReloadTextures";
			this.btnReloadTextures.Size = new System.Drawing.Size(115, 23);
			this.btnReloadTextures.TabIndex = 24;
			this.btnReloadTextures.Text = "Reload Textures";
			this.btnReloadTextures.UseVisualStyleBackColor = true;
			this.btnReloadTextures.Visible = false;
			this.btnReloadTextures.Click += new System.EventHandler(this.btnReloadTextures_Click);
			// 
			// cEnable3DPreview
			// 
			this.cEnable3DPreview.AutoSize = true;
			this.cEnable3DPreview.Checked = true;
			this.cEnable3DPreview.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cEnable3DPreview.Location = new System.Drawing.Point(455, 30);
			this.cEnable3DPreview.Name = "cEnable3DPreview";
			this.cEnable3DPreview.Size = new System.Drawing.Size(117, 17);
			this.cEnable3DPreview.TabIndex = 27;
			this.cEnable3DPreview.Text = "Enable 3D Preview";
			this.cEnable3DPreview.UseVisualStyleBackColor = true;
			this.cEnable3DPreview.CheckedChanged += new System.EventHandler(this.cEnable3DPreview_CheckedChanged);
			// 
			// btnResetView
			// 
			this.btnResetView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnResetView.Location = new System.Drawing.Point(713, 24);
			this.btnResetView.Name = "btnResetView";
			this.btnResetView.Size = new System.Drawing.Size(75, 23);
			this.btnResetView.TabIndex = 28;
			this.btnResetView.Text = "ResetView";
			this.btnResetView.UseVisualStyleBackColor = true;
			this.btnResetView.Visible = false;
			this.btnResetView.Click += new System.EventHandler(this.btnResetView_Click);
			// 
			// contextMenuStrip2
			// 
			this.contextMenuStrip2.BackColor = System.Drawing.SystemColors.Menu;
			this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.toolStripMenuItem3,
            this.findImageToolStripMenuItem,
            this.replaceImageToolStripMenuItem,
            this.toolStripMenuItem4,
            this.editColourToolStripMenuItem});
			this.contextMenuStrip2.Name = "contextMenuStrip2";
			this.contextMenuStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
			this.contextMenuStrip2.Size = new System.Drawing.Size(161, 104);
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
			this.editToolStripMenuItem.Text = "Edit";
			this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new System.Drawing.Size(157, 6);
			// 
			// findImageToolStripMenuItem
			// 
			this.findImageToolStripMenuItem.Name = "findImageToolStripMenuItem";
			this.findImageToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
			this.findImageToolStripMenuItem.Text = "Find Image";
			this.findImageToolStripMenuItem.Click += new System.EventHandler(this.findImageToolStripMenuItem_Click);
			// 
			// replaceImageToolStripMenuItem
			// 
			this.replaceImageToolStripMenuItem.Name = "replaceImageToolStripMenuItem";
			this.replaceImageToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
			this.replaceImageToolStripMenuItem.Text = "Replace Image...";
			this.replaceImageToolStripMenuItem.Click += new System.EventHandler(this.replaceImageToolStripMenuItem_Click);
			// 
			// toolStripMenuItem4
			// 
			this.toolStripMenuItem4.Name = "toolStripMenuItem4";
			this.toolStripMenuItem4.Size = new System.Drawing.Size(157, 6);
			// 
			// editColourToolStripMenuItem
			// 
			this.editColourToolStripMenuItem.Name = "editColourToolStripMenuItem";
			this.editColourToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
			this.editColourToolStripMenuItem.Text = "Edit Colour";
			this.editColourToolStripMenuItem.Click += new System.EventHandler(this.editColourToolStripMenuItem_Click);
			// 
			// renderWindow1
			// 
			this.renderWindow1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.renderWindow1.BackColor = System.Drawing.Color.White;
			this.renderWindow1.BackgroundColour = System.Drawing.Color.Empty;
			this.renderWindow1.CurrentFillMode = 1;
			this.renderWindow1.Location = new System.Drawing.Point(579, 47);
			this.renderWindow1.Name = "renderWindow1";
			this.renderWindow1.RenderEnabled = false;
			this.renderWindow1.Size = new System.Drawing.Size(411, 548);
			this.renderWindow1.TabIndex = 25;
			this.renderWindow1.WireframeColour = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
			this.renderWindow1.RequireNewTextures += new System.EventHandler(this.renderWindow1_RequireNewTextures);
			// 
			// button23
			// 
			this.button23.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button23.Location = new System.Drawing.Point(632, 24);
			this.button23.Name = "button23";
			this.button23.Size = new System.Drawing.Size(75, 23);
			this.button23.TabIndex = 29;
			this.button23.Text = "Get Texture";
			this.button23.UseVisualStyleBackColor = true;
			this.button23.Click += new System.EventHandler(this.button23_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(992, 623);
			this.Controls.Add(this.button23);
			this.Controls.Add(this.cEnable3DPreview);
			this.Controls.Add(this.tabControl3);
			this.Controls.Add(this.renderWindow1);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.btnReloadTextures);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.btnStart3D);
			this.Controls.Add(this.btnResetView);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.MinimumSize = new System.Drawing.Size(1000, 650);
			this.Name = "Form1";
			this.Text = "CAS Texture+Unitool";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.tabControl3.ResumeLayout(false);
			this.tabPage7.ResumeLayout(false);
			this.groupBox11.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picMeshPreview)).EndInit();
			this.tabPage9.ResumeLayout(false);
			this.tabPage10.ResumeLayout(false);
			this.tabPage10.PerformLayout();
			this.tabPage4.ResumeLayout(false);
			this.tabPage8.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.grpPatternA.ResumeLayout(false);
			this.grpPatternA.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picPatternThumb)).EndInit();
			this.groupBox7.ResumeLayout(false);
			this.groupBox7.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picPatternColour4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picPatternColour2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picPatternColour3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picPatternColourBg)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picPatternColour1)).EndInit();
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picHSVColorChannel3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picHSVColorChannel2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picHSVColorChannel1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picHSVColorBG)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picPatternSolidColour)).EndInit();
			this.tabPage13.ResumeLayout(false);
			this.tabPage13.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picLstTextureColour)).EndInit();
			this.tabPage3.ResumeLayout(false);
			this.tabPage3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picLstOtherColour)).EndInit();
			this.tabPage5.ResumeLayout(false);
			this.tabPage5.PerformLayout();
			this.grpLogo.ResumeLayout(false);
			this.grpLogo.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picLogoColour)).EndInit();
			this.tabPage6.ResumeLayout(false);
			this.tabPage6.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picCustomThumbnail)).EndInit();
			this.tabPage11.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.tabPage14.ResumeLayout(false);
			this.tabPage14.PerformLayout();
			this.contextMenuStrip1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.contextMenuStrip2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDumpFromFullbuild2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCasPartInstance;
        private System.Windows.Forms.TextBox txtCasPartName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMeshName;
        private System.Windows.Forms.ComboBox cmbSimGender;
        private System.Windows.Forms.ComboBox cmbSimAge;
        private System.Windows.Forms.ComboBox cmbPartTypes;
        private System.Windows.Forms.Label label87;
        private System.Windows.Forms.ListView lstCasPartDetails;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cmbPatternSelect;
        private System.Windows.Forms.GroupBox grpPatternA;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.PictureBox picPatternColour4;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.PictureBox picPatternColour2;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.PictureBox picPatternColour3;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.PictureBox picPatternColourBg;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.PictureBox picPatternColour1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.TextBox txtPatternAFilename;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.PictureBox picPatternSolidColour;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.ComboBox cmbPatternAType;
        private System.Windows.Forms.TextBox txtPatternAName;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Button btnPatternAReplaceSpec;
        private System.Windows.Forms.Button btnPatternAReplaceRGBMask;
        private System.Windows.Forms.CheckBox chkPatternAEnabled;
        private System.Windows.Forms.Button btnPatternAFindSpec;
        private System.Windows.Forms.TextBox txtPatternASpecular;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Button btnPatternAFindRGBMask;
        private System.Windows.Forms.TextBox txtPatternARGBMask;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.TextBox txtPatternAKey;
        private System.Windows.Forms.CheckBox chkPatternALinked;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.TextBox txtPatternATiling;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Button btnPatternACommit;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnCommitLstOther;
        private System.Windows.Forms.Button btnLstOtherReplace;
        private System.Windows.Forms.Button btnListOtherFind;
        private System.Windows.Forms.ListView lstOtherDetails;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btnGetOrigXML;
        private System.Windows.Forms.Button btnDeleteDesign;
        private System.Windows.Forms.Button btnAddNewDesign;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.GroupBox grpLogo;
        private System.Windows.Forms.Button btnLogoCommit;
        private System.Windows.Forms.Label label91;
        private System.Windows.Forms.Label label92;
        private System.Windows.Forms.TextBox txtLogoLowerRight;
        private System.Windows.Forms.TextBox txtLogoUpperLeft;
        private System.Windows.Forms.PictureBox picLogoColour;
        private System.Windows.Forms.Label label97;
        private System.Windows.Forms.Label label98;
        private System.Windows.Forms.TextBox txtLogoKey;
        private System.Windows.Forms.Label label99;
        private System.Windows.Forms.TextBox txtLogoName;
        private System.Windows.Forms.Label label100;
        private System.Windows.Forms.TextBox txtLogoFilename;
        private System.Windows.Forms.CheckBox chkLogoEnabled;
        private System.Windows.Forms.Label label102;
        private System.Windows.Forms.PictureBox picMeshPreview;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.TabPage tabPage10;
        private System.Windows.Forms.Button btnCategoryDetailsCommit;
        private System.Windows.Forms.CheckedListBox checkedListCategoryExtended;
        private System.Windows.Forms.Label label95;
        private System.Windows.Forms.CheckedListBox checkedListCategory;
        private System.Windows.Forms.CheckedListBox checkedListOther;
        private System.Windows.Forms.Label label94;
        private System.Windows.Forms.CheckedListBox checkedListGender;
        private System.Windows.Forms.CheckedListBox checkedListAge;
        private System.Windows.Forms.CheckedListBox checkedListType;
        private System.Windows.Forms.Label label93;
        private System.Windows.Forms.Label label90;
        private System.Windows.Forms.Label label89;
        private System.Windows.Forms.Label label88;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox picLstOtherColour;
        private System.Windows.Forms.Button btnCasPartDetailsCommit;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ComboBox cmbPatternStencil1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnPatternStencil1Preview;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem findKeyToolStripMenuItem;
        private System.Windows.Forms.Button btnPatternStencil2Preview;
        private System.Windows.Forms.ComboBox cmbPatternStencil2;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Button btnPatternStencil6Preview;
        private System.Windows.Forms.ComboBox cmbPatternStencil6;
        private System.Windows.Forms.Label label106;
        private System.Windows.Forms.Button btnPatternStencil5Preview;
        private System.Windows.Forms.Label label107;
        private System.Windows.Forms.ComboBox cmbPatternStencil5;
        private System.Windows.Forms.Button btnPatternStencil4Preview;
        private System.Windows.Forms.ComboBox cmbPatternStencil4;
        private System.Windows.Forms.Label label104;
        private System.Windows.Forms.Button btnPatternStencil3Preview;
        private System.Windows.Forms.Label label105;
        private System.Windows.Forms.ComboBox cmbPatternStencil3;
        private System.Windows.Forms.Button btnDesignStencilCommit;
        private System.Windows.Forms.Button btnExtractMeshes;
        private System.Windows.Forms.Button btnGetNewXML;
        private System.Windows.Forms.Button btnBrowsePatterns;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.TextBox txtCustomThumbnailPath;
        private System.Windows.Forms.Button btnCustomThumbnail;
        private System.Windows.Forms.CheckBox chkUseCustomThumbnail;
        private System.Windows.Forms.Label label108;
        private System.Windows.Forms.ToolStripMenuItem debugModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.CheckedListBox checkedListClothingType;
        private System.Windows.Forms.Label label109;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Panel panelMeshThumbs;
        private System.Windows.Forms.Label label110;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem generateThumbnailsToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage11;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage13;
        private System.Windows.Forms.Label label114;
        private System.Windows.Forms.PictureBox picLstTextureColour;
        private System.Windows.Forms.Button btnCommitLstTexture;
        private System.Windows.Forms.Button btnListTextureReplace;
        private System.Windows.Forms.Button btnListTextureFind;
        private System.Windows.Forms.ListView lstTextureDetails;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label113;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView lstStencilPool;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.PictureBox picPatternThumb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMeshName;
        private System.Windows.Forms.Button txtMeshNameCommit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.TextBox txtMeshLod3;
        private System.Windows.Forms.TextBox txtMeshLod2;
        private System.Windows.Forms.TextBox txtMeshLod1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button button33;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.TextBox txtOtherBumpMap;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TabPage tabPage14;
        private System.Windows.Forms.Button btnDesignTypeCommit;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.CheckedListBox chkDesignType;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addNewBlankToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewCopyLastToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyDefaultsToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker bwGenTexture;
        private System.Windows.Forms.Button btnStart3D;
        private System.Windows.Forms.Button btnReloadTextures;
        private MadScience.Render.RenderWindow renderWindow1;
        private System.Windows.Forms.CheckBox cEnable3DPreview;
        private System.Windows.Forms.Button btnResetView;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListView lstMeshTGILinks;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.Button btnMeshTGILinksFind;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem findImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem replaceImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem editColourToolStripMenuItem;
        private System.Windows.Forms.PictureBox picHSVColorBG;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.PictureBox picHSVColorChannel3;
        private System.Windows.Forms.PictureBox picHSVColorChannel2;
        private System.Windows.Forms.PictureBox picHSVColorChannel1;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtMeshLod1_3;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txtMeshLod1_2;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtMeshLod1_1;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox txtMeshLod0;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.TextBox txtMeshLod0_3;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox txtMeshLod0_2;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox txtMeshLod0_1;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.TextBox txtMeshLod2_2;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox txtMeshLod2_1;
        private System.Windows.Forms.Label label35;
		private System.Windows.Forms.Button button22;
		private System.Windows.Forms.TextBox txtMeshLod3_1;
		private System.Windows.Forms.Label label36;
		private System.Windows.Forms.PictureBox picCustomThumbnail;
		private System.Windows.Forms.ToolStripMenuItem useAlternativeToolStripMenuItem;
        private System.Windows.Forms.Button button23;
    }
}

