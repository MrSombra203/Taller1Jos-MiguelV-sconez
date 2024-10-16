using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Taller1JoséMiguelVásconez.Models;

    public class EstadioContext : DbContext
    {
        public EstadioContext (DbContextOptions<EstadioContext> options)
            : base(options)
        {
        }

        public DbSet<Taller1JoséMiguelVásconez.Models.Estadio> Estadio { get; set; } = default!;
    }
