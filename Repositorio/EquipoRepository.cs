using MichelleLigaPRO.Models;

namespace MichelleLigaPRO.Repositorio;
public class EquipoRepository      
    {
        private readonly List<Equipo> _equipos; // Campo para almacenar los equipos en memoria (simulación)

        public EquipoRepository(){
        
            _equipos = new List<Equipo>()
            {
                new Equipo { Id = 1, Nombre = "liga de Quito", PartidosJugados = 10, PartidosGanados = 10, PartidosEmpatados = 0, PartidosPerdidos = 0 },
                new Equipo { Id = 2, Nombre = "Barcelona SC", PartidosJugados = 10, PartidosGanados = 10, PartidosEmpatados = 0, PartidosPerdidos = 0 },
                new Equipo { Id = 3, Nombre = "Independiente del Valle", PartidosJugados = 10, PartidosGanados = 8, PartidosEmpatados = 2, PartidosPerdidos = 0 },
                new Equipo { Id = 4, Nombre = "Aucas", PartidosJugados = 10, PartidosGanados = 7, PartidosEmpatados = 2, PartidosPerdidos = 1 },
                new Equipo { Id = 5, Nombre = "Emelec", PartidosJugados = 10, PartidosGanados = 6, PartidosEmpatados = 3, PartidosPerdidos = 1 },
                new Equipo { Id = 6, Nombre = "U. Católica", PartidosJugados = 10, PartidosGanados = 5, PartidosEmpatados = 4, PartidosPerdidos = 1 },
                new Equipo { Id = 7, Nombre = "Delfín", PartidosJugados = 10, PartidosGanados = 4, PartidosEmpatados = 3, PartidosPerdidos = 3 },
                new Equipo { Id = 8, Nombre = "Técnico Universitario", PartidosJugados = 10, PartidosGanados = 3, PartidosEmpatados = 4, PartidosPerdidos = 3 },
                new Equipo { Id = 9, Nombre = "El Nacional", PartidosJugados = 10, PartidosGanados = 3, PartidosEmpatados = 3, PartidosPerdidos = 4 },
                new Equipo { Id = 10, Nombre = "Orense", PartidosJugados = 10, PartidosGanados = 2, PartidosEmpatados = 3, PartidosPerdidos = 5 },
                new Equipo { Id = 11, Nombre = "Deportivo Cuenca", PartidosJugados = 10, PartidosGanados = 1, PartidosEmpatados = 4, PartidosPerdidos = 5 },
                new Equipo { Id = 12, Nombre = "Libertad", PartidosJugados = 10, PartidosGanados = 1, PartidosEmpatados = 3, PartidosPerdidos = 6 },
                new Equipo { Id = 13, Nombre = "Mushuc Runa", PartidosJugados = 10, PartidosGanados = 1, PartidosEmpatados = 3, PartidosPerdidos = 6 },
                new Equipo { Id = 14, Nombre = "Imbabura", PartidosJugados = 10, PartidosGanados = 1, PartidosEmpatados = 2, PartidosPerdidos = 7 },
                new Equipo { Id = 15, Nombre = "Cumbayá", PartidosJugados = 10, PartidosGanados = 1, PartidosEmpatados = 2, PartidosPerdidos = 7 },
                new Equipo { Id = 16, Nombre = "Guayaquil City", PartidosJugados = 10, PartidosGanados = 0, PartidosEmpatados = 3, PartidosPerdidos = 7 }
            };
        }

        public List<Equipo> DevuelveListadoEquipos()
        {
            return _equipos.OrderByDescending(e => e.TotalPuntos).ToList(); 
        }

        public Equipo ObtenerEquipoPorId(int id)
        {
            return _equipos.FirstOrDefault(e => e.Id == id);
        }

        public void AgregarEquipo(Equipo equipo)
        {
            // Simulación de asignar un nuevo ID (en una base de datos esto sería automático)
            if (_equipos.Any())
            {
                equipo.Id = _equipos.Max(e => e.Id) + 1;
            }
            else
            {
                equipo.Id = 1;
            }
            _equipos.Add(equipo);
        }

        public bool ActualizarEquipo(Equipo equipo)
        {
            var existingEquipo = _equipos.FirstOrDefault(e => e.Id == equipo.Id);
            if (existingEquipo != null)
            {
                existingEquipo.Nombre = equipo.Nombre;
                existingEquipo.PartidosJugados = equipo.PartidosJugados;
                existingEquipo.PartidosGanados = equipo.PartidosGanados;
                existingEquipo.PartidosEmpatados = equipo.PartidosEmpatados;
                existingEquipo.PartidosPerdidos = equipo.PartidosPerdidos;
                return true;
            }
            return false;
        }

        public bool EliminarEquipo(int id)
        {
            var equipoToRemove = _equipos.FirstOrDefault(e => e.Id == id);
            if (equipoToRemove != null)
            {
                _equipos.Remove(equipoToRemove);
                return true;
            }
            return false;
        }
    }
