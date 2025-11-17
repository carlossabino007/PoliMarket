<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Poli_ProductosMain01.aspx.cs" Inherits="Poli_ProductosMain01" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
            <table cellspacing="1" class="style1">
     <tr>
        <td>
            </td>
        <td>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                <asp:Label ID="Label12" runat="server" 
                            Font-Bold="True" Font-Italic="False" 
                Font-Size="16pt" Font-Underline="True" ForeColor="#3333CC" 
                Text="Registro y actualización de productos en el inventario" 
                Font-Overline="False"></asp:Label>
                        &nbsp;</h2>
            </td>
        <td>
            </td>
    </tr>
     <tr>
        <td style="width: 41px; height: 13px;">
            &nbsp;</td>
        <td style="height: 13px">
            <asp:Label ID="lblParaSeguridadPaciente" runat="server" Visible="False"></asp:Label>
            <asp:Label ID="lblIPDeUsuarioLogueado" runat="server" Visible="False"></asp:Label>
            <asp:Label ID="lblUsuarioaProcesar" runat="server" Visible="False"></asp:Label>
            </td>
    </tr>
     <tr>
        <td style="width: 41px; height: 13px;">
            &nbsp;</td>
        <td style="height: 13px">
                <asp:Label ID="Label17" runat="server" Height="16px" Text="Usuario:" 
                    Width="55px"></asp:Label>
                <asp:Label ID="lbldocusulogueado" runat="server"></asp:Label>
            <asp:Label ID="lblusulog" runat="server"></asp:Label>
            <asp:Label ID="lblGuardaUsuario" runat="server" Visible="False"></asp:Label>
            <asp:Label ID="lblrol" runat="server" Visible="False"></asp:Label>
                        <asp:Label ID="lblmensajeagregartemperatura" runat="server"></asp:Label>
            <asp:Label ID="lblSeleccion" runat="server" Visible="False"></asp:Label>
                    <asp:Label ID="lblcodClienteEscogido" runat="server" Visible="False"></asp:Label>
                    <asp:Label ID="txtInformacionCliente" runat="server" Visible="False"></asp:Label>
                <asp:Label ID="lbltextofiltro" runat="server"></asp:Label>
            </td>
    </tr>
     <tr>
        <td style="width: 41px; height: 13px;">
            </td>
        <td style="height: 13px">
            <asp:Label ID="Label1" runat="server" Height="19px" Text="Fecha        : " 
                ForeColor="#006600"></asp:Label>
&nbsp;<asp:Label ID="lblFechaDelSistema" runat="server"></asp:Label>
        &nbsp;<asp:Label ID="Label37" runat="server" Text="(Día-Mes-Año)"></asp:Label>
&nbsp;&nbsp;
            <asp:Label ID="Label38" runat="server" ForeColor="#006600" Height="19px" 
                Text=" - Hora:" Visible="False"></asp:Label>
            <asp:Label ID="lblHoraDelSistema" runat="server" Visible="False"></asp:Label>
        </td>
    </tr>
    <tr>
        <td style="width: 41px; height: 13px;">
            </td>
        <td style="height: 13px">
            <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/LineaHorizontal.jpg" 
                Width="647px" />
        </td>
    </tr>


    
    <tr>
        <td style="width: 41px; height: 13px;">
            &nbsp;</td>
        <td style="height: 13px">
            &nbsp;</td>
    </tr>


    
    <tr>
        <td style="width: 41px; height: 13px;">
            &nbsp;</td>
        <td style="height: 13px">
            <asp:MultiView ID="MultiView1" runat="server">
                <asp:View ID="View2" runat="server">
                    <asp:Label ID="Label43" runat="server" Text="View1" Visible="False"></asp:Label>
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
                            <td style="width: 53px">
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td style="height: 126px">
                            </td>
                            <td style="height: 126px">
                            </td>
                            <td style="height: 126px">
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:ImageButton ID="ImageButton16" runat="server" Height="80px" 
                                    ImageUrl="~/Polimagenes/Inventar.JPG" onclick="ImageButton16_Click" 
                                    Width="80px" ToolTip="Registrar Nuevos Productos" />
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
                                <asp:ImageButton ID="ImageButton14" runat="server" Height="80px" 
                                    ImageUrl="~/Polimagenes/Oficio.jpg" onclick="ImageButton14_Click" 
                                    Width="80px" ToolTip="Listar  Productos registrados y el Stock actual" />
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:LinkButton ID="LinkButton6" runat="server" ForeColor="#006600" 
                                    ToolTip="Registrar Nuevos Productos">Registrar Productos</asp:LinkButton>
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:LinkButton ID="LinkButton4" runat="server" ForeColor="#006600" 
                                    onclick="LinkButton4_Click" 
                                    
                                    onclientclick="return confirm('Confirma CREAR nuevo consecutivo para los oficios?')" 
                                    ToolTip="Listar  Productos registrados y el Stock actual">Listar  Productos registrados y el Stock actualizado</asp:LinkButton>
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; &nbsp;
                            </td>
                            <td style="height: 126px">
                            </td>
                            <td style="height: 126px">
                            </td>
                            <td style="height: 126px" colspan="3">
                                <br />
                            </td>
                        </tr>
                        <tr>
                            <td style="height: 12px" colspan="8">
                                <asp:Image ID="Image3" runat="server" ImageUrl="~/Images/LineaHorizontal.jpg" 
                                    Width="647px" />
                                </td>
                        </tr>
                        <tr>
                            <td colspan="8" style="height: 12px">
                                <asp:Label ID="lblYear" runat="server" Visible="False"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="8" style="height: 12px">
                                <asp:Label ID="lbltextooltip" runat="server" Visible="False"></asp:Label>
                                <asp:Label ID="Label61" runat="server" Visible="False"></asp:Label>
                                <asp:Label ID="Label62" runat="server" Visible="False"></asp:Label>
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:Label ID="Label63" runat="server" Text="Label" Visible="False"></asp:Label>
                            </td>
                        </tr>
                    </table>
                </asp:View>
                <asp:View ID="View3" runat="server">
                    <asp:Label ID="Label44" runat="server" Text="View2" Visible="False"></asp:Label>
                    <br />
                    <br />
                    <table style="width: 100%">
                        <tr>
                            <td style="width: 254px">
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:ImageButton ID="ImageButton17" runat="server" Enabled="False" 
                                    Height="80px" ImageUrl="~/Polimagenes/Inventar.JPG" Width="80px" />
                                <br />
                                <asp:LinkButton ID="LinkButton7" runat="server" Enabled="False" 
                                    ForeColor="#006600" ToolTip="Registrar Nuevos Productos">Registrar Productos</asp:LinkButton>
                            </td>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td style="width: 254px">
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
                            <td colspan="3">


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
        <td colspan="4">
            <asp:Image ID="Image4" runat="server" ImageUrl="~/Images/LineaHorizontal.jpg" 
                Width="647px" />
        </td>
    </tr>
    <tr>
        <td style="width: 47px; height: 12px;">
            </td>
        <td style="height: 12px; width: 148px">
            <asp:Label ID="Label13" runat="server" Text="Bodega:"></asp:Label>
        </td>
        <td style="height: 12px">
            <asp:TextBox ID="TextBox1" runat="server" Height="20px" Width="50px" 
                Enabled="False" ForeColor="#3333FF">1</asp:TextBox>
        </td>
        <td style="height: 12px">
            </td>
    </tr>
    <tr>
        <td style="width: 47px">
            &nbsp;</td>
        <td style="width: 148px">
            <asp:Label ID="Label15" runat="server" Text="Código de Producto:"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="TextBox2" runat="server" Height="20px" Width="100px"></asp:TextBox>
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td style="width: 47px">
            &nbsp;</td>
        <td style="width: 148px">
            <asp:Label ID="Label16" runat="server" Text="Descripción:"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="TextBox3" runat="server" Height="20px" Width="300px"></asp:TextBox>
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td style="width: 47px">
            &nbsp;</td>
        <td style="width: 148px">
            <asp:Label ID="Label2" runat="server" Text="Precio:"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="TextBox4" runat="server" Height="20px" 
                ToolTip="Formato de la fecha de contratación: (aaaa/mm/dd) "></asp:TextBox>
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td style="width: 47px">
            &nbsp;</td>
        <td style="width: 148px">
            <asp:Label ID="Label18" runat="server" Text="Stock actual:"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="TextBox5" runat="server" Height="20px"></asp:TextBox>
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td style="width: 47px">
            &nbsp;</td>
        <td style="width: 148px">
            <asp:Label ID="Label19" runat="server" Text="Stock Mínimo:"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="TextBox6" runat="server" Height="20px"></asp:TextBox>
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td style="width: 47px">
            &nbsp;</td>
        <td style="width: 148px">
            <asp:Label ID="Label64" runat="server" Text="Categoría:"></asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="DropDownList4" runat="server" 
                Height="25px">
                <asp:ListItem Value="0">--Seleccione</asp:ListItem>
                <asp:ListItem Value="1">Electrónico</asp:ListItem>
                <asp:ListItem Value="2">Accesorio</asp:ListItem>
                <asp:ListItem Value="3">Insumo</asp:ListItem>
                <asp:ListItem Value="4">Otros</asp:ListItem>
            </asp:DropDownList>
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td style="width: 47px">
            &nbsp;</td>
        <td style="width: 148px">
            <asp:Label ID="Label20" runat="server" Text="Estado:"></asp:Label>
        </td>
        <td>
            <asp:Label ID="Label65" runat="server" ForeColor="#3366FF"></asp:Label>
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
            <asp:Button ID="Button1" runat="server" Height="25px" Text="Grabar" 
                Width="100px" onclick="Button1_Click" />
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" Height="25px" onclick="Button2_Click" 
                Text="Volver al Menú principal  de Productos en Bodega" Width="300px" />
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
            <asp:Label ID="lblmensaje" runat="server"></asp:Label>
        </td>
        <td>
            &nbsp;</td>
    </tr>
</table>                            

                            </td>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td style="width: 254px">
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
                    </table>
                </asp:View>
                <asp:View ID="View5" runat="server">
                    <br />
                    <br />
                    <table style="width: 100%">
                        <tr>
                            <td colspan="5">
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:ImageButton ID="ImageButton18" runat="server" Enabled="False" 
                                    Height="80px" ImageUrl="~/Polimagenes/oficio.jpg" Width="80px" />
                                <br />
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:LinkButton ID="LinkButton8" runat="server" Enabled="False" 
                                    ForeColor="#006600" ToolTip="Registrar Nuevos Productos">Listar  Productos registrados y el Stock actualizado</asp:LinkButton>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 254px">
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
                            <td style="width: 254px">
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
                            <td colspan="5">
                                <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
                                    AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" 
                                    DataKeyNames="codigo_producto" DataSourceID="SqlDataSource1" 
                                    ForeColor="#333333" GridLines="None" Width="700px">
                                    <AlternatingRowStyle BackColor="White" />
                                    <Columns>
                                        <asp:CommandField ShowSelectButton="True">
                                        <ItemStyle Font-Size="7pt" Width="150px" />
                                        </asp:CommandField>
                                        <asp:BoundField DataField="codigo_producto" HeaderText="codigo" 
                                            InsertVisible="False" ReadOnly="True" SortExpression="codigo_producto">
                                        <ItemStyle Font-Size="7pt" Width="100px" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="nombre" HeaderText="nombre" SortExpression="nombre">
                                        <ItemStyle Font-Size="7pt" Width="350px" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="descripcion" HeaderText="descripcion" 
                                            SortExpression="descripcion">
                                        <ItemStyle Font-Size="7pt" Width="300px" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="precio" HeaderText="precio" SortExpression="precio">
                                        <ItemStyle Font-Size="7pt" Width="300px" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="stock_actual" HeaderText="Stock" 
                                            SortExpression="stock_actual">
                                        <ItemStyle Font-Size="7pt" Width="300px" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="stock_minimo" HeaderText="stock_Minimo" 
                                            SortExpression="stock_minimo">
                                        <ItemStyle Font-Size="7pt" Width="150px" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="categoria" HeaderText="categoria" 
                                            SortExpression="categoria">
                                        <ItemStyle Font-Size="7pt" Width="350px" />
                                        </asp:BoundField>
                                        <asp:CheckBoxField DataField="activo" HeaderText="activo" 
                                            SortExpression="activo" />
                                    </Columns>
                                    <EditRowStyle BackColor="#7C6F57" />
                                    <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                                    <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                                    <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                                    <RowStyle BackColor="#E3EAEB" />
                                    <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                                    <SortedAscendingCellStyle BackColor="#F8FAFA" />
                                    <SortedAscendingHeaderStyle BackColor="#246B61" />
                                    <SortedDescendingCellStyle BackColor="#D4DFE1" />
                                    <SortedDescendingHeaderStyle BackColor="#15524A" />
                                </asp:GridView>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td colspan="3">
                                <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                                    ConnectionString="<%$ ConnectionStrings:BaseWebKardexConnectionString2 %>" 
                                    SelectCommand="SELECT [codigo_producto], [nombre], [descripcion], [precio], [stock_actual], [stock_minimo], [categoria], [activo] FROM [PRODUCTO]">
                                </asp:SqlDataSource>
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:Button ID="Button3" runat="server" Height="25px" onclick="Button3_Click" 
                                    Text="Volver al Menú principal  de Productos en Bodega" Width="300px" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3">
                                &nbsp;</td>
                        </tr>
                    </table>
                </asp:View>
                <asp:View ID="View6" runat="server">
                    <asp:Label ID="Label4" runat="server" Text="View3" Visible="False"></asp:Label>
                </asp:View>
                <asp:View ID="View7" runat="server">
                    <asp:Label ID="Label5" runat="server" Text="View3" Visible="False"></asp:Label>
                </asp:View>

            </asp:MultiView>
        </td>
    </tr>


    
       <tr>
        <td>
            &nbsp;</td>
        <td style="width: 62px">
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>

    </table>




</asp:Content>

