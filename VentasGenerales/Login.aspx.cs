using Entidades;
using Negocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VentasGenerales
{
    public partial class Login : Utilidad
    {
        ControladorUsuario usuarioManager = new ControladorUsuario();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnSesion_Click(object sender, EventArgs e)
        {
            var dni = txtDNI.Text;
            var clave = txtCLAVE.Text;
            SeguridadUsuario usuario = new SeguridadUsuario();
            usuario.DNI = int.Parse(dni);
            usuario.Clave = clave;
            var res = usuarioManager.LoginUsuario(usuario);
            if (res != 0)
            {
                MsgBox("El usuario existe");
            }
            else
            {
                MsgBox("no existe registrese");
            }
        }
    }
}