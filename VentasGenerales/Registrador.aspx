<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registrador.aspx.cs" Inherits="VentasGenerales.Registrador" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Dni"></asp:Label>
    <asp:TextBox ID="txtDni" runat="server"></asp:TextBox><br />
    <asp:Label ID="Label2" runat="server" Text="Nombre"></asp:Label>
    <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox><br />
    <asp:Label ID="Label3" runat="server" Text="Apellido"></asp:Label>
    <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox><br />
    <asp:Label ID="Label4" runat="server" Text="Direccion"></asp:Label>
    <asp:TextBox ID="txtDireccion" runat="server"></asp:TextBox><br />
    <asp:Label ID="Label5" runat="server" Text="Email"></asp:Label>
    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox><br />
    <asp:Label ID="Label6" runat="server" Text="Clave"></asp:Label>
    <asp:TextBox ID="txtClave" runat="server"></asp:TextBox><br />
    <asp:DropDownList ID="ddlCiudad" runat="server"></asp:DropDownList><br />
    <asp:DropDownList ID="ddlProvincia" runat="server"></asp:DropDownList><br />
    <asp:Button ID="btnRegistro" runat="server" Text="Registrarse" OnClick="btnRegistro_Click" />
</asp:Content>
