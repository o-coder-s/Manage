using Manage.Base;
using Manage.Models;
using System.Collections.Generic;
using System.Windows.Controls;

namespace Manage.ViewModels.Login
{
    public class SignInVM : Base.ViewModel
    {

        #region Properties
        public User User { get; set; }
        public List<User> Users { get; set; }
        #endregion

        #region Commands

        public RelayCommand LoginCommand { get; set; }

        public bool CanLogin(object param)
        {
            var values = param as object[];
            if (values == null) return false;
            var index = (values[0] as ComboBox)?.SelectedIndex == null ? -1 : (values[0] as ComboBox)?.SelectedIndex;
            var password = (values[1] as PasswordBox).Password;

            if (password == Users[(int)index].Password) return true;
            return false;
        }

        public void Login(object param)
        {
            var values = param as object[];
            var index = (values[0] as ComboBox)?.SelectedIndex;
            var password = (values[1] as PasswordBox).Password;
            Helpers.WindowHelper.Show(Helpers.Windows.Main, true);
        }

        #endregion

        public SignInVM()
        {
            LoginCommand = new RelayCommand(Login, CanLogin);

            // initializing users
            Users = new List<User>();
            Users.Add(new User() { Username = "oSethoum", Password = "1234", Role = "Administrator" });
            Users.Add(new User() { Username = "bYasser", Password = "4321", Role = "Employee" });
        }
    }
}
