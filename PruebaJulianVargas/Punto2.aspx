<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Punto2.aspx.cs" Inherits="PruebaJulianVargas.Punto2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 249px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:100%;">
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label1" runat="server" Font-Bold="True" Text="Grabar datos en novedades nomina"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        &nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label10" runat="server" Font-Bold="True" Text="Contrato:"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="CboContrato" runat="server" AutoPostBack="True">
                        </asp:DropDownList>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label2" runat="server" Font-Bold="True" Text="Numero Documento:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TxtNumeroDocumento" runat="server" TextMode="Number"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label3" runat="server" Font-Bold="True" Text="Horas total laboradas:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TxtHorasTotalLaboradas" runat="server" TextMode="Number"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label4" runat="server" Font-Bold="True" Text="Horas extras(diurnas):"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TxtHorasExtrasDiurnas" runat="server" TextMode="Number"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label7" runat="server" Font-Bold="True" Text="Horas extras(nocturnas):"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TxtHorasExtrasNocturnas" runat="server" TextMode="Number"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label8" runat="server" Font-Bold="True" Text="Horas extras(dominicales):"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TxtHorasExtrasDominicales" runat="server" TextMode="Number"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label9" runat="server" Font-Bold="True" Text="Horas extras(festivas):"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TxtNumeroFestivas" runat="server" TextMode="Number"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label5" runat="server" Font-Bold="True" Text="Periodo laborado:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TxtPeriodoLaborado" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label6" runat="server" Font-Bold="True" Text="Descuentos de nomina:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TxtDescuentosNomina" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td align="right">
                        <asp:Button ID="BtnGrabar" runat="server" BackColor="#66CCFF" Text="Grabar" OnClick="BtnGrabar_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
