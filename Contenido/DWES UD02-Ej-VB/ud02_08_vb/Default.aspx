<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html>

<html>
<head>
<title>Ejemplo(ASP08).-</title>
<script type="text/javascript" >
    
    function muevoraton()
    {
       alert('Aunque es un control de servidor, es posible asignarle código a eventos que se produce en el cliente como a onmouseover. En principio, no hay devolución de página ni interacción con el servidor.');
    }

    function hagoclic()
    {
        alert('Al elegir cualquier opción se está desencadenando la ejecución de este código en el navegador.');
        if (document.forms[0].RBLradioListASP[1].checked)
        {
          alert('El navegador ha detectado que ha seleccionado la segunda opción, esto provoca que se envíe la página al servidor.');
          document.forms[0].submit();
        }
        
    }
</script>
</head>
<body>
    <form id="miForm" runat="server">
       <table>
         <tr>
            <td >
                Control CheckBox:</td>
            <td>
                <asp:CheckBox ID="CBcasillaASP"  onmouseover="muevoraton();" runat="server" /></td>
            <td></td>
             <td></td>
         </tr>
         <tr>
            <td >
                Control RadioButtonList:</td>
            <td>
                <asp:RadioButtonList ID="RBLradioListASP" runat="server" onclick="hagoclic();">
                    <asp:ListItem>Contado</asp:ListItem>
                    <asp:ListItem>Finaciera</asp:ListItem>
                    <asp:ListItem>Banco</asp:ListItem>
                </asp:RadioButtonList></td>
            <td></td>
            <td></td>
         </tr>
         <tr>
            <td></td>
            <td></td>
            <td></td>
            <td>
                <asp:Button ID="BTbotonASP" runat="server" Text="Button ASP" Width="118px" OnClientClick="alert('Esto es un control de servidor (asp:Button), al hacer clic sobre él se devolverá la página al servidor, pero antes se ejecuta este código en el lado del cliente');" onclick="ProcesarBotonASP"/></td>
         </tr>
         <tr>
            <td></td>
            <td></td>
            <td></td>
            <td>
                <input id="botonHTML" type="button" onclick="alert('Esto es un boton HTML, al hacer clic el navegador ejecuta este código. No hay interacción con el servidor.');" value="Boton HTML" /></td>
         </tr>
       </table>   
    </form>
</body>
</html>
