﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Tester
{
    class Movie : IComparable<Movie>
    {
        public string Title { get; set; }
        public string Director { get; set; }
        public int Length { get; set; }
        public string Genre { get; set; }
        public string Synopsis { get; set; }
        public string ReleaseDate { get; set; }
        public double Rating { get; set; }
        public string Image { get; set; }


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
        //public string getImage() => Image;
        //public string getTitle() => Title;
        //public int getLength() => Length;
        //public string getDirector() => Director;
        //public string getGenre() => Genre;
        //public string getSynopsis() => Synopsis;
        //public string getReleaseDate() => ReleaseDate;
        //public double getRating() => Rating;

        public int CompareTo(Movie obj)
        {
            if (obj == null) return 1;

            return this.Title.CompareTo(obj.Title);

        }

        public override bool Equals(object obj)
        {

            var otherMovie = obj as Movie;

            return otherMovie == null ? false : this.Title.Equals(otherMovie.Title) &&
                                                this.Director.Equals(otherMovie.Director) &&
                                                this.Length.Equals(otherMovie.Length) &&
                                                this.Genre.Equals(otherMovie.Genre) &&
                                                this.ReleaseDate.Equals(otherMovie.ReleaseDate);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return $"Title: {this.Title}\nDirector: {this.Director}\nLength: {this.Length} Genre: {this.Genre}";
        }
    }
}
