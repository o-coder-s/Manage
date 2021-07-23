using Manage.Base;
using Manage.Models;
using System.Windows;
using System.Windows.Controls;

namespace Manage.ViewModels.Login
{
    public class SignInVM : Base.ViewModel
    {

        #region Properties
        public User User { get; set; }
        #endregion

        #region Commands

        public RelayCommand LoginCommand { get; set; }

        public bool CanLogin(object param)
        {
            var values = param as object[];
            if (values == null) return false;
            var index = (values[0] as ComboBox)?.SelectedIndex == null ? -1 : (values[0] as ComboBox)?.SelectedIndex;
            var password = (values[1] as PasswordBox).Password;

            if (password == "1234") return true;
            return false;
        }

        public void Login(object param)
        {
            var values = param as object[];
            var index = (values[0] as ComboBox)?.SelectedIndex;
            var password = (values[1] as PasswordBox).Password;
            MessageBox.Show(index.ToString(), "Index ");
            MessageBox.Show(password, "Password is ");
            Helpers.WindowHelper.Show(Helpers.Windows.Main, true);
        }

        #endregion

        public SignInVM()
        {
            LoginCommand = new RelayCommand(Login, CanLogin);
        }
    }
}
