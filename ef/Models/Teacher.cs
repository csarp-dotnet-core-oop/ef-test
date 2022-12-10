using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Models
{
    public  class Teacher : ClassWithId
    {
        private string name;
        bool isHeadTeacher;
        bool isWoman;

        public string Name { get => name; set => name = value; }
        public bool IsHeadTeacher { get => isHeadTeacher; set => isHeadTeacher = value; }
        public bool IsWoman { get => isWoman; set => isWoman = value; }

        [ForeignKey("Address")]
        public int StudentAddressId { get; set; }
        public virtual Address StudentAddress { get; set; }

        public virtual ICollection<Subject> Subjects { get; set; }

        public Teacher(long id, string name, bool isHeadTeacher, bool isWoman)
            : base(id)
        {
            this.Name = name;
            this.IsHeadTeacher = isHeadTeacher;
            this.isWoman = isWoman;
        }

        public Teacher()
            : base(-1)
        {
            name = string.Empty;
            isHeadTeacher = false;
            IsWoman = false;
        }
    }
}
