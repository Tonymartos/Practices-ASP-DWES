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
    
        <asp:Label ID="LTitulo" runat="server" Text="Generador de password"></asp:Label>
        :<br />
    
    </div>
        <asp:DropDownList ID="DDLsize" runat="server">
            <asp:ListItem Value="6">Contraseña de 6 carac</asp:ListItem>
            <asp:ListItem>7</asp:ListItem>
            <asp:ListItem>8</asp:ListItem>
            <asp:ListItem>9</asp:ListItem>
        </asp:DropDownList>
        <p>
            <asp:Button ID="Buno" runat="server" Text="Obtener" />
        </p>
        <p>
            <asp:TextBox ID="TBvalidar" runat="server"></asp:TextBox>
            <asp:Button ID="Bvalidar" runat="server" Text="Validar" />
        </p>
        <p>
            <asp:Label ID="Lresultado" runat="server" Text="Resultado: "></asp:Label>
        </p>
    </form>
</body>
</html>
