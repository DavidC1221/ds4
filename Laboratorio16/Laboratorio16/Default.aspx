
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Laboratorio16._Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Laboratorio 16</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin:30px;">
            <asp:Label ID="lblMensaje" runat="server"
                Text="" Font-Size="XX-Large" ForeColor="Red"></asp:Label>
            <br /><br />
            <asp:Button ID="btnMensaje" runat="server" Text="Mostrar Mensaje"
                OnClick="btnMensaje_Click" />
        </div>
    </form>
</body>
</html>
