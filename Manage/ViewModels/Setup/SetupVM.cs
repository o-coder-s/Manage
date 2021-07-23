using Manage.Base;

namespace Manage.ViewModels.Setup
{
    public class SetupVM : Base.ViewModel
    {
        #region Properties

        public string ThemeImage { get; set; }

        #endregion

        #region Commands


        public RelayCommand ChangeThemeCommand { set; get; }

        public void ChangeTheme(object param)
        {
            if (ThemeImage == "Dark")
            {
                ThemeImage = "Light";
                ModernWpf.ThemeManager.Current.ApplicationTheme = ModernWpf.ApplicationTheme.Dark;
            }
            else
            {
                ThemeImage = "Dark";
                ModernWpf.ThemeManager.Current.ApplicationTheme = ModernWpf.ApplicationTheme.Light;
            }
        }
        #endregion

        #region Constructors

        public SetupVM()
        {
            // check the theme
            ThemeImage = ModernWpf.ThemeManager.Current.ApplicationTheme == ModernWpf.ApplicationTheme.Light ? "Dark" : "Light";

            // initialize commands

            ChangeThemeCommand = new RelayCommand(ChangeTheme);
        }

        #endregion
    }
}
