﻿using System;
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
       public static List<Cliente> clientes = new List<Cliente>();
       Cliente cliente = new Cliente();

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
        public void AgregarCliente(string nombre, string usuario, string mail, string contraseña)
        {
            cliente = new Cliente { NombreYApellido = nombre, Usuario = usuario, Mail = mail, Contraseña = contraseña };
            clientes.Add(cliente);
        }
        public bool RevisarUsuarioYContraseña(string usuario, string contraseña)
        {
            Cliente cliente1 = null;
            foreach (var c in clientes)
            {
                if (c.Usuario == usuario && c.Contraseña == contraseña)
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
            else
            {
                return true;
            }
        }
        public bool RevisarMailOUsuario(string usuario, string mail)
        {
            Cliente cliente1 = null;
            foreach (var c in clientes)
            {
                if (c.Usuario == usuario)
                {
                    cliente1 = c;
                    return false;
                    throw new Exception("El usuario ya existe");

                }
                if (c.Mail == mail)
                {
                    return false;
                    throw new Exception("El mail ya existe");

                }
                else
                {
                   return true;
                }
            }
            if (cliente1 == null)
            {
                return true;
                throw new Exception("");
            }
            else
            {
                return false;
            }
        }
        public bool RevisarMailYUsuario(string usuario, string mail)
        {
            Cliente cliente1 = null;
            foreach (var c in clientes)
            {
                if (c.Usuario == usuario && c.Mail == mail)
                {
                    cliente1 = c;
                    return false;

                }
                else
                {
                    return true;
                }
            }
            if (cliente1 == null)
            {
                return true;
                throw new Exception("");
            }
            else
            {
                return false;
            }
        }

    }
    public partial class GestorClientes // Usuarios cargados
    {
        public GestorClientes()
        {
            clientes.Add(new Cliente { NombreYApellido = "z", Usuario = "z", Mail = "z", Contraseña = "z" });
            clientes.Add(new Cliente { NombreYApellido = "Juan Riggio", Usuario = "JuaniLGBT", Mail = "juanriggio@gmail.com", Contraseña = "a" });
            clientes.Add(new Cliente { NombreYApellido = "Maximo Ambrosion", Usuario = "Ambro", Mail = "MaximoAmbrosino@gmail.com", Contraseña = "a" });
            clientes.Add(new Cliente { NombreYApellido = "Carlos López", Usuario = "carloslopez", Mail = "carloslopez@example.com", Contraseña = "password123" });
            clientes.Add(new Cliente { NombreYApellido = "Ana Díaz", Usuario = "anadiaz", Mail = "anadiaz@example.com", Contraseña = "password123" });
            clientes.Add(new Cliente { NombreYApellido = "Pedro Martínez", Usuario = "pedromartinez", Mail = "pedromartinez@example.com", Contraseña = "password123" });
            clientes.Add(new Cliente { NombreYApellido = "Lucía García", Usuario = "luciagarcia", Mail = "luciagarcia@example.com", Contraseña = "password123" });
            clientes.Add(new Cliente { NombreYApellido = "Tomás Rodríguez", Usuario = "tomasrodriguez", Mail = "tomasrodriguez@example.com", Contraseña = "password123" });
            clientes.Add(new Cliente { NombreYApellido = "Sofía Hernández", Usuario = "sofiahernandez", Mail = "sofiahernandez@example.com", Contraseña = "password123" });
            clientes.Add(new Cliente { NombreYApellido = "Mateo Gómez", Usuario = "mateogomez", Mail = "mateogomez@example.com", Contraseña = "password123" });
            clientes.Add(new Cliente { NombreYApellido = "Isabel Sánchez", Usuario = "isabelsanchez", Mail = "isabelsanchez@example.com", Contraseña = "password123" });
            clientes.Add(new Cliente { NombreYApellido = "Alejandro Fernández", Usuario = "alejandrofernandez", Mail = "alejandrofernandez@example.com", Contraseña = "password123" });
            clientes.Add(new Cliente { NombreYApellido = "Valeria Díaz", Usuario = "valeriadiaz", Mail = "valeriadiaz@example.com", Contraseña = "password123" });
            clientes.Add(new Cliente { NombreYApellido = "Gabriel López", Usuario = "gabriellopez", Mail = "gabriellopez@example.com", Contraseña = "password123" });
            clientes.Add(new Cliente { NombreYApellido = "Eva García", Usuario = "evagarcia", Mail = "evagarcia@example.com", Contraseña = "password123" });
            clientes.Add(new Cliente { NombreYApellido = "Julio Martínez", Usuario = "juliomartinez", Mail = "juliomartinez@example.com", Contraseña = "password123" });
            clientes.Add(new Cliente { NombreYApellido = "Cristina Hernández", Usuario = "cristinahernandez", Mail = "cristinahernandez@example.com", Contraseña = "password123" });
            clientes.Add(new Cliente { NombreYApellido = "Daniel Gómez", Usuario = "danielgomez", Mail = "danielgomez@example.com", Contraseña = "password123" });
            clientes.Add(new Cliente { NombreYApellido = "Laura Sánchez", Usuario = "laurasanchez", Mail = "laurasanchez@example.com", Contraseña = "password123" });
        } 
    } 
}

