using Com.Cognizant.Truyum.Model;
using Com.Cognizant.Truyum.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Cognizant.Truyum.Dao
{
    public class movieItemDaoCollection : ImovieItemDao
    {
        static List<MovieItem> MovieItemList;

        public List<MovieItem> MovieItemList
        {
            get { return MovieItemList; }
            set { MovieItemList = value; }
        }


      

        public movieItemDaoCollection()
        {
            DateUtility dateUtility = new DateUtility();
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            if (MovieItemList == null)
            {
                MovieItemList = new List<MovieItem>()
                {
                    new MovieItem { Id = 1, Name = "Sandwich", Price = 99F, Active = true, DateOfLauch = dateUtility.ConvertToShortDateString("15/03/2017"), Category = "Main Course", FreeDelivery = true },
                    new MovieItem { Id = 2, Name = "Burger", Price = 129F, Active = true, DateOfLauch = dateUtility.ConvertToShortDateString("23/12/2017"), Category = "Main Course", FreeDelivery = false },
                    new MovieItem { Id = 3, Name = "Pizza", Price = 149F, Active = true, DateOfLauch = dateUtility.ConvertToShortDateString("21/08/2018"), Category = "Main Course", FreeDelivery = false },
                    new MovieItem { Id = 4, Name = "French Fries", Price = 57F, Active = false, DateOfLauch = dateUtility.ConvertToShortDateString("02/07/2017"), Category = "Starters", FreeDelivery = true },
                    new MovieItem { Id = 5, Name = "Chocolate Brownie", Price = 32F, Active = true, DateOfLauch = dateUtility.ConvertToShortDateString("02/11/2022"), Category = "Starters", FreeDelivery = true }
                };
            };
        }

        public MovieItem GetMovieItem(long MovieItemId)
        {
            foreach (var item in MovieItemList)
            {
                if (item.Id == MovieItemId)
                {
                    return item;
                }
            }
            return null;


        }
        public MovieItem GetMenu(long MovieItemId)
        {
            return MovieItemList.Where(i => i.Id == MovieItemId).FirstOrDefault();

        }

        public List<MovieItem> GetMovieItemListAdmin()
        {
            
            return MovieItemList;
        }

        public List<MovieItem> GetMovieItemListCustomer()

        {

            List<MovieItem> MovieItems = new List<MovieItem>();
            foreach (var item in MovieItemList)
            {
                if (!(item.DateOfLauch > DateTime.Today) && item.Active == true)
                {
                    MovieItems.Add(item);
                }
            }
            return MovieItems;
           
        }

        public void ModifyMovieItem(MovieItem MovieItem)
        {
            //for (int i = 0; i < MovieItemList.Count; i++)
            //{
            //    if (MovieItemList[i].Id == MovieItem.Id)
            //    {
            //        MovieItemList[i] = MovieItem;
            //    }
            //}
            MovieItem item = MovieItemList.Where(i => i.Id == MovieItem.Id).FirstOrDefault();
            item.Name = MovieItem.Name;
            item.Price = MovieItem.Price;
            item.Active = MovieItem.Active;
            item.DateOfLauch = MovieItem.DateOfLauch;
            item.Category = MovieItem.Category;
            item.FreeDelivery = MovieItem.FreeDelivery;
        }
    }
}
