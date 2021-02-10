using Com.Cognizant.Truyum.Dao;
using Com.Cognizant.Truyum.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruYumConsole
{
    class CartDaoCollectionTest
    {
        static void Main(string[] args)
        {
            
        }
        public void TestAddCartItem()
        {
            CartDaoCollection cartDao = new CartDaoCollection();
            cartDao.AddCartItem(1, 1);
            cartDao.AddCartItem(1, 2);
            cartDao.AddCartItem(1, 3);
            cartDao.AddCartItem(1, 4);
            cartDao.AddCartItem(1, 5);



        }

        public void TestGetAllCartItems() {
            CartDaoCollection cartDao = new CartDaoCollection();

            List<MenuItem> menuItems = cartDao.GetAllCartItems(1).MenuItemList;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            foreach (var item in menuItems)
            {
                Console.WriteLine(item);
            }
            var totalCartAmount = menuItems.Sum(i => i.Price);
            Console.WriteLine();
            Console.WriteLine($"Total Cart Amount  -\u20B9{totalCartAmount}");
            
        }
        public void TestRemoveCartItem()
        {
            CartDaoCollection cartDao = new CartDaoCollection();
            cartDao.RemoveCartItem(1, 1);
            cartDao.RemoveCartItem(1, 2);


            try
            {
                cartDao.GetAllCartItems(1);
            }
            catch (CartEmptyException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        
    }
}
