<%@ Page Language="C#"   Debug ="true"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>UD02. Ejemplos</title>
</head>
<body>
    <!-- Recordamos la forma de escribir un comentario HTML -->
    <form id="unformulario" runat="server">
    <div>
        <%-- Inclusión de una línea de comentarios en el código de la página --%>
        <h1>La tabla de multiplicar del 5</h1>
        <%
            int i;
            // Comentario en código
            for(i=1;i<=10;i++)
            {
                Response.Write("5x" + i + "=" + 5 * i + "</br>");
            }
         %>
         <br />
         <asp:Label ID="Etiqueta1" runat="server">Tabla de multiplicar solicitada desde la dirección URL <%=  Request.Url.OriginalString %> </asp:Label>
         <br />
         <asp:Label ID="Etiqueta2" Text="Através del puerto:" runat="server"/><%= Request.Url.Port %>
    </div>
    </form>
</body>
</html>
