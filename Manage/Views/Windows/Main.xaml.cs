using Manage.Helpers;

namespace Manage.Views.Windows
{
    /// <summary>
    /// Interaction logic for Main.xaml
    /// </summary>
    public partial class Main : System.Windows.Window
    {
        public Main(object ExtraData = null) : this()
        {

        }

        public Main()
        {
            InitializeComponent();
            App.MainF = MainF;
            NavigationHelper.Navigate(App.MainF, Helpers.Pages.Menu, Transitions.Suppress);
        }

        
    }
}
