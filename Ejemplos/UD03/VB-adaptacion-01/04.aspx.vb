
Partial Class _Default
    Inherits System.Web.UI.Page

    Private Sub _Default_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim frase As String = "hola"
        RotarI(frase, 10)
        'RotarI(frase)
        'RotarI(frase)
        RotarI(frase)
        Response.Write(frase)
    End Sub

    Public Sub RotarI(ByRef cadena As String, ByVal veces As Int16)
        For i = 1 To veces
            RotarI(cadena)
        Next
    End Sub

    ' Aunque el contenido de un string es inmutable, algunas formas de alterarlos ...

    'Public Sub RotarI(ByRef cadena As String)
    '    Dim nueva As Char() = cadena.ToCharArray() ' Paso de String a Char()
    '    Dim aux As Char = nueva(0)
    '    For i = 1 To nueva.Length - 1
    '        nueva(i - 1) = nueva(i)
    '    Next
    '    nueva(nueva.Length - 1) = aux
    '    cadena = New String(nueva) ' Paso de Char[] a String
    'End Sub

    'Public Sub RotarI(ByRef cadena As String) ' Concatenando carácter a carácter
    '    Dim nueva As String = ""
    '    Dim aux As Char = cadena(0)
    '    For i = 1 To cadena.Length - 1
    '        nueva &= cadena(i)
    '    Next
    '    cadena = nueva & aux
    'End Sub

    Public Sub RotarI(ByRef cadena As String) ' Propiedades y métodos de la clase String
        cadena = cadena.Substring(1).PadRight(cadena.Length, cadena(0))
    End Sub

End Class
