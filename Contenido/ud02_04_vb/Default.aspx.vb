Option Explicit Off

Partial Public Class _Default
    Inherits System.Web.UI.Page

    Private Shared todas As String = "TRWAGMYFPDXBNJZSQVHLCKE"

    ' Manejador de evento asignado mediante Handles
    Protected Sub TBdni_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBdni.TextChanged
        PNpanel.Visible = False
        Lmensaje.Text = "Su NIF es: " + IIf(Okey(TBdni.Text), "Correcto", "Incorrecto")
    End Sub

    ' Manejador de evento asignado en la propiedad OnTextChanged de la etiqueta correspondiente del marcado aspx
    'Protected Sub TBdniCambio()
    '    PNpanel.Visible = False
    '    Lmensaje.Text = "Su NIF es: " + IIf(Okey(TBdni.Text), "Correcto", "Incorrecto")
    'End Sub

    Public Function Okey(ByVal n As String) As Boolean
        l = n(n.Length - 1)
        nu = n.Substring(0, n.Length - 1)
        Dim ok As Boolean = Okey(nu, l)
        Return ok
    End Function

    Public Function Okey(ByVal n As String, ByVal l As Char) As Boolean
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