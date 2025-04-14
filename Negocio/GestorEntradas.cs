﻿using System;
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
        } // Funciona 
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
        } // Funciona 
        public void GenerarTicket(string NombreEvento, string NombreSector)
        {
            MensajeTicket = null;
            string hora = DateTime.Now.ToString();
            Guid idTicket = Guid.NewGuid();
            foreach (var c in eventos)
            {
                if (c.Nombre == NombreEvento)
                {
                    MensajeTicket =
                        "ENTRADA (" + c.Nombre + ")\n" +
                        "ID TICKET: " + idTicket.ToString() + "\n" +
                        "SECTOR: " + NombreSector + "\n" +
                        "PRECIO: " + c.Sectores.Find(x => x.Nombre == NombreSector).Precio.ToString() + "$\n" +
                        "HORARIO: " + hora + "\n" +
                        "LUGAR: " + c.Locacion + "\n" +
                        "FECHA: " + c.Fecha.ToString();
                    break;
                }
            }
        }  // Funciona
        public List<Evento> ObtenerListaEventos()
        {
            return eventos;
        } // Funciona
        public void DevolverEntrada(string NombreEvento)
        {
            foreach (var c in eventos)
            {
                if (c.Nombre == NombreEvento)
                {
                    break;
                }
            }
        } // Funciona
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
                Hora = new TimeSpan(21, 0, 0),
                Sectores = new List<Sector>
            {
                new Sector { Nombre = "Sector VIP", Precio = 45000, Capacidad = 500 },
                new Sector { Nombre = "Sector PLATEA", Precio = 20000, Capacidad = 500 },
                new Sector { Nombre = "Sector GENERAL", Precio = 12000, Capacidad = 500 }
            }
            }); // Ratones Paraonoicos
            eventos.Add(new Evento
            {
                Nombre = "Bersuit Vergarabat",
                Capacidad = 1500,
                Locacion = "Salón Metropolitano",
                Fecha = DateTime.Parse("12/12/2025"),
                Hora = new TimeSpan(22, 0, 0),
                Sectores = new List<Sector>
            {
                new Sector { Nombre = "Sector VIP", Precio = 70000, Capacidad = 500 },
                new Sector { Nombre = "Sector PLATEA", Precio = 45000, Capacidad = 500 },
                new Sector { Nombre = "Sector GENERAL", Precio = 25000, Capacidad = 500 }
            }
            }); // Bersuit Vergarabat
            eventos.Add(new Evento
            {
                Nombre = "La Renga",
                Capacidad = 1200,
                Locacion = "Salón El Circulo",
                Fecha = DateTime.Parse("12/12/2025"),
                Hora = new TimeSpan(20, 0, 0),
                Sectores = new List<Sector>
                {
                    new Sector { Nombre = "Sector VIP", Precio = 60000, Capacidad = 400 },
                    new Sector { Nombre = "Sector PLATEA", Precio = 35000, Capacidad = 400 },
                    new Sector { Nombre = "Sector GENERAL", Precio = 20000, Capacidad = 400 }
                }
            }); // La Renga
            eventos.Add(new Evento
            {
                Nombre = "Otto",
                Capacidad = 1800,
                Locacion = "Complejo Forest",
                Fecha = DateTime.Parse("14/12/2025"),
                Hora = new TimeSpan(22, 30, 0),
                Sectores = new List<Sector>
                {
                    new Sector { Nombre = "Sector MESA", Precio = 50000, Capacidad = 600 },
                    new Sector { Nombre = "Sector GENERAL", Precio = 30000, Capacidad = 600 },
                    new Sector { Nombre = "Sector PREVIA", Precio = 18000, Capacidad = 600 }
                }
            }); // Otto
            eventos.Add(new Evento
            {
                Nombre = "Lova",
                Capacidad = 700,
                Locacion = "Brown 3126",
                Fecha = DateTime.Parse("12/12/2025"),
                Hora = new TimeSpan(00, 30, 0),
                Sectores = new List<Sector>
                {
                    new Sector { Nombre = "Sector VIP", Precio = 20000, Capacidad = 400 },
                    new Sector { Nombre = "Sector GENERAL", Precio = 15000, Capacidad = 400 },
                    new Sector { Nombre = "Sector PREVIA", Precio = 10000, Capacidad = 400 }
                }
            }); // Lova
        }
    }
}
    
