<%@ Page Language="C#" AutoEventWireup="True" CodeFile="Default.aspx.cs" Inherits="_default" %>

<html>
<head>
    <title>UD02. Ejemplos</title>
</head>
<body>
    <form id="mifom" runat="server">
    <asp:Panel ID="PNpanel" runat="server" Height="33px" Width="435px">
        <asp:Label ID="L1" runat="server" Text="D.N.I:"></asp:Label>
        <asp:TextBox ID="TBdni" runat="server" Columns="9" MaxLength="9" 
             AutoPostBack="true"  OnTextChanged="TBdniCambio" >
        </asp:TextBox>
    </asp:Panel><br />
    <asp:Label ID="Lmensaje" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>
