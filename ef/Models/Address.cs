using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Models
{
    public class Address : ClassWithId
    {
        public Address(long id, string streetNumber, string city, int zipCode) : base(id)
        {
            this.StreetNumer = streetNumber;
            this.ZipCode = zipCode;
            this.City= city;
        }

        public string StreetNumer { get; set; }
        public string City { get; set; }
        public int ZipCode { get; set; }
    }
}
