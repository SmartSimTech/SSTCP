using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using WindowsTaskDialog;
using System.Net.Mail;
using System.Net;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;

namespace SSTCP
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Add the event handler for handling UI thread exceptions to the event.
            Application.ThreadException += new ThreadExceptionEventHandler(Form1_UIThreadException);

            // Set the unhandled exception mode to force all Windows Forms errors to go through
            // our handler.
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);

            // Add the event handler for handling non-UI thread exceptions to the event. 
            //AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);

            //Forms.frmSplash frm = new Forms.frmSplash();
            Forms.frmTransparentSplash launch = new Forms.frmTransparentSplash();
            launch.Show();
            launch.Refresh();

            // Check for latest version
            Version vrs = new Version(Application.ProductVersion);
            //lblAppVersion.Caption = String.Format("Version: {0}.{1}.{2}", vrs.Major, vrs.Minor, vrs.Build);
            try
            {
                string latestversion;
                WebClient getversion = new WebClient();
                latestversion = getversion.DownloadString("http://www.smartsimtech.com/software/sstcp-latestversion.txt");
                Version latver = new Version(latestversion);
                getversion.Dispose();
                if (latver > vrs)
                {
                    Forms.frmAutoUpdate update = new Forms.frmAutoUpdate();
                    update.AppVersion = latestversion;
                    update.ShowDialog();
                    if (update.ApplyUpdate)
                        return;
                }
            }
            catch (Exception)
            {
                // No internet access to check for updates
            }

            launch.CheckDatabase();
            //MessageBox.Show(XpoDefault.Session.ConnectionString);
            //XpoDefault.Session.ConnectionString = "data source=localhost\\SQLEXPRESS;integrated security=true;initial catalog=SSTCP2;";
            //XpoDefault.Session.ConnectionString = String.Format("data source=tcp:{0}.database.windows.net;initial catalog={1};user id={2};password={3};", serverName, databaseName, userName, password);

            launch.CheckRegistration();
            XPView view = new XPView(Session.DefaultSession, typeof(Database.Registration));
            view.AddProperty("Name", "Name");
            view.AddProperty("Company", "Company");
            bool registered = false;
            foreach (ViewRecord record in view)
            {
                registered = true;
            }

            if (!registered)
            {
                Forms.frmRegistrationDetails register = new Forms.frmRegistrationDetails();
                register.ShowDialog();
                register.Dispose();
            }

            launch.LaunchApplication();

            if (launch.RunApplication)
            {
                Forms.frmMain MainApp = new Forms.frmMain();
                MainApp.LaunchProcess = launch;
                Application.Run(MainApp);
            }
            else
            {
                launch.Dispose();
            }
        }

        private static void Form1_UIThreadException(object sender, ThreadExceptionEventArgs t)
        {
            try
            {
                // Create task dialog.
                TaskDialog taskDialog = new TaskDialog();
                taskDialog.WindowTitle = "Smart Sim Tech Application Error";
                taskDialog.MainIcon = TaskDialogIcon.Error;
                taskDialog.MainInstruction = "Smart Sim Tech Application Error";
                taskDialog.Content = "There was an unhandled exception with the application caused by an error.  The application is still running, but it is recommended to report the error and restart the application.";
                taskDialog.ExpandedInformation = t.Exception.ToString();
                taskDialog.ExpandFooterArea = true;   // Whether to display expanded information at footer.
                taskDialog.ExpandedByDefault = false;  // Whether expanded information is initially displayed.
                taskDialog.CollapsedControlText = "&Show debug information";  // Expand/collapse control caption can be changed.
                taskDialog.ExpandedControlText = "&Hide debug information";   // Expand/collapse control caption can be changed.
                TaskDialog.ShowNonVistaTaskDialogOnVistaOS = true;
                taskDialog.UseCommandLinks = true;
                List<TaskDialogButton> buttons = new List<TaskDialogButton>();
                buttons.Add(new TaskDialogButton(0, "Send Error Report and Close"));
                buttons.Add(new TaskDialogButton(1, "Send Error Report and Ignore"));
                buttons.Add(new TaskDialogButton(2, "Close Application"));
                buttons.Add(new TaskDialogButton(3, "Ignore Error"));
                taskDialog.Buttons = buttons.ToArray();
                taskDialog.DefaultButton = 0;

                int Result = taskDialog.Show(null);

                switch (Result)
                {
                    case 0: // Send Error Report and Close
                        Application.ExitThread();
                        sendErrorReport(t.Exception.ToString());
                        break;
                    case 1: // Send Error Report and Ignore
                        sendErrorReport(t.Exception.ToString());
                        break;
                    case 2: // Close Application
                        Application.ExitThread();
                        break;
                    case 3: // Ignore Error

                        break;
                    default:
                        Application.ExitThread();
                        break;
                }
            }
            catch
            {
                try
                {
                    MessageBox.Show("Fatal Windows Forms Error",
                        "Fatal Windows Forms Error", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Stop);
                }
                finally
                {
                    Application.Exit();
                }
            }

            // Exits the program when the user clicks Abort.
            //if (result == DialogResult.Abort)
            //    Application.Exit();
        }

        private static void sendErrorReport(string error)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("smartsimtech@gmail.com");
                mail.To.Add("smartsimtech@gmail.com");
                mail.Subject = "Smart Sim Tech Application Error";
                mail.Body = error;

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("smartsimtech", "proam445");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                MessageBox.Show("mail Send");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private static DialogResult ShowThreadExceptionDialog(string title, Exception e)
        {
            string errorMsg = "An application error occurred. Please contact the adminstrator " +
                "with the following information:\n\n";
            errorMsg = errorMsg + e.Message + "\n\nStack Trace:\n" + e.StackTrace;
            return MessageBox.Show(errorMsg, title, MessageBoxButtons.AbortRetryIgnore,
                MessageBoxIcon.Stop);
        }
    }
}
