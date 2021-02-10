using Com.Cognizant.Truyum.Model;
using Com.Cognizant.Truyum.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Cognizant.Truyum.Dao
{
    public class MenuItemDaoCollection : IMenuItemDao
    {
        static List<MenuItem> menuItemList;

        public List<MenuItem> MenuItemList
        {
            get { return menuItemList; }
            set { menuItemList = value; }
        }


      

        public MenuItemDaoCollection()
        {
            DateUtility dateUtility = new DateUtility();
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            if (MenuItemList == null)
            {
                MenuItemList = new List<MenuItem>()
                {
                    new MenuItem { Id = 1, Name = "Sandwich", Price = 99F, Active = true, DateOfLauch = dateUtility.ConvertToShortDateString("15/03/2017"), Category = "Main Course", FreeDelivery = true },
                    new MenuItem { Id = 2, Name = "Burger", Price = 129F, Active = true, DateOfLauch = dateUtility.ConvertToShortDateString("23/12/2017"), Category = "Main Course", FreeDelivery = false },
                    new MenuItem { Id = 3, Name = "Pizza", Price = 149F, Active = true, DateOfLauch = dateUtility.ConvertToShortDateString("21/08/2018"), Category = "Main Course", FreeDelivery = false },
                    new MenuItem { Id = 4, Name = "French Fries", Price = 57F, Active = false, DateOfLauch = dateUtility.ConvertToShortDateString("02/07/2017"), Category = "Starters", FreeDelivery = true },
                    new MenuItem { Id = 5, Name = "Chocolate Brownie", Price = 32F, Active = true, DateOfLauch = dateUtility.ConvertToShortDateString("02/11/2022"), Category = "Starters", FreeDelivery = true }
                };
            };
        }

        public MenuItem GetMenuItem(long menuItemId)
        {
            foreach (var item in MenuItemList)
            {
                if (item.Id == menuItemId)
                {
                    return item;
                }
            }
            return null;


        }
        public MenuItem GetMenu(long menuItemId)
        {
            return new MenuItem();

        }

        public List<MenuItem> GetMenuItemListAdmin()
        {
            
            return MenuItemList;
        }

        public List<MenuItem> GetMenuItemListCustomer()

        {

            List<MenuItem> menuItems = new List<MenuItem>();
            foreach (var item in menuItemList)
            {
                if (!(item.DateOfLauch > DateTime.Today) && item.Active == true)
                {
                    menuItems.Add(item);
                }
            }
            return menuItems;
           
        }

        public void ModifyMenuItem(MenuItem menuItem)
        {
            //for (int i = 0; i < MenuItemList.Count; i++)
            //{
            //    if (MenuItemList[i].Id == menuItem.Id)
            //    {
            //        MenuItemList[i] = menuItem;
            //    }
            //}
            MenuItem item = MenuItemList.Where(i => i.Id == menuItem.Id).FirstOrDefault();
            item.Name = menuItem.Name;
            item.Price = menuItem.Price;
            item.Active = menuItem.Active;
            item.DateOfLauch = menuItem.DateOfLauch;
            item.Category = menuItem.Category;
            item.FreeDelivery = menuItem.FreeDelivery;
        }
    }
}
