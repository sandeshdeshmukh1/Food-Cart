using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruYumConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            
            MenuItemDaoCollectionTest menuItemDaoCollectionTest = new MenuItemDaoCollectionTest();
            Console.WriteLine();
            Console.WriteLine("***************************-------------MENU LIST ADMIN---------*******************************");
            Console.WriteLine();
            menuItemDaoCollectionTest.TestGetMenuItemListAdmin();
            Console.WriteLine();
            Console.WriteLine("***************************----------MENU LIST CUSTOMER---------*******************************");
            Console.WriteLine();
            menuItemDaoCollectionTest.TestGetMenuItemListCustomer();
            Console.WriteLine();
            Console.WriteLine("*************************-------------RECENTLY MODIFIED -----------*****************************");
            Console.WriteLine();
            menuItemDaoCollectionTest.TestModifyMenuItem();
            Console.WriteLine();
            menuItemDaoCollectionTest.TestGetMenuItemListAdmin();
            Console.WriteLine();
            Console.WriteLine();


            CartDaoCollectionTest cartDaoCollectionTest = new CartDaoCollectionTest();
            Console.WriteLine("*************************-------------------CART ITEMS-------------*****************************");
            Console.WriteLine();

            cartDaoCollectionTest.TestAddCartItem();
            
            cartDaoCollectionTest.TestRemoveCartItem();
            Console.WriteLine("|  ID |  Name      |      Price  |  Active |  Date Of Launch |  Category  |  Delivery  |");
            cartDaoCollectionTest.TestGetAllCartItems();
            Console.WriteLine();
            Console.WriteLine("************************************************************************************************");
            Console.ReadKey();
        }
    }
}
