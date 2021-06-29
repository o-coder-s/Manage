using System;
using System.Diagnostics;
using System.Windows;

namespace Manage
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public ProcessStartInfo serverInfo { get; set; }
        public Process server { get; set; }
        public static ModernWpf.Controls.Frame MainF { get; set; }

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
    }
}
