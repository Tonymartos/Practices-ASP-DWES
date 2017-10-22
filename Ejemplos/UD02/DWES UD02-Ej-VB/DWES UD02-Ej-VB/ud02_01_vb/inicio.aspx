<%@ Page Language="VB" AutoEventWireup="false" CodeFile="inicio.aspx.vb" Inherits="_inicio"  debug="true"%>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>UD02. Ejemplos</title>
</head>
<body>
    <form id="miForm" runat="server">
    <div>
        Nif:&nbsp;&nbsp;
        <asp:TextBox ID="TBnif" runat="server" AutoPostBack="True" MaxLength="9"></asp:TextBox>
        <br />
        <asp:Label ID="Lmensaje" runat="server"></asp:Label>&nbsp;&nbsp;&nbsp;
        <asp:Panel ID="PNpanel" runat="server" Height="50px" Visible="False" Width="125px">
            Vehículos:<asp:DropDownList ID="DDLvehiculos"  runat="server"></asp:DropDownList>
        </asp:Panel>
    </div>
    </form>
</body>
</html>
