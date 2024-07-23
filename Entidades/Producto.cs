using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;
using static System.Net.Mime.MediaTypeNames;

namespace Entidades
{
    public class Producto
    {
        public int id { get; set; }

        public string nombrëProducto { get; set; }

        public string seccion { get; set; }

        public string descripcion { get; set; }

        public decimal precio { get; set; }

        public byte[] imagen1 { get; set; }

        public byte[] imagen2 { get; set; }

        public int idUsuario { get; set; }

         
    }
}
