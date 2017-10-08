
Public Class Cuenta

#Region "Campos"
    Private cNumero As String
    Private cApertura As Date
    Private cSaldo As Decimal
#End Region

#Region "Eventos"
    'Public Delegate Sub eReintegroManejador(ByVal c As Decimal, ByVal s As Decimal)
    'Public Event eReintegro As eReintegroManejador
    ' Versión reducida
    Public Event eReintegro(ByVal c As Decimal, ByVal s As Decimal)
#End Region

#Region "Propiedades implementadas automáticamente"
    Public Property estado() As Boolean = True
#End Region

#Region "Propiedades"
    Public ReadOnly Property numero() As String
        Get
            Return cNumero
        End Get
    End Property

    Public ReadOnly Property apertura() As Date
        Get
            Return cApertura
        End Get
    End Property

    Public ReadOnly Property saldo() As Decimal
        Get
            Return cSaldo
        End Get
    End Property
#End Region

#Region "Constructores"
    Public Sub New(ByVal numero As String, Optional ByVal saldoInicial As Decimal = 0.0)
        If Not Regex.IsMatch(numero, "^\d{10}$") Or saldoInicial < 0 Then
            Throw New Exception("Error: No es posible crear la cuenta")
        End If
        cNumero = numero
        cApertura = Date.Now.Date
        cSaldo = Math.Round(saldoInicial, 2)
    End Sub
#End Region

#Region "Métodos"
    Public Sub Ingreso(ByVal cantidad As Decimal)
        If Not estado Then
            Throw New Exception("Error: Cuenta bloqueada")
        End If

        If Not (IsNumeric(cantidad) And cantidad > 0) Then
            Throw New Exception("Error: No es posible realizar la operación")
        End If

        cSaldo += Math.Round(cantidad, 2)
    End Sub

    Public Sub Reintegro(ByVal cantidad As Decimal)
        If Not estado Then
            Throw New Exception("Error: Cuenta bloqueada")
        End If

        If Not (IsNumeric(cantidad) And cantidad > 0) Then
            Throw New Exception("Error: No es posible realizar la operación")
        End If

        If cantidad > cSaldo Then
            Throw New Exception("Error: Saldo insuficiente")
        End If

        cSaldo -= Math.Round(cantidad, 2)
        ' Se dispara el evento
        If cantidad > 500 Then RaiseEvent eReintegro(cantidad, cSaldo)

    End Sub

    Public Sub Traspaso(ByVal cantidad As Decimal, ByRef cuenta As Cuenta)
        Reintegro(cantidad)
        cuenta.Ingreso(cantidad)
    End Sub

    Public Overrides Function ToString() As String
        Return "Saldo(ccc-" & numero & "):" & saldo.ToString("C2")
    End Function
#End Region

End Class
