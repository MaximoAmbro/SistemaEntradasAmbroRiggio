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
                    if (c.NombreUsuario == usuario)
                    {
                        c.Contraseña = null;
                        c.Contraseña = contraseña;
                        break;
                    }
                }
            }
            public void AgregarCliente(string nombre, string apellido, string usuario, string mail, string contraseña)
            {
            cliente = new Cliente { Nombre = nombre, Apellido = apellido, NombreUsuario = usuario, Mail = mail, Contraseña = contraseña }; clientes.Add(cliente);
            }
            public bool EncontrarUsuario(string usuario)
            {
                Cliente cliente1 = null;
                foreach (var c in clientes)
                {
                    if (c.NombreUsuario == usuario)
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
            public bool EncontrarContraseña(string contraseña, string usuario)
            {
                Cliente cliente1 = null;
                foreach (var c in clientes)
                {
                    if (c.NombreUsuario == usuario && c.Contraseña == contraseña)
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
            public void DevolverUsuario(string mail, out string usuario)
            {
                usuario = null;
                foreach (var c in clientes)
                {
                    if (c.Mail == mail)
                    {
                        usuario = c.Nombre;
                        break;
                    }
                }
            }
            public void AgregarEntrada(Evento evento, string usuario)
            {
                Cliente cliente1 = null;
                foreach (var c in clientes)
                {
                    if (c.NombreUsuario == usuario)
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
                    if (c.Mail == mail && c.NombreUsuario == usuario)
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
                    if (c.NombreUsuario == usuario)
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
            clientes.Add(new Cliente { Nombre = "Pedro", Apellido = "Lopez", NombreUsuario = "Pedro_Lopez35", Mail = "Cliente", Contraseña = "a" });
            clientes.Add(new Cliente { Nombre = "Juan pedro", Apellido = "", NombreUsuario = "z", Mail = "z", Contraseña = "z" });
            clientes.Add(new Cliente { Nombre = "Juan", Apellido = "Riggio", NombreUsuario = "JuaniLGBT", Mail = "juanriggio@gmail.com", Contraseña = "a" });
            clientes.Add(new Cliente { Nombre = "Maximo", Apellido = "Ambrosion", NombreUsuario = "Ambrosape", Mail = "Maximoambrosino5@gmail.com", Contraseña = "Ambro" });
            clientes.Add(new Cliente { Nombre = "Carlos", Apellido = "López", NombreUsuario = "carloslopez", Mail = "carloslopez@example.com", Contraseña = "password123" });
            clientes.Add(new Cliente { Nombre = "Ana", Apellido = "Díaz", NombreUsuario = "anadiaz", Mail = "anadiaz@example.com", Contraseña = "password123" });
            clientes.Add(new Cliente { Nombre = "Pedro", Apellido = "Martínez", NombreUsuario = "pedromartinez", Mail = "pedromartinez@example.com", Contraseña = "password123" });
            clientes.Add(new Cliente { Nombre = "Lucía", Apellido = "García", NombreUsuario = "luciagarcia", Mail = "luciagarcia@example.com", Contraseña = "password123" });
            clientes.Add(new Cliente { Nombre = "Tomás", Apellido = "Rodríguez", NombreUsuario = "tomasrodriguez", Mail = "tomasrodriguez@example.com", Contraseña = "password123" });
            clientes.Add(new Cliente { Nombre = "Sofía", Apellido = "Hernández", NombreUsuario = "sofiahernandez", Mail = "sofiahernandez@example.com", Contraseña = "password123" });
            clientes.Add(new Cliente { Nombre = "Mateo", Apellido = "Gómez", NombreUsuario = "mateogomez", Mail = "mateogomez@example.com", Contraseña = "password123" });
            clientes.Add(new Cliente { Nombre = "Isabel", Apellido = "Sánchez", NombreUsuario = "isabelsanchez", Mail = "isabelsanchez@example.com", Contraseña = "password123" });
            clientes.Add(new Cliente { Nombre = "Alejandro", Apellido = "Fernández", NombreUsuario = "alejandrofernandez", Mail = "alejandrofernandez@example.com", Contraseña = "password123" });
            clientes.Add(new Cliente { Nombre = "Valeria", Apellido = "Díaz", NombreUsuario = "valeriadiaz", Mail = "valeriadiaz@example.com", Contraseña = "password123" });
            clientes.Add(new Cliente { Nombre = "Gabriel", Apellido = "López", NombreUsuario = "gabriellopez", Mail = "gabriellopez@example.com", Contraseña = "password123" });
            clientes.Add(new Cliente { Nombre = "Eva", Apellido = "García", NombreUsuario = "evagarcia", Mail = "evagarcia@example.com", Contraseña = "password123" });
            clientes.Add(new Cliente { Nombre = "Julio", Apellido = "Martínez", NombreUsuario = "juliomartinez", Mail = "juliomartinez@example.com", Contraseña = "password123" });
            clientes.Add(new Cliente { Nombre = "Cristina", Apellido = "Hernández", NombreUsuario = "cristinahernandez", Mail = "cristinahernandez@example.com", Contraseña = "password123" });
            clientes.Add(new Cliente { Nombre = "Daniel", Apellido = "Gómez", NombreUsuario = "danielgomez", Mail = "danielgomez@example.com", Contraseña = "password123" });
            clientes.Add(new Cliente { Nombre = "Laura", Apellido = "Sánchez", NombreUsuario = "laurasanchez", Mail = "laurasanchez@example.com", Contraseña = "password123" });
        } 
    } 
}

