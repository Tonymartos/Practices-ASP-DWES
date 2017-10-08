<%@ Page Language="C#" AutoEventWireup="true"%>
<html>
<head>
    <title>UD02. Ejemplos</title>
</head>

<script runat="server" >
    protected void Page_Load()
    {
        if (IsPostBack)
        {
            PNpanel.Visible = false;
            Lmensaje.Text = "Su NIF es:" + Comprobar();
        }
    }

    bool Okey(string n,char l)
    {
        string todas = "TRWAGMYFPDXBNJZSQVHLCKE";
        bool ok = false;
        try
        {
            l = char.ToUpper(l);
            char Le = todas[int.Parse(n) % 23];
            if (Le == l) ok = true;
        }
        catch
        { }
        return ok;
    }

    string Comprobar()
    {
        string aviso = "incorrecto.";
        if (Okey(TBdni.Text, TBletra.Text.ToUpper()[0])) aviso = " correcto.";
        return aviso;
    }
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




