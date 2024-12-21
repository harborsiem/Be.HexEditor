namespace Be.HexEditor
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            btnOK = new System.Windows.Forms.Button();
            ucAbout1 = new UCAbout();
            SuspendLayout();
            // 
            // btnOK
            // 
            resources.ApplyResources(btnOK, "btnOK");
            btnOK.Name = "btnOK";
            btnOK.Click += btnOK_Click;
            // 
            // ucAbout1
            // 
            resources.ApplyResources(ucAbout1, "ucAbout1");
            ucAbout1.Name = "ucAbout1";
            // 
            // FormAbout
            // 
            AcceptButton = btnOK;
            resources.ApplyResources(this, "$this");
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.Control;
            Controls.Add(btnOK);
            Controls.Add(ucAbout1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            ShowIcon = false;
            ShowInTaskbar = false;
            Load += FormAbout_CorrectWidth;
            Resize += FormAbout_CorrectWidth;
            ResumeLayout(false);
        }
        #endregion

        private UCAbout ucAbout1;
        private System.Windows.Forms.Button btnOK;
    }
}
