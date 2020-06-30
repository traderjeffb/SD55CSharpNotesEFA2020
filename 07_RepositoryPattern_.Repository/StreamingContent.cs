using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _07_RepositoryPattern_.Repository
{
    public enum GenreType
    {
        Horror = 1,
        SciFi,
        Drama,
        Action,
        Comedy,
        Anime,
        Documentary,
        Thriller,
        Romance
    }
    public enum MaturityRating
    {
        G,
        PG,
        R,
        PG_13,
        NC_17,
        TV_MA
    }
    public class StreamingContent
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public MaturityRating MaturityRating { get; set; }
        public int StarRating { get; set; }
        public bool IsFamilyFriendly
        {
            get
            {
                switch (MaturityRating)
                {
                    case MaturityRating.G:
                    case MaturityRating.PG:
                        return true;
                    case MaturityRating.PG_13:
                    case MaturityRating.R:
                    case MaturityRating.NC_17:
                    case MaturityRating.TV_MA:
                    default:
                        return false;
                }
                //Another way to do this
                if ((int)MaturityRating > 1)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

        }


        public GenreType TypeOfGenre { get; set; }
        public StreamingContent() { }
        //constructors serve as a kind of validation allow us to "new up", or instantiate, an object while ensuring that all necessary data is given at the point of construction , aka instantiation(below)
        public StreamingContent(string title, string description, MaturityRating maturityRating, int starRating, GenreType typeOfGenre)

        {
            Title = title;//this is our set method: we are setting the value of our property Title to whatever the arguement of our the variable "title"  declared in the prarmeters of our constructor
            Description = description;
            MaturityRating = maturityRating;
            StarRating = starRating;
            TypeOfGenre = typeOfGenre;

        }
    }
}
