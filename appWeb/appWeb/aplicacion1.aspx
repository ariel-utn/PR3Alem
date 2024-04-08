<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="aplicacion1.aspx.cs" Inherits="appWeb.aplicacion1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblTexto" runat="server" Text="Ingrese su nombre" Font-Bold="True"></asp:Label>
    &nbsp;
        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
    &nbsp;
        <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" OnClick="btnAceptar_Click" />
        <br />
        <br />
        <asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>
