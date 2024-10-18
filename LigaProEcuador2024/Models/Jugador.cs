namespace LigaProEcuador2024.Models
{
    public class Jugador
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Posicion { get; set; }
        public int Edad { get; set; }

        // Relación con Equipo
        public int EquipoId { get; set; }
        public Equipo Equipo { get; set; }
    }
}
