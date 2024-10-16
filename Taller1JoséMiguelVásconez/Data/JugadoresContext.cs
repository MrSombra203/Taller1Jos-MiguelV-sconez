using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Taller1JoséMiguelVásconez.Models;

    public class JugadoresContext : DbContext
    {
        public JugadoresContext (DbContextOptions<JugadoresContext> options)
            : base(options)
        {
        }

        public DbSet<Taller1JoséMiguelVásconez.Models.Jugador> Jugador { get; set; } = default!;
    }
