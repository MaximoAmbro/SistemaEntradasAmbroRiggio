using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Negocio;

namespace Repositorio
{
    public partial class GestorVendedores
    {
        public List <Vendedor> vendedores = new List<Vendedor>();
        private static GestorVendedores _instance;

        public static GestorVendedores Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new GestorVendedores();
                }
                return _instance;
            }
        }
    } // Lista
    public partial class GestorVendedores
    {
        public bool EncontrarMail(string mail)
        {
            Vendedor cliente1 = null;
            foreach (var c in vendedores)
            {
                if (c.Mail == mail)
                {
                    cliente1 = c;
                    break;
                }
            }
            if (cliente1 == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool EncontrarContraseña(string contraseña, string mail)
        {
            Vendedor vendedor1= null;
            foreach (var c in vendedores)
            {
                if (c.Mail == mail && c.Contraseña == contraseña)
                {
                    vendedor1 = c;
                    break;
                }
            }
            if (vendedor1 == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public List<Local> ObtenerListaLocales(string mail)
        {
            Vendedor vendedor1 = null;
            foreach (var c in vendedores)
            {
                if (c.Mail == mail)
                {
                    vendedor1 = c;
                    return vendedor1.Locales;
                }
                vendedor1 = null;
            }
            return null;
        }
        public void DevolverNombre(string mail, out string nombre)
        {
            nombre = "";
            foreach (var c in vendedores)
            {
                if (c.Mail == mail)
                {
                    nombre = c.Nombre;
                    break;
                }
            }
        }
    } // Metodos
    public partial class GestorVendedores
    {
        public void CargarLista()
        {
            vendedores.Add(new Vendedor { Nombre = "Ambro", Apellido = "Sape", Mail = "V", Contraseña = "V"  });
        }

    } // Creacion de Elementos
}
