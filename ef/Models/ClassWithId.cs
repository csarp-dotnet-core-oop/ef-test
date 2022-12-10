using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EF.Models
{
    public abstract class ClassWithId
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }

        public ClassWithId(long id)
        {
            this.Id = id;
        }
    }
}
