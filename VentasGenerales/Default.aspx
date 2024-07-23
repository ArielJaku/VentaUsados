<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="VentasGenerales._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <section class="row" aria-labelledby="aspnetTitle">
            <h1 id="aspnetTitle">VENTAS GENERALES</h1>
            <p class="lead">&nbsp;</p>
            
        </section>

        <div class="row">
            <section class="col-md-4" aria-labelledby="gettingStartedTitle">
                <h2 id="gettingStartedTitle">PUBLICAR</h2>
                
            </section>
            <section class="col-md-4" aria-labelledby="librariesTitle">
                <h2 id="librariesTitle">REGISTRAR</h2>
                
            </section>
            <section class="col-md-4" aria-labelledby="hostingTitle">
                <h2 id="hostingTitle">NOSOTROS</h2>
                <a href="#"></a>
            </section>
        </div>
    </main>
    <asp:Button ID="btnSesion" runat="server" Text="Cerrar Sesion" OnClick="btnSesion_Click" />
</asp:Content>
