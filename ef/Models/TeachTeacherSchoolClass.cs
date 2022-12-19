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
        private long teacherId;
        private long schoolClassId;

        
        public long TeacherId { get => teacherId; set => teacherId = value; }
        public long SchoolClassId { get => schoolClassId; set => schoolClassId = value; }

        public TeachTeacherSchoolClass(long teacherId, long schoolClassId)
        {
            this.teacherId = teacherId;
            this.schoolClassId = schoolClassId;
        }

        public TeachTeacherSchoolClass()
        {
            teacherId = -1;
            schoolClassId = -1;
        }
    }
}
