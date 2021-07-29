using Manage.Base;
using Manage.Helpers;
using Manage.Models;

namespace Manage.ViewModels.Setup
{
    public class SetupVM : Base.ViewModel
    {

        #region Properties

        public Company Company { get; set; }
        public User User{ get; set; }

        public static SetupVM Instance { get; set; } = new SetupVM();

        Pages[] SetupPages =
        {
            Pages.Welcome,
            Pages.Agreement,
            Pages.Information,
            Pages.Account,
            Pages.Finish,
        };
        #endregion

        #region Commands
        public RelayCommand FinishCommand { get; set; }

        void Finish(object param)
        {
            WindowHelper.Show(Helpers.Windows.Login, true);
        }
        public RelayCommand NextCommand { get; set; }


        void Next(object param)
        {
            var index = int.Parse(param.ToString());
            NavigationHelper.Navigate(App.SetupF, SetupPages[index], Transitions.SlideFromRight, false);
        }

        bool CanNext(object param)
        {
            return true;
        }


        public RelayCommand PreviousCommand { get; set; }

        void Previous(object param)
        {
            var index = int.Parse(param.ToString());
            NavigationHelper.Navigate(App.SetupF, SetupPages[index], Transitions.SlideFromLeft, false);
        }

        bool CanPrevious(object param)
        {
            return true;
        }

        #endregion

        #region Constructors

        public SetupVM()
        {

            NextCommand = new RelayCommand(Next,CanNext);
            PreviousCommand = new RelayCommand(Previous,CanPrevious);
            FinishCommand = new RelayCommand(Finish);

        }

        #endregion
    }
}
