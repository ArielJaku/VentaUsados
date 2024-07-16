using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class ControladorProducto
    {
        DatosProducto accessoDatos = new DatosProducto();
        public int altaProductos(Producto producto)
        {
            
            if(producto != null)
            {
                return accessoDatos.altaProductos(producto);
            }
            else
            {
                return 0;
            }
            
        }
    }
}
