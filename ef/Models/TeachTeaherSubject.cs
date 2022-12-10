using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Models
{
    public class TeachTeaherSubject
    {
        private long teacherId;
        private long subjectId;

        public long TeacherId { get => teacherId; set => teacherId = value; }
        public long SubjectId { get => subjectId; set => subjectId = value; }

        public TeachTeaherSubject(long teacherId, long subjectId)
        {
            this.teacherId = teacherId;
            this.subjectId = subjectId;
        }

    }
}
