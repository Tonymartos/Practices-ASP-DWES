<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="miform" runat="server">
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
