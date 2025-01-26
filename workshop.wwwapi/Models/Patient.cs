﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using Microsoft.EntityFrameworkCore;

namespace workshop.wwwapi.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public List<Appointment> Appointments { get; set; }
    }
}
