using Manage.Views.Pages.Error;
using Manage.Views.Pages.Login;
using Manage.Views.Pages.Main;
using Manage.Views.Pages.Setup;
using ModernWpf.Media.Animation;
using System;


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
        Welcome,
        Agreement,
        Information,
        Account,
        Finish,
        // Print Pages

        // Setup Pages

        // Error Pages
        Empty
    }



    public class NavigationHelper
    {
        #region Static Properties


        #endregion

        #region Static Methods

        public static void Navigate(ModernWpf.Controls.Frame frame, Pages page, Transitions transitions, bool clearHistory = true)
        {
            App.CurrentPage = page;
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

                case Pages.Clients:
                    return typeof(Clinets);

                case Pages.Suppliers:
                    return typeof(Suppliers);

                case Pages.Stock:
                    return typeof(Stock);

                case Pages.Purchases:
                    return typeof(Purchases);

                case Pages.Sales:
                    return typeof(Sales);

                case Pages.ReturnPurchases:
                    return typeof(ReturnPurchases);

                case Pages.ReturnSales:
                    return typeof(ReturnSales);

                case Pages.SellOnDesk:
                    return typeof(SellOnDesk);

                case Pages.CashRegister:
                    return typeof(CashRegister);

                case Pages.Expenses:
                    return typeof(Expenses);

                case Pages.Articles:
                    return typeof(Articles);

                case Pages.Settings:
                    return typeof(Settings);

                case Pages.SignIn:
                    return typeof(SignIn);

                case Pages.NewPassword:
                    return typeof(NewPassword);

                case Pages.Questions:
                    return typeof(Questions);

                case Pages.Welcome:
                    return typeof(Welcome);
                
                case Pages.Agreement:
                    return typeof(Agreement);

                case Pages.Information:
                    return typeof(Information);

                case Pages.Account:
                    return typeof(Account);

                case Pages.Finish:
                    return typeof(Finish);


                case Pages.Empty:
                    return typeof(Empty);

                default:
                    return typeof(Error);

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
