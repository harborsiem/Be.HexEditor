using System;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using System.Diagnostics;

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
#if Ribbon
            lblAuthor.Text = "Bernhard Elbl, harborsiem";
            lnkWorkspace.Text = "https://github.com/harborsiem/HexEdit-Ribbon";
#else
            lblAuthor.Text = "Bernhard Elbl";
            lnkWorkspace.Text = "https://sourceforge.net/projects/hexbox";
#endif
            lnkWorkspace.TabStop = true;
            try
            {
                Assembly ca = Assembly.GetExecutingAssembly();
                Stream resourceStream;

                string resThanksTo = "Be.HexEditor.Resources.ThanksTo.rtf";
                resourceStream = ca.GetManifestResourceStream(resThanksTo);
                if (resourceStream != null)
                {
                    txtThanksTo.LoadFile(resourceStream, RichTextBoxStreamType.RichText);
                }

                string resLicense = "Be.HexEditor.Resources.LICENSE.txt";
                resourceStream = ca.GetManifestResourceStream(resLicense);
                if (resourceStream != null)
                {
                    txtLicense.LoadFile(resourceStream, RichTextBoxStreamType.PlainText);
                }

                string resChanges = "Be.HexEditor.Resources.CHANGELOG.txt";
                resourceStream = ca.GetManifestResourceStream(resChanges);
                if (resourceStream != null)
                {
                    txtChanges.LoadFile(resourceStream, RichTextBoxStreamType.PlainText);
                }

                FileVersionInfo info = FileVersionInfo.GetVersionInfo(ca.Location);
                //Version version = ca.GetName().Version;
                if (info != null)
                {
                    lblVersion.Text = info.FileVersion;
                }
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
