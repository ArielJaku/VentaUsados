using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DatosUsuario
    {
        static string conexionstring = "server=OmenHP\\SQLEXPRESS; database= VentasVarias; integrated security=true";
        SqlConnection con = new SqlConnection(conexionstring);
        public int LoginUsuario(SeguridadUsuario usuario)
        {
            int flag = 0;
            con.Open();
            string query = "select count(*) from Seguridad where dniUsuario = " + usuario.DNI + " AND clave = '" + usuario.Clave +"'";
            SqlCommand cmd = new SqlCommand(query, con);
            flag = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            return flag;
        }

        public int RegistroUsuario(SeguridadUsuario seg , Usuario usu)
        {
            int flag = 0;
            con.Open();
            string query = "insert into Usuario values ("+usu.DNI+",'"+usu.nombre+"','"+usu.apellido+"','"+usu.dirección+"',"+usu.ciudad+","+usu.provincia+",'"+usu.email+"');insert into Seguridad values ("+usu.DNI+",'"+seg.Clave+"',2)";
            SqlCommand cmd = new SqlCommand(query, con);
            flag = cmd.ExecuteNonQuery();
            con.Close();
            return flag;
        }

        public DataTable TraerCiudades()
        {
            string query = "select * from Ciudades";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            return tabla;
        }

        public DataTable TraerProvincias()
        {
            string query = "select * from Provincias";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            return tabla;
        }


    }
}
