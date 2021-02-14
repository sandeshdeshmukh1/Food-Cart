using Com.Cognizant.Truyum.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Cognizant.Truyum.Dao
{
    public class FavoriteDaoCollection : IFavoriteDao
    {
        static Dictionary <long, Favorite> userFavorites;
        public FavoriteDaoCollection()
        {
            if (userFavorites == null)
            {
                userFavorites = new Dictionary<long, Favorite>();
            }
        }
       
        public void AddFavoriteItem(long userId, long MovieItemId)
        {
            movieItemDaoCollection movieItemDao = new movieItemDaoCollection();
            MovieItem item = movieItemDao.GetMovieItem(MovieItemId);
            if(userFavorites.ContainsKey(userId))
            {
                userFavorites[userId].MovieItemList.Add(item);
            }
            else
            {
                Favorite Favorite = new Favorite()
                {
                    MovieItemList = new List<MovieItem>(),
                    Total = 0
                };
                Favorite.MovieItemList.Add(item);
                userFavorites.Add(userId, Favorite);
            }
        }

        public Favorite GetAllFavoriteItems(long userId)
        {
            Favorite Favorite = userFavorites[userId];
            if(Favorite.MovieItemList.Count  == 0)
            {
                throw new FavoriteEmptyException("Favorite is empty");
            }
            double total = Favorite.MovieItemList.Sum(i => i.Price);
            Favorite.Total = total;
            return Favorite;
        }

        public void RemoveFavoriteItem(long userId, long MovieItemId)
        {
            List<MovieItem> MovieItems = userFavorites[userId].MovieItemList;

            foreach (var item in MovieItems)
            {
                if (item.Id == MovieItemId)
                {
                    userFavorites[userId].MovieItemList.Remove(item);
                    break;
                }
            }
        }
    }
}
