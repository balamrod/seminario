<%@ Page Title="" Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="trsConsultaNotasAlumno.aspx.vb" Inherits="trsConsultaNotasAlumno" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" Runat="Server">
     
                 <section class="featured" >
        
        <div class="content-wrapper" style="min-height:600px">
             <hgroup class="title">
                <h1>Selección:</h1>
            </hgroup>
             <div style="border:double;border-color:white;min-height:580px">
                 <table style="width:100%">
	                <tr>
		                <td style="width:100px">Año:</td>
		                <td style="width:30%">
                            <asp:DropDownList ID="ddlAnio" runat="server">
                            </asp:DropDownList>
                        </td>
		                <td style="width:100px">Ciclo:</td>
		                <td style="width:30%">
                            <asp:DropDownList ID="ddlCiclo" runat="server" Width="100%">
                                <asp:ListItem>1</asp:ListItem>
                                <asp:ListItem>2</asp:ListItem>
                            </asp:DropDownList>
                        </td>
		                <td style="width:100px">&nbsp;</td>
		                <td style="width:30%">
                            <div style ="padding: 10px 10px 10px 10px;float:right">
                                <asp:ImageButton ID="btnBuscar" runat="server" Height="29px" ImageUrl="~/Images/search-50.png" ToolTip="Buscar " Width="34px" />
                            </div>
                        </td>
	                </tr>
                </table>
                <center>
                <asp:GridView ID="gvCatedras" runat="server" CellPadding="4" EmptyDataText="Por favor seleccione la catedra y seccion que desa visualizar" ForeColor="#333333" GridLines="Horizontal" Width="80%">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <EditRowStyle BackColor="#999999" />
                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#E9E7E2" />
                    <SortedAscendingHeaderStyle BackColor="#506C8C" />
                    <SortedDescendingCellStyle BackColor="#FFFDF8" />
                    <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                </asp:GridView>
             </center>
             </div>
            

           </center>
        </div>
         

    </section>
                    
              

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" Runat="Server">
</asp:Content>

