using Manage.Base;
using Manage.Models;
using System;
using System.Windows.Threading;

namespace Manage.ViewModels.Main
{
    public class MainVM : Base.ViewModel
    {

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



        #endregion

        #region Properties
        public string MenuIcon { get; set; } = "MenuIcon";

        public DateTime Now { get; set; }
        public string DayOfWeek { get; set; }
        public User CurrentUser { get; set; }
        public bool CanGoHome { get; set; }
        public Uri MainPage { get; set; }

        #endregion

        #region Private Properties

        private string[] Days { get; } =
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
