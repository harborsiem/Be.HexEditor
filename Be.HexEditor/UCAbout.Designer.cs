namespace Be.HexEditor
{
    partial class UCAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCAbout));
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            lblAuthor = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            lnkWorkspace = new System.Windows.Forms.LinkLabel();
            label7 = new System.Windows.Forms.Label();
            lblVersion = new System.Windows.Forms.Label();
            txtThanksTo = new System.Windows.Forms.RichTextBox();
            tabThanksTo = new System.Windows.Forms.TabPage();
            txtLicense = new System.Windows.Forms.RichTextBox();
            tabLicense = new System.Windows.Forms.TabPage();
            txtChanges = new System.Windows.Forms.RichTextBox();
            tabChanges = new System.Windows.Forms.TabPage();
            tabControl = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabThanksTo.SuspendLayout();
            tabLicense.SuspendLayout();
            tabChanges.SuspendLayout();
            tabControl.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = images.Logo;
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // lblAuthor
            // 
            resources.ApplyResources(lblAuthor, "lblAuthor");
            lblAuthor.BackColor = System.Drawing.Color.White;
            lblAuthor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblAuthor.Name = "lblAuthor";
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.Name = "label5";
            // 
            // lnkWorkspace
            // 
            resources.ApplyResources(lnkWorkspace, "lnkWorkspace");
            lnkWorkspace.BackColor = System.Drawing.Color.White;
            lnkWorkspace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lnkWorkspace.Name = "lnkWorkspace";
            lnkWorkspace.TabStop = true;
            lnkWorkspace.LinkClicked += lnkCompany_LinkClicked;
            // 
            // label7
            // 
            resources.ApplyResources(label7, "label7");
            label7.Name = "label7";
            // 
            // lblVersion
            // 
            resources.ApplyResources(lblVersion, "lblVersion");
            lblVersion.BackColor = System.Drawing.Color.White;
            lblVersion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblVersion.Name = "lblVersion";
            // 
            // txtThanksTo
            // 
            txtThanksTo.BackColor = System.Drawing.Color.White;
            txtThanksTo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(txtThanksTo, "txtThanksTo");
            txtThanksTo.Name = "txtThanksTo";
            txtThanksTo.ReadOnly = true;
            // 
            // tabThanksTo
            // 
            resources.ApplyResources(tabThanksTo, "tabThanksTo");
            tabThanksTo.Controls.Add(txtThanksTo);
            tabThanksTo.Name = "tabThanksTo";
            // 
            // txtLicense
            // 
            txtLicense.BackColor = System.Drawing.Color.White;
            txtLicense.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(txtLicense, "txtLicense");
            txtLicense.Name = "txtLicense";
            txtLicense.ReadOnly = true;
            // 
            // tabLicense
            // 
            tabLicense.Controls.Add(txtLicense);
            resources.ApplyResources(tabLicense, "tabLicense");
            tabLicense.Name = "tabLicense";
            // 
            // txtChanges
            // 
            txtChanges.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(txtChanges, "txtChanges");
            txtChanges.Name = "txtChanges";
            // 
            // tabChanges
            // 
            tabChanges.Controls.Add(txtChanges);
            resources.ApplyResources(tabChanges, "tabChanges");
            tabChanges.Name = "tabChanges";
            // 
            // tabControl
            // 
            resources.ApplyResources(tabControl, "tabControl");
            tabControl.Controls.Add(tabThanksTo);
            tabControl.Controls.Add(tabLicense);
            tabControl.Controls.Add(tabChanges);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            // 
            // UCAbout
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            Controls.Add(pictureBox1);
            Controls.Add(tabControl);
            Controls.Add(lblVersion);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(lnkWorkspace);
            Controls.Add(lblAuthor);
            Controls.Add(label1);
            Name = "UCAbout";
            Load += UCAbout_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabThanksTo.ResumeLayout(false);
            tabLicense.ResumeLayout(false);
            tabChanges.ResumeLayout(false);
            tabControl.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.TabPage tabLicense;
        private System.Windows.Forms.RichTextBox txtLicense;
        private System.Windows.Forms.TabPage tabChanges;
        private System.Windows.Forms.RichTextBox txtChanges;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel lnkWorkspace;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabThanksTo;
        private System.Windows.Forms.RichTextBox txtThanksTo;

    }
}
