using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Negocio
{
    public partial class GestorClientes // Lista
    {
        List<Cliente> clientes = new List<Cliente>();
        Cliente cliente = new Cliente();

    }
    public partial class GestorClientes // Metodos
    {
        public void CambiarContraseña()
        {
            foreach (var c in clientes)
            {
                if (c.Mail == cliente.Mail)
                {
                    string contracambiar = c.Contraseña;
                    cliente.Contraseña = contracambiar;
                    break;
                }
            }
        }
        public void AgregarCliente()
        {
            RevisarClientes();
            if (RevisarClientes() == false)
            {
                clientes.Add(cliente);
            }
            else { throw new Exception("El cliente ya existe"); }
        }
        public bool RevisarClientes()
        {

            Cliente cliente1 = null;

            foreach (var c in clientes)
            {
                if (c.Mail == cliente.Mail)
                {
                    cliente1 = c;
                    break;
                }
            }
            if (cliente1 == null)
            {
                return false;
                throw new Exception("Correo no encontrado");
            }
            if (cliente1 != null && cliente1.Contraseña == cliente.Contraseña)
            {
                return true;
            }
            else
            {
                return false;
                throw new Exception("Contraseña incorrecta");
            }
        }
    }
    public partial class GestorClientes // Usuarios cargados
    {
        public GestorClientes()
        {
            clientes.Add(new Cliente { Nombre = "Juan", Apellido = "Pérez", DNI = 123456, Usuario = "juanperez", Mail = "juanperez@example.com", Contraseña = "password123" });
            clientes.Add(new Cliente { Nombre = "María", Apellido = "González", DNI = 234567, Usuario = "mariagonzalez", Mail = "mariagonzalez@example.com", Contraseña = "password123" });
            clientes.Add(new Cliente { Nombre = "Carlos", Apellido = "López", DNI = 345678, Usuario = "carloslopez", Mail = "carloslopez@example.com", Contraseña = "password123" });
            clientes.Add(new Cliente { Nombre = "Ana", Apellido = "Díaz", DNI = 456789, Usuario = "anadiaz", Mail = "anadiaz@example.com", Contraseña = "password123" });
            clientes.Add(new Cliente { Nombre = "Pedro", Apellido = "Martínez", DNI = 567890, Usuario = "pedromartinez", Mail = "pedromartinez@example.com", Contraseña = "password123" });
            clientes.Add(new Cliente { Nombre = "Lucía", Apellido = "García", DNI = 678901, Usuario = "luciagarcia", Mail = "luciagarcia@example.com", Contraseña = "password123" });
            clientes.Add(new Cliente { Nombre = "Tomás", Apellido = "Rodríguez", DNI = 789012, Usuario = "tomasrodriguez", Mail = "tomasrodriguez@example.com", Contraseña = "password123" });
            clientes.Add(new Cliente { Nombre = "Sofía", Apellido = "Hernández", DNI = 890123, Usuario = "sofiahernandez", Mail = "sofiahernandez@example.com", Contraseña = "password123" });
            clientes.Add(new Cliente { Nombre = "Mateo", Apellido = "Gómez", DNI = 901234, Usuario = "mateogomez", Mail = "mateogomez@example.com", Contraseña = "password123" });
            clientes.Add(new Cliente { Nombre = "Isabel", Apellido = "Sánchez", DNI = 123456, Usuario = "isabelsanchez", Mail = "isabelsanchez@example.com", Contraseña = "password123" });
            clientes.Add(new Cliente { Nombre = "Alejandro", Apellido = "Fernández", DNI = 234567, Usuario = "alejandrofernandez", Mail = "alejandrofernandez@example.com", Contraseña = "password123" });
            clientes.Add(new Cliente { Nombre = "Valeria", Apellido = "Díaz", DNI = 345678, Usuario = "valeriadiaz", Mail = "valeriadiaz@example.com", Contraseña = "password123" });
            clientes.Add(new Cliente { Nombre = "Gabriel", Apellido = "López", DNI = 456789, Usuario = "gabriellopez", Mail = "gabriellopez@example.com", Contraseña = "password123" });
            clientes.Add(new Cliente { Nombre = "Eva", Apellido = "García", DNI = 567890, Usuario = "evagarcia", Mail = "evagarcia@example.com", Contraseña = "password123" });
            clientes.Add(new Cliente { Nombre = "Julio", Apellido = "Martínez", DNI = 678901, Usuario = "juliomartinez", Mail = "juliomartinez@example.com", Contraseña = "password123" });
            clientes.Add(new Cliente { Nombre = "Cristina", Apellido = "Hernández", DNI = 789012, Usuario = "cristinahernandez", Mail = "cristinahernandez@example.com", Contraseña = "password123" });
            clientes.Add(new Cliente { Nombre = "Daniel", Apellido = "Gómez", DNI = 890123, Usuario = "danielgomez", Mail = "danielgomez@example.com", Contraseña = "password123" });
            clientes.Add(new Cliente { Nombre = "Laura", Apellido = "Sánchez", DNI = 901234, Usuario = "laurasanchez", Mail = "laurasanchez@example.com", Contraseña = "password123" });
        } 
    } 
}

