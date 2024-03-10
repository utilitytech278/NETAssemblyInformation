namespace AssemblyInformation
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.lblCompilation = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTrackingEnabled = new System.Windows.Forms.TextBox();
            this.txtOptimized = new System.Windows.Forms.TextBox();
            this.txtSequencing = new System.Windows.Forms.TextBox();
            this.txtEditAndContinue = new System.Windows.Forms.TextBox();
            this.frameWorkVersion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.assemblyKindTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.targetProcessorTextBox = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblReferences = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dependencyTreeView = new System.Windows.Forms.TreeView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.referenceListListBox = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.referringAssemblyFolderTextBox = new System.Windows.Forms.TextBox();
            this.referringAssemblyBrowseFolderButton = new System.Windows.Forms.Button();
            this.referringAssemblyFolderSearchButton = new System.Windows.Forms.Button();
            this.referringAssembliesListtBox = new System.Windows.Forms.ListBox();
            this.DebuggableFlagsToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.mainMenu = new System.Windows.Forms.MainMenu(this.components);
            this.mnuView = new System.Windows.Forms.MenuItem();
            this.mnuHideGACAssemblies = new System.Windows.Forms.MenuItem();
            this.mnuShowAssemblyFullName = new System.Windows.Forms.MenuItem();
            this.mnuHelp = new System.Windows.Forms.MenuItem();
            this.mnuAbout = new System.Windows.Forms.MenuItem();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCompilation
            // 
            this.lblCompilation.AutoSize = true;
            this.lblCompilation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblCompilation.Location = new System.Drawing.Point(10, 11);
            this.lblCompilation.Name = "lblCompilation";
            this.lblCompilation.Size = new System.Drawing.Size(76, 13);
            this.lblCompilation.TabIndex = 0;
            this.lblCompilation.Text = "Compilation:";
            this.lblCompilation.MouseEnter += new System.EventHandler(this.LblCompilationMouseEnter);
            this.lblCompilation.MouseLeave += new System.EventHandler(this.LblCompilationMouseLeave);
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblFullName.Location = new System.Drawing.Point(10, 106);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(67, 13);
            this.lblFullName.TabIndex = 0;
            this.lblFullName.Text = "Full Name:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblCompilation);
            this.panel1.Controls.Add(this.txtTrackingEnabled);
            this.panel1.Controls.Add(this.txtOptimized);
            this.panel1.Controls.Add(this.txtSequencing);
            this.panel1.Controls.Add(this.txtEditAndContinue);
            this.panel1.Controls.Add(this.frameWorkVersion);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.assemblyKindTextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.targetProcessorTextBox);
            this.panel1.Controls.Add(this.lblFullName);
            this.panel1.Controls.Add(this.txtFullName);
            this.panel1.Controls.Add(this.lblReferences);
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(816, 382);
            this.panel1.TabIndex = 2;
            // 
            // txtTrackingEnabled
            // 
            this.txtTrackingEnabled.ForeColor = System.Drawing.SystemColors.Info;
            this.txtTrackingEnabled.Location = new System.Drawing.Point(131, 8);
            this.txtTrackingEnabled.Name = "txtTrackingEnabled";
            this.txtTrackingEnabled.ReadOnly = true;
            this.txtTrackingEnabled.Size = new System.Drawing.Size(47, 20);
            this.txtTrackingEnabled.TabIndex = 0;
            this.txtTrackingEnabled.Text = "Release";
            // 
            // txtOptimized
            // 
            this.txtOptimized.ForeColor = System.Drawing.SystemColors.Info;
            this.txtOptimized.Location = new System.Drawing.Point(179, 8);
            this.txtOptimized.Name = "txtOptimized";
            this.txtOptimized.ReadOnly = true;
            this.txtOptimized.Size = new System.Drawing.Size(74, 20);
            this.txtOptimized.TabIndex = 0;
            this.txtOptimized.Text = "Not Optimized";
            // 
            // txtSequencing
            // 
            this.txtSequencing.ForeColor = System.Drawing.SystemColors.Info;
            this.txtSequencing.Location = new System.Drawing.Point(254, 8);
            this.txtSequencing.Name = "txtSequencing";
            this.txtSequencing.ReadOnly = true;
            this.txtSequencing.Size = new System.Drawing.Size(94, 20);
            this.txtSequencing.TabIndex = 0;
            this.txtSequencing.Text = "MSIL Sequencing";
            // 
            // txtEditAndContinue
            // 
            this.txtEditAndContinue.ForeColor = System.Drawing.SystemColors.Info;
            this.txtEditAndContinue.Location = new System.Drawing.Point(349, 8);
            this.txtEditAndContinue.Name = "txtEditAndContinue";
            this.txtEditAndContinue.ReadOnly = true;
            this.txtEditAndContinue.Size = new System.Drawing.Size(136, 20);
            this.txtEditAndContinue.TabIndex = 0;
            this.txtEditAndContinue.Text = "Edit and Continue Disabled";
            // 
            // frameWorkVersion
            // 
            this.frameWorkVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frameWorkVersion.Location = new System.Drawing.Point(494, 8);
            this.frameWorkVersion.Name = "frameWorkVersion";
            this.frameWorkVersion.ReadOnly = true;
            this.frameWorkVersion.Size = new System.Drawing.Size(199, 20);
            this.frameWorkVersion.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Assembly Kind:";
            // 
            // assemblyKindTextBox
            // 
            this.assemblyKindTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.assemblyKindTextBox.Location = new System.Drawing.Point(131, 37);
            this.assemblyKindTextBox.Multiline = true;
            this.assemblyKindTextBox.Name = "assemblyKindTextBox";
            this.assemblyKindTextBox.ReadOnly = true;
            this.assemblyKindTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.assemblyKindTextBox.Size = new System.Drawing.Size(673, 38);
            this.assemblyKindTextBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Target Processor:";
            // 
            // targetProcessorTextBox
            // 
            this.targetProcessorTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.targetProcessorTextBox.Location = new System.Drawing.Point(131, 79);
            this.targetProcessorTextBox.Name = "targetProcessorTextBox";
            this.targetProcessorTextBox.ReadOnly = true;
            this.targetProcessorTextBox.Size = new System.Drawing.Size(673, 20);
            this.targetProcessorTextBox.TabIndex = 0;
            // 
            // txtFullName
            // 
            this.txtFullName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFullName.Location = new System.Drawing.Point(131, 103);
            this.txtFullName.Multiline = true;
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.ReadOnly = true;
            this.txtFullName.Size = new System.Drawing.Size(673, 36);
            this.txtFullName.TabIndex = 0;
            // 
            // lblReferences
            // 
            this.lblReferences.AutoSize = true;
            this.lblReferences.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblReferences.Location = new System.Drawing.Point(10, 146);
            this.lblReferences.Name = "lblReferences";
            this.lblReferences.Size = new System.Drawing.Size(76, 13);
            this.lblReferences.TabIndex = 0;
            this.lblReferences.Text = "References:";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(131, 143);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(673, 237);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dependencyTreeView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(665, 211);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Direct References";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dependencyTreeView
            // 
            this.dependencyTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dependencyTreeView.Location = new System.Drawing.Point(-3, 0);
            this.dependencyTreeView.Name = "dependencyTreeView";
            this.dependencyTreeView.Size = new System.Drawing.Size(669, 215);
            this.dependencyTreeView.TabIndex = 0;
            this.dependencyTreeView.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.DependencyTreeViewBeforeExpand);
            this.dependencyTreeView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dependencyTreeView_KeyDown);
            this.dependencyTreeView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DependencyTreeViewMouseDoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.referenceListListBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(665, 211);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "All Direct & Indirect References";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // referenceListListBox
            // 
            this.referenceListListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.referenceListListBox.FormattingEnabled = true;
            this.referenceListListBox.Location = new System.Drawing.Point(0, 0);
            this.referenceListListBox.Name = "referenceListListBox";
            this.referenceListListBox.Size = new System.Drawing.Size(663, 212);
            this.referenceListListBox.TabIndex = 0;
            this.referenceListListBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.referenceListListBox_KeyDown);
            this.referenceListListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.AssemblyListBoxMouseDoubleClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.referringAssemblyFolderTextBox);
            this.tabPage3.Controls.Add(this.referringAssemblyBrowseFolderButton);
            this.tabPage3.Controls.Add(this.referringAssemblyFolderSearchButton);
            this.tabPage3.Controls.Add(this.referringAssembliesListtBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(665, 211);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Referring Assemblies";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(313, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Select the directory in which you want to find referring assemblies";
            // 
            // referringAssemblyFolderTextBox
            // 
            this.referringAssemblyFolderTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.referringAssemblyFolderTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.referringAssemblyFolderTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.referringAssemblyFolderTextBox.Location = new System.Drawing.Point(7, 21);
            this.referringAssemblyFolderTextBox.Name = "referringAssemblyFolderTextBox";
            this.referringAssemblyFolderTextBox.Size = new System.Drawing.Size(558, 20);
            this.referringAssemblyFolderTextBox.TabIndex = 0;
            this.referringAssemblyFolderTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.referringAssemblyFolderTextBox_KeyDown);
            // 
            // referringAssemblyBrowseFolderButton
            // 
            this.referringAssemblyBrowseFolderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.referringAssemblyBrowseFolderButton.Location = new System.Drawing.Point(571, 19);
            this.referringAssemblyBrowseFolderButton.Name = "referringAssemblyBrowseFolderButton";
            this.referringAssemblyBrowseFolderButton.Size = new System.Drawing.Size(25, 23);
            this.referringAssemblyBrowseFolderButton.TabIndex = 0;
            this.referringAssemblyBrowseFolderButton.Text = "...";
            this.referringAssemblyBrowseFolderButton.UseVisualStyleBackColor = true;
            this.referringAssemblyBrowseFolderButton.Click += new System.EventHandler(this.referringAssemblyBrowseFolderButton_Click);
            // 
            // referringAssemblyFolderSearchButton
            // 
            this.referringAssemblyFolderSearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.referringAssemblyFolderSearchButton.Location = new System.Drawing.Point(602, 19);
            this.referringAssemblyFolderSearchButton.Name = "referringAssemblyFolderSearchButton";
            this.referringAssemblyFolderSearchButton.Size = new System.Drawing.Size(57, 23);
            this.referringAssemblyFolderSearchButton.TabIndex = 0;
            this.referringAssemblyFolderSearchButton.Text = "Find";
            this.referringAssemblyFolderSearchButton.UseVisualStyleBackColor = true;
            this.referringAssemblyFolderSearchButton.Click += new System.EventHandler(this.referringAssemblyFolderSearchButton_Click);
            // 
            // referringAssembliesListtBox
            // 
            this.referringAssembliesListtBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.referringAssembliesListtBox.FormattingEnabled = true;
            this.referringAssembliesListtBox.Location = new System.Drawing.Point(7, 47);
            this.referringAssembliesListtBox.Name = "referringAssembliesListtBox";
            this.referringAssembliesListtBox.Size = new System.Drawing.Size(656, 160);
            this.referringAssembliesListtBox.TabIndex = 0;
            this.referringAssembliesListtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.referringAssembliesListtBox_KeyDown);
            this.referringAssembliesListtBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.AssemblyListBoxMouseDoubleClick);
            // 
            // mainMenu
            // 
            this.mainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuView,
            this.mnuHelp});
            // 
            // mnuView
            // 
            this.mnuView.Index = 0;
            this.mnuView.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuHideGACAssemblies,
            this.mnuShowAssemblyFullName});
            this.mnuView.Text = "View";
            // 
            // mnuHideGACAssemblies
            // 
            this.mnuHideGACAssemblies.Index = 0;
            this.mnuHideGACAssemblies.Text = "Hide GAC Assemblies";
            this.mnuHideGACAssemblies.Click += new System.EventHandler(this.mnuHideGACAssemblies_Click);
            // 
            // mnuShowAssemblyFullName
            // 
            this.mnuShowAssemblyFullName.Checked = true;
            this.mnuShowAssemblyFullName.Index = 1;
            this.mnuShowAssemblyFullName.Text = "Show Assembly Full Name";
            this.mnuShowAssemblyFullName.Click += new System.EventHandler(this.mnuShowAssemblyFullName_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.Index = 1;
            this.mnuHelp.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuAbout});
            this.mnuHelp.Text = "Help";
            // 
            // mnuAbout
            // 
            this.mnuAbout.Index = 0;
            this.mnuAbout.Text = "About";
            this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 382);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Menu = this.mainMenu;
            this.MinimumSize = new System.Drawing.Size(154, 110);
            this.Name = "FormMain";
            this.Text = ".NET Assembly Information";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMainFormClosing);
            this.Load += new System.EventHandler(this.FormMainLoad);
            this.Shown += new System.EventHandler(this.FormMain_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCompilation;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtTrackingEnabled;
        private System.Windows.Forms.Label lblReferences;
        private System.Windows.Forms.TextBox txtOptimized;
        private System.Windows.Forms.ToolTip DebuggableFlagsToolTip;
        private System.Windows.Forms.TextBox txtSequencing;
        private System.Windows.Forms.TextBox txtEditAndContinue;
        private System.Windows.Forms.TextBox targetProcessorTextBox;
        private System.Windows.Forms.TextBox assemblyKindTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView dependencyTreeView;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button referringAssemblyFolderSearchButton;
        private System.Windows.Forms.TextBox referringAssemblyFolderTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button referringAssemblyBrowseFolderButton;
        private System.Windows.Forms.ListBox referringAssembliesListtBox;
        private System.Windows.Forms.ListBox referenceListListBox;
        private System.Windows.Forms.TextBox frameWorkVersion;
        private System.Windows.Forms.MainMenu mainMenu;
        private System.Windows.Forms.MenuItem mnuView;
        private System.Windows.Forms.MenuItem mnuHideGACAssemblies;
        private System.Windows.Forms.MenuItem mnuShowAssemblyFullName;
        private System.Windows.Forms.MenuItem mnuHelp;
        private System.Windows.Forms.MenuItem mnuAbout;
    }
}