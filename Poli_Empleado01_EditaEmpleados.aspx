<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Poli_Empleado01_EditaEmpleados.aspx.cs" Inherits="Poli_Empleado01_EditaEmpleados" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            <asp:Label ID="Label12" runat="server" 
                            Font-Bold="True" Font-Italic="False" 
                Font-Size="16pt" Font-Underline="True" ForeColor="#0033CC" 
                Text="Editar/Actualizar Empleado" 
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
                        Text="Empleados registrados en el sistema:"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:ImageButton ID="ImageButton1" runat="server" Height="19px" 
                        ImageUrl="~/Images/Volver.png" Width="19px" />
                    <asp:LinkButton ID="LinkButton1" runat="server" ForeColor="#0099FF" 
                        PostBackUrl="~/pagePrincipal.aspx">Formulario anterior</asp:LinkButton>
                    <br />
                    <br />
                    <br />
                    <table style="width: 100%">
                        <tr>
                            <td style="width: 12px">
                                &nbsp;</td>
                            <td style="width: 647px">
                            <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" 
                GridLines="None" PageSize="30" Width="700px" AllowPaging="True" 
                AllowSorting="True" AutoGenerateColumns="False" CaptionAlign="Bottom" 
                DataKeyNames="id_empleado" DataSourceID="SqlDataSource1" 
                                    onselectedindexchanged="GridView1_SelectedIndexChanged">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <Columns>
                    <asp:CommandField ShowSelectButton="True" SelectText="Editar">
                    <ItemStyle Font-Size="8pt" Width="100px" />
                    </asp:CommandField>
                    <asp:BoundField DataField="id_empleado" HeaderText="id" InsertVisible="False" 
                        ReadOnly="True" SortExpression="id_empleado">
                    <ItemStyle Width="50px" />
                    </asp:BoundField>

                    <asp:BoundField DataField="usuario" HeaderText="usuario" SortExpression="usuario">
                    <ItemStyle Font-Size="8pt" Width="200px" />
                    </asp:BoundField>
                    <asp:BoundField DataField="nombre" HeaderText="nombre" SortExpression="nombre">
                    <ItemStyle Font-Size="8pt" Width="400px" />
                    </asp:BoundField>
                    <asp:BoundField DataField="cargo" HeaderText="cargo" SortExpression="cargo">
                    <ItemStyle Font-Size="8pt" Width="200px" />
                    </asp:BoundField>
                    <asp:BoundField DataField="email" HeaderText="email" SortExpression="email">
                    <ItemStyle Font-Size="8pt" Width="300px" />
                    </asp:BoundField>
                    <asp:BoundField DataField="telefono" HeaderText="telefono" 
                        SortExpression="telefono">
                    <ItemStyle Font-Size="8pt" Width="200px" />
                    </asp:BoundField>
                    <asp:BoundField DataField="fecha_contratacion" 
                        DataFormatString="{0:yyyy-MM-dd} " HeaderText="fecha_contratacion" 
                        SortExpression="Fech_Contrat.">
                    <ItemStyle Font-Size="8pt" />
                    </asp:BoundField>
                    <asp:CheckBoxField DataField="activo" HeaderText="activo" 
                        SortExpression="activo">
                    <ItemStyle Font-Size="10pt" />
                    </asp:CheckBoxField>
                </Columns>
                <EditRowStyle BackColor="#999999" Font-Size="11pt" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" Font-Size="8pt" ForeColor="#333333" Font-Bold="False" 
                                    Font-Italic="False" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
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
                            
                            SelectCommand="SELECT [id_empleado], [nombre], [cargo], [email], [telefono], [fecha_contratacion], [activo], [usuario] FROM [EMPLEADO]">
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
                <asp:Label ID="Label2" runat="server" Text="V02" Visible="False"></asp:Label>
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
            <asp:Label ID="Label22" runat="server" Text="Id:"></asp:Label>
        </td>
        <td>
            <asp:Label ID="lblId" runat="server" ForeColor="#0066FF">...</asp:Label>
            &nbsp;&nbsp;
            <asp:Label ID="Label23" runat="server" ForeColor="#3366FF" Text="Usuario: "></asp:Label>
            &nbsp;&nbsp;
            <asp:Label ID="lblelUsu" runat="server" ForeColor="#3366FF"></asp:Label>
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
            <asp:Label ID="Label15" runat="server" Text="Email:"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtemail0" runat="server" Height="20px" Width="300px"></asp:TextBox>
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
            <asp:TextBox ID="txttelefono0" runat="server" Height="20px"></asp:TextBox>
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td style="width: 47px">
            &nbsp;</td>
        <td style="width: 148px">
            <asp:Label ID="Label17" runat="server" Text="Fecha de contratación:"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtfechacontrat" runat="server" Height="20px" 
                ToolTip="Formato de la fecha de contratación: (aaaa/mm/dd) "></asp:TextBox>
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
            <asp:Label ID="Label14" runat="server" Text="Cargo:"></asp:Label>
        </td>
        <td>
            <asp:Label ID="lblcargo" runat="server" Height="20px" Text="..." 
                ForeColor="#0066FF"></asp:Label>
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
                <asp:Label ID="Label3" runat="server" Text="V03"></asp:Label>
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

