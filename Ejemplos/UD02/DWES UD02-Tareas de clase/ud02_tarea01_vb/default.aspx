<%@ Page Language="VB" Debug="true" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>

<body>
    <form id="miForm" runat="server">
    <div>
        <h1>La tabla de multiplicar del 5</h1>
        <table style="margin-left:100px;background-color: #00FFFF; border: thin solid #000080">
        <% Dim i As Integer
            For i = 1 To 10 %>
                <tr>
                    <td><%= "5 x " & i%> </td>
                    <td><%= " = " %> </td>
                    <td style="font-weight: bolder;color: #0000FF;"><%= 5*i %> </td>
                </tr>
            <%Next%>
        </table>
     <br />
    </div>
    </form>
</body>
</html>
