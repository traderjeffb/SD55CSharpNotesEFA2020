using _07_RepositoryPattern_.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_StreamingContent_Inheritance
{
    public class StreamingRepository : StreamingContentRepository
    {
        public Show GetShowByTitle(string title)
        {

            foreach (StreamingContent content in _contentDirectory)
            {
                if (content.Title.ToLower() == title.ToLower() && content.GetType() == typeof(Show))
                {
                    return (Show)content;
                }
            }
            return null;
        }
        public Movie GetMovieByTitle(string title)
        {
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content.Title.ToLower() == title.ToLower() && content is Movie)
                {
                    return (Movie)content;
                }
            }
            return null;
        }

        public List<Show> GetAllShows()
        {
            List<Show> allShows = new List<Show>();
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content is Show)
                {
                    allShows.Add((Show)content);
                }
            }
            return allShows;
        }

        //Get All Movies
        public List<Movie> GetAllMovies()
        {
            List<Movie> allMovies = new List<Movie>();
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content is Movie)
                {
                    allMovies.Add((Movie)content);
                }
            }
            return allMovies;
        }

        //get by other parameters
        //get by RunTime/averageRuntime
        //get shows with over x episodes
        //get shows/movies by rating

        //public List<Movie> GetAllMoviesByRunTime(double runTime)
        //{
        //    List<Movie> allRunTimes = new List<Movie>()
        //        foreach(StreamingContent content in _contentDirectory)
        //    {
        //        if(content.GetType()==
        //        {

        //        }
        //    }
        //}
    }
}
