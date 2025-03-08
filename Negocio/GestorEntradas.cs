using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Entidades;
using static Entidades.Evento;
namespace Negocio
{
    public partial class GestorEntradas //Lista
    {
        List<Entrada> entradas = new List<Entrada>();
        List<Evento> eventos = new List<Evento>();
        public string SectorA { get; set; }
        public string SectorB { get; set; }
        public string SectorC { get; set; }
        public string PrecioA { get; set; }
        public string PrecioB { get; set; }
        public string PrecioC { get; set; }
        public int TotalEntradas { get; set; }
        public string MensajeTicket { get; set; }
    }
    public partial class GestorEntradas //Metodos
    {
        public bool BuscarLista(string NombreEvento)
        {
            Evento evento1 = null;
            foreach (var c in eventos)
            {
                if (c.Nombre == NombreEvento)
                {
                    evento1 = c;
                    break;
                }
            }
            if (evento1 == null)
            {

                return false;
                throw new Exception("Evento no encontrado");
            }
            else
            {
                SectorA = evento1.Sectores[0].Nombre;
                SectorB = evento1.Sectores[1].Nombre;
                SectorC = evento1.Sectores[2].Nombre;
                PrecioA = evento1.Sectores[0].Precio.ToString();
                PrecioB = evento1.Sectores[1].Precio.ToString();
                PrecioC = evento1.Sectores[2].Precio.ToString();
                return true;
            }
        }
        public void RestarEntrada(string NombreEvento, int cantidadA, int cantidadB, int cantidadC
        ,int cantidadTotal)
        {
            int TotalEntradasRestantes = 0;
            foreach (var c in eventos)
            {
                if (c.Nombre == NombreEvento)
                {
                    TotalEntradasRestantes = c.Capacidad;
                    c.Sectores[0].Capacidad -= cantidadA;
                    c.Sectores[1].Capacidad -= cantidadB;
                    c.Sectores[2].Capacidad -= cantidadC;
                    c.Capacidad -= cantidadTotal;
                    TotalEntradasRestantes -= cantidadTotal;
                    TotalEntradas = TotalEntradasRestantes;
                    break;
                }
            }
        }
        public void GenerarTicket(string NombreEvento, string NombreSector)
        {
            MensajeTicket = null;
            foreach (var c in eventos)
            {

                if (c.Nombre == NombreEvento)
                {
                        MensajeTicket=
                        "ENTRADA (" + c.Nombre + ")\n"+
                        "SECTOR: " + NombreSector + "\n"+
                        "PRECIO: " + c.Sectores.Find(x => x.Nombre == NombreSector).Precio.ToString()+ "\n"+
                        "HORARIO: " + c.Hora.ToString() + "\n"+
                        "LUGAR: " + c.Locacion + "\n"+
                        "FECHA: " + c.Fecha.ToString();
                        break;
                }
            }

        }
        public List<Evento> ObtenerListaEventos()
        {
            return eventos;
        }
    }
    public partial class GestorEntradas //Eventos cargados
    {
        public GestorEntradas()
        {
           eventos.Add(new Evento
            {
                Nombre = "Ratones Paraonoicos",
                Capacidad = 1500,
                Locacion = "Complejo Vorterix",
                Fecha = DateTime.Parse("12/12/2025"),
                Hora = HourOfDay.TwentyOne,
                Sectores = new List<Sector>
            {
                new Sector { Nombre = "Sector A", Precio = 100, Capacidad = 500 },
                new Sector { Nombre = "Sector B", Precio = 80, Capacidad = 500 },
                new Sector { Nombre = "Sector C", Precio = 60, Capacidad = 500 }
            }
            });

            eventos.Add(new Evento
            {
                Nombre = "Bersuit Vergarabat",
                Capacidad = 1500,
                Locacion = "Salón Metropolitano",
                Fecha = DateTime.Parse("12/12/2025"),
                Hora = HourOfDay.Seventeen,
                Sectores = new List<Sector>
        {
            new Sector { Nombre = "Sector A", Precio = 120, Capacidad = 500 },
            new Sector { Nombre = "Sector B", Precio = 100, Capacidad = 500 },
            new Sector { Nombre = "Sector C", Precio = 80, Capacidad = 500 }
        }
            });

            eventos.Add(new Evento
            {
                Nombre = "La Renga",
                Capacidad = 1200,
                Locacion = "Salón El Circulo",
                Fecha = DateTime.Parse("12/12/2025"),
                Hora = HourOfDay.Eighteen,
                Sectores = new List<Sector>
        {
            new Sector { Nombre = "Sector A", Precio = 150, Capacidad = 400 },
            new Sector { Nombre = "Sector B", Precio = 120, Capacidad = 400 },
            new Sector { Nombre = "Sector C", Precio = 100, Capacidad = 400 }
        }
            });
            eventos.Add(new Evento
            {
                Nombre = "Illya Kuryaki and the Valderramas",
                Capacidad = 1800,
                Locacion = "Salón City Center",
                Fecha = DateTime.Parse("14/12/2025"),
                Hora = HourOfDay.Nineteen,
                Sectores = new List<Sector>
                {
                new Sector { Nombre = "Sector A", Precio = 180, Capacidad = 600 },
                new Sector { Nombre = "Sector B", Precio = 150, Capacidad = 600 },
                new Sector { Nombre = "Sector C", Precio = 120, Capacidad = 600 }
                }
            }
                );
        }
    }
}
    
