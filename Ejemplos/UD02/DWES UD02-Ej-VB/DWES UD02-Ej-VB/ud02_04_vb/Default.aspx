<%@ Page Language="vb" AutoEventWireup="true" CodeFile="Default.aspx.vb" Inherits="_Default"  %>

<html>
<head>
    <title>UD02. Ejemplos</title>
</head>
<body>
    <form id="miFom" runat="server">
    <asp:Panel ID="PNpanel" runat="server" Height="33px" Width="435px">
        <asp:Label ID="L1" runat="server" Text="D.N.I:"></asp:Label>
        <asp:TextBox ID="TBdni" runat="server" Columns="9" MaxLength="9" AutoPostBack="true"></asp:TextBox>
        <%--
        <asp:TextBox ID="TBdni" runat="server" Columns="9" MaxLength="9" AutoPostBack="true" OnTextChanged="TBdniCambio"></asp:TextBox>
        --%>
    </asp:Panel><br />
    <asp:Label ID="Lmensaje" runat="server" Text=""></asp:Label></form>
</body>
</html>
