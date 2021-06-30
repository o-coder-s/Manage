using Manage.Helpers;
using Manage.Views.Pages.Main;
namespace Manage.Views.Windows
{
    /// <summary>
    /// Interaction logic for Main.xaml
    /// </summary>
    public partial class Main : System.Windows.Window
    {
        public Main()
        {
            InitializeComponent();
            App.MainF = MainF;

            NavigationHelper.Navigate(App.MainF, Helpers.Pages.Menu, Transitions.Entrance);
        }
    }
}
