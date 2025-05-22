using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Negocio
{
    public partial class GestorClientes // Lista
    {
        public static List<Cliente> clientes = new List<Cliente>();
        Cliente cliente = new Cliente();
        private static GestorClientes _instance;

        public static GestorClientes Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new GestorClientes();
                }
                return _instance;
            }
        }

    }
    public partial class GestorClientes // Metodos
        {
       
            public void CambiarContraseña(string usuario, string contraseña)
            {
                foreach (var c in clientes)
                {
                    if (c.Usuario == usuario)
                    {
                        c.Contraseña = null;
                        c.Contraseña = contraseña;
                        break;
                    }
                }
            }
            public void AgregarCliente(string nombre, string apellido, string usuario, string mail, string contraseña)
            {
            cliente = new Cliente { Nombre = nombre, Apellido = apellido, Usuario = usuario, Mail = mail, Contraseña = contraseña }; clientes.Add(cliente);
            }
            public bool EncontrarUsuario(string usuario)
            {
                Cliente cliente1 = null;
                foreach (var c in clientes)
                {
                    if (c.Usuario == usuario)
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
                Cliente cliente1 = null;
                foreach (var c in clientes)
                {
                    if (c.Mail == mail && c.Contraseña == contraseña)
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
            public bool EncontrarMail(string mail)
            {
                Cliente cliente1 = null;
                foreach (var c in clientes)
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
            public void AgregarEntrada(Evento evento, string usuario)
            {
                Cliente cliente1 = null;
                foreach (var c in clientes)
                {
                    if (c.Usuario == usuario)
                    {
                        cliente1 = c;
                        cliente1.entradasUsuario.Add(evento);
                        break;
                    }
                }
            }
            public bool BuscarMailDeUsuario(string mail, string usuario)
            {
                Cliente cliente1 = null;
                foreach (var c in clientes)
                {
                    if (c.Mail == mail && c.Usuario == usuario)
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
            public List<Evento> ObtenerListaEventos(string usuario)
            {
                Cliente cliente1 = null;
                foreach (var c in clientes)
                {
                    if (c.Usuario == usuario)
                    {
                        cliente1 = c;
                        return cliente1.entradasUsuario;
                    }
                    cliente1 = null;
                }
                 return null;
        }
    }
        public partial class GestorClientes // Usuarios cargados
    {
        public void CargarLista()
        {
            clientes.Add(new Cliente { Nombre = "Pedro", Apellido = "Lopez", Usuario = "Pedro_Lopez35", Mail = "C", Contraseña = "C" });
            clientes.Add(new Cliente { Nombre = "Pedro", Apellido = "Lopez", Usuario = "Pedro_Lopez35", Mail = "PedroLopez@gmail.com", Contraseña = "Aa1234" });
            clientes.Add(new Cliente { Nombre = "", Apellido = "", Usuario = "z", Mail = "z", Contraseña = "z" });
            clientes.Add(new Cliente { Nombre = "Juan", Apellido = "Riggio", Usuario = "JuaniLGBT", Mail = "juanriggio@gmail.com", Contraseña = "a" });
            clientes.Add(new Cliente { Nombre = "Maximo", Apellido = "Ambrosion", Usuario = "Ambrosape", Mail = "Maximoambrosino5@gmail.com", Contraseña = "Ambro" });
            clientes.Add(new Cliente { Nombre = "Carlos", Apellido = "López", Usuario = "carloslopez", Mail = "carloslopez@example.com", Contraseña = "password123" });
            clientes.Add(new Cliente { Nombre = "Ana", Apellido = "Díaz", Usuario = "anadiaz", Mail = "anadiaz@example.com", Contraseña = "password123" });
            clientes.Add(new Cliente { Nombre = "Pedro", Apellido = "Martínez", Usuario = "pedromartinez", Mail = "pedromartinez@example.com", Contraseña = "password123" });
            clientes.Add(new Cliente { Nombre = "Lucía", Apellido = "García", Usuario = "luciagarcia", Mail = "luciagarcia@example.com", Contraseña = "password123" });
            clientes.Add(new Cliente { Nombre = "Tomás", Apellido = "Rodríguez", Usuario = "tomasrodriguez", Mail = "tomasrodriguez@example.com", Contraseña = "password123" });
            clientes.Add(new Cliente { Nombre = "Sofía", Apellido = "Hernández", Usuario = "sofiahernandez", Mail = "sofiahernandez@example.com", Contraseña = "password123" });
            clientes.Add(new Cliente { Nombre = "Mateo", Apellido = "Gómez", Usuario = "mateogomez", Mail = "mateogomez@example.com", Contraseña = "password123" });
            clientes.Add(new Cliente { Nombre = "Isabel", Apellido = "Sánchez", Usuario = "isabelsanchez", Mail = "isabelsanchez@example.com", Contraseña = "password123" });
            clientes.Add(new Cliente { Nombre = "Alejandro", Apellido = "Fernández", Usuario = "alejandrofernandez", Mail = "alejandrofernandez@example.com", Contraseña = "password123" });
            clientes.Add(new Cliente { Nombre = "Valeria", Apellido = "Díaz", Usuario = "valeriadiaz", Mail = "valeriadiaz@example.com", Contraseña = "password123" });
            clientes.Add(new Cliente { Nombre = "Gabriel", Apellido = "López", Usuario = "gabriellopez", Mail = "gabriellopez@example.com", Contraseña = "password123" });
            clientes.Add(new Cliente { Nombre = "Eva", Apellido = "García", Usuario = "evagarcia", Mail = "evagarcia@example.com", Contraseña = "password123" });
            clientes.Add(new Cliente { Nombre = "Julio", Apellido = "Martínez", Usuario = "juliomartinez", Mail = "juliomartinez@example.com", Contraseña = "password123" });
            clientes.Add(new Cliente { Nombre = "Cristina", Apellido = "Hernández", Usuario = "cristinahernandez", Mail = "cristinahernandez@example.com", Contraseña = "password123" });
            clientes.Add(new Cliente { Nombre = "Daniel", Apellido = "Gómez", Usuario = "danielgomez", Mail = "danielgomez@example.com", Contraseña = "password123" });
            clientes.Add(new Cliente { Nombre = "Laura", Apellido = "Sánchez", Usuario = "laurasanchez", Mail = "laurasanchez@example.com", Contraseña = "password123" });
        } 
    } 
}

