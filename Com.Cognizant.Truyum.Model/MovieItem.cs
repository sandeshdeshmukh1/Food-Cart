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

        private string title;
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        private float boxoffice;

        public float BoxOffice
        {
            get { return boxoffice; }
            set { boxoffice = value; }
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


        private string genre;

        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }

        private bool hasTeaser;

        public bool HasTeaser
        {
            get { return hasTeaser; }
            set { hasTeaser = value; }
        }

        public MovieItem()
        {
        }

        public MovieItem(long id, string title, float boxoffice, bool active, DateTime dateOfLaunch, string genre, bool hasTeaser)
        {
            Id = id;
            Title = title;
            BoxOffice = boxoffice;
            Active = active;
            DateOfLauch = dateOfLaunch;
            Genre = genre;
            HasTeaser = hasTeaser;
        }




        public override string ToString()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string active = Active == true ? "Yes" : "No";
            return $"{Id,5} {Title,-20} \u20B9{BoxOffice,3} {active,10} {DateOfLauch.ToShortDateString(),15} {Genre,15} {HasTeaser,10}";
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