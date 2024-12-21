namespace Be.HexEditor
{
    partial class FormFind
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFind));
            txtFind = new System.Windows.Forms.TextBox();
            rbString = new System.Windows.Forms.RadioButton();
            rbHex = new System.Windows.Forms.RadioButton();
            btnOK = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            lblPercent = new System.Windows.Forms.Label();
            lblFinding = new System.Windows.Forms.Label();
            chkMatchCase = new System.Windows.Forms.CheckBox();
            timerPercent = new System.Windows.Forms.Timer(components);
            timer = new System.Windows.Forms.Timer(components);
            hexFind = new Windows.Forms.HexBox();
            flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            groupBox1 = new System.Windows.Forms.GroupBox();
            flowLayoutPanel2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtFind
            // 
            resources.ApplyResources(txtFind, "txtFind");
            txtFind.Name = "txtFind";
            txtFind.TextChanged += txtString_TextChanged;
            // 
            // rbString
            // 
            resources.ApplyResources(rbString, "rbString");
            rbString.Checked = true;
            rbString.Name = "rbString";
            rbString.TabStop = true;
            // 
            // rbHex
            // 
            resources.ApplyResources(rbHex, "rbHex");
            rbHex.Name = "rbHex";
            // 
            // btnOK
            // 
            resources.ApplyResources(btnOK, "btnOK");
            btnOK.Name = "btnOK";
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            resources.ApplyResources(btnCancel, "btnCancel");
            btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancel.Name = "btnCancel";
            btnCancel.Click += btnCancel_Click;
            // 
            // lblPercent
            // 
            resources.ApplyResources(lblPercent, "lblPercent");
            lblPercent.Name = "lblPercent";
            // 
            // lblFinding
            // 
            lblFinding.ForeColor = System.Drawing.Color.Blue;
            resources.ApplyResources(lblFinding, "lblFinding");
            lblFinding.Name = "lblFinding";
            // 
            // chkMatchCase
            // 
            resources.ApplyResources(chkMatchCase, "chkMatchCase");
            chkMatchCase.Name = "chkMatchCase";
            chkMatchCase.UseVisualStyleBackColor = true;
            // 
            // timerPercent
            // 
            timerPercent.Tick += timerPercent_Tick;
            // 
            // timer
            // 
            timer.Interval = 50;
            timer.Tick += timer_Tick;
            // 
            // hexFind
            // 
            resources.ApplyResources(hexFind, "hexFind");
            // 
            // 
            // 
            hexFind.BuiltInContextMenu.CopyMenuItemImage = images.CopyHS;
            hexFind.BuiltInContextMenu.CopyMenuItemText = resources.GetString("hexFind.BuiltInContextMenu.CopyMenuItemText");
            hexFind.BuiltInContextMenu.CutMenuItemImage = images.CutHS;
            hexFind.BuiltInContextMenu.CutMenuItemText = resources.GetString("hexFind.BuiltInContextMenu.CutMenuItemText");
            hexFind.BuiltInContextMenu.PasteMenuItemImage = images.PasteHS;
            hexFind.BuiltInContextMenu.PasteMenuItemText = resources.GetString("hexFind.BuiltInContextMenu.PasteMenuItemText");
            hexFind.BuiltInContextMenu.SelectAllMenuItemText = resources.GetString("hexFind.BuiltInContextMenu.SelectAllMenuItemText");
            hexFind.InfoForeColor = System.Drawing.Color.Empty;
            hexFind.Name = "hexFind";
            hexFind.ShadowSelectionColor = System.Drawing.Color.FromArgb(100, 60, 188, 255);
            // 
            // flowLayoutPanel2
            // 
            resources.ApplyResources(flowLayoutPanel2, "flowLayoutPanel2");
            flowLayoutPanel2.Controls.Add(btnCancel);
            flowLayoutPanel2.Controls.Add(btnOK);
            flowLayoutPanel2.Controls.Add(lblFinding);
            flowLayoutPanel2.Controls.Add(lblPercent);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            // 
            // groupBox1
            // 
            resources.ApplyResources(groupBox1, "groupBox1");
            groupBox1.Controls.Add(rbString);
            groupBox1.Controls.Add(chkMatchCase);
            groupBox1.Controls.Add(hexFind);
            groupBox1.Controls.Add(rbHex);
            groupBox1.Controls.Add(txtFind);
            groupBox1.Name = "groupBox1";
            groupBox1.TabStop = false;
            // 
            // FormFind
            // 
            AcceptButton = btnOK;
            resources.ApplyResources(this, "$this");
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.Control;
            CancelButton = btnCancel;
            Controls.Add(groupBox1);
            Controls.Add(flowLayoutPanel2);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormFind";
            ShowIcon = false;
            ShowInTaskbar = false;
            Activated += FormFind_Activated;
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Be.Windows.Forms.HexBox hexFind;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.RadioButton rbString;
        private System.Windows.Forms.RadioButton rbHex;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblPercent;
        private System.Windows.Forms.Label lblFinding;
        private System.Windows.Forms.CheckBox chkMatchCase;
        private System.Windows.Forms.Timer timerPercent;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
