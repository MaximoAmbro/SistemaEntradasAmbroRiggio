﻿using System;
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
        public void DevolverUsuario(string mail, out string usuario)
        {
            usuario = null;
            foreach (var c in vendedores)
            {
                if (c.Mail == mail)
                {
                    usuario = c.Nombre;
                    break;
                }
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
        public void AgregarLocal(Local local, string usuario)
        {
            Vendedor vendedor1 = null;
            foreach (var c in vendedores)
            {
                if (c.Nombre == usuario)
                {
                    vendedor1 = c;
                    vendedor1.Locales.Add(local);
                    break;
                }
            }
        }
        public void AgregarEventoLocal (Local local, Evento evento, string usuario)
        {
            foreach (var c in vendedores)
            {
                if (c.Nombre == usuario)
                {
                    if (c.Locales.Contains(local))
                    {
                        local.Eventos.Add(evento);
                    }
                    break;
                }
            }
        }
    } // Metodos
    public partial class GestorVendedores
    {
        public void CargarLista()
        {
            vendedores.Add(new Vendedor { Nombre = "Juan", Apellido = "Garcia", NombreUsuario = "Juan_Garcia23", Mail = "Vendedor", Contraseña = "a" });
            vendedores.Add(new Vendedor { Nombre = "Maria", Apellido = "Rodriguez", NombreUsuario = "Maria_Rodriguez12", Mail = "MariaRodriguez@yahoo.com", Contraseña = "Cc1234" });
            vendedores.Add(new Vendedor { Nombre = "Carlos", Apellido = "Perez", NombreUsuario = "Carlos_Perez34", Mail = "CarlosPerez@gmail.com", Contraseña = "Dd1234" });
            vendedores.Add(new Vendedor { Nombre = "Ana", Apellido = "Gomez", NombreUsuario = "Ana_Gomez56", Mail = "AnaGomez@hotmail.com", Contraseña = "Ee1234" });
            vendedores.Add(new Vendedor { Nombre = "Luis", Apellido = "Martinez", NombreUsuario = "Luis_Martinez78", Mail = "LuisMartinez@yahoo.com", Contraseña = "Ff1234" });
            vendedores.Add(new Vendedor { Nombre = "Sofia", Apellido = "Gonzalez", NombreUsuario = "Sofia_Gonzalez90", Mail = "SofiaGonzalez@gmail.com", Contraseña = "Gg1234" });
            vendedores.Add(new Vendedor { Nombre = "Miguel", Apellido = "Hernandez", NombreUsuario = "Miguel_Hernandez12", Mail = "MiguelHernandez@hotmail.com", Contraseña = "Hh1234" });
            vendedores.Add(new Vendedor { Nombre = "Elena", Apellido = "Garcia", NombreUsuario = "Elena_Garcia34", Mail = "ElenaGarcia@yahoo.com", Contraseña = "Jj1234" });
            vendedores.Add(new Vendedor { Nombre = "Rafael", Apellido = "Perez", NombreUsuario = "Rafael_Perez56", Mail = "RafaelPerez@gmail.com", Contraseña = "Kk1234" });
            vendedores.Add(new Vendedor { Nombre = "Isabel", Apellido = "Gomez", NombreUsuario = "Isabel_Gomez78", Mail = "IsabelGomez@hotmail.com", Contraseña = "Ll1234" });
        }
    }// Creacion de Elementos
}
