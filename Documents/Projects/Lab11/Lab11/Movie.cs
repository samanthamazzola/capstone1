using System;
namespace Lab11
{
    public class Movie
    {
        //fields
        private string title;
        private string category;


        //properties
        public string Title
        {
            set { title = value; }
            get { return title; }
        }

        public string Category
        {
            set { category = value; }
            get { return category; }
        }

        //constuctors default/overload
        public Movie()
        {
            Title = "title";
            Category = "category";
        }

        public Movie(string tl, string ct)
        {
            Title = tl;
            Category = ct;
        }

        //method (virtual/override)


    }
}
