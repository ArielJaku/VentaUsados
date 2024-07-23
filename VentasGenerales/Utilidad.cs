using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
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

        public string HashContraseña(string con)
        {
            using (var sha256 = SHA256.Create())
            {
                // Send a sample text to hash.  
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(con));
                // Get the hashed string.  
                var co = BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
                // Print the string.   
                //Console.WriteLine(co);

                return co;
            }
        }
    }
}