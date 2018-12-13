using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Tester
{
    
    class User : Person, IComparable<User>
    {
        [JsonProperty("favorite")]
        public LinkedList<Movie> favoriteList { get; set; }
        public bool banned { get; set; }

        public User() : base()
        {
            favoriteList = new LinkedList<Movie>();
            banned = false;
        }

        public User(string firstName, string lastName, string username, string password, int age)
            : base(firstName, lastName, username, password, age)
        {
            favoriteList = new LinkedList<Movie>();
            banned = false;
        } 


        /// <summary>
        ///     Adds a new Movie object into the movie list
        /// </summary>
        /// <param name="obj"> the Movie object to be added </param>
        /// <returns> Returns true if Movie obj was added, false otherwise </returns>
        public bool addMovie(Movie obj)
        {
            if (favoriteList.Contains(obj))
                return false;

            favoriteList.AddLast(obj);
            return true;
        }

        public Movie getMovie(Movie movie) => favoriteList.Find(movie).Value;

        //Deletes all Movie objects in the list
        public void clearFavoriteList() { favoriteList.Clear(); }

        public void removeMovie(Movie obj) { favoriteList.Remove(obj); }

        public Movie[] getMovieList() { return favoriteList.ToArray<Movie>(); }

        public int CompareTo(User obj)
        {
            if (obj == null)
                return 1;

            return this.username.CompareTo(obj.username);
        }

        public void setBan(bool ban) { this.banned = ban;  }

        
    }
}
