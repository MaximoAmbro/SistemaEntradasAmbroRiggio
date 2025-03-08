using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Entidades;

namespace Negocio
{
    public partial class GestorEntradas //Lista
    {
        List<Entrada> entradas = new List<Entrada>();
        List<Evento> eventos = new List<Evento>();
        Entrada entrada = new Entrada();
        Cliente cliente = new Cliente();
    }
    public partial class GestorEntradas //Metodos
    {
        public void AgregarEntrada()
        {
            if (ChequearDisponibilidad() == true)
            {
                entrada.Cliente = cliente;
                entrada.CantidadVendida = entrada.CantidadVendida + 1;
            }
            else { throw new Exception("No hay disponibilidad"); }
        }
        public bool ChequearDisponibilidad()
        {
            Entrada entrada = null;

            foreach (var c in entradas)
            {
                if (c.Nombre == entrada.Nombre)
                {
                    if (c.Capacidad >= c.CantidadVendida+1)
                    {
                        return true;
                    }
                    else { return false; }
                }
            }
            return false;
        }
        public void EliminarEntrada()
        {
            foreach (var c in entradas)
            {
                if (c.IDEntrada == entrada.IDEntrada)
                {
                    entrada.CantidadVendida = entrada.CantidadVendida - 1;
                }
                else { throw new Exception("ID no encontrado"); }
                }
            }
        }
    public partial class GestorEntradas //Eventos cargados
    {
        public GestorEntradas()
        {
            eventos.Add(new Evento { Nombre = "Ratones Paraonoicos", Capacidad = 1500, Locacion = "Complejo Vorterix", Fecha = DateTime.Parse("12/12/2025"),Hora = HourOfDay.TwentyOne});
            eventos.Add(new Evento
            {
                Nombre = "Bersuit Vergarabat",
                Capacidad = 1500,
                Locacion = "Salón Metropolitano",
                Fecha = DateTime.Parse("12/12/2025"),
                Hora = HourOfDay.Seventeen
            });

            eventos.Add(new Evento
            {
                Nombre = "La Renga",
                Capacidad = 1200,
                Locacion = "Salón El Circulo",
                Fecha = DateTime.Parse("12/12/2025"),
                Hora = HourOfDay.Eighteen
            });

            eventos.Add(new Evento
            {
                Nombre = "Patricio Rey y sus Redonditos de Ricota",
                Capacidad = 1800,
                Locacion = "Salón City Center",
                Fecha = DateTime.Parse("12/12/2025"),
                Hora = HourOfDay.Nineteen
            });

            eventos.Add(new Evento
            {
                Nombre = "Divididos",
                Capacidad = 1500,
                Locacion = "Salón Metropolitano",
                Fecha = DateTime.Parse("12/12/2025"),
                Hora = HourOfDay.Twenty
            });

            eventos.Add(new Evento
            {
                Nombre = "Ataque 77",
                Capacidad = 1200,
                Locacion = "Salón El Circulo",
                Fecha = DateTime.Parse("12/12/2025"),
                Hora = HourOfDay.TwentyOne
            });

            eventos.Add(new Evento
            {
                Nombre = "Los Piojos",
                Capacidad = 1800,
                Locacion = "Salón City Center",
                Fecha = DateTime.Parse("12/12/2025"),
                Hora = HourOfDay.TwentyTwo
            });

            eventos.Add(new Evento
            {
                Nombre = "Fobia",
                Capacidad = 1500,
                Locacion = "Salón Metropolitano",
                Fecha = DateTime.Parse("13/12/2025"),
                Hora = HourOfDay.Seventeen
            });

            eventos.Add(new Evento
            {
                Nombre = "El Otro Yo",
                Capacidad = 1200,
                Locacion = "Salón El Circulo",
                Fecha = DateTime.Parse("13/12/2025"),
                Hora = HourOfDay.Eighteen
            });

            eventos.Add(new Evento
            {
                Nombre = "Catupecu Machu",
                Capacidad = 1800,
                Locacion = "Salón City Center",
                Fecha = DateTime.Parse("13/12/2025"),
                Hora = HourOfDay.Nineteen
            });

            eventos.Add(new Evento
            {
                Nombre = "Hermética",
                Capacidad = 1500,
                Locacion = "Salón Metropolitano",
                Fecha = DateTime.Parse("13/12/2025"),
                Hora = HourOfDay.Twenty
            });

            eventos.Add(new Evento
            {
                Nombre = "Rata Blanca",
                Capacidad = 1200,
                Locacion = "Salón El Circulo",
                Fecha = DateTime.Parse("13/12/2025"),
                Hora = HourOfDay.TwentyOne
            });

            eventos.Add(new Evento
            {
                Nombre = "Almafuerte",
                Capacidad = 1800,
                Locacion = "Salón City Center",
                Fecha = DateTime.Parse("13/12/2025"),
                Hora = HourOfDay.TwentyTwo
            });

            eventos.Add(new Evento
            {
                Nombre = "A.N.I.M.A.L.",
                Capacidad = 1500,
                Locacion = "Salón Metropolitano",
                Fecha = DateTime.Parse("14/12/2025"),
                Hora = HourOfDay.Seventeen
            });

            eventos.Add(new Evento
            {
                Nombre = "Carajo",
                Capacidad = 1200,
                Locacion = "Salón El Circulo",
                Fecha = DateTime.Parse("14/12/2025"),
                Hora = HourOfDay.Eighteen
            });

            eventos.Add(new Evento
            {
                Nombre = "Illya Kuryaki and the Valderramas",
                Capacidad = 1800,
                Locacion = "Salón City Center",
                Fecha = DateTime.Parse("14/12/2025"),
                Hora = HourOfDay.Nineteen
            });
        }
    }
}
    
