﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tester
{
    class Movie :IComparable<Movie>
    {
        public String Title { get; set; }
        public String Director { get; set; }
        public int Length { get; set; }
        public String Genre { get; set; }
        public String Synopsis { get; set; }
        public string ReleaseDate { get; set; }
        public double Rating { get; set; }
        public String Image { get; set; }


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

        //public String getTitle()
        //    {
        //        return Title;
        //    }

        //    public String getDirector()
        //    {
        //        return Director;
        //    }

        //    public int getLength()
        //    {
        //        return Length;
        //    }

        //    public String getGenre()
        //    {
        //        return Genre;
        //    }

        //    public String getSynopsis()
        //    {
        //        return Synopsis;
        //    }

        //public DateTime getReleaseDate()
        //{
        //    return ReleaseDate;
        //}

        //public double getRating()
        //{
        //    return Rating;
        //}
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
    }
}
