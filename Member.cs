using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.Net_Demo
{
    public class Member
    {
        public string number { set; get; }
        public string joindate { set; get; }
        public string firstname { set; get; }
        public string lastname { set; get; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public string phone { get; set; }
        public string member_status { set; get; }
        public string password { set; get; }
    }
}
