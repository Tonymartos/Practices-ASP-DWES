Imports System.Net.Mail

Partial Class _Default
    Inherits System.Web.UI.Page

    Private Sub _Default_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Ejemplo de llamada.
        ' Se recuerda que una matriz de parámetros es declarada como opcional por defecto.

        EnviarEmail("godoyquilez@iesoretania.es", "Nuestro asunto", "Hola")

        EnviarEmail("godoyquilez@iesoretania.es", "Nuestro asunto", "Hola", "archivos\A.txt", "archivos\B.txt")
    End Sub

    Public Sub EnviarEmail(ByVal direccion As String, ByVal asunto As String, ByVal mensaje As String, ByVal ParamArray adjuntos() As String)
        If Not Regex.IsMatch(direccion, "^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$") Then
            Throw New System.Exception("La dirección de correo no tiene el formato adecuado")
        End If

        Dim origen As MailAddress = New MailAddress("iesoretania@gmail.com", "IES Oretania") ' La cuenta de correo no tiene que ser la misma que es utilizada en el cliente SMTP
        Dim destino As MailAddress = New MailAddress(direccion)

        Dim email As New MailMessage(origen, destino)
        email.Subject = asunto
        email.Body = mensaje

        Try
            Dim cliente As SmtpClient = New SmtpClient("smtp.gmail.com")
            cliente.Credentials = New System.Net.NetworkCredential("iesoretania@gmail.com", "password")
            cliente.Port = 587
            cliente.EnableSsl = True

            If adjuntos.Count <> 0 Then
                For Each archivo As String In adjuntos
                    ' Suponemos que los archivos adjuntos existen y están ubicados en las carpetas
                    ' especificadas. Esto implica que los parámetros se deben pasar convenientemente verificados.
                    email.Attachments.Add(New Attachment(archivo))
                Next
            End If
            cliente.Send(email)
        Catch ex As SystemException
            Throw New System.Exception(ex.Message)
        End Try
    End Sub

End Class
