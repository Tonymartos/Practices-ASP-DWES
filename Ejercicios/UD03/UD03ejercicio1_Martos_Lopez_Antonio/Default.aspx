<%@ Page Language="VB" AutoEventWireup="true" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Luno" runat="server" Text="Introduce el Texto: "></asp:Label>
        <asp:TextBox ID="TBuno" runat="server"></asp:TextBox>
        <asp:Label ID="Ldos" runat="server" Text="Introduce la letra: "></asp:Label>
        <asp:TextBox ID="TBdos" MaxLength="1" runat="server"></asp:TextBox>
        <asp:Button ID="Buno" runat="server" Text="Button" />

    </div>
    </form>
</body>
</html>
