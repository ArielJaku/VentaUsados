using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace VentasGenerales
{
    public class Utilidad : Page
    {
        public void MsgBox(string mensaje)
        {
            string msj = "<script language='javascript'> alert('" + mensaje + "');</script>";
            Page.ClientScript.RegisterStartupScript(Page.GetType(), "mensaje", msj);
        }
    }
}