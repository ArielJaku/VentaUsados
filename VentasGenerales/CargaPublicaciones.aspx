<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CargaPublicaciones.aspx.cs" Inherits="VentasGenerales.CargaPublicaciones" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Titulo de la publicacion"></asp:Label>
    <asp:TextBox ID="txtTit" runat="server"></asp:TextBox><br />
    <asp:Label ID="Label2" runat="server" Text="Seccion"></asp:Label>
    <asp:TextBox ID="txtSec" runat="server"></asp:TextBox><br />
    <asp:Label ID="Label3" runat="server" Text="Describi tu producto"></asp:Label>
    <asp:TextBox ID="txtDes" runat="server"></asp:TextBox><br />
    <asp:Label ID="Label4" runat="server" Text="Precio"></asp:Label>
    <asp:TextBox ID="txtPrecio" runat="server"></asp:TextBox><br />
    <asp:FileUpload ID="fuImagen1" runat="server" />
    <asp:FileUpload ID="fuImagen2" runat="server" />
    <asp:Button ID="btnCarga" runat="server" Text="Carga Publicacion" OnClick="btnCarga_Click" />
</asp:Content>
