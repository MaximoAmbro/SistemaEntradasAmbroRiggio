using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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
        Entrada entrada = new Entrada();
    }
    public partial class GestorEntradas //Metodos
    {
        public void AgregarEntrada()
        {
            if (ChequearDisponibilidad() == true)
            {
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
    }
    public partial class GestorEntradas //Eventos cargados
    {

    }
}
