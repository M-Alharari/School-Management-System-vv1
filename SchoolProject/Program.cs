

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
 
using System.Windows.Forms;

namespace SchoolProject
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // License check BEFORE login
            if (!LicenseManager.IsLicenseValid())
            {
                using (var activateForm = new frmActivateLicense())
                {
                    if (activateForm.ShowDialog() != DialogResult.OK)
                    {
                        MessageBox.Show("License is required. Application will exit.");
                        return; // Exit application
                    }
                }
            }

            // Show login form
            using (var loginForm = new frmLogin())
            {
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    // Only run main form if login succeeds
                    Application.Run(new frmMain(loginForm));
                }
            }
        }
    }

}
