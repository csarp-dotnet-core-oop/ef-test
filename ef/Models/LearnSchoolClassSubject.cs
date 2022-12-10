using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Models
{
    public class LearnSchoolClassSubject
    {
        private long schoolClassId;
        private long subjectId;

        public long SchoolClassId { get => schoolClassId; set => schoolClassId = value; }
        public long SubjectId { get => subjectId; set => subjectId = value; }

        public LearnSchoolClassSubject(long schoolClassId, long subjectId)
        {
            this.SchoolClassId = schoolClassId;
            this.SubjectId = subjectId;
        }

        public LearnSchoolClassSubject()
        {
            schoolClassId = -1;
            subjectId = -1;
        }

    }
}
