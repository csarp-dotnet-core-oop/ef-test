using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Models
{
    public class Address : ClassWithId
    {
        public string StreetNumber { get; set; }
        public string City { get; set; }
        public int ZipCode { get; set; }


        public Address() : base(-1)
        {
            this.StreetNumber = string.Empty;
            this.ZipCode = -1;
            this.City = string.Empty;
        }

        public Address(long id, string streetNumber, string city, int zipCode) : base(id)
        {
            this.StreetNumber = streetNumber;
            this.ZipCode = zipCode;
            this.City = city;
        }
    }
}
