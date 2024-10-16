using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Taller1JoséMiguelVásconez.Models
{
    public class Jugador
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(200)]
        [Required(ErrorMessage = "El nombre del equipo es obligatorio")]
        public string Nombre { get; set; }
        [MaxLength(200)]
        public string Pocición {  get; set; }
        public int Edad {  get; set; }
        public Equipo Equipo { get; set; }
        [ForeignKey("Equipo")]
        public int IdEquipo { get; set; }
    }
}
