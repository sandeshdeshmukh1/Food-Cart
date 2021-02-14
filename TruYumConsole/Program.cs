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
            Console.WriteLine("***************************-------------MENU LIST ADMIN---------*******************************");
            Console.WriteLine();
            movieItemDaoCollectionTest.TestGetMovieItemListAdmin();
            Console.WriteLine();
            Console.WriteLine("***************************----------MENU LIST CUSTOMER---------*******************************");
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
            Console.WriteLine("*************************-------------------Favorite ITEMS-------------*****************************");
            Console.WriteLine();

            FavoriteDaoCollectionTest.TestAddFavoriteItem();
            
            FavoriteDaoCollectionTest.TestRemoveFavoriteItem();
            Console.WriteLine("|  ID |  Name      |      Price  |  Active |  Date Of Launch |  Category  |  Delivery  |");
            FavoriteDaoCollectionTest.TestGetAllFavoriteItems();
            Console.WriteLine();
            Console.WriteLine("************************************************************************************************");
            Console.ReadKey();
        }
    }
}
