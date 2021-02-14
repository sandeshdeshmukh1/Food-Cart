using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruYumConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            
            MovieItemDaoCollectionTest movieItemDaoCollectionTest = new MovieItemDaoCollectionTest();
            Console.WriteLine();
            Console.WriteLine("***************************-------------MOVIE LIST ADMIN---------*******************************");
            Console.WriteLine();
            movieItemDaoCollectionTest.TestGetMovieItemListAdmin();
            Console.WriteLine();
            Console.WriteLine("***************************----------MOVIE LIST CUSTOMER---------*******************************");
            Console.WriteLine();
            movieItemDaoCollectionTest.TestGetMovieItemListCustomer();
            Console.WriteLine();
            Console.WriteLine("*************************-------------RECENTLY MODIFIED -----------*****************************");
            Console.WriteLine();
            movieItemDaoCollectionTest.TestModifyMovieItem();
            Console.WriteLine();
            movieItemDaoCollectionTest.TestGetMovieItemListAdmin();
            Console.WriteLine();
            Console.WriteLine();


            FavoriteDaoCollectionTest FavoriteDaoCollectionTest = new FavoriteDaoCollectionTest();
            Console.WriteLine("*************************-------------------FAVORITES ITEMS-------------*****************************");
            Console.WriteLine();

            FavoriteDaoCollectionTest.TestAddFavoriteItem();
            
            FavoriteDaoCollectionTest.TestRemoveFavoriteItem();
            Console.WriteLine("|  ID |  TITLE      |      BOX OFFICE  |  Active |  Date Of Launch |  GENRE  |  HAS TEASER  |");
            FavoriteDaoCollectionTest.TestGetAllFavoriteItems();
            Console.WriteLine();
            Console.WriteLine("************************************************************************************************");
            Console.ReadKey();
        }
    }
}
