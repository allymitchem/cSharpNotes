using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace giraffe
{
    public class Movie
    {
        public string title;
        public string director;
        private string rating;
        // if using private, only code this Movie class is going to be able to access this

        public Movie(string aTitle, string aDirector, string aRating)
        {
            title = aTitle;
            director = aDirector;
            Rating = aRating; //using the capital R for Rating is essentially calling Rating below => making it more secure
        }

        public string Rating 
        {
            get { return rating;} //allows us to get the rating
            set { //allows us to set the rating but we have to go through if statement
                if(value == "G" || value == "PG" || value == "PG-13" || value == "R" || value =="NR"){
                    rating = value;
                }
                else {
                    rating = "NR";
                }
            }
        }
    }
}