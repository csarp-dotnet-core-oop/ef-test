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
        private string name;
        private int schoolClassId;

        public string Name { get => name; set => name = value; }

        /*[ForeignKey("SchoolClass")]
        public int SchoolClassId { get => schoolClassId; set => schoolClassId = value; }
        public virtual SchoolClass SchoolClass { get; set; }*/

        public long StudentAddressId { get; set; }
        public virtual Address StudentAddress { get; set; }



        public Student(long id, string name, int schoolClassId, long studentAddressId)
            : base(id)
        {

            this.name = name;
            this.schoolClassId = schoolClassId;
            StudentAddressId = studentAddressId;    
        }

        public Student()
            :base(-1)
        {

            name = string.Empty;
            schoolClassId = -1;
        }
    }
}
