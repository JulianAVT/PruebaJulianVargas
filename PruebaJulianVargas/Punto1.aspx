<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Punto1.aspx.cs" Inherits="PruebaJulianVargas.Punto1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 221px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:100%;">
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label1" runat="server" Font-Bold="True" Text="Consulta de contratos laborales"></asp:Label>
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
                        <asp:Label ID="Label2" runat="server" Font-Bold="True" Text="Numero Documento:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TxtNumeroDocumento" runat="server" TextMode="Number"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td colspan="3">
                        <asp:GridView ID="GrdContratoLaboral" runat="server" AutoGenerateColumns="False">
                            <Columns>
                                <asp:BoundField DataField="numero_documento" HeaderText="Numero Documento" />
                                <asp:BoundField DataField="descripcion_documento" HeaderText="Descripcion Documento" />
                                <asp:BoundField DataField="primer_nombre" HeaderText="Primer Nombre" />
                                <asp:BoundField DataField="segundo_nombre" HeaderText="Segundo Nombre" />
                                <asp:BoundField DataField="primer_apellido" HeaderText="Primer Apellido" />
                                <asp:BoundField DataField="segundo_apellido" HeaderText="Segundo Apellido" />
                                <asp:BoundField DataField="numero_contrato" HeaderText="Numero Contrato" />
                                <asp:BoundField DataField="cargo" HeaderText="Cargo" />
                                <asp:BoundField DataField="valor_arl" HeaderText="Valor Arl" />
                                <asp:BoundField DataField="fecha_inicio_contrato_laboral" HeaderText="Fecha Inicio Contrato Laboral" />
                                <asp:BoundField DataField="fecha_fin_contrato_laboral" HeaderText="Fecha Fin Contrato Laboral" />
                                <asp:BoundField DataField="salario_laboral" HeaderText="Salario Laboral" />
                            </Columns>
                        </asp:GridView>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td align="right">
                        <asp:Button ID="BtnConsultar" runat="server" BackColor="#66CCFF" Text="Consultar" OnClick="BtnConsultar_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
