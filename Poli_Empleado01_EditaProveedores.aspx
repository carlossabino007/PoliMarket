<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Poli_Empleado01_EditaProveedores.aspx.cs" Inherits="Poli_Empleado01_EditaProveedores" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            <asp:Label ID="Label12" runat="server" 
                            Font-Bold="True" Font-Italic="False" 
                Font-Size="16pt" Font-Underline="True" ForeColor="#00CC66" 
                Text="Editar/Actualizar Proveedores" 
                Font-Overline="False"></asp:Label>
            </p>
<table style="width: 100%">
    <tr>
        <td style="width: 47px">
            &nbsp;</td>
        <td style="width: 148px">
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td style="width: 47px">
            &nbsp;</td>
        <td colspan="3">
            <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/LineaHorizontal.jpg" 
                Width="700px" />
        </td>
    </tr>
    <tr>
        <td style="width: 47px; height: 12px;">
            </td>
        <td style="width: 148px; height: 12px;">
            </td>
        <td style="height: 12px">
            </td>
        <td style="height: 12px">
            </td>
    </tr>
    <tr>
        <td style="width: 47px; height: 12px;">
            </td>
        <td colspan="2" style="height: 12px">
            </td>
        <td style="height: 12px">
            </td>
    </tr>
    <tr>
        <td style="width: 47px">
            &nbsp;</td>
        <td colspan="2">
            <asp:MultiView ID="MultiView1" runat="server">
                <asp:View ID="View1" runat="server">
                    <asp:Label ID="Label1" runat="server" Text="V01" Visible="False"></asp:Label>
                    <asp:Label ID="Label13" runat="server" ForeColor="#0033CC" 
                        Text="Proveedores registrados en el sistema:"></asp:Label>
                    &nbsp;&nbsp; 
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:ImageButton ID="ImageButton1" runat="server" Height="19px" 
                        ImageUrl="~/Images/Volver.png" Width="19px" />
                    <asp:LinkButton ID="LinkButton1" runat="server" ForeColor="#0099FF" 
                        PostBackUrl="~/pagePrincipal.aspx">Formulario anterior</asp:LinkButton>
                    <br />
                    &nbsp;
                    <br />
                    <br />
                    <table style="width: 100%">
                        <tr>
                            <td style="width: 12px">
                                &nbsp;</td>
                            <td style="width: 647px">
                            <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="Black" 
                GridLines="Horizontal" PageSize="30" Width="700px" AllowPaging="True" 
                AllowSorting="True" AutoGenerateColumns="False" CaptionAlign="Bottom" 
                DataKeyNames="id_proveedor" DataSourceID="SqlDataSource1" 
                                    onselectedindexchanged="GridView1_SelectedIndexChanged" BackColor="White" 
                                    BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px">
                <Columns>
                    <asp:CommandField SelectText="Editar" ShowSelectButton="True">
                    <ItemStyle Width="100px" />
                    </asp:CommandField>
                    <asp:BoundField DataField="id_proveedor" HeaderText="id" InsertVisible="False" 
                        ReadOnly="True" SortExpression="id_proveedor">
                    <ItemStyle Font-Size="8pt" Width="80px" />
                    </asp:BoundField>

                    <asp:BoundField DataField="nit" HeaderText="nit" SortExpression="nit">
                    <ItemStyle Font-Size="7pt" Width="300px" />
                    </asp:BoundField>


                    <asp:BoundField DataField="nombre" HeaderText="nombre" SortExpression="nombre">
                    <ItemStyle Font-Size="7pt" Width="600px" />
                    </asp:BoundField>
                    <asp:BoundField DataField="contacto" HeaderText="contacto" 
                        SortExpression="contacto">
                    <ItemStyle Font-Size="7pt" Width="500px" />
                    </asp:BoundField>
                    <asp:BoundField DataField="telefono" HeaderText="telefono" 
                        SortExpression="telefono">
                    <ItemStyle Font-Size="7pt" Width="200px" />
                    </asp:BoundField>
                    <asp:BoundField DataField="email" HeaderText="email" 
                        SortExpression="email">
                    <ItemStyle Font-Size="7pt" Width="300px" />
                    </asp:BoundField>
                    <asp:BoundField DataField="direccion" HeaderText="direccion" 
                        SortExpression="direccion">
                    <ItemStyle Font-Size="7pt" Width="600px" />
                    </asp:BoundField>
                    <asp:CheckBoxField DataField="activo" HeaderText="activo" 
                        SortExpression="activo">
                    <ItemStyle Font-Size="8pt" Width="50px" />
                    </asp:CheckBoxField>
                </Columns>
                <EditRowStyle Font-Size="11pt" />
                <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                <RowStyle Font-Size="8pt" />
                <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F7F7F7" />
                <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                <SortedDescendingCellStyle BackColor="#E5E5E5" />
                <SortedDescendingHeaderStyle BackColor="#242121" />
            </asp:GridView>
                                </td>
                            <td>
                                &nbsp;</td>
                        </tr>
                    </table>


                    <td style="width: 148px">
            &nbsp;</td>
        <td>
            <table style="width: 100%">
                <tr>
                    <td style="width: 191px">
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                            ConnectionString="<%$ ConnectionStrings:BaseWebKardexConnectionString2 %>" 
                            
                            
                            SelectCommand="SELECT [id_proveedor], [nombre], [contacto], [telefono], [email], [direccion], [activo], [nit] FROM [PROVEEDOR]">
                        </asp:SqlDataSource>
                    </td>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
            </table>
        </td>

                    <asp:Label ID="lblmensaje" runat="server"></asp:Label>

                    <br />
                    <br />
                </asp:View>
                <asp:View ID="View2" runat="server">
                    &nbsp;<asp:Label ID="Label2" runat="server" Text="V02" Visible="False"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label21" runat="server" ForeColor="#0033CC" 
                        Text="Editando datos Empleado seleccionado"></asp:Label>
                    <br />

<table style="width: 100%">
    <tr>
        <td style="width: 47px">
            &nbsp;</td>
        <td style="width: 148px">
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td style="width: 47px; height: 11px;">
            </td>
        <td style="height: 11px;" colspan="2">
            &nbsp; </td>
        <td style="height: 11px">
            </td>
    </tr>
    <tr>
        <td style="width: 47px">
            &nbsp;</td>
        <td style="width: 148px">
            <asp:Label ID="Label22" runat="server" Text="Id:"></asp:Label>
        </td>
        <td>
            <asp:Label ID="lblId" runat="server">...</asp:Label>
            &nbsp;&nbsp;
            <asp:Label ID="Label24" runat="server" ForeColor="#0033CC" 
                Text="Nit/Documento del Proveedor:"></asp:Label>
            &nbsp;
            <asp:Label ID="lblmiNit" runat="server" Font-Bold="True" ForeColor="#0033CC"></asp:Label>
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td style="width: 47px">
            &nbsp;</td>
        <td style="width: 148px">
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td style="width: 47px; height: 12px;">
            </td>
        <td style="height: 12px; width: 148px">
            <asp:Label ID="Label4" runat="server" Text="Nombre:"></asp:Label>
        </td>
        <td style="height: 12px">
            <asp:TextBox ID="txtNombre0" runat="server" Height="20px" Width="350px"></asp:TextBox>
        </td>
        <td style="height: 12px">
            </td>
    </tr>
    <tr>
        <td style="width: 47px">
            &nbsp;</td>
        <td style="width: 148px">
            <asp:Label ID="Label15" runat="server" Text="Contacto:"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtcontact0" runat="server" Height="20px" Width="350px"></asp:TextBox>
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td style="width: 47px">
            &nbsp;</td>
        <td style="width: 148px">
            <asp:Label ID="Label16" runat="server" Text="Teléfono:"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txttelefono0" runat="server" Height="20px" Width="150px"></asp:TextBox>
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td style="width: 47px">
            &nbsp;</td>
        <td style="width: 148px">
            <asp:Label ID="Label17" runat="server" Text="Email:"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtemail00" runat="server" Height="20px" 
                ToolTip="Formato de la fecha de contratación: (aaaa/mm/dd) " Width="350px"></asp:TextBox>
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td style="width: 47px">
            &nbsp;</td>
        <td style="width: 148px">
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
        <tr>
        <td style="width: 47px">
            &nbsp;</td>
        <td style="width: 148px">
            <asp:Label ID="Label14" runat="server" Text="Dirección:"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtdirec" runat="server" Height="20px" Width="350px"></asp:TextBox>
        </td>
        <td>
            &nbsp;</td>
    </tr>

    <tr>
        <td style="width: 47px">
            &nbsp;</td>
        <td style="width: 148px">
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td style="width: 47px">
            &nbsp;</td>
        <td style="width: 148px">
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td style="width: 47px">
            &nbsp;</td>
        <td style="width: 148px">
            &nbsp;</td>
        <td>
            <asp:Button ID="Button4" runat="server" Height="25px" Text="Grabar" 
                Width="100px" onclick="Button4_Click" 
                onclientclick="return confirm('Confirma Grabar los cambios?')" />
            <asp:Button ID="Button5" runat="server" Height="25px" Text="Volver al ver el listado de empleados" 
                Width="300px" onclick="Button5_Click" />
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td style="width: 47px">
            &nbsp;</td>
        <td style="width: 148px">
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td style="width: 47px">
            &nbsp;</td>
        <td style="width: 148px">
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td style="width: 47px">
            &nbsp;</td>
        <td style="width: 148px">
            &nbsp;</td>
        <td>
            <asp:Label ID="Label5" runat="server"></asp:Label>
        </td>
        <td>
            &nbsp;</td>
    </tr>
</table>

                    <br />
                </asp:View>
                <asp:View ID="View3" runat="server">
                    <table style="width: 100%">
                        <tr>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                            <td colspan="4">
                                <asp:GridView ID="GridView2" runat="server" CellPadding="4" ForeColor="#333333" 
                                    GridLines="None" Width="700px">
                                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                                    <EditRowStyle BackColor="#999999" />
                                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                                    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" Font-Size="7pt" 
                                        ForeColor="#333333" />
                                    <SortedAscendingCellStyle BackColor="#E9E7E2" />
                                    <SortedAscendingHeaderStyle BackColor="#506C8C" />
                                    <SortedDescendingCellStyle BackColor="#FFFDF8" />
                                    <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                                </asp:GridView>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                            <td>
                                <asp:SqlDataSource ID="SqlDataSource2" runat="server"></asp:SqlDataSource>
                            </td>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                    </table>
                </asp:View>
                <asp:View ID="View4" runat="server">
                <asp:Label ID="Label6" runat="server" Text="V03"></asp:Label>
                </asp:View>
            </asp:MultiView>
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td style="width: 47px">
            &nbsp;</td>
        <td colspan="2">
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td style="width: 47px">
            &nbsp;</td>
        <td colspan="2">
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td style="width: 47px">
            &nbsp;</td>
        <td colspan="2">
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td style="width: 47px">
            &nbsp;</td>
        
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td style="width: 47px">
            &nbsp;</td>
        <td colspan="2">
            
        </td>
        <td>
            &nbsp;</td>
    </tr>
        <tr>
        <td style="width: 47px">
            &nbsp;</td>
        <td colspan="2">
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td style="width: 47px">
            &nbsp;</td>
        <td style="width: 148px">
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td style="width: 47px">
            &nbsp;</td>
        <td style="width: 148px">
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td style="width: 47px">
            &nbsp;</td>
        <td style="width: 148px">
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td style="width: 47px">
            &nbsp;</td>
        <td style="width: 148px">
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>

    <tr>
        <td style="width: 47px">
            &nbsp;</td>
        <td style="width: 148px">
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td style="width: 47px">
            &nbsp;</td>
        <td style="width: 148px">
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td style="width: 47px">
            &nbsp;</td>
        <td style="width: 148px">
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td style="width: 47px">
            &nbsp;</td>
        <td style="width: 148px">
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
</table>
<p>
    &nbsp;</p>
<p>
</p>


</asp:Content>

