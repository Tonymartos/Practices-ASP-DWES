
Public Class Corriente : Inherits Cuenta

#Region "Campos"
    Private cLimite As Decimal ' cLimite=0 significa sin límite.
#End Region

#Region "Constructor"
    Public Sub New(ByVal numero As String, Optional saldoInicial As Decimal = 0, Optional ByVal limite As Decimal = 0)
        If Not (IsNumeric(limite) And limite >= 0) Then
            Throw New Exception("Error: Límite de la cuenta inadecuado")
        End If
        Init(numero, saldoInicial)
        cLimite = limite
    End Sub
#End Region

#Region "Propiedades"
    Public Property limite() As Decimal
        Get
            Return cLimite
        End Get
        Set(ByVal valor As Decimal)
            If Not (IsNumeric(valor) And valor >= 0) Then
                Throw New Exception("Error: Límite de la cuenta inadecuado")
            End If
            cLimite = valor
        End Set
    End Property
#End Region

#Region "Métodos"
    '''
    '''  Los reintegros están condicionados al límite y al saldo existente. cLimite=0 => sin límite de reintegro
    '''
    Public Overrides Sub Reintegro(ByVal cantidad As Decimal)
        If Not estado Then
            Throw New Exception("Error: Cuenta bloqueada")
        End If

        If Not (IsNumeric(cantidad) And cantidad > 0) Then
            Throw New Exception("Error: No es posible realizar la operación")
        Else
            If cantidad > cSaldo Or (cLimite <> 0 And cantidad > cLimite) Then
                Throw New Exception("Error: Saldo insuficiente")
            End If
        End If

        cSaldo -= Math.Round(cantidad, 2)
    End Sub

    Public Overrides Function ToString() As String
        Return "Saldo C. Corriente(" & numero & "):" & saldo.ToString("C2")
    End Function
#End Region

End Class
