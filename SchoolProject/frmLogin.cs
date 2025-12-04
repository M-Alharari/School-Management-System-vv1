using SchoolProject.Global;
using SchoolProjectBusiness;

namespace SchoolProject
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            clsUser user = clsUser.FindByUsernameAndPassword(txtUserName.Text.Trim(), txtPassword.Text.Trim());

            if (user != null)
            {
                if (chkRememberMe.Checked)
                {
                    //store username and password
                    clsGlobal.RememberUsernameAndPassword(txtUserName.Text.Trim(), txtPassword.Text.Trim());
                }
                else
                {
                    //store empty username and password
                    clsGlobal.RememberUsernameAndPassword("", "");
                }

                //incase the user is not active
                if (!user.IsActive)
                {
                    txtUserName.Focus();
                    MessageBox.Show("Your account is not Active, Contact Admin.", "In Active Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Set current user
                clsGlobal.CurrentUser = user;

                // ------------------ LICENSE CHECK ------------------
                if (!LicenseManager.IsLicenseValid())
                {
                    MessageBox.Show("License invalid or expired. Contact support.", "License Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // stop login, do not open main form
                }

                // Optional: show remaining days
                MessageBox.Show(LicenseManager.GetLicenseExpiryMessage(), "License Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // ----------------------------------------------------

                // Open Main Form
                this.Hide();
                frmMain frm = new frmMain(this);
                frm.ShowDialog();
            }
            else
            {
                txtUserName.Focus();
                MessageBox.Show("Invalid Username/Password.", "Wrong Credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            string UserName = "", Password = "";

            if (clsGlobal.GetStoredCredential(ref UserName, ref Password))
            {
                txtUserName.Text = UserName;
                txtPassword.Text = Password;
                chkRememberMe.Checked = true;
            }
            else
                chkRememberMe.Checked = false;
        }
    }
}
