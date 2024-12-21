using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Be.HexEditor
{
	/// <summary>
	/// Summary description for FormAbout.
	/// </summary>
	public partial class FormAbout : Form //Core.FormEx
	{
		public FormAbout()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
            
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			Close();
		}

        private void FormAbout_CorrectWidth(object sender, EventArgs e)
        {
            //var factor = this.DpiNew / Core.FormEx.DpiAtDesign;
            //this.ucAbout1.Width = (int)((this.Width - 40) * factor);
        }
	}
}
