using Manage.Views.Windows;
using System.Windows;
using Action = Manage.Views.Windows.Action;

namespace Manage.Helpers
{
    public enum Windows
    {
        Action,
        Login,
        Main,
        Print,
        Setup
    }

    public class WindowHelper
    {
        #region Static Properties

        public static Window CurrentWindow { get; private set; } = App.Current.Windows[0];

        #endregion

        #region Static Methods

        public static void Show(Windows window, bool CloseCurrent = false, object ExtraData = null)
        {
            Window tmp = CurrentWindow;
            CurrentWindow = GetWindow(window, ExtraData);
            CurrentWindow.Show();
            if (CloseCurrent) tmp.Close();
        }

        public static void ShowDialog(Windows window, object ExtraData = null)
        {

            Window Dialog = GetWindow(window, ExtraData);
            Dialog.ShowInTaskbar = false;
            Dialog.ShowDialog();

        }

        private static Window GetWindow(Windows window, object ExtraData = null)
        {
            switch (window)
            {
                case Windows.Action:
                    return new Action(ExtraData);

                case Windows.Login:
                    return new Login(ExtraData);

                case Windows.Main:
                    return new Main(ExtraData);

                case Windows.Print:
                    return new Print(ExtraData);

                case Windows.Setup:
                    return new Setup(ExtraData);

                default:
                    return new Main(ExtraData);
            }
        }

        #endregion

    }
}
