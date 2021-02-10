using Com.Cognizant.Truyum.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Cognizant.Truyum.Dao
{
    public class CartDaoCollection : ICartDao
    {
        static Dictionary <long, Cart> userCarts;
        public CartDaoCollection()
        {
            if (userCarts == null)
            {
                userCarts = new Dictionary<long, Cart>();
            }
        }
       
        public void AddCartItem(long userId, long menuItemId)
        {
            MenuItemDaoCollection MenuItemDao = new MenuItemDaoCollection();
            MenuItem item = MenuItemDao.GetMenuItem(menuItemId);
            if(userCarts.ContainsKey(userId))
            {
                userCarts[userId].MenuItemList.Add(item);
            }
            else
            {
                Cart cart = new Cart()
                {
                    MenuItemList = new List<MenuItem>(),
                    Total = 0
                };
                cart.MenuItemList.Add(item);
                userCarts.Add(userId, cart);
            }
        }

        public Cart GetAllCartItems(long userId)
        {
            Cart cart = userCarts[userId];
            if(cart.MenuItemList.Count  == 0)
            {
                throw new CartEmptyException("Cart is empty");
            }
            double total = cart.MenuItemList.Sum(i => i.Price);
            cart.Total = total;
            return cart;
        }

        public void RemoveCartItem(long userId, long menuItemId)
        {
            List<MenuItem> menuItems = userCarts[userId].MenuItemList;

            foreach (var item in menuItems)
            {
                if (item.Id == menuItemId)
                {
                    userCarts[userId].MenuItemList.Remove(item);
                    break;
                }
            }
        }
    }
}
