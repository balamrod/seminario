<%@ Page Title="SGA - Sistema de Gestión Académica" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Actualizacion.aspx.vb" Inherits="_Default" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1>Actualización.</h1>
            </hgroup>
            <asp:Panel ID="Panel1" runat="server">
            </asp:Panel>
            <div >
                <asp:Label ID="Label1" runat="server" Text="Correo Personal:"></asp:Label>

                <asp:TextBox ID="txtCorreo" runat="server" Width="59%" MaxLength="100" Height="16px"></asp:TextBox>

                &nbsp;<asp:Label ID="Label3" runat="server" Text="Celular:"></asp:Label>

                &nbsp;&nbsp;

                <asp:TextBox ID="txtCelular" runat="server" Width="21%" MaxLength="100" Height="16px"></asp:TextBox>

                <br />
                <asp:Label ID="Label2" runat="server" Text="Domicilio:"></asp:Label>

                <asp:TextBox ID="txtDomicilio" runat="server" Width="50%"></asp:TextBox>            
                &nbsp;
                <asp:Label ID="Label4" runat="server" Text="Teléfono:"></asp:Label>

                &nbsp;&nbsp;

                <asp:TextBox ID="txtTelefono" runat="server" Width="21%" MaxLength="100" Height="16px"></asp:TextBox>

                <br />
                <br />
              <br />
                <br />
                &nbsp;            
                <asp:ImageButton ID="btnGuardar" runat="server" Height="35px" ImageAlign="Right" ImageUrl="~/Images/save.png" Width="40px" ToolTip="Guardar" Visible="False" />
                <asp:ImageButton ID="btnModificar" runat="server" Height="35px" ImageAlign="Right" ImageUrl="~/Images/editar2.png" Width="40px" Visible="False" ToolTip="Modfiicar" />
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
