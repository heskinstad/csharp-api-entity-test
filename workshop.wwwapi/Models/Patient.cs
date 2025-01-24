using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using Microsoft.EntityFrameworkCore;

namespace workshop.wwwapi.Models
{
    [Table("Patient")] 
    public class Patient
    {
        [Column("id")]
        [Key]
        public int Id { get; set; }
        [Column("fullName")]
        public string FullName { get; set; }
    }
}
