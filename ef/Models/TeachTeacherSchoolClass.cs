using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EF.Models
{
    public class TeachTeacherSchoolClass
    {
        private long subjectId;
        private long teacherId;

        
        public long SubjectId { get => subjectId; set => subjectId = value; }
        public long TeacherId { get => teacherId; set => teacherId = value; }

        [ForeignKey("SubjectId")]
        public Subject Subject { get; set; }
        [ForeignKey("TeacherId")]
        public Teacher Teacher { get; set; }

        public TeachTeacherSchoolClass(long subjectId, long teacherId)
        {
            this.subjectId = subjectId;
            this.teacherId = teacherId;
        }

        public TeachTeacherSchoolClass()
        {
            subjectId = -1;
            teacherId = -1;
        }
    }
}
