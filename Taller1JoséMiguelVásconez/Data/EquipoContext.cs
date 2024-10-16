using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Taller1JoséMiguelVásconez.Models;

    public class EquipoContext : DbContext
    {
        public EquipoContext (DbContextOptions<EquipoContext> options)
            : base(options)
        {
        }

        public DbSet<Taller1JoséMiguelVásconez.Models.Equipo> Equipo { get; set; } = default!;
    }
