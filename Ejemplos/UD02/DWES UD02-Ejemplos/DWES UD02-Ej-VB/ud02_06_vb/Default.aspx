<%@ Page Language="VB" AutoEventWireup="true" CodeFile="Default.aspx.vb" Inherits="_Default"  Debug="true"%>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head" runat="server">
    <title>Ejemplo(ASP05).-</title>
</head>
<body>
    <form id="miForm" runat="server">
    <div>
        Fecha de conexión:<asp:Label ID="Lfecha" runat="server" ></asp:Label><br />
        Hora de conexión:
        <asp:Label ID="Lhora" runat="server" ></asp:Label><br />
        Usuarios activos:
        <asp:Label ID="LusuariosOnline" runat="server"></asp:Label>
        <br />
        Usuario nº:<asp:Label ID="Lusuario" runat="server"></asp:Label>
    </div>
    </form>
</body>
</html>

