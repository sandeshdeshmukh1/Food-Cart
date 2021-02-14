using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Cognizant.Truyum.Model
{
    public class Favorite
    { 
        
        private List<MovieItem> MovieItemList;

        public List<MovieItem> MovieItemList
        {
            get { return MovieItemList; }
            set { MovieItemList = value; }
        }

        private double total;

        public double Total
        {
            get { return total; }
            set { total = value; }
        }
        public Favorite()
        {
        }

        public Favorite(List<MovieItem> MovieItemList, double total)
        {
            MovieItemList = MovieItemList;
            Total = total;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
       

    }
}
