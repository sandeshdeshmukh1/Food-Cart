using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Cognizant.Truyum.Model;

namespace Com.Cognizant.Truyum.Dao
{
    interface ImovieItemDao
    {
        List<MovieItem> GetMovieItemListAdmin();
        List<MovieItem> GetMovieItemListCustomer();
        void ModifyMovieItem(MovieItem MovieItem);
        MovieItem GetMovieItem(long MovieItemId);
    }
}
