<%@ Page Language="VB" Debug="true" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .estiloTabla
        {
             margin-left:100px;
             background-color:#00FFFF;
             border: thin solid #000080;
        }
</style>
</head>

<body>
    <form id="miForm" runat="server">
    <div>
        <asp:Label ID="Lcabecera" runat="server" Text="LA TABLA DE MULTIPLICAR" Font-Size ="XX-Large"/>
        <br />
        <asp:Label ID="Ltabla" runat="server" Text ="Calcular la tabla del: " />
        <asp:TextBox ID="TBnumero" runat="server"  size="10" />
        <br />
        <asp:Button ID="BTaceptar" runat="server" Text="Aceptar" />
        <br />
        <%
            If IsPostBack Then
                Response.Write("<table class='estiloTabla'>")
                Dim i As Integer
                Dim numero As String = TBnumero.Text
                For i = 1 To 10
                    Response.write("<tr>")
                    Response.Write("<td>" & numero & " x " & i & "</td>")
                    Response.Write("<td>=</td>")
                    Response.Write("<td style='font-weight: bolder;color: #0000FF;'>" & numero * i & "</td>")
                    Response.Write("</tr>")
                Next
                Response.Write("</table>")
            End If
        %>
    </div>
    </form>
</body>
</html>
