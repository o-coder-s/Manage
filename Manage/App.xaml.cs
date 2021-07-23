using System.Diagnostics;
using System.Windows;

namespace Manage
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        #region Frames

        public static ModernWpf.Controls.Frame MainF { get; set; }
        public static ModernWpf.Controls.Frame ActionF { get; set; }
        public static ModernWpf.Controls.Frame PrintF { get; set; }
        public static ModernWpf.Controls.Frame LoginF { get; set; }
        public static ModernWpf.Controls.Frame SetupF { get; set; }

        #endregion

        #region Static Properties
        public static string ServerIP { get; set; }
        public static string ServerPort { get; set; }
        public static string JwtToken { get; set; }
        #endregion

        #region Properties
        public ProcessStartInfo serverInfo { get; set; }
        public Process server { get; set; }
        #endregion

        #region Overrides


        protected override void OnStartup(StartupEventArgs e)
        {
            //try
            //{
            //    serverInfo = new ProcessStartInfo { WorkingDirectory = Environment.CurrentDirectory, FileName = "server.exe", CreateNoWindow = true, UseShellExecute = false };
            //    server = Process.Start(serverInfo);

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Server is not running \n" + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            //}
        }

        protected override void OnExit(ExitEventArgs e)
        {
            // Make sure it's only in the server 
            //try
            //{
            //    server?.Kill();

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Server is not running\n" + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            //}
        }
        #endregion

        #region Constructors

        public App()
        {
            // Find server if this Application is a client

            ModernWpf.ThemeManager.Current.ApplicationTheme = ModernWpf.ApplicationTheme.Light;
        }
        #endregion
    }
}
