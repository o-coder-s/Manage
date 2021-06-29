using Manage.Views.Windows;
using Action = Manage.Views.Windows.Action;
using System.Windows;

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

        public static void Show(Windows window, bool CloseCurrent)
        {
            Window tmp = CurrentWindow;
            CurrentWindow = GetWindow(window);
            CurrentWindow.Show();
            if (CloseCurrent) tmp.Close();
        }

        public static void ShowDialog(Windows window)
        {

            Window Dialog = GetWindow(window);
            Dialog.ShowInTaskbar = false;
            Dialog.ShowDialog();

        }

        private static Window GetWindow(Windows window)
        {
            switch (window)
            {
                case Windows.Action:
                    return new Action();

                case Windows.Login:
                    return new Login();

                case Windows.Main:
                    return new Main();

                case Windows.Print:
                    return new Print();

                case Windows.Setup:
                    return new Setup();

                default:
                    return new Main();
            }
        }

        #endregion

    }
}
