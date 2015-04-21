<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadMemb.aspx.cs" Inherits="IEADWebApp.CadMemb" %>
<!DOCTYPE html>
<html mlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title> Cadastro de Membros</title>
<link type="html/css" rel="stylesheet" href="StyleInicial.css"/>
</head>
<body>
    <h3>Cadastro de novo membro</h3>
    </p>
    </p>
        <form ID="FormCadMemb" runat="server">
            <table  id="TabMemb">
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
        </form>
</body>
</html>
