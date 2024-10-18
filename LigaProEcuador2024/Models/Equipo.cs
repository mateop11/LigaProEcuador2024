using System.Collections.Generic;

namespace LigaProEcuador2024.Models
{
    public class Equipo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Ciudad { get; set; }
        public int Titulos { get; set; }
        public bool AceptaExtranjeros { get; set; }

        // Relación uno a muchos con Jugadores
        public List<Jugador> Jugadores { get; set; }
    }
}
