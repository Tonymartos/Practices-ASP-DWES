<%@ Page Language="VB" Debug="true" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>UD02. Ejemplos</title>
</head>
<body>
    <!-- Recordamos la forma de escribir un comentario HTML -->
    <form id="unFormulario" runat="server">
    <div>
      <%-- Inclusión de una línea de comentarios en el código de la página --%>
        <h1>La tabla de multiplicar del 5</h1>
        <% Dim i As Integer
            ' Comentario en código
            For i = 1 To 10
                Response.Write("5x" & i & "=" & 5 * i & "</br>")
            Next%>
     <br />
     <asp:Label ID="Etiqueta1" runat="server">Tabla de multiplicar solicitada desde la dirección URL <%= Request.Url.OriginalString  %> </asp:Label>
     <br />
     <asp:Label ID="Etiqueta2" Text="Através del puerto:" runat="server"/><%= Request.Url.Port %>
    </div>
    </form>
</body>
</html>
