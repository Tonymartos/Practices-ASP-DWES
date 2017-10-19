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
    
        <asp:Label ID="Label1" runat="server" Text="Cintura: "></asp:Label>
    
    </div>
        <asp:TextBox ID="TBcintura" runat="server" Height="21px"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Cadera: "></asp:Label>
        <p>
            <asp:TextBox ID="TBcadera" runat="server"></asp:TextBox>
            <asp:RadioButtonList ID="RBLSexo" runat="server" style="margin-right: 0px" Width="106px">
                <asp:ListItem>Masculino</asp:ListItem>
                <asp:ListItem>Femenino</asp:ListItem>
            </asp:RadioButtonList>
        </p>
        <asp:DropDownList ID="DDLEdad" runat="server">
            <asp:ListItem>20-29</asp:ListItem>
            <asp:ListItem>30-39</asp:ListItem>
            <asp:ListItem>40-49</asp:ListItem>
        </asp:DropDownList>
        <p>
            <asp:Button ID="Benviar" runat="server" Text="Enviar" />
        </p>
    </form>
</body>
</html>
