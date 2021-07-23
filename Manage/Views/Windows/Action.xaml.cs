using System.Windows;

namespace Manage.Views.Windows
{
    /// <summary>
    /// Interaction logic for Action.xaml
    /// </summary>
    public partial class Action : Window
    {
        public Action(object ExtraData = null)
        {
            InitializeComponent();
            App.ActionF = ActionF;
        }
        public Action()
        {
            InitializeComponent();
            App.ActionF = ActionF;
        }
    }
}
