using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class Vendedor : Cliente
    {
        public List <Local> Locales { get; set; }
    }
}
