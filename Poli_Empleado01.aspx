<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Poli_Empleado01.aspx.cs" Inherits="Poli_Empleado01" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            <asp:Label ID="Label12" runat="server" 
                            Font-Bold="True" Font-Italic="False" 
                Font-Size="16pt" Font-Underline="True" ForeColor="#0033CC" 
                Text="Formulario Empleado" 
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
                Width="630px" />
        </td>
    </tr>
   
    <tr>
        <td style="width: 47px">
            &nbsp;</td>
        <td style="width: 148px">
            <asp:Image ID="Image2" runat="server" Height="70px" 
                ImageUrl="~/Polimagenes/imgempleado.jpeg" 
                ToolTip="Formulario para el registro de nuevos Empleados" Width="70px" />
        </td>
        <td>
            <table style="width: 100%">
                <tr>
                    <td style="width: 280px">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
            </table>
        </td>
        <td>
            &nbsp;</td>
    </tr>
     <tr>
        <td style="width: 47px">
            &nbsp;</td>
        <td style="width: 148px">
            <asp:Label ID="Label18" runat="server" Text="*Usuario:"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="TextBox5" runat="server" Height="20px"></asp:TextBox>
            <asp:Label ID="lblreqUsuario" runat="server" ForeColor="#990033" 
                Text="** Requerido"></asp:Label>
        </td>
        <td>
            &nbsp;</td>
    </tr>

    <tr>
        <td style="width: 47px; height: 12px;">
            </td>
        <td style="height: 12px; width: 148px">
            <asp:Label ID="Label13" runat="server" Text="*Nombre:"></asp:Label>
        </td>
        <td style="height: 12px">
            <asp:TextBox ID="TextBox1" runat="server" Height="20px" Width="300px"></asp:TextBox>
            <asp:Label ID="lblreqNombre" runat="server" ForeColor="#990033" 
                Text="** Requerido"></asp:Label>
        </td>
        <td style="height: 12px">
            </td>
    </tr>
    <tr>
        <td style="width: 47px">
            &nbsp;</td>
        <td style="width: 148px">
            <asp:Label ID="Label14" runat="server" Text="*Rol/Cargo:"></asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="DropDownList1" runat="server" 
                Height="25px" Width="200px">
                <asp:ListItem Value="0">--Seleccione</asp:ListItem>
                <asp:ListItem Value="1">Ventas</asp:ListItem>
                <asp:ListItem Value="2">Bodega</asp:ListItem>
                <asp:ListItem Value="3">Entregas</asp:ListItem>
                <asp:ListItem Value="4">Recursos Humanos</asp:ListItem>
            </asp:DropDownList>
        &nbsp;<asp:Label ID="lblreqRol" runat="server" ForeColor="#990033" 
                Text="** Requerido"></asp:Label>
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td style="width: 47px">
            &nbsp;</td>
        <td style="width: 148px">
            <asp:Label ID="Label15" runat="server" Text="Email:"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="TextBox2" runat="server" Height="20px" Width="300px"></asp:TextBox>
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
            <asp:TextBox ID="TextBox3" runat="server" Height="20px"></asp:TextBox>
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td style="width: 47px">
            &nbsp;</td>
        <td style="width: 148px">
            <asp:Label ID="Label17" runat="server" Text="*Fecha de contratación:"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="TextBox4" runat="server" Height="20px" 
                ToolTip="Formato de la fecha de contratación: (aaaa/mm/dd) "></asp:TextBox>
            <asp:Label ID="lblreqFechaContrat" runat="server" ForeColor="#990033" 
                Text="** Requerido"></asp:Label>
        </td>
        <td>
            &nbsp;</td>
    </tr>
   
    <tr>
        <td style="width: 47px">
            &nbsp;</td>
        <td style="width: 148px">
            <asp:Label ID="Label19" runat="server" Text="*Password:"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="TextBox6" runat="server" Height="20px" TextMode="Password"></asp:TextBox>
            <asp:Label ID="lblreqPassw" runat="server" ForeColor="#990033" 
                Text="** Requerido"></asp:Label>
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
            <asp:Label ID="Label20" runat="server" Text="Estado:"></asp:Label>
        </td>
        <td>
            <asp:Label ID="Label21" runat="server" Font-Bold="True" Font-Italic="False" 
                Font-Underline="False" ForeColor="#0066CC" Text="Activo" Visible="False"></asp:Label>
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
                Width="100px" onclick="Button1_Click" 
                onclientclick="return confirm('Confirma guardar los cambios y agregar el nuevo funcionario al Sistema?')" />
            <asp:Button ID="Button2" runat="server" Height="25px" Text="Nuevo" 
                Width="100px" onclick="Button2_Click" 
                onclientclick="return confirm('Desea ingresar un Nuevo funcionario al sistemas?')" />
            <asp:Button ID="Button3" runat="server" Height="25px" Text="Limpiar" 
                Width="100px" onclick="Button3_Click" 
                onclientclick="return confirm('Comfirma limpiar el formulario?')" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:ImageButton ID="ImageButton1" runat="server" Height="19px" 
                            ImageUrl="~/Images/Volver.png" Width="19px" />
                        <asp:LinkButton ID="LinkButton1" runat="server" ForeColor="#0099FF" 
                            PostBackUrl="~/pagePrincipal.aspx" onclick="LinkButton1_Click">Formulario anterior</asp:LinkButton>
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
<p>
    &nbsp;</p>
<p>
</p>

</asp:Content>

