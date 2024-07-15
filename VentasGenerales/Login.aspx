<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="VentasGenerales.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="Label1" runat="server" Text="DNI : "></asp:Label>
    <asp:TextBox ID="txtDNI" runat="server"></asp:TextBox><br />
    <asp:Label ID="Label2" runat="server" Text="CLAVE : "></asp:Label>
    <asp:TextBox ID="txtCLAVE" runat="server" TextMode="Password"></asp:TextBox><br />
    <asp:Button ID="btnSesion" runat="server" Text="Iniciar" class="btn btn-success" OnClick="btnSesion_Click"/>
</asp:Content>
