using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DatosProducto
    {
        static string conexionstring = "server=OmenHP\\SQLEXPRESS; database= VentasVarias; integrated security=true";
        SqlConnection con = new SqlConnection(conexionstring);
        public int altaProductos(Producto producto)
        {
            string temp_inBase64img1 = Convert.ToBase64String(producto.imagen1);
            string temp_inBase64img2 = Convert.ToBase64String(producto.imagen2);
            int flag = 0;
            con.Open();
            string query = "insert into Producto values ('"+ producto.nombrëProducto + "','"+ producto.seccion + "','"+ producto.descripcion + "','"+ temp_inBase64img1 + "','"+ temp_inBase64img2 + "',"+ producto.precio + ","+ producto.idUsuario + ")";
            SqlCommand cmd = new SqlCommand(query, con);
            flag = cmd.ExecuteNonQuery();
            con.Close();
            return flag;
        }
    }
}
