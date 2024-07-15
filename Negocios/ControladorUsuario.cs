using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class ControladorUsuario
    {
        DatosUsuario Dusuario = new DatosUsuario();
        public int LoginUsuario(SeguridadUsuario usuario)
        {
            return Dusuario.LoginUsuario(usuario);
        }

        public int RegistroUsuario(SeguridadUsuario seg, Usuario usu)
        {
            return Dusuario.RegistroUsuario(seg, usu);
        }
        public DataTable TraerCiudades()
        {
            return Dusuario.TraerCiudades();
        }

        public DataTable TraerProvincias()
        {
            return Dusuario.TraerProvincias();
        }

    }
}
