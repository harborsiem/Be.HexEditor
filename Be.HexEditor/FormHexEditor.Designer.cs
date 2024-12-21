namespace Be.HexEditor
{
    partial class FormHexEditor
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHexEditor));
            menuStrip = new Core.MenuStripEx();
            fileToolStripMenuItem = new Core.ToolStripMenuItemEx();
            openToolStripMenuItem = new Core.ToolStripMenuItemEx();
            toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            saveToolStripMenuItem = new Core.ToolStripMenuItemEx();
            toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            recentFilesToolStripMenuItem = new Core.ToolStripMenuItemEx();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            exitToolStripMenuItem = new Core.ToolStripMenuItemEx();
            editToolStripMenuItem = new Core.ToolStripMenuItemEx();
            cutToolStripMenuItem = new Core.ToolStripMenuItemEx();
            copyToolStripMenuItem = new Core.ToolStripMenuItemEx();
            pasteToolStripMenuItem = new Core.ToolStripMenuItemEx();
            toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            copyHexStringToolStripMenuItem = new Core.ToolStripMenuItemEx();
            pasteHexToolStripMenuItem = new Core.ToolStripMenuItemEx();
            toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            findToolStripMenuItem = new Core.ToolStripMenuItemEx();
            findNextToolStripMenuItem = new Core.ToolStripMenuItemEx();
            goToToolStripMenuItem = new Core.ToolStripMenuItemEx();
            toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            selectAllToolStripMenuItem = new Core.ToolStripMenuItemEx();
            viewToolStripMenuItem = new Core.ToolStripMenuItemEx();
            encodingToolStripMenuItem = new Core.ToolStripMenuItemEx();
            bitsToolStripMenuItem = new Core.ToolStripMenuItemEx();
            toolsToolStripMenuItem = new Core.ToolStripMenuItemEx();
            optionsToolStripMenuItem = new Core.ToolStripMenuItemEx();
            helpToolStripMenuItem = new Core.ToolStripMenuItemEx();
            aboutToolStripMenuItem = new Core.ToolStripMenuItemEx();
            toolStrip = new Core.ToolStripEx();
            openToolStripButton = new Core.ToolStripButtonEx();
            saveToolStripButton = new Core.ToolStripButtonEx();
            toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            cutToolStripButton = new Core.ToolStripButtonEx();
            copyToolStripSplitButton = new Core.ToolStripSplitButtonEx();
            copyToolStripMenuItem1 = new Core.ToolStripMenuItemEx();
            copyHexToolStripMenuItem1 = new Core.ToolStripMenuItemEx();
            pasteToolStripSplitButton = new Core.ToolStripSplitButtonEx();
            pasteToolStripMenuItem1 = new Core.ToolStripMenuItemEx();
            pasteHexToolStripMenuItem1 = new Core.ToolStripMenuItemEx();
            encodingToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            statusStrip = new System.Windows.Forms.StatusStrip();
            toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            fileSizeToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            bitToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            openFileDialog = new System.Windows.Forms.OpenFileDialog();
            bodyPanel = new System.Windows.Forms.Panel();
            hexBox = new Windows.Forms.HexBox();
            bitControl1 = new BitControl();
            RecentFileHandler = new RecentFileHandler(components);
            menuStrip.SuspendLayout();
            toolStrip.SuspendLayout();
            statusStrip.SuspendLayout();
            bodyPanel.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.BackColor = System.Drawing.SystemColors.Control;
            menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, viewToolStripMenuItem, toolsToolStripMenuItem, helpToolStripMenuItem });
            resources.ApplyResources(menuStrip, "menuStrip");
            menuStrip.Name = "menuStrip";
            menuStrip.ItemClicked += menuStrip_ItemClicked;
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { openToolStripMenuItem, toolStripSeparator, saveToolStripMenuItem, toolStripSeparator2, recentFilesToolStripMenuItem, toolStripSeparator1, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Image = ScalingImages.FolderOpen_16;
            openToolStripMenuItem.Image16 = ScalingImages.FolderOpen_16;
            openToolStripMenuItem.Image24 = ScalingImages.FolderOpen_24;
            openToolStripMenuItem.Image32 = ScalingImages.FolderOpen_32;
            resources.ApplyResources(openToolStripMenuItem, "openToolStripMenuItem");
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Click += open_Click;
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            resources.ApplyResources(toolStripSeparator, "toolStripSeparator");
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Image = ScalingImages.save16;
            saveToolStripMenuItem.Image16 = ScalingImages.save16;
            saveToolStripMenuItem.Image24 = ScalingImages.Save24;
            saveToolStripMenuItem.Image32 = ScalingImages.Save32;
            resources.ApplyResources(saveToolStripMenuItem, "saveToolStripMenuItem");
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Click += save_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(toolStripSeparator2, "toolStripSeparator2");
            // 
            // recentFilesToolStripMenuItem
            // 
            resources.ApplyResources(recentFilesToolStripMenuItem, "recentFilesToolStripMenuItem");
            recentFilesToolStripMenuItem.Name = "recentFilesToolStripMenuItem";
            recentFilesToolStripMenuItem.DropDownItemClicked += recentFiles_DropDownItemClicked;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(toolStripSeparator1, "toolStripSeparator1");
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            resources.ApplyResources(exitToolStripMenuItem, "exitToolStripMenuItem");
            exitToolStripMenuItem.Click += exit_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { cutToolStripMenuItem, copyToolStripMenuItem, pasteToolStripMenuItem, toolStripSeparator3, copyHexStringToolStripMenuItem, pasteHexToolStripMenuItem, toolStripSeparator4, findToolStripMenuItem, findNextToolStripMenuItem, goToToolStripMenuItem, toolStripSeparator5, selectAllToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            resources.ApplyResources(editToolStripMenuItem, "editToolStripMenuItem");
            // 
            // cutToolStripMenuItem
            // 
            cutToolStripMenuItem.Image = ScalingImages.Cut16;
            cutToolStripMenuItem.Image16 = ScalingImages.Copy16;
            cutToolStripMenuItem.Image24 = ScalingImages.Copy24;
            cutToolStripMenuItem.Image32 = ScalingImages.Copy32;
            resources.ApplyResources(cutToolStripMenuItem, "cutToolStripMenuItem");
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.Click += cut_Click;
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Image = ScalingImages.Copy16;
            copyToolStripMenuItem.Image16 = ScalingImages.Copy16;
            copyToolStripMenuItem.Image24 = ScalingImages.Copy24;
            copyToolStripMenuItem.Image32 = ScalingImages.Copy32;
            resources.ApplyResources(copyToolStripMenuItem, "copyToolStripMenuItem");
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.Click += copy_Click;
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Image = ScalingImages.Paste16;
            pasteToolStripMenuItem.Image16 = ScalingImages.Paste16;
            pasteToolStripMenuItem.Image24 = ScalingImages.Paste24;
            pasteToolStripMenuItem.Image32 = ScalingImages.Paste32;
            resources.ApplyResources(pasteToolStripMenuItem, "pasteToolStripMenuItem");
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.Click += paste_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            resources.ApplyResources(toolStripSeparator3, "toolStripSeparator3");
            // 
            // copyHexStringToolStripMenuItem
            // 
            copyHexStringToolStripMenuItem.Name = "copyHexStringToolStripMenuItem";
            resources.ApplyResources(copyHexStringToolStripMenuItem, "copyHexStringToolStripMenuItem");
            copyHexStringToolStripMenuItem.Click += copyHex_Click;
            // 
            // pasteHexToolStripMenuItem
            // 
            pasteHexToolStripMenuItem.Name = "pasteHexToolStripMenuItem";
            resources.ApplyResources(pasteHexToolStripMenuItem, "pasteHexToolStripMenuItem");
            pasteHexToolStripMenuItem.Click += pasteHex_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            resources.ApplyResources(toolStripSeparator4, "toolStripSeparator4");
            // 
            // findToolStripMenuItem
            // 
            findToolStripMenuItem.Image = ScalingImages.Find16;
            findToolStripMenuItem.Image16 = ScalingImages.Find16;
            findToolStripMenuItem.Image24 = ScalingImages.Find24;
            findToolStripMenuItem.Image32 = ScalingImages.Find32;
            findToolStripMenuItem.Name = "findToolStripMenuItem";
            resources.ApplyResources(findToolStripMenuItem, "findToolStripMenuItem");
            findToolStripMenuItem.Click += find_Click;
            // 
            // findNextToolStripMenuItem
            // 
            findNextToolStripMenuItem.Image = ScalingImages.FindNext16;
            findNextToolStripMenuItem.Image16 = ScalingImages.FindNext16;
            findNextToolStripMenuItem.Image24 = ScalingImages.FindNext24;
            findNextToolStripMenuItem.Image32 = ScalingImages.FindNext32;
            findNextToolStripMenuItem.Name = "findNextToolStripMenuItem";
            resources.ApplyResources(findNextToolStripMenuItem, "findNextToolStripMenuItem");
            findNextToolStripMenuItem.Click += findNext_Click;
            // 
            // goToToolStripMenuItem
            // 
            goToToolStripMenuItem.Name = "goToToolStripMenuItem";
            resources.ApplyResources(goToToolStripMenuItem, "goToToolStripMenuItem");
            goToToolStripMenuItem.Click += goTo_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            resources.ApplyResources(toolStripSeparator5, "toolStripSeparator5");
            // 
            // selectAllToolStripMenuItem
            // 
            selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            resources.ApplyResources(selectAllToolStripMenuItem, "selectAllToolStripMenuItem");
            selectAllToolStripMenuItem.Click += selectAllToolStripMenuItem_Click;
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { encodingToolStripMenuItem, bitsToolStripMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            resources.ApplyResources(viewToolStripMenuItem, "viewToolStripMenuItem");
            // 
            // encodingToolStripMenuItem
            // 
            encodingToolStripMenuItem.Name = "encodingToolStripMenuItem";
            resources.ApplyResources(encodingToolStripMenuItem, "encodingToolStripMenuItem");
            // 
            // bitsToolStripMenuItem
            // 
            bitsToolStripMenuItem.CheckOnClick = true;
            bitsToolStripMenuItem.Name = "bitsToolStripMenuItem";
            resources.ApplyResources(bitsToolStripMenuItem, "bitsToolStripMenuItem");
            bitsToolStripMenuItem.CheckedChanged += bitsToolStripMenuItem_CheckedChanged;
            // 
            // toolsToolStripMenuItem
            // 
            toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { optionsToolStripMenuItem });
            toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            resources.ApplyResources(toolsToolStripMenuItem, "toolsToolStripMenuItem");
            // 
            // optionsToolStripMenuItem
            // 
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            resources.ApplyResources(optionsToolStripMenuItem, "optionsToolStripMenuItem");
            optionsToolStripMenuItem.Click += options_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            resources.ApplyResources(helpToolStripMenuItem, "helpToolStripMenuItem");
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            resources.ApplyResources(aboutToolStripMenuItem, "aboutToolStripMenuItem");
            aboutToolStripMenuItem.Click += about_Click;
            // 
            // toolStrip
            // 
            resources.ApplyResources(toolStrip, "toolStrip");
            toolStrip.BackColor = System.Drawing.SystemColors.Control;
            toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { openToolStripButton, saveToolStripButton, toolStripSeparator6, cutToolStripButton, copyToolStripSplitButton, pasteToolStripSplitButton, encodingToolStripComboBox });
            toolStrip.Name = "toolStrip";
            // 
            // openToolStripButton
            // 
            openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            openToolStripButton.Image = images.openHS;
            openToolStripButton.Image16 = ScalingImages.FolderOpen_16;
            openToolStripButton.Image24 = ScalingImages.FolderOpen_24;
            openToolStripButton.Image32 = ScalingImages.FolderOpen_32;
            resources.ApplyResources(openToolStripButton, "openToolStripButton");
            openToolStripButton.Name = "openToolStripButton";
            openToolStripButton.Click += open_Click;
            // 
            // saveToolStripButton
            // 
            saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            saveToolStripButton.Image = images.saveHS;
            saveToolStripButton.Image16 = ScalingImages.save16;
            saveToolStripButton.Image24 = ScalingImages.Save24;
            saveToolStripButton.Image32 = ScalingImages.Save32;
            resources.ApplyResources(saveToolStripButton, "saveToolStripButton");
            saveToolStripButton.Name = "saveToolStripButton";
            saveToolStripButton.Click += save_Click;
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            resources.ApplyResources(toolStripSeparator6, "toolStripSeparator6");
            // 
            // cutToolStripButton
            // 
            cutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            cutToolStripButton.Image = images.CutHS;
            cutToolStripButton.Image16 = ScalingImages.Cut16;
            cutToolStripButton.Image24 = ScalingImages.Copy24;
            cutToolStripButton.Image32 = ScalingImages.Copy32;
            resources.ApplyResources(cutToolStripButton, "cutToolStripButton");
            cutToolStripButton.Name = "cutToolStripButton";
            cutToolStripButton.Click += cut_Click;
            // 
            // copyToolStripSplitButton
            // 
            copyToolStripSplitButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            copyToolStripSplitButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { copyToolStripMenuItem1, copyHexToolStripMenuItem1 });
            copyToolStripSplitButton.ForeColor = System.Drawing.SystemColors.ControlText;
            copyToolStripSplitButton.Image = ScalingImages.Copy16;
            copyToolStripSplitButton.Image16 = ScalingImages.Copy16;
            copyToolStripSplitButton.Image24 = ScalingImages.Copy24;
            copyToolStripSplitButton.Image32 = ScalingImages.Copy32;
            resources.ApplyResources(copyToolStripSplitButton, "copyToolStripSplitButton");
            copyToolStripSplitButton.Name = "copyToolStripSplitButton";
            copyToolStripSplitButton.ButtonClick += copy_Click;
            // 
            // copyToolStripMenuItem1
            // 
            copyToolStripMenuItem1.Image = images.CopyHS;
            copyToolStripMenuItem1.Name = "copyToolStripMenuItem1";
            resources.ApplyResources(copyToolStripMenuItem1, "copyToolStripMenuItem1");
            copyToolStripMenuItem1.Click += copy_Click;
            // 
            // copyHexToolStripMenuItem1
            // 
            copyHexToolStripMenuItem1.Image = images.CopyHS;
            copyHexToolStripMenuItem1.Name = "copyHexToolStripMenuItem1";
            resources.ApplyResources(copyHexToolStripMenuItem1, "copyHexToolStripMenuItem1");
            copyHexToolStripMenuItem1.Click += copyHex_Click;
            // 
            // pasteToolStripSplitButton
            // 
            pasteToolStripSplitButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            pasteToolStripSplitButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { pasteToolStripMenuItem1, pasteHexToolStripMenuItem1 });
            pasteToolStripSplitButton.Image = ScalingImages.Paste16;
            pasteToolStripSplitButton.Image16 = ScalingImages.Paste16;
            pasteToolStripSplitButton.Image24 = ScalingImages.Paste24;
            pasteToolStripSplitButton.Image32 = ScalingImages.Paste32;
            resources.ApplyResources(pasteToolStripSplitButton, "pasteToolStripSplitButton");
            pasteToolStripSplitButton.Name = "pasteToolStripSplitButton";
            pasteToolStripSplitButton.ButtonClick += paste_Click;
            // 
            // pasteToolStripMenuItem1
            // 
            pasteToolStripMenuItem1.Name = "pasteToolStripMenuItem1";
            resources.ApplyResources(pasteToolStripMenuItem1, "pasteToolStripMenuItem1");
            pasteToolStripMenuItem1.Click += paste_Click;
            // 
            // pasteHexToolStripMenuItem1
            // 
            pasteHexToolStripMenuItem1.Name = "pasteHexToolStripMenuItem1";
            resources.ApplyResources(pasteHexToolStripMenuItem1, "pasteHexToolStripMenuItem1");
            pasteHexToolStripMenuItem1.Click += pasteHex_Click;
            // 
            // encodingToolStripComboBox
            // 
            encodingToolStripComboBox.BackColor = System.Drawing.SystemColors.Control;
            encodingToolStripComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            encodingToolStripComboBox.DropDownWidth = 180;
            resources.ApplyResources(encodingToolStripComboBox, "encodingToolStripComboBox");
            encodingToolStripComboBox.Name = "encodingToolStripComboBox";
            encodingToolStripComboBox.SelectedIndexChanged += toolStripEncoding_SelectedIndexChanged;
            // 
            // statusStrip
            // 
            statusStrip.BackColor = System.Drawing.SystemColors.Control;
            statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripStatusLabel, fileSizeToolStripStatusLabel, bitToolStripStatusLabel });
            resources.ApplyResources(statusStrip, "statusStrip");
            statusStrip.Name = "statusStrip";
            statusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            statusStrip.SizingGrip = false;
            // 
            // toolStripStatusLabel
            // 
            toolStripStatusLabel.Margin = new System.Windows.Forms.Padding(5, 3, 0, 2);
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            toolStripStatusLabel.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            resources.ApplyResources(toolStripStatusLabel, "toolStripStatusLabel");
            // 
            // fileSizeToolStripStatusLabel
            // 
            fileSizeToolStripStatusLabel.Name = "fileSizeToolStripStatusLabel";
            fileSizeToolStripStatusLabel.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            resources.ApplyResources(fileSizeToolStripStatusLabel, "fileSizeToolStripStatusLabel");
            // 
            // bitToolStripStatusLabel
            // 
            bitToolStripStatusLabel.Name = "bitToolStripStatusLabel";
            resources.ApplyResources(bitToolStripStatusLabel, "bitToolStripStatusLabel");
            // 
            // bodyPanel
            // 
            resources.ApplyResources(bodyPanel, "bodyPanel");
            bodyPanel.Controls.Add(hexBox);
            bodyPanel.Controls.Add(bitControl1);
            bodyPanel.Name = "bodyPanel";
            // 
            // hexBox
            // 
            hexBox.AllowDrop = true;
            resources.ApplyResources(hexBox, "hexBox");
            hexBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            // 
            // 
            // 
            hexBox.BuiltInContextMenu.CopyMenuItemImage = images.CopyHS;
            hexBox.BuiltInContextMenu.CopyMenuItemText = resources.GetString("hexBox.BuiltInContextMenu.CopyMenuItemText");
            hexBox.BuiltInContextMenu.CutMenuItemImage = images.CutHS;
            hexBox.BuiltInContextMenu.CutMenuItemText = resources.GetString("hexBox.BuiltInContextMenu.CutMenuItemText");
            hexBox.BuiltInContextMenu.PasteMenuItemImage = images.PasteHS;
            hexBox.BuiltInContextMenu.PasteMenuItemText = resources.GetString("hexBox.BuiltInContextMenu.PasteMenuItemText");
            hexBox.BuiltInContextMenu.SelectAllMenuItemText = resources.GetString("hexBox.BuiltInContextMenu.SelectAllMenuItemText");
            hexBox.ColumnInfoVisible = true;
            hexBox.HexCasing = Windows.Forms.HexCasing.Lower;
            hexBox.LineInfoVisible = true;
            hexBox.Name = "hexBox";
            hexBox.ShadowSelectionColor = System.Drawing.Color.FromArgb(100, 60, 188, 255);
            hexBox.StringViewVisible = true;
            hexBox.UseFixedBytesPerLine = true;
            hexBox.VScrollBarVisible = true;
            hexBox.SelectionStartChanged += hexBox_SelectionStartChanged;
            hexBox.SelectionLengthChanged += hexBox_SelectionLengthChanged;
            hexBox.CurrentLineChanged += Position_Changed;
            hexBox.CurrentPositionInLineChanged += Position_Changed;
            hexBox.Copied += hexBox_Copied;
            hexBox.CopiedHex += hexBox_CopiedHex;
            hexBox.RequiredWidthChanged += hexBox_RequiredWidthChanged;
            hexBox.DragDrop += hexBox_DragDrop;
            hexBox.DragEnter += hexBox_DragEnter;
            // 
            // bitControl1
            // 
            resources.ApplyResources(bitControl1, "bitControl1");
            bitControl1.Name = "bitControl1";
            bitControl1.BitChanged += bitControl1_BitChanged;
            // 
            // RecentFileHandler
            // 
            RecentFileHandler.RecentFileToolStripItem = recentFilesToolStripMenuItem;
            // 
            // FormHexEditor
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            BackColor = System.Drawing.SystemColors.Control;
            Controls.Add(bodyPanel);
            Controls.Add(statusStrip);
            Controls.Add(toolStrip);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Name = "FormHexEditor";
            FormClosing += FormHexEditor_FormClosing;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            bodyPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Core.MenuStripEx menuStrip;
        private Core.ToolStripMenuItemEx fileToolStripMenuItem;
        private Core.ToolStripMenuItemEx openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private Core.ToolStripMenuItemEx saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private Core.ToolStripMenuItemEx exitToolStripMenuItem;
        private Core.ToolStripMenuItemEx editToolStripMenuItem;
        private Core.ToolStripMenuItemEx cutToolStripMenuItem;
        private Core.ToolStripMenuItemEx copyToolStripMenuItem;
        private Core.ToolStripMenuItemEx pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private Core.ToolStripMenuItemEx findToolStripMenuItem;
        private Core.ToolStripMenuItemEx toolsToolStripMenuItem;
        private Core.ToolStripMenuItemEx optionsToolStripMenuItem;
        private Core.ToolStripMenuItemEx helpToolStripMenuItem;
        private Core.ToolStripMenuItemEx aboutToolStripMenuItem;
        private Core.ToolStripEx toolStrip;
        private Core.ToolStripButtonEx openToolStripButton;
        private Core.ToolStripButtonEx saveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private Core.ToolStripButtonEx cutToolStripButton;
        private Be.Windows.Forms.HexBox hexBox;
        private System.Windows.Forms.StatusStrip statusStrip;
        private Core.ToolStripMenuItemEx findNextToolStripMenuItem;
        private Core.ToolStripMenuItemEx goToToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private Core.ToolStripMenuItemEx recentFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripStatusLabel fileSizeToolStripStatusLabel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private Core.ToolStripMenuItemEx copyHexStringToolStripMenuItem;
        private Core.ToolStripMenuItemEx pasteHexToolStripMenuItem;
        private Core.ToolStripSplitButtonEx copyToolStripSplitButton;
        private Core.ToolStripMenuItemEx copyToolStripMenuItem1;
        private Core.ToolStripMenuItemEx copyHexToolStripMenuItem1;
        private Core.ToolStripSplitButtonEx pasteToolStripSplitButton;
        private Core.ToolStripMenuItemEx pasteToolStripMenuItem1;
        private Core.ToolStripMenuItemEx pasteHexToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private Core.ToolStripMenuItemEx selectAllToolStripMenuItem;
        public RecentFileHandler RecentFileHandler;
		private System.Windows.Forms.ToolStripStatusLabel bitToolStripStatusLabel;
		private System.Windows.Forms.ToolStripComboBox encodingToolStripComboBox;
		private Core.ToolStripMenuItemEx viewToolStripMenuItem;
		private Core.ToolStripMenuItemEx encodingToolStripMenuItem;
		private Core.ToolStripMenuItemEx bitsToolStripMenuItem;
		private BitControl bitControl1;
		private System.Windows.Forms.Panel bodyPanel;
    }
}