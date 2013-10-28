<%@ Page Title="" Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="mstConsultaNotas.aspx.vb" Inherits="mstIngresoNotas" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
    <link href="Content/bootstrap.css" rel="stylesheet" />
     <style type="text/css">
        .modalBack
        {
            background-color:black;
                opacity: 0.8;
                filter:alpha(opacity=90);
                z-index:1000;
        }
        .auto-style1
        {
            width: 124px;
            color: white
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" Runat="Server">

     <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                 <section class="featured" >
        
        <div class="content-wrapper" style="height:auto">
             <hgroup class="title">
                <h1>Seleccionar catedra:</h1>
            </hgroup>
             <div style="border:double;border-color:white;height:auto">
                 <table style="width:100%">
	                <tr>
		                <td style="width:100px">&nbsp;</td>
		                <td style="width:30%">
                            &nbsp;</td>
		                <td style="width:100px">Cátedra:</td>
		                <td style="width:30%">
                            <asp:DropDownList ID="ddlAnio" runat="server" Width="100%">
                            </asp:DropDownList>
                        </td>
		                <td style="width:100px">&nbsp;</td>
		                <td style="width:30%">
                            <div style="float:left;width:70%;padding-top:25px">
                            </div>                           
                            <div style ="padding: 10px 10px 10px 10px;float:right">
                            </div>
                        </td>
	                </tr>
                </table>
                <center>
                <asp:GridView ID="gvSecciones" runat="server" CellPadding="4" EmptyDataText="Por favor seleccione la catedra y seccion que desa visualizar" ForeColor="#333333" GridLines="Horizontal" Width="80%">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
                        <asp:CommandField ShowSelectButton="True"/>
                    </Columns>
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
                 <center/>
             </div>
            

            <hgroup class="title">
                <h1>Notas:</h1>
            </hgroup>
            <center>
            <div style="border:double;border-color:white;min-height:500px"  >
                <asp:GridView ID="gvNotas" runat="server" CellPadding="4" EmptyDataText="Por favor seleccione la catedra y seccion que desa visualizar" ForeColor="#333333" GridLines="Horizontal" Width="95%" AllowPaging="True">
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
            </div>
           </center>
        </div>
         

    </section>
                    
                <div id="divOpenner" runat="server" />
                <div id="divEditDetail" style="background-color:#7AC0DA;  width:390px;height:auto">
                     <div class="modal-header">
                            
                            <h4 class="modal-title" style="color:white;font-size:x-large">Actualizar Notas</h4>
                          </div>
                          <div class="modal-body">
                            <div style="width:300px;color:white;height:280px">
                                    <table width="100%"  >
	                                <tr>
		                                <td class="auto-style1" >
                                            <hgroup class="title" >  
                                                <h1 style="color:white;font-size:large">Actividad</h1>
                                            </hgroup>
                                            </td>
		                                <td>
                                            <hgroup class="title">  
                                                <h1 style="color:white;font-size:large">Nota</h1>
                                            </hgroup>
		                                </td>
	                                </tr>
	                                <tr>
		                                <td class="auto-style1">1er. Parcial:</td>
		                                <td>
                                            <asp:TextBox ID="txt1" runat="server">0</asp:TextBox>
                                        </td>
	                                </tr>
	                                <tr>
		                                <td class="auto-style1">2do. Parcial:</td>
		                                <td>
                                            <asp:TextBox ID="txt2" runat="server">0</asp:TextBox>
                                        </td>
	                                </tr>
	                                <tr>
		                                <td class="auto-style1">Zona:</td>
		                                <td>
                                            <asp:TextBox ID="txt3" runat="server">0</asp:TextBox>
                                        </td>
	                                </tr>
	                                <tr>
		                                <td class="auto-style1">Final:</td>
		                                <td>
                                            <asp:TextBox ID="txt4" runat="server">0</asp:TextBox>
                                        </td>
	                                </tr>
                                </table>
                        

              

                                    </div>
                          </div>
                          <div class="modal-footer">
                              <asp:Button ID="btnsalir" runat="server" Text="Salir" class="btn btn-default" />
                              <asp:Button ID="btnGuardar" runat="server" Text="Guardar" class="btn btn-primary"/>
                            
                          </div>
                </div>
                <cc1:ModalPopupExtender ID="mpeUserDetail" runat="server" 
                    TargetControlID="divOpenner"
                    PopupControlID="divEditDetail"                    
                    BackgroundCssClass="modalBack"                    
                    enabled="true"
                    DropShadow="false" />
                            </ContentTemplate>
                     </asp:UpdatePanel>

    
    

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" Runat="Server">
</asp:Content>

