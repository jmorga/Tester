using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Tester
{
    [Serializable()]
    class Movie : IComparable<Movie>, ISerializable
    {
        private string Title;
        private string Director;
        private int Length;
        private string Genre;
        private string Synopsis;
        private string ReleaseDate;
        private double Rating;
        private string Image;


        public Movie()
        {
            Title = "No title yet";
            Director = "No director yet";
            Length = 0;
            Genre = " No genre yet";
            Synopsis = "No synopsis yet";
            ReleaseDate = "Never";
            Rating = 0.0;
        }

        public Movie(String title, String director, int length, String genre, String synopsis,
            string releaseDate, double rating, string image)
        {
            Title = title;
            Director = director;
            Length = length;
            Genre = genre;
            Synopsis = synopsis;
            ReleaseDate = releaseDate;
            Rating = rating;
            Image = image;
        }

        public Movie(SerializationInfo info, StreamingContext ctxt)
        {
            Title = (string)info.GetValue("title", typeof(string));
            Director = (string)info.GetValue("director", typeof(string));
            Length = (int)info.GetValue("length", typeof(int));
            Genre = (string)info.GetValue("genre", typeof(string));
            Synopsis = (string)info.GetValue("synopsis", typeof(string));
            ReleaseDate = (string)info.GetValue("releaseDate", typeof(string));
            Rating = (double)info.GetValue("rating", typeof(double));
            Image = (string)info.GetValue("image", typeof(string));
        }

        public string getImage() => Image;
        public string getTitle() => Title;
        public int getLength() => Length;
        public string getDirector() => Director;
        public string getGenre() => Genre;
        public string getSynopsis() => Synopsis;
        public string getReleaseDate() => ReleaseDate;
        public double getRating() => Rating;

        public int CompareTo(Movie obj)
        {
            if (obj == null) return 1;

            return this.Title.CompareTo(obj.Title);

        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;

            if (this.Title.Equals(((Movie)obj).Title) && this.Director.Equals(((Movie)obj).Director)
                && this.Length == ((Movie)obj).Length && this.Genre.Equals(((Movie)obj).Genre)
                && this.ReleaseDate.Equals(((Movie)obj).ReleaseDate)) return true;

            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return $"Title: {this.Title}\nDirector: {this.Director}\nLength: {this.Length} Genre: {this.Genre}";
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("title", Title);
            info.AddValue("director", Director);
            info.AddValue("length", Length);
            info.AddValue("genre", Genre);
            info.AddValue("synopsis", Synopsis);
            info.AddValue("releaseDate", ReleaseDate);
            info.AddValue("rating", Rating);
            info.AddValue("image", Image);
        }
    }
}
