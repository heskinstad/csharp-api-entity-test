﻿namespace workshop.wwwapi.DTO
{
    public class PatientDTO
    {
        public string FullName { get; set; }
        public List<AppointmentDTO> Appointments { get; set; }
    }
}
