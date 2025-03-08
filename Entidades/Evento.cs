using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public partial class Evento
    {
        public string Nombre { get; set; }
        public HourOfDay Hora { get; set; }
        public int Capacidad { get; set; }
        public DateTime Fecha { get; set; }
        public string Locacion { get; set; }
        public class Sector
        {
            public string Nombre { get; set; }
            public decimal Precio { get; set; }
            public int Capacidad { get; set; }
        }
        public List<Sector> Sectores { get; set; }

    }
}
