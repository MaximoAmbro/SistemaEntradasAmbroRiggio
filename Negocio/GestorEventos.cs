using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using Entidades;
using System.Threading.Tasks;

namespace Negocio
{
    public partial class GestorEventos
    {
        private List<Evento> eventos;
        public GestorEventos()
        {
            eventos = new List<Evento>();
            CargarEventosIniciales();
        }
        public List<Evento> ObtenerListaEventos()
        {
            return eventos;
        }
    } 
    public partial class GestorEventos
    {
        private void CargarEventosIniciales()
        {
            eventos.Add(new Evento
            {
                Nombre = "Concierto de Rock",
                Hora = HourOfDay.Seven,
                Capacidad = 500,
                Fecha = new DateTime(2023, 3, 15),
                Locacion = "Estadio de Fútbol"
            });
            eventos.Add(new Evento
            {
                Nombre = "Festival de Música Electrónica",
                Hora = HourOfDay.Nine,
                Capacidad = 1000,
                Fecha = new DateTime(2023, 4, 1),
                Locacion = "Parque de la Ciudad"
            });
            eventos.Add(new Evento
            {
                Nombre = "Conferencia de Negocios",
                Hora = HourOfDay.Ten,
                Capacidad = 200,
                Fecha = new DateTime(2023, 3, 22),
                Locacion = "Hotel de la Ciudad"
            });
            eventos.Add(new Evento
            {
                Nombre = "Exposición de Arte",
                Hora = HourOfDay.Three,
                Capacidad = 300,
                Fecha = new DateTime(2023, 4, 15),
                Locacion = "Museo de Arte Moderno"
            });
            eventos.Add(new Evento
            {
                Nombre = "Partido de Fútbol",
                Hora = HourOfDay.Eight,
                Capacidad = 800,
                Fecha = new DateTime(2023, 3, 29),
                Locacion = "Estadio de Fútbol"
            });
        }

    }
}
