using System.ComponentModel.DataAnnotations.Schema;

namespace EF.Models
{
    public class SchoolClass : ClassWithId
    {
        public SchoolClass(long id, int schoolYear, char classType, long headTeachId) : base(id)
        {
            SchoolYear = schoolYear;
            ClassType = classType;
            HeadTeacherId = headTeachId;

        }

        public virtual int SchoolYear { get; set; }

        public virtual char ClassType { get; set; }

        [ForeignKey("HeadTeacher")]
        public long HeadTeacherId { get; set; }
        public virtual Teacher HeadTeacher { get; set; }


        public ICollection<Student> Students { get; set; }
    }
}
