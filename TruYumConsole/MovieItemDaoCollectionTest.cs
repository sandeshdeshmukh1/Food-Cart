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
            Console.WriteLine("|  ID |  Name      |      Price  |  Active |  Date Of Launch |  Category  |  Delivery  |");
            foreach (var item in MovieItems)
            {

                Console.WriteLine(String.Format("|{0}|", item));

                
            }
            


        }
        public void TestGetMovieItemListCustomer()
        {
            MovieItemDaoCollection movieItemDao = new MovieItemDaoCollection();
            List<MovieItem> MovieItems = movieItemDao.GetMovieItemListCustomer();
            Console.WriteLine("|  ID |  Name      |      Price  |  Active |  Date Of Launch |  Category  |  Delivery  |");
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
                Name = "Dosa",
                Price = 29,
                Active = true,
                DateOfLauch = new DateTime(2010, 12, 1, 4, 0, 15),
                Category = "Starter",
                FreeDelivery = true



            };

            MovieItemDaoCollection movieItemDao = new MovieItemDaoCollection();
            movieItemDao.ModifyMovieItem(MovieItem);
            Console.WriteLine("|  ID |  Name      |      Price  |  Active |  Date Of Launch |  Category  |  Delivery  |");
            //Console.WriteLine(movieItemDao.GetMovieItem(MovieItem.Id));
            Console.WriteLine(movieItemDao.GetMenu(MovieItem.Id));

            //MovieItem MovieItem;
            //movieItemDaoCollection movieItemDaoCollection = new movieItemDaoCollection();
            //MovieItem = movieItemDaoCollection.MovieItemList[1];
            //movieItemDaoCollection.ModifyMovieItem(MovieItem);
            //movieItemDaoCollection.GetMovieItem(MovieItem.Id);
        }
    }
}
