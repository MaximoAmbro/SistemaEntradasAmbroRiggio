﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public partial class Cliente
    {
        public string Nombre{ get; set; }
        public string Apellido{ get; set; }
        public string Usuario { get; set; } //hola
        public string Mail { get; set; }
        public string Contraseña { get; set; }
        public List<Evento> entradasUsuario = new List<Evento>();

    }
}
