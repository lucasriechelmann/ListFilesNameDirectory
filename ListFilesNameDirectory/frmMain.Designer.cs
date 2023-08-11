namespace ListFilesNameDirectory
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtFolderFiles = new TextBox();
            btnSelectFolder = new Button();
            folderBrowserDialog = new FolderBrowserDialog();
            clbFilesToList = new CheckedListBox();
            label2 = new Label();
            btnList = new Button();
            cnIncludeSubFolders = new CheckBox();
            btnCheckAll = new Button();
            btnUncheckAll = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 0;
            label1.Text = "Folder Files";
            // 
            // txtFolderFiles
            // 
            txtFolderFiles.Location = new Point(12, 27);
            txtFolderFiles.Name = "txtFolderFiles";
            txtFolderFiles.Size = new Size(408, 23);
            txtFolderFiles.TabIndex = 1;
            // 
            // btnSelectFolder
            // 
            btnSelectFolder.Location = new Point(426, 27);
            btnSelectFolder.Name = "btnSelectFolder";
            btnSelectFolder.Size = new Size(75, 23);
            btnSelectFolder.TabIndex = 2;
            btnSelectFolder.Text = "Select";
            btnSelectFolder.UseVisualStyleBackColor = true;
            btnSelectFolder.Click += btnSelectFolder_Click;
            // 
            // clbFilesToList
            // 
            clbFilesToList.FormattingEnabled = true;
            clbFilesToList.Location = new Point(12, 101);
            clbFilesToList.Name = "clbFilesToList";
            clbFilesToList.Size = new Size(489, 238);
            clbFilesToList.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 4;
            label2.Text = "Files to List";
            // 
            // btnList
            // 
            btnList.Location = new Point(12, 380);
            btnList.Name = "btnList";
            btnList.Size = new Size(489, 45);
            btnList.TabIndex = 5;
            btnList.Text = "List";
            btnList.UseVisualStyleBackColor = true;
            btnList.Click += btnList_Click;
            // 
            // cnIncludeSubFolders
            // 
            cnIncludeSubFolders.AutoSize = true;
            cnIncludeSubFolders.Location = new Point(12, 355);
            cnIncludeSubFolders.Name = "cnIncludeSubFolders";
            cnIncludeSubFolders.Size = new Size(131, 19);
            cnIncludeSubFolders.TabIndex = 6;
            cnIncludeSubFolders.Text = "Include Sub-Folders";
            cnIncludeSubFolders.UseVisualStyleBackColor = true;
            // 
            // btnCheckAll
            // 
            btnCheckAll.Location = new Point(12, 71);
            btnCheckAll.Name = "btnCheckAll";
            btnCheckAll.Size = new Size(112, 23);
            btnCheckAll.TabIndex = 7;
            btnCheckAll.Text = "Check All";
            btnCheckAll.UseVisualStyleBackColor = true;
            btnCheckAll.Click += btnCheckAll_Click;
            // 
            // btnUncheckAll
            // 
            btnUncheckAll.Location = new Point(130, 71);
            btnUncheckAll.Name = "btnUncheckAll";
            btnUncheckAll.Size = new Size(112, 23);
            btnUncheckAll.TabIndex = 8;
            btnUncheckAll.Text = "Uncheck All";
            btnUncheckAll.UseVisualStyleBackColor = true;
            btnUncheckAll.Click += btnUncheckAll_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(510, 437);
            Controls.Add(btnUncheckAll);
            Controls.Add(btnCheckAll);
            Controls.Add(cnIncludeSubFolders);
            Controls.Add(btnList);
            Controls.Add(label2);
            Controls.Add(clbFilesToList);
            Controls.Add(btnSelectFolder);
            Controls.Add(txtFolderFiles);
            Controls.Add(label1);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "List Files Name Directory";
            Load += frmMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFolderFiles;
        private Button btnSelectFolder;
        private FolderBrowserDialog folderBrowserDialog;
        private CheckedListBox clbFilesToList;
        private Label label2;
        private Button btnList;
        private CheckBox cnIncludeSubFolders;
        private Button btnCheckAll;
        private Button btnUncheckAll;
    }
}