<%@ Page Title="SGA - Sistema de Gestión Académica" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1>Prueba BD</h1>
            </hgroup>
            <div >
                <asp:Label ID="Label1" runat="server" Text="Carnet"></asp:Label>
&nbsp;
                <asp:TextBox ID="TextBox1" runat="server" Width="20%"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label2" runat="server" Text="Nombre"></asp:Label>
&nbsp;
                <asp:TextBox ID="TextBox2" runat="server" Width="50%"></asp:TextBox>            
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;            
                <asp:ImageButton ID="ImageButton1" runat="server" Height="35px" ImageAlign="Top" ImageUrl="~/Images/save.png" Width="40px" />
                <asp:ImageButton ID="ImageButton2" runat="server" Height="35px" ImageAlign="Top" ImageUrl="~/Images/cancel_48.png" Width="40px" Visible="False" />
                <asp:ImageButton ID="ImageButton3" runat="server" Height="35px" ImageAlign="Top" ImageUrl="~/Images/editar2.png" Width="40px" Visible="False" />
                <br />
                <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" Width="100%">
                    <FooterStyle BackColor="White" ForeColor="#000066" />
                    <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                    <RowStyle ForeColor="#000066" />
                    <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="#007DBB" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#00547E" />
                </asp:GridView>
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
