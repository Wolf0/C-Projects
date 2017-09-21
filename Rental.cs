using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.Net_Demo
{
   public class Rental
    {
        public string movie_number { set; get; }
        public string member_number { set; get; }
        public string media_checkout_date { set; get; }
        public string media_return_date { set; get; }
        public string media_exp_return_date { set; get; }
        public string media_rental_cost { get; set; }
       
    }
}
