using Manage.Base;
using System;
using System.Collections.ObjectModel;

namespace Manage.ViewModels.Main
{
    public class MenuVM : Base.ViewModel
    {
        #region Properties
        public ObservableCollection<MenuItem> MenuItems { get; set; }

        #endregion

        #region Commands

        public RelayCommand ChooseCommand { get; set; }

        public void Choose(object param)
        {

        }

        #endregion

        #region Private Properties

        String[] Images =
        {
            "Client",
            "Supplier",
            "Stock",
            "Purchase",
            "Sale",
            "ReturnPurchase",
            "ReturnSale",
            "Desk",
            "CashRegister",
            "Expense",
            "Article",
            "Setting"
        };

        String[] Titles =
        {
            "Clients",
            "Suppliers",
            "Stock",
            "Purchase",
            "Sales",
            "Return Purchases",
            "Return Sales",
            "Sell On Desk",
            "Cash Register",
            "Expenses",
            "Articles",
            "Settings"
        };
        #endregion

        #region Constructors


        public MenuVM()
        {
            // Initialize menu items based on the user and the permissions 
            MenuItems = new ObservableCollection<MenuItem>();
            for (int i = 0; i < Images.Length; i++)
            {
                MenuItems.Add(new MenuItem() { Image = Images[i], Title = Titles[i], Color = "#2D9CDB" });
            }

            // Initializing Commands

            ChooseCommand = new RelayCommand(Choose);
        }
        #endregion
    }

    #region Extra Classes

    public class MenuItem
    {
        public string Image { get; set; }
        public string Title { get; set; }
        public string Color { get; set; }
    }
    #endregion
}
