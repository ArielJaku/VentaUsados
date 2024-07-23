using Entidades;
using Negocios;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VentasGenerales
{
    public partial class CargaPublicaciones : System.Web.UI.Page
    {
        ControladorProducto managerProducto = new ControladorProducto();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["Id"]==null)
            {
                Response.Redirect("/");
            }
            
        }

        protected void btnCarga_Click(object sender, EventArgs e)
        {
            Producto prodCarga = new Producto();
            prodCarga.nombrëProducto = txtTit.Text;
            prodCarga.seccion = txtSec.Text;
            prodCarga.descripcion = txtDes.Text;
            prodCarga.precio = int.Parse(txtPrecio.Text);
            prodCarga.idUsuario = int.Parse(Session["Id"].ToString());
            #region IMAGEN1
            //obtener datos de la imagen 1

            int tamanio = fuImagen1.PostedFile.ContentLength;

            byte[] imagenOriginal = new byte[tamanio];

            fuImagen1.PostedFile.InputStream.Read(imagenOriginal, 0, tamanio);


            Bitmap ImagenOriginalBinaria = new Bitmap(fuImagen1.PostedFile.InputStream);

            //Crear una Imagen Thumbail
            System.Drawing.Image imtThumbnail;
            int tamanioThumbnail = 200;
            imtThumbnail = RedimencionarImagen(ImagenOriginalBinaria, tamanioThumbnail);
            byte[] bImagenThumbnail1 = new byte[tamanioThumbnail];
            ImageConverter Convertidor = new ImageConverter();

            bImagenThumbnail1 = (byte[])Convertidor.ConvertTo(imtThumbnail, typeof(byte[]));

            #endregion
            #region IMAGEN2
            //obtener datos de la imagen 2
            int tamanio2 = fuImagen2.PostedFile.ContentLength;

            byte[] imagenOriginal2 = new byte[tamanio2];

            fuImagen2.PostedFile.InputStream.Read(imagenOriginal2, 0, tamanio2);

            Bitmap ImagenOriginalBinaria2 = new Bitmap(fuImagen2.PostedFile.InputStream);

            //Crear una Imagen Thumbail
            System.Drawing.Image imtThumbnail2;
            int tamanioThumbnail2 = 200;
            imtThumbnail2 = RedimencionarImagen(ImagenOriginalBinaria2, tamanioThumbnail2);
            byte[] bImagenThumbnail2 = new byte[tamanioThumbnail2];

            bImagenThumbnail2 = (byte[])Convertidor.ConvertTo(imtThumbnail2, typeof(byte[]));

            string ImagenDataURL64 = "data:image/jpeg;base64," + Convert.ToBase64String(bImagenThumbnail1);

            //imgPreview.ImageUrl = "/ok.png";

            string ImagenDataURL642 = "data:image/jpg;base64," + Convert.ToBase64String(bImagenThumbnail2);

            //imgPreview2.ImageUrl = "/ok.png";

            #endregion

            prodCarga.imagen1 = bImagenThumbnail1;
            prodCarga.imagen2 = bImagenThumbnail2;
            managerProducto.altaProductos(prodCarga);

        }

        public string pruebita()
        {
            #region IMAGEN1
            //obtener datos de la imagen 1

            int tamanio = fuImagen1.PostedFile.ContentLength;

            byte[] imagenOriginal = new byte[tamanio];

            fuImagen1.PostedFile.InputStream.Read(imagenOriginal, 0, tamanio);


            Bitmap ImagenOriginalBinaria = new Bitmap(fuImagen1.PostedFile.InputStream);

            //Crear una Imagen Thumbail
            System.Drawing.Image imtThumbnail;
            int tamanioThumbnail = 200;
            imtThumbnail = RedimencionarImagen(ImagenOriginalBinaria, tamanioThumbnail);
            byte[] bImagenThumbnail1 = new byte[tamanioThumbnail];
            ImageConverter Convertidor = new ImageConverter();

            bImagenThumbnail1 = (byte[])Convertidor.ConvertTo(imtThumbnail, typeof(byte[]));

            #endregion
            #region IMAGEN2
            //obtener datos de la imagen 2
            int tamanio2 = fuImagen2.PostedFile.ContentLength;

            byte[] imagenOriginal2 = new byte[tamanio2];

            fuImagen2.PostedFile.InputStream.Read(imagenOriginal2, 0, tamanio2);

            Bitmap ImagenOriginalBinaria2 = new Bitmap(fuImagen2.PostedFile.InputStream);

            //Crear una Imagen Thumbail
            System.Drawing.Image imtThumbnail2;
            int tamanioThumbnail2 = 200;
            imtThumbnail2 = RedimencionarImagen(ImagenOriginalBinaria2, tamanioThumbnail2);
            byte[] bImagenThumbnail2 = new byte[tamanioThumbnail2];

            bImagenThumbnail2 = (byte[])Convertidor.ConvertTo(imtThumbnail2, typeof(byte[]));

            string ImagenDataURL64 = "data:image/jpeg;base64," + Convert.ToBase64String(bImagenThumbnail1);

            //imgPreview.ImageUrl = "/ok.png";

            string ImagenDataURL642 = "data:image/jpg;base64," + Convert.ToBase64String(bImagenThumbnail2);

            //imgPreview2.ImageUrl = "/ok.png";

            #endregion

            return "papanta";
        }

        public System.Drawing.Image RedimencionarImagen(System.Drawing.Image ImagenOrinal, int Alto)
        {
            var Radio = (double)Alto / ImagenOrinal.Height;
            var NuevoAncho = (int)(ImagenOrinal.Width * Radio);
            var NuevoAlto = (int)(ImagenOrinal.Height * Radio);
            var NuevaImagenRedimencionada = new Bitmap(NuevoAncho, NuevoAlto);
            var g = Graphics.FromImage(NuevaImagenRedimencionada);
            g.DrawImage(ImagenOrinal, 0, 0, NuevoAncho, NuevoAlto);
            return NuevaImagenRedimencionada;
        }
    }
}