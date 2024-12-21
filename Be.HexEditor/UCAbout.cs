using System;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;

namespace Be.HexEditor
{
	/// <summary>
	/// Summary description for UCAbout.
	/// </summary>
	public partial class UCAbout : UserControl
	{
		public UCAbout()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call

            try
            {
                Assembly ca = Assembly.GetExecutingAssembly();

                string resThanksTo = "Be.HexEditor.Resources.ThanksTo.rtf";
                txtThanksTo.LoadFile(ca.GetManifestResourceStream(resThanksTo), RichTextBoxStreamType.RichText);

                string resLicense = "Be.HexEditor.Resources.LICENSE.txt";
                txtLicense.LoadFile(ca.GetManifestResourceStream(resLicense), RichTextBoxStreamType.PlainText);

                string resChanges = "Be.HexEditor.Resources.CHANGELOG.txt";
                txtChanges.LoadFile(ca.GetManifestResourceStream(resChanges), RichTextBoxStreamType.PlainText);

                lblVersion.Text = ca.GetName().Version.ToString();
            }
            catch (Exception)
            {
                return;
            }
		}

        protected override void ScaleControl(SizeF factor, BoundsSpecified specified)
        {
            
            base.ScaleControl(factor, specified);
        }

		private void lnkCompany_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			try
			{
				System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(lnkWorkspace.Text));
			}
			catch (Exception ex1)
			{
				MessageBox.Show(ex1.Message);
			}
		}

        private void UCAbout_Load(object sender, EventArgs e)
        {
            tabControl.Width = Width - 10;
            tabControl.Height = Height - tabControl.Top - 10;
            lblAuthor.Width = Width - lblAuthor.Left - 10;
            lnkWorkspace.Width = Width - lnkWorkspace.Left - 10;
            lblVersion.Width = Width - lblVersion.Left - 10;
        }
	}
}
