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
            MainF.Navigate(typeof(Menu));
        }
    }
}
