namespace Be.HexEditor
{
	partial class BitControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BitControl));
            lblValue = new System.Windows.Forms.Label();
            lblBit = new System.Windows.Forms.Label();
            pnBitsEditor = new System.Windows.Forms.Panel();
            pnBitsHeader = new System.Windows.Forms.Panel();
            flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            flowLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // lblValue
            // 
            resources.ApplyResources(lblValue, "lblValue");
            lblValue.Name = "lblValue";
            // 
            // lblBit
            // 
            resources.ApplyResources(lblBit, "lblBit");
            lblBit.Name = "lblBit";
            // 
            // pnBitsEditor
            // 
            resources.ApplyResources(pnBitsEditor, "pnBitsEditor");
            pnBitsEditor.Name = "pnBitsEditor";
            // 
            // pnBitsHeader
            // 
            resources.ApplyResources(pnBitsHeader, "pnBitsHeader");
            flowLayoutPanel.SetFlowBreak(pnBitsHeader, true);
            pnBitsHeader.Name = "pnBitsHeader";
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.Controls.Add(lblBit);
            flowLayoutPanel.Controls.Add(pnBitsHeader);
            flowLayoutPanel.Controls.Add(lblValue);
            flowLayoutPanel.Controls.Add(pnBitsEditor);
            resources.ApplyResources(flowLayoutPanel, "flowLayoutPanel");
            flowLayoutPanel.Name = "flowLayoutPanel";
            // 
            // BitControl
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            Controls.Add(flowLayoutPanel);
            Name = "BitControl";
            flowLayoutPanel.ResumeLayout(false);
            flowLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label lblBit;
        private System.Windows.Forms.Panel pnBitsEditor;
        private System.Windows.Forms.Panel pnBitsHeader;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
	}
}
