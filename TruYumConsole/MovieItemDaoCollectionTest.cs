using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Cognizant.Truyum.Dao;
using Com.Cognizant.Truyum.Model;

namespace TruYumConsole
{
    class MovieItemDaoCollectionTest
    {
       

        public void TestGetMovieItemListAdmin()
        {
            MovieItemDaoCollection movieItemDao = new MovieItemDaoCollection();
            List<MovieItem> MovieItems = movieItemDao.GetMovieItemListAdmin();
            Console.WriteLine("ID    |  TITLE |  BOX OFFICE      |      ACTIVE  |    DATE OF LAUNCH |  GENRE  |  HAS TEASER  |");
            foreach (var item in MovieItems)
            {

                Console.WriteLine(String.Format("|{0}|", item));

                
            }
            


        }
        public void TestGetMovieItemListCustomer()
        {
            MovieItemDaoCollection movieItemDao = new MovieItemDaoCollection();
            List<MovieItem> MovieItems = movieItemDao.GetMovieItemListCustomer();
            Console.WriteLine("ID    |  TITLE |  BOX OFFICE      |      ACTIVE  |    DATE OF LAUNCH |  GENRE  |  HAS TEASER  |");
            foreach (var item in MovieItems)
            {
                Console.WriteLine(item);
                
            }
            


        }

        public void TestModifyMovieItem()
        {
           
            MovieItem MovieItem = new MovieItem()
            {
                Id = 4,
                Title = "iron man",
                BoxOffice = 2956645566,
                Active = true,
                DateOfLauch = new DateTime(2010, 12, 1, 4, 0, 15),
                Genre = "Sci-Fi",
                HasTeaser = true




            };

            MovieItemDaoCollection movieItemDao = new MovieItemDaoCollection();
            movieItemDao.ModifyMovieItem(MovieItem);
            Console.WriteLine("ID    |  TITLE |  BOX OFFICE      |      ACTIVE  |    DATE OF LAUNCH |  GENRE  |  HAS TEASER  |");

            Console.WriteLine(movieItemDao.GetMovie(MovieItem.Id));

            
        }
    }

}
