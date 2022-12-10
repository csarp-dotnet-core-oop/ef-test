using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Models
{
    public class Address : ClassWithId
    {
        public Address(long id) : base(id)
        {
            
        }

        public string StreetNumer { get; set; }
        public string City { get; set; }
        public int Zipcode { get; set; }
    }
}
