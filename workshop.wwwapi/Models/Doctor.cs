using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace workshop.wwwapi.Models
{
    [Table("Doctor")]  
    public class Doctor
    {
        [Column("id")]
        [Key]
        public int Id { get; set; }
        [Column("fullName")]
        public string FullName { get; set; }
    }
}
