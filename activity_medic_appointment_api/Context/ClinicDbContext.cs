using activity_medic_appointment_api.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Numerics;

namespace activity_medic_appointment_api.Context
{
    public class ClinicDbContext : DbContext
    {
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Cita> Citas { get; set; }

        public ClinicDbContext(DbContextOptions<ClinicDbContext> options)
            : base(options) { }
    }
}
