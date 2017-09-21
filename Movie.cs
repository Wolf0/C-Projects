using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.Net_Demo
{
   public class Movie
    {
        public string movie_number { set; get; }
        public string movie_title { set; get; }
        public string Description { set; get; }
        public string movie_year_made { set; get; }
        public string genre_id { set; get; }
        public string movie_rating { get; set; }
        public string media_type { set; get; }
        public string movie_retail_cost { get; set; }
        public string tape_rental_cost { get; set; }
        public string copies_on_hand { get; set; }
        public string image { get; set; }
        public string trailer { get; set; }
       
    }
}
