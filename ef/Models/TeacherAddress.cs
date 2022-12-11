using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Models
{
    public class TeacherAddress : ClassWithId
    {
        public string StreetNumber { get; set; }
        public string City { get; set; }
        public int ZipCode { get; set; }

        public virtual Teacher Teacher {get; set;}

        public TeacherAddress(long id, string streetNumber, string city, int zipCode) : base(id)
        {
            this.StreetNumber = streetNumber;
            this.ZipCode = zipCode;
            this.City = city;
        }
    }
}
