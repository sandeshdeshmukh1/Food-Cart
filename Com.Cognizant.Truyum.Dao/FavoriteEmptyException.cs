using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Cognizant.Truyum.Dao
{
    public class FavoriteEmptyException: Exception
    {
        public FavoriteEmptyException(string message) : base(message)
        {
            

        }
        
    }
}
