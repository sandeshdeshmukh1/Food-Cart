using Com.Cognizant.Truyum.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Cognizant.Truyum.Dao
{
    interface IFavoriteDao
    {
        void AddFavoriteItem(long userId, long MovieItemId);
        Favorite GetAllFavoriteItems(long userId);  
        void RemoveFavoriteItem(long userId, long productId);
    }
}
