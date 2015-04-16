<html>
<head runat="server">
<title> Cadastro de Membros</title>
</head>
<body>
<h3>Cadastro de novo membro</h3>
</p>
</p>
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
</body>
</html>
