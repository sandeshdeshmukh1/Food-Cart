using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Cognizant.Truyum.Dao;
using Com.Cognizant.Truyum.Model;

namespace TruYumConsole
{
    class MenuItemDaoCollectionTest
    {
       

        public void TestGetMenuItemListAdmin()
        {
            MenuItemDaoCollection menuItemDao = new MenuItemDaoCollection();
            List<MenuItem> menuItems = menuItemDao.GetMenuItemListAdmin();
            Console.WriteLine("|  ID |  Name      |      Price  |  Active |  Date Of Launch |  Category  |  Delivery  |");
            foreach (var item in menuItems)
            {

                Console.WriteLine(String.Format("|{0}|", item));

                
            }
            


        }
        public void TestGetMenuItemListCustomer()
        {
            MenuItemDaoCollection menuItemDao = new MenuItemDaoCollection();
            List<MenuItem> menuItems = menuItemDao.GetMenuItemListCustomer();
            Console.WriteLine("|  ID |  Name      |      Price  |  Active |  Date Of Launch |  Category  |  Delivery  |");
            foreach (var item in menuItems)
            {
                Console.WriteLine(item);
                
            }
            


        }

        public void TestModifyMenuItem()
        {
           
            MenuItem menuItem = new MenuItem()
            {
                Id = 4,
                Name = "Dosa",
                Price = 29,
                Active = true,
                DateOfLauch = new DateTime(2010, 12, 1, 4, 0, 15),
                Category = "Starter",
                FreeDelivery = true



            };

            MenuItemDaoCollection menuItemDao = new MenuItemDaoCollection();
            menuItemDao.ModifyMenuItem(menuItem);
            Console.WriteLine("|  ID |  Name      |      Price  |  Active |  Date Of Launch |  Category  |  Delivery  |");
            Console.WriteLine(menuItemDao.GetMenuItem(menuItem.Id));
            Console.WriteLine(menuItemDao.GetMenu(menuItem.Id));

            //MenuItem menuItem;
            //MenuItemDaoCollection menuItemDaoCollection = new MenuItemDaoCollection();
            //menuItem = menuItemDaoCollection.MenuItemList[1];
            //menuItemDaoCollection.ModifyMenuItem(menuItem);
            //menuItemDaoCollection.GetMenuItem(menuItem.Id);
        }
    }
}
