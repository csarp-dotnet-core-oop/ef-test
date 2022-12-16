using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Models
{
    public class Student : ClassWithId
    {

        public string Name { get; set ; }

        // navigation property
        // one- one
        public long StudentAddressId { get; set; }
        public virtual Address StudentAddress { get; set; }

        // one-many
        public long SchoolClassId { get; set ; }
        public virtual SchoolClass SchoolClassOfStudent { get; set; }


        public Student(long id, string name, int schoolClassId, long studentAddressId)
            : base(id)
        {

            Name = name;
            SchoolClassId = schoolClassId;
            StudentAddressId = studentAddressId;    
        }

        public Student()
            :base(-1)
        {

            Name = string.Empty;
            SchoolClassId = -1;
        }
    }
}
