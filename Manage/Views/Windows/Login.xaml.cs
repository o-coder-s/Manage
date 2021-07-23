using System.Windows;

namespace Manage.Views.Windows
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login(object ExtraData = null) : this()
        {
           
        }

        public Login()
        {
            InitializeComponent();
            App.LoginF = LoginF;
            Helpers.NavigationHelper.Navigate(App.LoginF, Helpers.Pages.SignIn, Helpers.Transitions.DrillIn, true);
            
        }
    }
}
