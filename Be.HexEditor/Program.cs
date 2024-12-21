using System;
using System.Windows.Forms;
using System.Threading;
using System.Globalization;
using Be.HexEditor.Properties;

namespace Be.HexEditor
{
    class Program
    {
        public const string SoftwareName = "Be.HexEditor";

        public static FormHexEditor ApplicationForm;

        [STAThread()]
        static void Main(string[] args)
        {
            if (!Settings.Default.UseSystemLanguage)
            {
                string l = Settings.Default.SelectedLanguage;
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(l);
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(l);
            }

            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            ApplicationForm = new FormHexEditor();
            if (args.Length > 0 && System.IO.File.Exists(args[0]))
                ApplicationForm.OpenFile(args[0]);
            Application.Run(ApplicationForm);
        }

        public static DialogResult ShowError(Exception ex)
        {
            return ShowError(ex.Message);
        }


        internal static DialogResult ShowError(string text)
        {
            DialogResult result = MessageBox.Show(text, SoftwareName,
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            return result;
        }

        public static void ShowMessage(string text)
        {
            MessageBox.Show(text, SoftwareName,
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        public static DialogResult ShowQuestion(string text)
        {
            DialogResult result = MessageBox.Show(text, SoftwareName,
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question);
            return result;
        }
    }
}
