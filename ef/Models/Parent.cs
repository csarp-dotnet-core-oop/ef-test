using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Models
{
    public class Parent : ClassWithId
    {

        private string name;
        bool isWoman;

        public string Name { get => name; set => name = value; }
        public bool IsWoman { get => isWoman; set => isWoman = value; }
        
        // navigation property
        // one-one
        public int ParentAddressId { get; set; }
        public virtual Address ParentAddress { get; set; }

        public Parent(long id, string name, bool isWoman)
            :base (id)
        {
            this.name = name;
            this.isWoman = isWoman;
        }

        public Parent()
            :base(-1)
        {
            name = string.Empty;
            isWoman = false;
        }
    }
}
