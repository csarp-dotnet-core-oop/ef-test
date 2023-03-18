using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Models
{
    public class Subject :ClassWithId
    {
        private string name;
        public string Name { get => name; set => name = value; }

        private long subjectTypeId;

        public long SubjectTypeId { get => subjectTypeId; set => subjectTypeId = value; }        


        public Subject()
            : base(-1)
        {

            name=string.Empty;
        }

        public Subject(long id, string name, long typeId)
            :base(id)
        {
            this.name = name;
            this.subjectTypeId = typeId;
        }

        public override string ToString() 
        {
            return $"{Id} {name}";
        }
        
    }
}
