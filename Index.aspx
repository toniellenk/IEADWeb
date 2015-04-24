<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="IEADWebApp.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sistema IEAD</title>
    <link type="text/css" rel="stylesheet" href="StyleInicial.css" />
</head>
<body>
    <p id:"tit >Bem vindo ao sistema IEAD (Igreja Evangélica Assembéia de Deus). </p>
    <form id="Telainicial" runat="server">
    <div>
        <table border="0" id="TabMemb">
            <tr><td colspan="5" style="text-align:center">Membros</td></tr>
            <tr>
                <td style="font-style:initial; font-family:Arial">
                    Cod. Membro: <asp:TextBox ID="CodMemb" Text="" runat="server" BorderStyle="Inset"></asp:TextBox></td>               
                <td>
                    <asp:Button ID="ConsultarMemb" Text="Consultar" runat="server" OnClick="ConsultarMemb_Click" /></td>
                <td>                    
                    <asp:Button ID="Listar" Text="Listar Membros" runat="server" OnClick="ListMemb" /></td>
                <td>
                    <asp:Button ID="Limpar" Text="Limpar Consulta" runat="server" OnClick="Limpar_Clik" /></td>
                <td>
                    <asp:Button ID="ButCadMemb" Text="Novo Membro" runat="server" OnClick="NovoMemb"/>
                    </td>
                </tr>
        </table>
        <asp:DataGrid runat="server" ID="GridMemb" AlternatingItemStyle-BackColor="#CCCCFF" BackColor="#BEBEBE">
<AlternatingItemStyle BackColor="#CCCCFF"></AlternatingItemStyle>
        </asp:DataGrid>
        <asp:Label ID="Texto" runat="server" />
    </div>
    </form>
</body>
</html>
