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

        <asp:GridView runat="server" ID="GridMemb" BackColor="#BEBEBE" AlternatingRowStyle-BackColor="#CCCCFF" AutoGenerateColumns="False">
            
                        <AlternatingRowStyle BackColor="#CCCCFF"></AlternatingRowStyle>
            <Columns>
                        <asp:boundfield datafield="idmembro" headertext="ID"/>
                        <asp:boundfield datafield="nome" headertext="Nome"/>
                        <asp:boundfield datafield="cidade" headertext="Cidade"/>
                        <asp:boundfield datafield="uf" headertext="UF"/>
                        <asp:boundfield datafield="endereco" headertext="Endereço"/>
                        <asp:boundfield datafield="tel" headertext="Telefone"/>
                        <asp:boundfield datafield="sexo" headertext="Sexo"/>
                        <asp:boundfield datafield="tipomembro" headertext="Tipo"/>
            </Columns>
            
        </asp:GridView>
    </form>
</body>
</html>
