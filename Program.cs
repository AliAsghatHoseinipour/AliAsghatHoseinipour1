using System;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.UserSkins;
using DevExpress.XtraSplashScreen; // Required for SplashScreenManager

static class Program
{
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // Register DevExpress skins
        BonusSkins.Register();
        SkinManager.EnableFormSkins();
        SkinManager.EnableMdiFormSkins(); // For MDI applications

        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        // --- How to use SplashScreenManager ---
        // 1. Add a new DevExpress SplashScreen or WaitForm to your project.
        //    Let's assume you named it 'SplashScreen1'.
        // 2. Show it before the main form loads:
        // SplashScreenManager.ShowForm(typeof(SplashScreen1));

        // Simulate some loading time for the splash screen to be visible
        // System.Threading.Thread.Sleep(3000); // Remove this in a real application

        MainForm mainForm = new MainForm();

        // 3. Close the splash screen when the main form is ready (e.g., in MainForm's Load or Shown event)
        //    or right before showing the main form if loading is quick.
        // SplashScreenManager.CloseForm(false); // Pass 'false' to close smoothly

        Application.Run(mainForm);
    }
}
