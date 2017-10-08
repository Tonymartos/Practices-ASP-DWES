' La carpeta App_Code contiene código fuente para clases de utilidad y objetos comerciales
' (por ejemplo, archivos .cs, .vb, etc.) que debe compilar como parte de su aplicación.
' En una aplicación compilada de forma dinámica, ASP.NET compila el código en la carpeta
' App_Code en la solicitud inicial de su aplicación. Los elementos de esta carpeta se vuelven
' a compilar cuando se detecta cualquier cambio.

Option Explicit Off

Public Class NifVB
    Private Shared todas As String = "TRWAGMYFPDXBNJZSQVHLCKE"

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

    Public Shared Function Okey(ByVal n As String) As Boolean
        l = n(n.Length - 1)
        nu = n.Substring(0, n.Length - 1)
        Dim ok As Boolean = Okey(nu, l)
        Return ok
    End Function

End Class
