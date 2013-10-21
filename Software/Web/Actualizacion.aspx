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
                <table border="" bordercolor="1" width="100%" cellpadding="" cellspacing="">
	<tr>
		<td class="auto-style1">



                <asp:Label ID="Label1" runat="server" Text="Correo Personal:"></asp:Label>

                </td>
		<td class="auto-style2">

                <asp:TextBox ID="txtCorreo" runat="server" Width="95%" MaxLength="100" Height="16px"></asp:TextBox>

                </td>
		<td class="auto-style3"><asp:Label ID="Label3" runat="server" Text="Celular:"></asp:Label>

                </td>
		<td class="auto-style4">

                <asp:TextBox ID="txtCelular" runat="server" Width="95%" MaxLength="100" Height="16px"></asp:TextBox>

                </td>
	</tr>
	<tr>
		<td class="auto-style1">
                <asp:Label ID="Label2" runat="server" Text="Domicilio:"></asp:Label>

                </td>
		<td class="auto-style2">

                <asp:TextBox ID="txtDomicilio" runat="server" Width="95%"></asp:TextBox>            
                </td>
		<td class="auto-style3">
                <asp:Label ID="Label4" runat="server" Text="Teléfono:"></asp:Label>

                </td>
		<td class="auto-style4">

                <asp:TextBox ID="txtTelefono" runat="server" Width="95%" MaxLength="100" Height="16px"></asp:TextBox>

                </td>
	</tr>
</table>
                <asp:ImageButton ID="btnGuardar" runat="server" Height="35px" ImageAlign="Right" ImageUrl="~/Images/save.png" Width="40px" ToolTip="Guardar" Visible="False" />
                <asp:ImageButton ID="btnModificar" runat="server" Height="35px" ImageAlign="Right" ImageUrl="~/Images/editar2.png" Width="40px" Visible="False" ToolTip="Modfiicar" />
                <br />
                <br />
            </div>
           
        </div>
    </section>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    
</asp:Content>
<asp:Content ID="Content1" runat="server" contentplaceholderid="HeadContent">
    <style type="text/css">
        .auto-style1
        {
            width: 104px;
        }
        .auto-style2
        {
            width: 780px;
        }
        .auto-style3
        {
            width: 69px;
        }
        .auto-style4
        {
            width: 422px;
        }
    </style>
</asp:Content>

