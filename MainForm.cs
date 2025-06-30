using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

public partial class MainForm : RibbonForm
{
    public MainForm()
    {
        InitializeComponent();
        // Apply a DevExpress skin
        DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Office 2019 Colorful");
        this.StartPosition = FormStartPosition.CenterScreen;
    }

    private void btnLogin_Click(object sender, EventArgs e)
    {
        // Basic login logic (replace with your actual authentication)
        if (txtUsername.Text == "admin" && txtPassword.Text == "password")
        {
            XtraMessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Proceed to the main application window or next step
            // For example:
            // MainApplicationForm mainApp = new MainApplicationForm();
            // mainApp.Show();
            // this.Hide();
        }
        else
        {
            XtraMessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void hyperLinkEditForgotPassword_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
    {
        // Handle "Forgot Password?" link click
        e.Handled = true; // Prevents the default browser action
        XtraMessageBox.Show("Forgot Password link clicked. Implement your password recovery logic here.", "Forgot Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
        // For example, open a password recovery form or webpage
        // System.Diagnostics.Process.Start("https://yourdomain.com/forgot-password");
    }
}
