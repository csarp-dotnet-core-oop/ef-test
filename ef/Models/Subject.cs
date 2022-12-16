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

        public Subject()
            : base(-1)
        {

            name=string.Empty;
        }

        public Subject(long id, string name)
            :base(id)
        {
            this.name = name;
        }
    }
}
