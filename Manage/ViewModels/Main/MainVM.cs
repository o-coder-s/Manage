using Manage.Base;
using Manage.Models;
using System;
using System.Collections.Generic;
using System.Windows.Threading;

namespace Manage.ViewModels.Main
{
    public class MainVM : Base.ViewModel
    {
        public string MenuIcon { get; set; } = "MenuIcon";

        #region Commands;

        public RelayCommand NavigateHomeCommand { get; set; }
        // Can Navigate Home
        public bool CanNavigateHome(object param)
        {
            return true;
        }


        // Navigate to Main Page 
        //public void NavigateHome(object param)
        //{
        //    NavigationHelper.NavigateTo(App.MainF, NavigationHelper.Pages.Main, NavigationHelper.Transitions.DrillIn, true);
        //}

        //public RelayCommand LogoutCommand { get; set; }


        //public bool CanLogout(object param) => true;
        //public void Logout(object param)
        //{
        //    App.DialogRequest = true;
        //    Logout logout = new Logout();
        //    logout.ShowAsync();
        //}

        public RelayCommand ChangeThemeCommand { set; get; }

        public void ChangeTheme(object param)
        {
            if (ThemeImage == "Dark")
            {
                ThemeImage = "Light";
                ModernWpf.ThemeManager.Current.ApplicationTheme = ModernWpf.ApplicationTheme.Dark;
            }
            else
            {
                ThemeImage = "Dark";
                ModernWpf.ThemeManager.Current.ApplicationTheme = ModernWpf.ApplicationTheme.Light;
            }
        }

        #endregion

        #region Properties

        public DateTime Now { get; set; }
        public string DayOfWeek { get; set; }
        public string ThemeImage { get; set; }
        public User CurrentUser { get; set; }
        public bool CanGoHome { get; set; }
        public Uri MainPage { get; set; }

        #endregion

        #region Private Properties

        private List<string> Days { get; } = new List<string>()
        {
            "Dimanche",
            "Lundi",
            "Mardi",
            "Mercredi",
            "Jeudi",
            "Vendredi",
            "Samedi",
        };

        #endregion

        #region Constructors

        public MainVM()
        {
            // Initializing commands
            ChangeThemeCommand = new RelayCommand(ChangeTheme);
            //NavigateHomeCommand = new RelayCommand(NavigateHome, CanNavigateHome);
            //LogoutCommand = new RelayCommand(Logout, CanLogout);
            // Theme Image
            ThemeImage = ModernWpf.ThemeManager.Current.ApplicationTheme == ModernWpf.ApplicationTheme.Light ? "Dark" : "Light";

            // Main Page

            // MainPage = new Uri("../../Views/Pages/Main/Main.xaml", UriKind.Relative);

            // Timer
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);

            timer.Tick += new EventHandler(TimerTick);
            timer.Start();
            DayOfWeek = Days[(int)DateTime.Now.DayOfWeek];

        }

        #endregion

        #region Methods

        void TimerTick(object sender, EventArgs e)
        {
            Now = DateTime.Now;
            DayOfWeek = Days[(int)DateTime.Now.DayOfWeek];
        }

        #endregion
    }
}
