using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Cognizant.Truyum.Model
{
    public class MovieItem
    {

        private long id;
        public long Id
        {
            get { return id; }
            set { id = value; }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private float price;

        public float Price
        {
            get { return price; }
            set { price = value; }
        }

        private bool active;

        public bool Active
        {
            get { return active; }
            set { active = value; }
        }

        //date 
        private DateTime dateOfLaunch;

        public DateTime DateOfLauch
        {
            get { return dateOfLaunch; }
            set { dateOfLaunch = value; }
        }


        private string category;

        public string Category
        {
            get { return category; }
            set { category = value; }
        }

        private bool freeDelivery;

        public bool FreeDelivery
        {
            get { return freeDelivery; }
            set { freeDelivery = value; }
        }

        public MovieItem()
        {
        }

        public MovieItem(long id, string name, float price, bool active, DateTime dateOfLaunch, string category, bool freeDelivery)
        {
            Id = id;
            Name = name;
            Price = price;
            Active = active;
            DateOfLauch = dateOfLaunch;
            Category = category;
            FreeDelivery = freeDelivery;
        }




        public override string ToString()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string active = Active == true ? "Yes" : "No";
            return $"{Id,5} {Name,-20} \u20B9{Price,3} {active,10} {DateOfLauch.ToShortDateString(),15} {Category,15} {FreeDelivery,10}";
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
            }




        //equals to do 





    }
}
//Notes:
//Instance constructors are used to create and initialize any instance member variables
//when you use the new expression to create an object of a class. 
//To initialize a static class, or static variables in a non-static class, 
//you define a static constructor