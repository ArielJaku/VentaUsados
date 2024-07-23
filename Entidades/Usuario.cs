using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        public int DNI { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string dirección { get; set; }
        public int ciudad { get; set; }
        public int provincia { get; set; }
        public string email { get; set; }


    }
}
