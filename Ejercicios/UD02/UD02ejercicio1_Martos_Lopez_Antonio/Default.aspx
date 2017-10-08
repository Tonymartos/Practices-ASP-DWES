<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
    <script runat="server">
        Private Sub BTenviar_Click(sender As Object, e As EventArgs) Handles BTenviar.Click
            Dim a As Double = TBuno.Text
            Dim b As Double = TBdos.Text
            Dim c As Double = TBtres.Text
            Dim x = New ec2g(a, b, c)

            resultadoxuno.Text = "x1= " & ec2g.Imprimir(x.x0, 3)
            resultadoxdos.Text = "x2=" & ec2g.Imprimir(x.x1, 3)
        End Sub
    </script>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="TBuno" runat="server"></asp:TextBox>
        <asp:Label ID="Label1" runat="server" Text="Label">X2+</asp:Label>
        <asp:TextBox ID="TBdos" runat="server"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" Text="Label">X+</asp:Label>
        <asp:TextBox ID="TBtres" runat="server"></asp:TextBox>
        <asp:Label ID="Label3" runat="server" Text="Label">=</asp:Label>
        <asp:Label ID="Label4" runat="server" Text="Label">0</asp:Label>
        <br />
        <asp:Button ID="BTenviar" runat="server" Text="Enviar" />
        <br />
        <asp:Literal ID="resultadoxuno" runat="server"></asp:Literal>
        <br />
        <asp:Literal ID="resultadoxdos" runat="server"></asp:Literal>
    </div>
    </form>
</body>
</html>
