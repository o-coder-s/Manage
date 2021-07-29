using Manage.Helpers;
using System.Windows;
using System.Windows.Media.Animation;

namespace Manage.Views.Windows
{
    /// <summary>
    /// Interaction logic for Setup.xaml
    /// </summary>
    public partial class Setup : Window
    { 
        public Setup(object ExtraData = null) : this()
        {

        }
        public Setup()
        {
            InitializeComponent();
            App.SetupF = SetupF;
            NavigationHelper.Navigate(App.SetupF, Helpers.Pages.Welcome, Transitions.Suppress);
        }
    }
}
