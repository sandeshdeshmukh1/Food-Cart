using Com.Cognizant.Truyum.Dao;
using Com.Cognizant.Truyum.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruYumConsole
{
    class FavoriteDaoCollectionTest
    {
        static void Main(string[] args)
        {
            
        }
        public void TestAddFavoriteItem()
        {
            FavoriteDaoCollection FavoriteDao = new FavoriteDaoCollection();
            FavoriteDao.AddFavoriteItem(1, 1);
            FavoriteDao.AddFavoriteItem(1, 2);
            FavoriteDao.AddFavoriteItem(1, 3);
            FavoriteDao.AddFavoriteItem(1, 4);
            FavoriteDao.AddFavoriteItem(1, 5);



        }

        public void TestGetAllFavoriteItems() {
            FavoriteDaoCollection FavoriteDao = new FavoriteDaoCollection();

            List<MovieItem> MovieItems = FavoriteDao.GetAllFavoriteItems(1).MovieItemList;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            foreach (var item in MovieItems)
            {
                Console.WriteLine(item);
            }
            var totalFavoriteAmount = MovieItems.Sum(i => i.Price);
            Console.WriteLine();
            Console.WriteLine($"Total Favorite Amount : \u20B9{totalFavoriteAmount}");
            
        }
        public void TestRemoveFavoriteItem()
        {
            FavoriteDaoCollection FavoriteDao = new FavoriteDaoCollection();
            FavoriteDao.RemoveFavoriteItem(1, 1);
            FavoriteDao.RemoveFavoriteItem(1, 2);


            try
            {
                FavoriteDao.GetAllFavoriteItems(1);
            }
            catch (FavoriteEmptyException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        
    }
}
