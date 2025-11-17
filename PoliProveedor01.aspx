<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="PoliProveedor01.aspx.cs" Inherits="PoliProveedor01" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            <asp:Label ID="Label12" runat="server" 
                            Font-Bold="True" Font-Italic="False" 
                Font-Size="16pt" Font-Underline="True" ForeColor="#339933" 
                Text="Formulario Proveedores" 
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
            <asp:Image ID="Image2" runat="server" 
                ImageUrl="~/Polimagenes/imgprov.jpeg" Width="70px" 
                ToolTip="Formulaio para el registro de nuevos Prooveedores" />
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
        <td style="width: 47px; height: 12px;">
            &nbsp;</td>
        <td style="height: 12px; width: 148px">
            <asp:Label ID="Label27" runat="server" Text="Nit/Documento:"></asp:Label>
        </td>
        <td style="height: 12px">
            <asp:TextBox ID="TextBox6" runat="server" Height="20px"></asp:TextBox>
            <asp:Label ID="Label28" runat="server" ForeColor="#990033" Text="** Requerido"></asp:Label>
        </td>
        <td style="height: 12px">
            &nbsp;</td>
    </tr>
    <tr>
        <td style="width: 47px; height: 12px;">
            </td>
        <td style="height: 12px; width: 148px">
            <asp:Label ID="Label13" runat="server" Text="*Nombre/Razón Social:"></asp:Label>
        </td>
        <td style="height: 12px">
            <asp:TextBox ID="TextBox1" runat="server" Height="20px" Width="300px"></asp:TextBox>
            <asp:Label ID="Label21" runat="server" ForeColor="#990033" Text="** Requerido"></asp:Label>
        </td>
        <td style="height: 12px">
            </td>
    </tr>
    <tr>
        <td style="width: 47px">
            &nbsp;</td>
        <td style="width: 148px">
            <asp:Label ID="Label15" runat="server" Text="*Contacto:"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="TextBox2" runat="server" Height="20px" Width="300px"></asp:TextBox>
            <asp:Label ID="Label22" runat="server" ForeColor="#990033" Text="** Requerido"></asp:Label>
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td style="width: 47px">
            &nbsp;</td>
        <td style="width: 148px">
            <asp:Label ID="Label16" runat="server" Text="*Teléfono:"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="TextBox3" runat="server" Height="20px"></asp:TextBox>
            <asp:Label ID="Label24" runat="server" ForeColor="#990033" Text="** Requerido"></asp:Label>
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td style="width: 47px">
            &nbsp;</td>
        <td style="width: 148px">
            <asp:Label ID="Label17" runat="server" Text="*Email:"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="TextBox4" runat="server" Height="20px" 
                ToolTip="Formato de la fecha de contratación: (aaaa/mm/dd) " Width="300px"></asp:TextBox>
            <asp:Label ID="Label25" runat="server" ForeColor="#990033" Text="** Requerido"></asp:Label>
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td style="width: 47px">
            &nbsp;</td>
        <td style="width: 148px">
            <asp:Label ID="Label18" runat="server" Text="*Dirección:"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="TextBox5" runat="server" Height="20px" Width="300px"></asp:TextBox>
            <asp:Label ID="Label26" runat="server" ForeColor="#990033" Text="** Requerido"></asp:Label>
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td style="width: 47px; height: 18px;">
            </td>
        <td style="width: 148px; height: 18px;">
            &nbsp;</td>
        <td style="height: 18px">
            &nbsp;</td>
        <td style="height: 18px">
            </td>
    </tr>
    <tr>
        <td style="width: 47px">
            &nbsp;</td>
        <td style="width: 148px">
            <asp:Label ID="Label20" runat="server" Text="Estado:"></asp:Label>
        </td>
        <td>
            <asp:Label ID="Label23" runat="server" Font-Bold="True" ForeColor="#0066CC"></asp:Label>
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
            <asp:Button ID="Button2" runat="server" Height="25px" Text="Nuevo" 
                Width="100px" onclick="Button2_Click" />
            <asp:Button ID="Button3" runat="server" Height="25px" Text="Limpiar" 
                Width="100px" onclick="Button3_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:ImageButton ID="ImageButton1" runat="server" Height="19px" 
                            ImageUrl="~/Images/Volver.png" Width="19px" />
                        <asp:LinkButton ID="LinkButton1" runat="server" ForeColor="#0099FF" 
                            PostBackUrl="~/pagePrincipal.aspx">Formulario anterior</asp:LinkButton>
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

