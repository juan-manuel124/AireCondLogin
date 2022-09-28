using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AiresAcondDomi.Models;

    public class AppAuthDbContext : DbContext
    {
        public AppAuthDbContext (DbContextOptions<AppAuthDbContext> options)
            : base(options)
        {
        }

        public DbSet<AiresAcondDomi.Models.Cliente> Cliente { get; set; } = default!;
        public DbSet<AiresAcondDomi.Models.Persona> Persona { get; set; } = default!;
        public DbSet<AiresAcondDomi.Models.ProfecionalDesignado> ProfecionalDesignado { get; set; } = default!;
        public DbSet<AiresAcondDomi.Models.Profesional> Profesional { get; set; } = default!;
        public DbSet<AiresAcondDomi.Models.SugerenciaMantenimiento> SugerenciaMantenimiento { get; set; } = default!;
        public DbSet<AiresAcondDomi.Models.Servicios> Servicio { get; set; } = default!;
    }
