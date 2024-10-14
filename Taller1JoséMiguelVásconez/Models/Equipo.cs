namespace Taller1JoséMiguelVásconez.Models
{
    public class Equipo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Ciudad {  get; set; }
        public int Titulos { get; set; }
        public bool AceptaExtranjeros {  get; set; }
        public Estadio Estadio { get; set; }
    }
}
