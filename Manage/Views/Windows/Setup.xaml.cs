using System.Windows;

namespace Manage.Views.Windows
{
    /// <summary>
    /// Interaction logic for Setup.xaml
    /// </summary>
    public partial class Setup : Window
    {
        public Setup(object ExtraData = null)
        {
            InitializeComponent();
            App.SetupF = SetupF;
        }
        public Setup()
        {
            InitializeComponent();
            App.SetupF = SetupF;
        }


    }
}
