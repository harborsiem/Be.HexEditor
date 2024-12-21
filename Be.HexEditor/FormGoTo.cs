using System;
using System.Windows.Forms;

namespace Be.HexEditor
{
    /// <summary>
    /// Summary description for FormGoTo.
    /// </summary>
    public partial class FormGoTo : Form //Core.FormEx
    {
        public FormGoTo()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        public void SetDefaultValue(long byteIndex)
        {
            nup.Value = byteIndex + 1;
        }

        public void SetMaxByteIndex(long maxByteIndex)
        {
            nup.Maximum = maxByteIndex + 1;
        }

        public long GetByteIndex()
        {
            return Convert.ToInt64(nup.Value) - 1;
        }

        private void FormGoTo_Activated(object sender, EventArgs e)
        {
            nup.Focus();
            nup.Select(0, nup.Value.ToString().Length);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void chkHexa_CheckedChanged(object sender, EventArgs e)
        {
            nup.Hexadecimal = chkHexa.Checked;
        }
    }
}
