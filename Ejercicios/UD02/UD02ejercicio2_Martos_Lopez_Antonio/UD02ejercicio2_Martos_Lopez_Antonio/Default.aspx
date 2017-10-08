<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="TBuno" runat="server" ></asp:TextBox>
        <asp:Label ID="Label1" runat="server" Text="Label" >X2+</asp:Label>
        <asp:TextBox ID="TBdos" runat="server"  ></asp:TextBox>
        <asp:Label ID="Label2" runat="server" Text="Label" >X+</asp:Label>
        <asp:TextBox ID="TBtres" runat="server" ></asp:TextBox>
        <asp:Label ID="Label3" runat="server" Text="Label" >=</asp:Label>
        <asp:Label ID="Label4" runat="server" Text="Label" >0</asp:Label>
        <br />
        <asp:CheckBox ID="CBCheck" Text="Solución real" runat="server" />
        <br />
        <asp:Button ID="BTenviar" runat="server" Text="Enviar"/>
        <br />
        <asp:Literal ID="resultadoxuno" runat="server"></asp:Literal>
        <br />
        <asp:Literal ID="resultadoxdos" runat="server"></asp:Literal>
        <br />
        <asp:Button ID="BTvolver" runat="server" Text="Volver" Visible="False"/>
    </div>
    </form>
</body>
</html>
