using Com.Cognizant.Truyum.Model;
using Com.Cognizant.Truyum.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Cognizant.Truyum.Dao
{
    public class MovieItemDaoCollection : ImovieItemDao
    {
        static List<MovieItem> movieItemList;

        public List<MovieItem> MovieItemList
        {
            get { return movieItemList; }
            set { movieItemList = value; }
        }


      

        public MovieItemDaoCollection()
        {
            DateUtility dateUtility = new DateUtility();
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            if (MovieItemList == null)
            {
                MovieItemList = new List<MovieItem>()
                {
                    new MovieItem { Id = 1, Title = "Avatar", BoxOffice = 2787965087, Active = true, DateOfLauch = dateUtility.ConvertToShortDateString("15/03/2017"), Genre = "Science Fiction", HasTeaser = true },
                    new MovieItem { Id = 2, Title = "The Avengers", BoxOffice = 15188812988, Active = true, DateOfLauch = dateUtility.ConvertToShortDateString("23/12/2017"), Genre = "Romance", HasTeaser = false },
                    new MovieItem { Id = 3, Title = "Titanic", BoxOffice = 2187463944, Active = true, DateOfLauch = dateUtility.ConvertToShortDateString("21/08/2018"), Genre = "Romance", HasTeaser = false },
                    new MovieItem { Id = 4, Title = "Jurassic World", BoxOffice = 16548713525, Active = false, DateOfLauch = dateUtility.ConvertToShortDateString("02/07/2017"), Genre = "Superhero", HasTeaser = true },
                    new MovieItem { Id = 5, Title = "Avengers:End Game", BoxOffice = 2750760348, Active = true, DateOfLauch = dateUtility.ConvertToShortDateString("02/11/2022"), Genre = "Science Fiction", HasTeaser = true }
                };
            };
        }

        public MovieItem GetMovieItem(long movieItemId)
        {
            foreach (var item in MovieItemList)
            {
                if (item.Id == movieItemId)
                {
                    return item;
                }
            }
            return null;


        }
        public MovieItem GetMovie(long movieItemId)
        {
            return MovieItemList.Where(i => i.Id == movieItemId).FirstOrDefault();

        }

        public List<MovieItem> GetMovieItemListAdmin()
        {
            
            return MovieItemList;
        }

        public List<MovieItem> GetMovieItemListCustomer()

        {

            List<MovieItem> movieItems = new List<MovieItem>();
            foreach (var item in movieItemList)
            {
                if (!(item.DateOfLauch > DateTime.Today) && item.Active == true)
                {
                    movieItems.Add(item);
                }
            }
            return movieItems;
           
        }

        public void ModifyMovieItem(MovieItem movieItem)
        {
            //for (int i = 0; i < MovieItemList.Count; i++)
            //{
            //    if (MovieItemList[i].Id == MovieItem.Id)
            //    {
            //        MovieItemList[i] = MovieItem;
            //    }
            //}
            MovieItem item = MovieItemList.Where(i => i.Id == movieItem.Id).FirstOrDefault();
            item.Title = movieItem.Title;
            item.BoxOffice = movieItem.BoxOffice;
            item.Active = movieItem.Active;
            item.DateOfLauch = movieItem.DateOfLauch;
            item.Genre = movieItem.Genre;
            item.HasTeaser = movieItem.HasTeaser;
        }
    }
}
