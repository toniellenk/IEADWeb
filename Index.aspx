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
                    <asp:Button ID="CadMemb" Text="Novo Membro" runat="server" OnClick="Novo_Memb" />
                    <asp:Panel ID="PnMemb" Title="Novo Membro" runat="server> 
                        <form ID="FormCadMemb" runat="server">
                        <table>
                            <tr><td>Nome: <asp:TextBox ID="NomeMemb" runat="server"/></td></tr>
                            <tr><td>Sexo: <asp:TextBox ID="SexMemb" runat="server"/></td></tr>
                            <tr><td>Telefone: <asp:TextBox ID="TelMemb" runat="server"/></td></tr>
                            <tr><td>Endereço: <asp:TextBox ID="EndMemb" runat="server"/></td></tr>
                            <tr><td>UF: <asp:TextBox ID="UfMemb" runat="server"/></td></tr>
                            <tr><td>Cidade: <asp:TextBox ID="CidMemb" runat="server"/></td></tr>
                            <tr><td>CEP: <asp:TextBox ID="CepMemb" runat="server"/></td></tr>
                            <tr><td>Tipo de Membro: <asp:TextBox ID="TipMemb" runat="server"/></td></tr>
                        </table>
                        </p>
                        <asp:Button ID="ButCadMemb" Text="Enviar" runat="server" OnClick="NovoMemb"/>
                        </forn>
                    </asp:Panel> 
                    </td>
                </tr>
        </table>
        <asp:DataGrid runat="server" ID="GridMemb"></asp:DataGrid>
        <asp:Label ID="Texto" runat="server" />
    </div>
    </form>
</body>
</html>
