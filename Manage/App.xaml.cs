using Manage.Helpers;
using Manage.Models;
using SQLite;
using System;
using System.Diagnostics;
using System.IO;
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

        // Database
        public static string AppDataFolder { get; } = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Manage");
        public static string ImagesFolder { get; } = Path.Combine(AppDataFolder, "Images");
        public static string DatabasePath { get; } = Path.Combine(AppDataFolder, "Manage.db");

        public static SQLiteConnection DBConn { get; set; }
        //public static 


        public static Pages CurrentPage { get; set; }
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

            try
            {
                // Created the folder
                Directory.CreateDirectory(AppDataFolder);
                Directory.CreateDirectory(ImagesFolder);

                // Create database
                DBConn = new SQLiteConnection(DatabasePath);

                // Migration Database

                DBConn.CreateTable<BillIn>();
                DBConn.CreateTable<BillInProduct>();
                DBConn.CreateTable<BillOut>();
                DBConn.CreateTable<BillOutProduct>();
                DBConn.CreateTable<Brand>();
                DBConn.CreateTable<Category>();
                DBConn.CreateTable<Client>();
                DBConn.CreateTable<ClientPayment>();
                DBConn.CreateTable<Company>();
                DBConn.CreateTable<Depot>();
                DBConn.CreateTable<Employee>();
                DBConn.CreateTable<Expense>();
                DBConn.CreateTable<Favourite>();
                DBConn.CreateTable<Order>();
                DBConn.CreateTable<OrderProduct>();
                DBConn.CreateTable<Person>();
                DBConn.CreateTable<Role>();
                DBConn.CreateTable<Stock>();
                DBConn.CreateTable<Supplier>();
                DBConn.CreateTable<Tax>();
                DBConn.CreateTable<User>();

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Error");
                throw;
            }
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
