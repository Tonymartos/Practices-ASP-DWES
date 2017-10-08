<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<%-- Diversas formas de retornar la página al servidor para su procesado.
    
     Por defecto, al hacer clic sobre un control asp:Button, la página se devuelve automáticamente al servidor.
     En el ejemplo, se ha asignado el mismo manejador al evento clic de todos los botones.
     El código de servidor detecta sobre cuál se ha hecho clic y se actúa en consecuencia.
     
     El control RadioButtonList no presenta una devolución automática de la página, esta se establece a través de su propiedad AutoPostBack (true).
     Cuando la página llega devuelta al servidor se ejecuta el método asociado a su evento OnSelectedIndexChanged.
               
     Al cambiar el valor del control CheckBox no se realiza una devolución automática, pero cuando otro control devuelve la página al servidor se ejecuta el manejador de eventos (ProcesarCheckBox) que se le ha asociado al evento OnCheckedChanged. 
     Siempre y cuando su valor fuera diferente al que tenía la última vez que se ejecutó la página en el servidor. 
--%>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
     <title>Ejemplo (ASP07).- </title>
</head>
<body>
    <form id="miform" runat="server">
    <div>
    <table>
         <tr>
            <td >Teléfono:</td>
            <td>
                <asp:TextBox ID="TBtelefono" runat="server" Columns="9" MaxLength="9"></asp:TextBox></td>
            <td ></td>
            <td></td>
         </tr>
         <tr>
            <td >Apellidos:</td>
            <td>
                <asp:TextBox ID="TBapellidos" runat="server" Columns="40" MaxLength="40"></asp:TextBox></td>
            <td>Nombre:</td>
            <td>
                <asp:TextBox ID="TBnombre" runat="server" Columns="20" MaxLength="20"></asp:TextBox></td>
         </tr>
         <tr>
            <td >Localidad:</td>
            <td>
                <asp:TextBox ID="TBlocalidad" runat="server" Columns="40" MaxLength="40"></asp:TextBox></td>
            <td>C.P.:</td>
            <td>
                <asp:TextBox ID="TBcPostal" runat="server" Columns="5" Enabled="False" MaxLength="5"></asp:TextBox></td>
         </tr>
         <tr>
            <td >Entregara vehículo:</td>
            <td>
                <asp:CheckBox ID="CBentrega" OnCheckedChanged="ProcesarCheckBox" runat="server" /></td>
            <td></td>
             <td></td>
         </tr>
         <tr>
            <td >Modelo:</td>
            <td>
                <asp:DropDownList ID="DDLmodelos" runat="server">
                    <asp:ListItem Value="a0">[Seleccione el modelo deseado]</asp:ListItem>
                    <asp:ListItem Value="a146">Alfa 146</asp:ListItem>
                    <asp:ListItem Value="a156">Alfa 156</asp:ListItem>
                    <asp:ListItem Value="aspider">Alfa Spider</asp:ListItem>
                </asp:DropDownList></td>
            <td></td>
            <td></td>
         </tr>
         <tr>
            <td ></td>
            <td></td>
            <td ></td>
            <td></td>
         </tr>
         <tr>
            <td >Forma de Pago:</td>
            <td>
                <asp:RadioButtonList ID="RBLmodopago" runat="server" OnSelectedIndexChanged="CambioRadioButton" AutoPostBack="True">
                    <asp:ListItem Selected="True">Contado</asp:ListItem>
                    <asp:ListItem>Finaciera</asp:ListItem>
                    <asp:ListItem>Banco</asp:ListItem>
                </asp:RadioButtonList></td>
            <td></td>
            <td></td>
         </tr>
         <tr>
            <td ></td>
            <td></td>
            <td ></td>
            <td>
                <asp:Button ID="BTreservar" runat="server" Text="Realizar reserva" Width="125px"  OnClick="ProcesarBotones"/></td>
         </tr>
         <tr>
            <td></td>
            <td></td>
            <td ></td>
            <td>
                <asp:Button ID="BTborrar" runat="server" Text="Nuevos datos" Width="125px" OnClick="ProcesarBotones" /></td>
         </tr>
         <tr>
             <td colspan="4">
                 Observaciones:</td>
         </tr>
         <tr>
             <td colspan="4">
                <asp:TextBox ID="TBobservaciones" runat="server" Columns="75" Height="200px" TextMode="MultiLine"></asp:TextBox></td>
         </tr>
         <tr>
            <td></td>
            <td></td>
            <td ></td>
            <td></td>
         </tr>
       </table>   
    </div>
    </form>
</body>
</html>
