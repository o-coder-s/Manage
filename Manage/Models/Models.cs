using Manage.Base;

namespace Manage.Models
{

    public class BillIn : Model
    {
        public int BillInID { get; set; }
        public int UserID { get; set; }
        public int SupplierID { get; set; }
        public int Total { get; set; }
    }

    public class BillInProduct : Model
    {
        public int BillInID { get; set; }
        public int ProductID { get; set; }
        public int ProductBarcode { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
    }

    public class BillOut : Model
    {
        public int BillOutID { get; set; }
        public int ClientID { get; set; }
        public int Total { get; set; }
    }

    public class BillOutProduct : Model
    {
        public int BillOutID { get; set; }
        public int ProductID { get; set; }
        public int ProductBarcode { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
    }

    public class Brand : Model
    {
        public int BrandID { get; set; }
        public string Name { get; set; }
    }

    public class Category : Model
    {
        public int CategoryID { get; set; }
        public string Name { get; set; }
    }

    public class Client : Model
    {
        public int ClientID { get; set; }
        public int PersonID { get; set; }
        public int Balance { get; set; }
        public int Type { get; set; }
        public int Restricted { get; set; }
    }

    public class ClientPayment : Model
    {
        public int ClientID { get; set; }
        public int UserID { get; set; }
        public int Amount { get; set; }
    }

    public class Company : Model
    {
        public int CompanyID { get; set; }
        public string RegisterNumber { get; set; }
        public string CompanyLogo { get; set; }
        public string CompanyName { get; set; }
        public string Phone { get; set; }
        public int Moblie { get; set; }
        public string Fax { get; set; }
        public string Website { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Balance { get; set; }
    }

    public class Depot : Model
    {
        public int DepotID { get; set; }
        public string Name { get; set; }
    }

    public class Employee : Model
    {
        public int EmployeeID { get; set; }
        public int PersonID { get; set; }
        public int Salary { get; set; }
    }

    public class Expense : Model
    {
        public int ExpenseID { get; set; }
        public int UserID { get; set; }
        public int RegisterID { get; set; }
        public int Amount { get; set; }
        public string Reason { get; set; }
    }

    public class Favourite : Model
    {
        public int FavouriteID { get; set; }
        public string Name { get; set; }
    }

    public class Order : Model
    {
        public int OrderID { get; set; }
        public int SupplierID { get; set; }
        public int UserID { get; set; }
    }

    public class OrderProduct : Model
    {
        public int ProductID { get; set; }
        public int ProductBarcode { get; set; }
        public int OrderID { get; set; }
        public int Quantity { get; set; }
    }

    public class Person : Model
    {
        public int PersonID { get; set; }
        public string Name { get; set; }
        public string FamilyName { get; set; }
        public int PhoneNumber { get; set; }
        public string Picture { get; set; }
        public string IDentityNumber { get; set; }
    }

    public class Product : Model
    {
        public int ProductID { get; set; }
        public int ProductBarcode { get; set; }
        public int CategoryID { get; set; }
        public int BrandID { get; set; }
        public int TaxID { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
    }

    public class Role : Model
    {
        public int RoleID { get; set; }
        public string Title { get; set; }
        public string Permissions { get; set; }
    }

    public class Stock : Model
    {
        public int ProductID { get; set; }
        public int ProductBarcode { get; set; }
        public int DepotID { get; set; }
        public int FavouriteID { get; set; }
        public int Quantity { get; set; }
        public int QuantityMin { get; set; }
        public int QuantityMax { get; set; }
        public int QuantityAlert { get; set; }
    }

    public class Supplier : Model
    {
        public int SupplierID { get; set; }
        public int PersonID { get; set; }
        public int Restricted { get; set; }
        public int Balance { get; set; }
        public int Type { get; set; }
    }

    public class Tax : Model
    {
        public int TaxID { get; set; }
        public string Name { get; set; }
        public int Percentage { get; set; }
    }

    public class User : Model
    {
        public int UserID { get; set; }
        public int EmployeeID { get; set; }
        public int RoleID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }



}
