using Manage.Base;
using Manage.Helpers;
using Manage.Models;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace Manage.ViewModels.Login
{
    public class LoginVM : ViewModel
    {
        #region Static Properties

        // Singlton Object
        public static LoginVM Instance { get; set; } = new LoginVM();

        #endregion

        #region Properties
        public int SelectedIndex { get; set; } = 0;
        public User SelectedUser { get; set; }
        public User User { get; set; }
        public List<User> Users { get; set; }

        public string FirstAnswer { get; set; }
        public string SecondAnswer { get; set; }

        #endregion

        #region Commands

        public RelayCommand ResetPasswordCommand { get; set; }
        public RelayCommand BackCommand { get; set; }
        public RelayCommand NextCommand { get; set; }
        public RelayCommand DoneCommand { get; set; }
        public RelayCommand LoginCommand { get; set; }
        public RelayCommand CancelCommand { get; set; }
        #endregion

        #region Constructors

        public LoginVM()
        {
            LoginCommand = new RelayCommand(Login, CanLogin);
            ResetPasswordCommand = new RelayCommand(ResetPassword);
            BackCommand = new RelayCommand(Back);
            NextCommand = new RelayCommand(Next,CanNext);
            DoneCommand = new RelayCommand(Done, CanDone);
            CancelCommand = new RelayCommand(Cancel);

            // initializing users
            Users = new List<User>();
            Users.Add(new User()
            {
                Username = "oSethoum",
                Password = "1234",
                Role = "Administrator",
                FirstQuestion = "What's the name of your pet",
                FirstAnswer = "Caty",
                SecondQuestion = "The name of your father",
                SecondAnswer = "Oussama"
            });
            Users.Add(new User()
            {
                Username = "bYasser",
                Password = "4321",
                Role = "Employee",
                FirstQuestion = "What's the name of your pet",
                FirstAnswer = "Dog",
                SecondQuestion = "The name of your father",
                SecondAnswer = "Salim"
            });
        }

        private void Cancel(object obj)
        {
            NavigationHelper.Navigate(App.LoginF, Pages.SignIn, Transitions.SlideFromLeft, true);
        }

        #endregion

        #region Methods

        private bool CanDone(object param)
        {
            var values = param as object[];
            if (values == null) return false;
            var newPassword = (values[0] as PasswordBox).Password;
            var confirmPassword = (values[1] as PasswordBox).Password;

            return newPassword.Length > 4 && newPassword == confirmPassword;
        }

        private void Done(object obj)
        {
            NavigationHelper.Navigate(App.LoginF, Pages.SignIn, Transitions.SlideFromLeft);
        }

        private void Next(object param)
        {
            
            NavigationHelper.Navigate(App.LoginF, Pages.NewPassword, Transitions.SlideFromRight, true);
        }

        private bool CanNext(object param)
        {
            var Answers = param as object[];
            return Answers != null && SelectedUser.FirstAnswer == Answers[0].ToString() && SelectedUser.SecondAnswer == Answers[1].ToString();
        }

        private void Back(object param)
        {
            NavigationHelper.Navigate(App.LoginF, Pages.SignIn, Transitions.SlideFromLeft, true);
        }

        private bool CanLogin(object param)
        {
            var values = param as object[];
            if (values == null) return false;
            var index = (values[0] as ComboBox)?.SelectedIndex == null ? -1 : (values[0] as ComboBox)?.SelectedIndex;
            var password = (values[1] as PasswordBox).Password;

            if (password == Users[(int)index].Password) return true;
            return false;
        }

        private void Login(object param)
        {
            WindowHelper.Show(Helpers.Windows.Main, true);
        }

        public void ResetPassword(object param)
        {
            SelectedUser = Users[SelectedIndex];
            NavigationHelper.Navigate(App.LoginF, Pages.Questions, Transitions.SlideFromRight, true);
        }

        #endregion
    }
}
