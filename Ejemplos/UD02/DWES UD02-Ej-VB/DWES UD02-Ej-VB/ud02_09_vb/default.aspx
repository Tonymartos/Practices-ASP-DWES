<%@ Page Language="VB" AutoEventWireup="false" CodeFile="default.aspx.vb" Inherits="_default" debug="true"%>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>

<script type="text/javascript" >

    // A priori, se desconoce el nombre que van a tomar los controles ASP en su representación en el cliente,
    // deberíamos utilizar su propiedad clientID para referenciarlos.
    // Para determinar el algoritmo que se va a usar en la asignación de nombres de los controles, 
    // establecer la propiedad ClientIDMode del control.
    // Es posible utilizar como nombre en el cliente el mismo que se
    // le asigno en el servidor.
    // document.getElementById('TBgrados'), pero se recomienda usar clientID para evitar errores.

    function vacio() 
    {
        var grados = document.getElementById('<%= TBgrados.ClientID %>');

        if (grados.value==null || grados.value=='')
        {
            document.getElementById('<%= TBresultado.ClientID %>').value = '';
            document.getElementById('<%= TBtipo.ClientID %>').value = '';
            return false;
        }
        else
            return true;
    }
        
</script>

<body>
    <form id="miForm" runat="server">
    <div>
    
        <table>
            <tr>
                <td colspan="6">
                    <asp:Label ID="L1" runat="server" Text="Conversión de grados"/>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="TBgrados" runat="server" Width="64px"/>
                </td>
                <td>
                    <asp:Label ID="L2" runat="server" Text="grados " />
                </td>
                <td>
                    <asp:RadioButtonList ID="RBLtipo" runat="server">
                        <asp:ListItem Value="0" Selected="True">Celsius</asp:ListItem>
                        <asp:ListItem Value="1">Fahrenheits</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
                <td>
                    <asp:Label ID="L3" runat="server" Text="son " />
                </td>
                <td>
                    <!-- El resultado se presenta utilizando TextBox (los Label son representados como span). -->
                     <asp:Textbox ID="TBresultado" runat="server" Text="" BorderStyle="None" width="40px"
                          ReadOnly="True" style="text-align:right;"  />
                </td>
                <td>
                    <asp:Textbox ID="TBtipo" runat="server" Text="" BorderStyle="None" width="75px"
                         ReadOnly="True"  style=" text-align:left;" />
                </td>
            </tr>
            <tr>
                <td colspan="6">
                    <asp:Button ID="BTcalcular" runat="server" Text="Convertir" OnClientClick="return(vacio());" />
                </td>
            </tr>
        </table>
        <br />
    </div>
    </form>
</body>
</html>
