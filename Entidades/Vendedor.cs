using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Vendedor : Cliente
    {
        public class Local()
        {
            public string Nombre { get; set; }
            public string Direccion { get; set; }
            public string Telefono { get; set; }
            public string Mail { get; set; }
            public int Capacidad { get; set; }
            public List<Evento> Eventos { get; set; }
        }
        public List <Local> Locales { get; set; }
    }
}
