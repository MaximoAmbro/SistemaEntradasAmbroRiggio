using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Negocio
{
    public partial class GestorClientes
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
}
