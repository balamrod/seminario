<%@ Page Title="SGA - Sistema de Gestión Académica" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Inicio.aspx.vb" Inherits="inicio" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <center>
        <div class="content-wrapper">
            
            <hgroup class="title">
                <h1>Utilice una cuenta local para iniciar sesión</h1>
            </hgroup>
            <div >
                <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/LoginIcon.png" ImageAlign="Middle"/>
        <asp:Login ID="Login1" runat="server" ViewStateMode="Disabled" RenderOuterTable="false" Font-Bold="True" Font-Size="Medium">
        </asp:Login>
        <p>
            &nbsp;</p>
            </div>
           
        </div>
    </section>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <h3>Acerca del proyecto</h3>
    <ol class="round">
        <li class="one">
            <h5>Introducción</h5>
            Esta es una prueba preliminar para hosting y conexion con la Base de datos, se estará actualizando de forma periodica el sistema con fines académicos</li>
        <li class="two">
            <h5>B&#39;alam Luis Felipe Rodríguez García</h5>
            .
        </li>
        <li class="three">
            <h5>Estuardo Martínez</h5>
            .
        </li>
        <li class="four"><div id="popup">Cronograma de actividades</div>
            .
        </li>
    </ol>
    <div id="mydiv" title="Basic dialog"> 

            asgdfasdfasdfdsa
        </div>
</asp:Content>
