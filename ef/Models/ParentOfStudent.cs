using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Models
{
    public class ParentOfStudent
    {
        private long parentId;
        private long studentId;

        public long ParentId { get => parentId; set => parentId = value; }
        public long StudentId { get => studentId; set => studentId = value; }

        public ParentOfStudent(long parentId, long studentId)
        {
            this.parentId = parentId;
            this.studentId = studentId;
        }

        public ParentOfStudent()
        {
            parentId = -1;
            studentId = -1;
        }
        
    }
}
