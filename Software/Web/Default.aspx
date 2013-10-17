<%@ Page Title="SGA - Sistema de Gestión Académica" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1>Prueba BD</h1>
            </hgroup>
            <asp:Panel ID="Panel1" runat="server">
            </asp:Panel>
            <div >
                <asp:Label ID="Label1" runat="server" Text="Carnet"></asp:Label>
&nbsp;
                <asp:TextBox ID="TextBox1" runat="server" Width="4%" MaxLength="100" Height="16px"></asp:TextBox>
&nbsp;-
&nbsp;&nbsp;<asp:TextBox ID="TextBox3" runat="server" Width="4%" MaxLength="100" Height="16px"></asp:TextBox>
&nbsp;-
                <asp:TextBox ID="TextBox4" runat="server" Width="4%" MaxLength="100" Height="16px"></asp:TextBox>
                &nbsp;&nbsp;
                <asp:Label ID="Label2" runat="server" Text="Nombre Completo:"></asp:Label>
&nbsp;
                <asp:TextBox ID="TextBox2" runat="server" Width="50%"></asp:TextBox>            
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
                <br />
                &nbsp;            
                <asp:ImageButton ID="ImageButton1" runat="server" Height="35px" ImageAlign="Top" ImageUrl="~/Images/save.png" Width="40px" />
                <asp:ImageButton ID="ImageButton3" runat="server" Height="35px" ImageAlign="Top" ImageUrl="~/Images/editar2.png" Width="40px" Visible="False" />
                <br />
                <br />
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
    </ol>
</asp:Content>
