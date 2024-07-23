using Entidades;
using Negocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VentasGenerales
{
    public partial class Registrador : Utilidad
    {
        ControladorUsuario usuarioManager = new ControladorUsuario();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                ddlCiudad.DataSource = usuarioManager.TraerCiudades();
                ddlCiudad.DataTextField = "ciudad";
                ddlCiudad.DataValueField = "id";
                ddlCiudad.DataBind();
                ddlProvincia.DataSource = usuarioManager.TraerProvincias();
                ddlProvincia.DataTextField = "provincia";
                ddlProvincia.DataValueField = "id";
                ddlProvincia.DataBind();
            }

        }

        protected void btnRegistro_Click(object sender, EventArgs e)
        {
            int flag = 0;
            Usuario usuario = new Usuario();
            SeguridadUsuario seg = new SeguridadUsuario();
            usuario.DNI = int.Parse(txtDni.Text);
            usuario.nombre = txtNombre.Text;
            usuario.apellido = txtApellido.Text;
            usuario.dirección = txtDireccion.Text;
            usuario.email = txtEmail.Text;
            usuario.ciudad = int.Parse(ddlCiudad.SelectedValue);
            usuario.provincia = int.Parse(ddlProvincia.SelectedValue);
            string claveHash = HashContraseña(txtClave.Text);
            seg.Clave = claveHash;
            try
            {
                flag = usuarioManager.RegistroUsuario(seg, usuario);
                int pepito;
            }
            catch (Exception ex)
            {
                MsgBox(ex.Message);
            }
            

        }
    }
}