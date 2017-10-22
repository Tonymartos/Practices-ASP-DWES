<%@ Page Language="VB" %>
<html>
<head>
<title></title>
</head>
<body>
    <form name ="miForm" runat ="server" action="respuesta2.aspx">
        <h2>Formulario ASP (POST)</h2>
        <asp:Label ID="Ldni" runat="server" Text ="Dni:" />
        <asp:TextBox ID="TBdniAsp" runat="server"  MaxLength ="8" size="8"/>
        <asp:Label ID="Lletra" runat="server" Text ="Letra:" />
        <asp:TextBox ID="TBletraAsp" runat="server"  MaxLength ="1" size="1"/>
        <asp:Button ID="BTenviarAsp" runat ="server"  Text="Enviar" />
        <hr />
        <h2>Cadena de consulta</h2>
        <asp:HyperLink ID="HLget" runat="server" NavigateUrl="respuesta2.aspx?dni=26100100&letra=E" Text="Pruebe la validez del NIF:26100100E"/>
    </form>
</body>
</html>
