using System.Windows;

namespace Manage.Views.Windows
{
    /// <summary>
    /// Interaction logic for Action.xaml
    /// </summary>
    public partial class Action : Window
    {
        public Action(object ExtraData = null): this ()
        {

            
        }
        public Action()
        {
            InitializeComponent();
            App.ActionF = ActionF;
            
        }
    }
}
