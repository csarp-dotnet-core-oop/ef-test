using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Models
{
    public class SchoolLesson : ClassWithId
    {
        long studentId;
        long teacherId;
        long subjectId;

        public long SchoolLessonId { get => Id; set => Id = value; }
        public long StudentId { get => studentId; set => studentId = value; }
        public long TeacherId { get => teacherId; set => teacherId = value; }
        public long SubjectId { get => subjectId; set => subjectId = value; }

        public SchoolLesson(long schoolLessonId, long studentId, long teacherId, long subjectId)
            : base(schoolLessonId)
        {
            this.studentId = studentId;
            this.teacherId = teacherId;
            this.subjectId = subjectId;
        }

        public SchoolLesson():
            base(-1)
        {
            studentId = -1;
            teacherId = -1;
            subjectId = -1;
        }

    }
}
