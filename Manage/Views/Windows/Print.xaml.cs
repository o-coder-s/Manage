using System.Windows;

namespace Manage.Views.Windows
{
    /// <summary>
    /// Interaction logic for Print.xaml
    /// </summary>
    public partial class Print : Window
    {
        public Print(object ExtraData = null) : this() { }

        public Print()
        {
            InitializeComponent();
            App.PrintF = PrintF;
        }
    }
}
