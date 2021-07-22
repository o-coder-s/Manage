using System;
using Manage.Views.Pages.Main;
using Manage.Views.Pages.Login;
using ModernWpf.Media.Animation;


namespace Manage.Helpers
{
    public enum Transitions
    {
        Entrance,
        DrillIn,
        Suppress,
        SlideFromRight,
        SlideFromLeft,
        SlideFromBottom
    }

    public enum Pages
    {
        // Main Pages
        Menu,
        Clients,
        Suppliers,
        Stock,
        Purchases,
        Sales,
        ReturnPurchases,
        ReturnSales,
        SellOnDesk,
        CashRegister,
        Expenses,
        Articles,
        Settings,

        // Login Pages
        SignIn,
        NewPassword,
        Questions,

        // Action Pages

        // Print Pages

        // Setup Pages

    }



    public class NavigationHelper
    {
        #region Static Properties


        #endregion

        #region Static Methods

        public static void Navigate(ModernWpf.Controls.Frame frame, Pages page, Transitions transitions, bool clearHistory = true)
        {
            frame.Navigate(GetPageType(page), null, GetTransition(transitions));
            if (clearHistory)
            {
                // Check the property back stack to see if you can save sometimes instances
                frame.RemoveBackEntry();
            }
        }

        private static Type GetPageType(Pages page)
        {
            switch (page)
            {
                case Pages.Menu:
                    return typeof(Menu);
                case Pages.SignIn:
                    return typeof(SignIn);
                case Pages.NewPassword:
                    return typeof(NewPassword);
                case Pages.Questions:
                    return typeof(Questions);

                default:
                    // Default no data or Error 404
                    return typeof(Menu);
            }
        }

        private static NavigationTransitionInfo GetTransition(Transitions transition)
        {
            switch (transition)
            {
                case Transitions.Entrance:
                    return new EntranceNavigationTransitionInfo();
                case Transitions.DrillIn:
                    return new DrillInNavigationTransitionInfo();
                case Transitions.Suppress:
                    return new SuppressNavigationTransitionInfo();

                case Transitions.SlideFromRight:
                    return new SlideNavigationTransitionInfo() { Effect = SlideNavigationTransitionEffect.FromRight };

                case Transitions.SlideFromLeft:
                    return new SlideNavigationTransitionInfo() { Effect = SlideNavigationTransitionEffect.FromLeft };

                case Transitions.SlideFromBottom:
                    return new SlideNavigationTransitionInfo() { Effect = SlideNavigationTransitionEffect.FromBottom };

                default:
                    return new EntranceNavigationTransitionInfo();

            }
        }

        #endregion
    }
}
