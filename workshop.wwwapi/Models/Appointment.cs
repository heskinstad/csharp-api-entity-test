using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace workshop.wwwapi.Models
{
    [Table("Appointment")]
    [PrimaryKey(nameof(Booking), nameof(DoctorId), nameof(PatientId))]
    public class Appointment
    {
        [Column("booking")]
        public DateTime Booking { get; set; }
        [Column("doctorId")]
        public int DoctorId { get; set; }
        [Column("patientId")]
        public int PatientId { get; set; }

    }
}
