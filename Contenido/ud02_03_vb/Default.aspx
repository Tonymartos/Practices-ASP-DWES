<%@ Page Language="vb"  AutoEventWireup="true"%>
<!-- AutoEventWireup... asignación directa entre el nombre del manejador(Vg. Page_Load) del evento 
     y los eventos Page (vg. Load) -->
<html>
<head>
    <title>UD02. Ejemplos</title>
</head>

<script runat="server" >

    'AutoEventWireup="false"
    'Protected Sub Al_Cargar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    '    If (IsPostBack) Then
    '        PNpanel.Visible = False
    '        Lmensaje.Text = "Su NIF es:" + Comprobar()
    '    End If
    'End Sub
    
    ''AutoEventWireup="true"
    Protected Sub Page_Load()
        If (IsPostBack) Then
            PNpanel.Visible = False
            Lmensaje.Text = "Su NIF es:" + Comprobar()
        End If
    End Sub
           
    Public Function Okey(ByVal n As String, ByVal l As Char) As Boolean
        Dim todas As String = "TRWAGMYFPDXBNJZSQVHLCKE"
        Dim ok As Boolean = False
        Try
            l = Char.ToUpper(l)
            Dim Le As Char = todas(Int64.Parse(n) Mod 23)
            If (Le = l) Then ok = True
        Catch
        End Try
        Return ok
    End Function
    
    Public Function Comprobar() As String
        Dim aviso As String = "incorrecto."
        If (Okey(TBdni.Text, TBletra.Text.ToUpper()(0))) Then aviso = " correcto."
        Return aviso
    End Function
    
</script>
<body>
    <form id="miForm" runat="server">
    <asp:Panel ID="PNpanel" runat="server" Height="29px" Width="327px">
        <asp:Label ID="L01" runat="server" Text="D.N.I:"></asp:Label>
        <asp:TextBox ID="TBdni" runat="server" Columns="8" MaxLength="8"></asp:TextBox>
        <asp:Label ID="L02" runat="server" Text="Letra:"></asp:Label>
        <asp:TextBox ID="TBletra" runat="server" Columns="1" MaxLength="1"></asp:TextBox>
        <asp:Button ID="BTaceptar" runat="server" Text="Verificar" />
   </asp:Panel><br />
   <asp:Label ID="Lmensaje" runat="server" Text=""></asp:Label></form>
</body>
</html>




