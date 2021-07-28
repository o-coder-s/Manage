using Manage.Base;
using SQLite;
namespace Manage.Models
{

    public class BillIn : Model
    {
        [Indexed]
        public int BillInID { get; set; }
        [Indexed]
        public int UserID { get; set; }
        [Indexed]
        public int SupplierID { get; set; }
        public int Total { get; set; }
    }

    public class BillInProduct : Model
    {
        [Indexed]
        public int BillInID { get; set; }
        [Indexed]
        public int ProductID { get; set; }
        [Indexed]
        public int ProductBarcode { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
    }

    public class BillOut : Model
    {
        [PrimaryKey,AutoIncrement]
        public int BillOutID { get; set; }
        [Indexed]
        public int ClientID { get; set; }
        public int Total { get; set; }
    }

    public class BillOutProduct : Model
    {
        [Indexed]
        public int BillOutID { get; set; }
        [Indexed]
        public int ProductID { get; set; }
        [Indexed]
        public int ProductBarcode { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
    }

    public class Brand : Model
    {
        [PrimaryKey,AutoIncrement]
        public int BrandID { get; set; }
        public string Name { get; set; }
    }

    public class Category : Model
    {
        [PrimaryKey, AutoIncrement]
        public int CategoryID { get; set; }
        public string Name { get; set; }
    }

    public class Client : Model
    {
        [PrimaryKey, AutoIncrement]
        public int ClientID { get; set; }
        [Indexed]
        public int PersonID { get; set; }
        public int Balance { get; set; }
        public int Type { get; set; }
        public int Restricted { get; set; }
    }

    public class ClientPayment : Model
    {
        [Indexed]
        public int ClientID { get; set; }
        [Indexed]
        public int UserID { get; set; }
        public int Amount { get; set; }
    }

    public class Company : Model
    {
        [PrimaryKey,AutoIncrement]
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
        [PrimaryKey,AutoIncrement]
        public int DepotID { get; set; }
        public string Name { get; set; }
    }

    public class Employee : Model
    {
        [PrimaryKey,AutoIncrement]
        public int EmployeeID { get; set; }
        [Indexed]
        public int PersonID { get; set; }
        public int Salary { get; set; }
    }

    public class Expense : Model
    {
        [PrimaryKey,AutoIncrement]
        public int ExpenseID { get; set; }
        [Indexed]
        public int UserID { get; set; }
        [Indexed]
        public int RegisterID { get; set; }
        public int Amount { get; set; }
        public string Reason { get; set; }
    }

    public class Favourite : Model
    {
        [PrimaryKey]
        public int FavouriteID { get; set; }
        public string Name { get; set; }
    }

    public class Order : Model
    {
        [PrimaryKey,AutoIncrement]
        public int OrderID { get; set; }
        [Indexed]
        public int SupplierID { get; set; }
        [Indexed]
        public int UserID { get; set; }
    }

    public class OrderProduct : Model
    {
        [Indexed]
        public int ProductID { get; set; }
        [Indexed]
        public int ProductBarcode { get; set; }
        [Indexed]
        public int OrderID { get; set; }
        public int Quantity { get; set; }
    }

    public class Person : Model
    {
        [PrimaryKey,AutoIncrement]
        public int PersonID { get; set; }
        public string Name { get; set; }
        public string FamilyName { get; set; }
        public int PhoneNumber { get; set; }
        public string Picture { get; set; }
        public string IdentityNumber { get; set; }
    }

    public class Product : Model
    {
        [PrimaryKey,AutoIncrement]
        public int ProductID { get; set; }
        [PrimaryKey]
        public int ProductBarcode { get; set; }
        public int CategoryID { get; set; }
        public int BrandID { get; set; }
        public int TaxID { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
    }

    public class Role : Model
    {
        [PrimaryKey,AutoIncrement]
        public int RoleID { get; set; }
        public string Title { get; set; }
        public string Permissions { get; set; }
    }

    public class Stock : Model
    {
        [Indexed]
        public int ProductID { get; set; }
        public int ProductBarcode { get; set; }
        [Indexed]
        public int DepotID { get; set; }
        [Indexed]
        public int FavouriteID { get; set; }
        public int Quantity { get; set; }
        public int QuantityMin { get; set; }
        public int QuantityMax { get; set; }
        public int QuantityAlert { get; set; }
    }

    public class Supplier : Model
    {
        [PrimaryKey,AutoIncrement]
        public int SupplierID { get; set; }
        [Indexed]
        public int PersonID { get; set; }
        public int Restricted { get; set; }
        public int Balance { get; set; }
        public int Type { get; set; }
    }

    public class Tax : Model
    {
        [PrimaryKey,AutoIncrement]
        public int TaxID { get; set; }
        public string Name { get; set; }
        public int Percentage { get; set; }
    }

    public class User : Model
    {
        [PrimaryKey,AutoIncrement]
        public int UserID { get; set; }
        [Indexed]
        public int EmployeeID { get; set; }
        public int RoleID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}
