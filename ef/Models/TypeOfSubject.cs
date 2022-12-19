using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Models
{
    public class TypeOfSubject : ClassWithId
    {
		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		public TypeOfSubject():base(-1)
		{
			name = string.Empty;
		}

		public TypeOfSubject(long id, string name) : base(id)
		{
			this.name = name;			
		}
	}
}
