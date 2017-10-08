Option Explicit Off
Partial Public Class _respuesta
    Inherits System.Web.UI.Page

    Private Shared todas As String = "TRWAGMYFPDXBNJZSQVHLCKE"

    Protected Sub Page_Load()
        Dim mensaje As String = " Letra del NIF ¡Incorrecta!"
        If Request.UrlReferrer.ToString.Contains("default.html") Then
            Dim metodo As String = Request.RequestType
            If (metodo = "GET") Then
                N = Request.QueryString("TBdniHtml")
                L = Request.QueryString("TBletraHtml").ToUpper()
            Else
                N = Request.Form("TBdniHtml")
                L = Request.Form("TBletraHtml").ToUpper()
            End If
            If (L.Length = 1) Then
                If (Okey(N, L(0))) Then mensaje = "Letra del NIF ¡Correcta!"
            End If
        Else
            mensaje = "Acceso prohibido"
        End If
        Lmensaje.Text = mensaje
    End Sub
        
    Public Shared Function Okey(ByVal n As String, ByVal l As Char) As Boolean
        ok = False
        Try
            l = Char.ToUpper(l)
            Dim Le As Char = todas(Int64.Parse(n) Mod 23)
            If (Le = l) Then ok = True
        Catch
        End Try
        Return ok
    End Function

End Class