using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class GestorEventos
    {
        private List<Evento> eventos;

        public GestorEventos()
        {
            eventos = new List<Evento>();
            CargarEventosIniciales();
        }

        private void CargarEventosIniciales()
        {
            eventos.Add(new Evento(1, "Club Nocturno XYZ", new DateTime(2025, 3, 15, 22, 0, 0), 200, 500));
            eventos.Add(new Evento(2, "Discoteca ABC", new DateTime(2025, 3, 20, 21, 30, 0), 150, 300));
            eventos.Add(new Evento(3, "Sala Fiesta 123", new DateTime(2025, 3, 25, 23, 0, 0), 300, 400));
            eventos.Add(new Evento(4, "Terraza Night", new DateTime(2025, 3, 30, 1, 0, 0), 100, 200));
        }

        public List<Evento> ObtenerListaEventos()
        {
            return eventos;
        }
    }


}
