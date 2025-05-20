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
        Vendedor vendedor = new Vendedor();
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
            Vendedor vendedor1 = null;
            foreach (var c in vendedores)
            {
                if (c.Mail == mail)
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

        public bool EncontrarContraseña(string contraseña, string mail)
        {
            Vendedor vendedor1 = null;
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
    } // Metodos
    public partial class GestorVendedores
    {
        public void CargarLista()
        {
            vendedores.Clear(); // Limpia la lista para evitar duplicados
            vendedores.Add(new Vendedor { Nombre = "Juan", Apellido = "Garcia", Usuario = "Juan_Garcia23", Mail = "Vendedor", Contraseña = "a" });
            vendedores.Add(new Vendedor { Nombre = "Maria", Apellido = "Rodriguez", Usuario = "Maria_Rodriguez12", Mail = "MariaRodriguez@yahoo.com", Contraseña = "Cc1234" });
            vendedores.Add(new Vendedor { Nombre = "Carlos", Apellido = "Perez", Usuario = "Carlos_Perez34", Mail = "CarlosPerez@gmail.com", Contraseña = "Dd1234" });
            vendedores.Add(new Vendedor { Nombre = "Ana", Apellido = "Gomez", Usuario = "Ana_Gomez56", Mail = "AnaGomez@hotmail.com", Contraseña = "Ee1234" });
            vendedores.Add(new Vendedor { Nombre = "Luis", Apellido = "Martinez", Usuario = "Luis_Martinez78", Mail = "LuisMartinez@yahoo.com", Contraseña = "Ff1234" });
            vendedores.Add(new Vendedor { Nombre = "Sofia", Apellido = "Gonzalez", Usuario = "Sofia_Gonzalez90", Mail = "SofiaGonzalez@gmail.com", Contraseña = "Gg1234" });
            vendedores.Add(new Vendedor { Nombre = "Miguel", Apellido = "Hernandez", Usuario = "Miguel_Hernandez12", Mail = "MiguelHernandez@hotmail.com", Contraseña = "Hh1234" });
            vendedores.Add(new Vendedor { Nombre = "Elena", Apellido = "Garcia", Usuario = "Elena_Garcia34", Mail = "ElenaGarcia@yahoo.com", Contraseña = "Jj1234" });
            vendedores.Add(new Vendedor { Nombre = "Rafael", Apellido = "Perez", Usuario = "Rafael_Perez56", Mail = "RafaelPerez@gmail.com", Contraseña = "Kk1234" });
            vendedores.Add(new Vendedor { Nombre = "Isabel", Apellido = "Gomez", Usuario = "Isabel_Gomez78", Mail = "IsabelGomez@hotmail.com", Contraseña = "Ll1234" });
        }
    }// Creacion de Elementos
}
