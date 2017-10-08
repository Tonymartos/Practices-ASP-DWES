<%@ Page Language="VB" AutoEventWireup="true" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
    <script runat="server">
        Public Sub BTenviar_Click(sender As Object, e As EventArgs) Handles BTenviar.Click
            'Variables de cada valor de las Cajas de Texto
            Dim a As Double = TBuno.Text
            Dim b As Double = TBdos.Text
            Dim c As Double = TBtres.Text
            'Dim x = New ec2g (Double.Parse(TBuno.Text),Double.Parse(TBdos.Text),Double.Parse(TBtres.Text))
            'Instanciar objeto con sus respectivos valores a, b y c
            Dim x = New ec2g(a, b, c)

            'Realizar Verificacion del Boton Check para extraer el numero real
            If CBCheck.Checked = True Then
                Dim dreal = x.D
                If dreal >= 0 Then
                    borrarbotones()
                    resultadoxuno.Text = "x1=" & ec2g.Imprimir(x.x0, 2)
                    resultadoxdos.Text = "x2=" & ec2g.Imprimir(x.x1, 2)
                    BTvolver.Visible = True
                Else
                    borrarbotones()
                    Response.Write("Error: No se puede realizar la ecuación")
                    BTvolver.Visible = True
                End If
            Else
                borrarbotones()
                resultadoxuno.Text = "x1= " & ec2g.Imprimir(x.x0, 2)
                resultadoxdos.Text = "x2=" & ec2g.Imprimir(x.x1, 2)
            End If
        End Sub
        ' Gestion de errores nivel pagina
        Protected Sub Page_Error(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Error
            Dim miError As String
            Dim objErr As Exception = Server.GetLastError().GetBaseException()
            miError = "<h1><B>Error</B></h1><hr>" &
                      "<br><B>En     : </B>" & Request.Url.ToString() &
                      "<br><B>Mensaje: </B>" & objErr.Message.ToString() &
                      "<br><B>Controlado Por:</B> Page_Error"
            Response.Write(miError.ToString())
            Server.ClearError()
        End Sub

        Private Sub BTvolver_Click(sender As Object, e As EventArgs) Handles BTvolver.Click
            BTvolver.Visible = True
            Response.Redirect("Default.aspx")
        End Sub

        Protected Function borrarbotones() As Boolean
            TBuno.Visible = False
            Label1.Visible = False
            TBdos.Visible = False
            Label2.Visible = False
            TBtres.Visible = False
            Label3.Visible = False
            Label4.Visible = False
            CBCheck.Visible = False
            BTenviar.Visible = False
            BTvolver.Visible = True
        End Function
    </script>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="TBuno" runat="server" ></asp:TextBox>
        <asp:Label ID="Label1" runat="server" Text="Label" >X2+</asp:Label>
        <asp:TextBox ID="TBdos" runat="server"  ></asp:TextBox>
        <asp:Label ID="Label2" runat="server" Text="Label" >X+</asp:Label>
        <asp:TextBox ID="TBtres" runat="server" ></asp:TextBox>
        <asp:Label ID="Label3" runat="server" Text="Label" >=</asp:Label>
        <asp:Label ID="Label4" runat="server" Text="Label" >0</asp:Label>
        <br />
        <asp:CheckBox ID="CBCheck" Text="Solución real" runat="server" />
        <br />
        <asp:Button ID="BTenviar" runat="server" Text="Enviar"/>
        <br />
        <asp:Literal ID="resultadoxuno" runat="server"></asp:Literal>
        <br />
        <asp:Literal ID="resultadoxdos" runat="server"></asp:Literal>
        <br />
        <asp:Button ID="BTvolver" runat="server" Text="Volver" Visible="False"/>
    </div>
    </form>
</body>
</html>
