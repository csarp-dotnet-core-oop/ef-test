using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Models
{
    public class Grade : ClassWithId
    {

        long lessonId;
        DateTime date;
        int grade;

        public Grade(long id) : base(id)
        {
        }
    }
}
