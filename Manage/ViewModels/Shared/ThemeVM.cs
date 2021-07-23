using Manage.Base;

namespace Manage.ViewModels.Shared
{
    public class ThemeVM: Base.ViewModel
    {
       
        public string ThemeImage { get; set; }

        public RelayCommand ChangeThemeCommand{ get; set; }

        public void ChangeTheme (object param)
        {
            if (ThemeImage == "Light")
            {
                ThemeImage = "Dark";
                ModernWpf.ThemeManager.Current.ApplicationTheme = ModernWpf.ApplicationTheme.Light;
            }
            else
            {
                ThemeImage = "Light";
                ModernWpf.ThemeManager.Current.ApplicationTheme = ModernWpf.ApplicationTheme.Dark;
            }
        }

        public ThemeVM()
        {
            ThemeImage = ModernWpf.ThemeManager.Current.ApplicationTheme == ModernWpf.ApplicationTheme.Light ? "Dark" : "Light";
            ChangeThemeCommand = new RelayCommand(ChangeTheme);
        }

        public static ThemeVM Instance { get; set; } = new ThemeVM();

    }
}
