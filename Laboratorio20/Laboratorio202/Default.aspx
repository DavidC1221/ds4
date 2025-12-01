<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs"
    Inherits="Laboratorio202._Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Laboratorio 20-2 - Matriz N x N</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Problema 2 - Matriz N x N con diagonal inversa en 1</h2>

            <asp:Label ID="Label1" runat="server" Text="Valor de N: "></asp:Label>
            <asp:TextBox ID="txtN" runat="server" Width="60"></asp:TextBox>

            <asp:Button ID="btnGenerar" runat="server" Text="Generar matriz"
                OnClick="btnGenerar_Click" />

            <br /><br />

            <asp:Literal ID="ltMatriz" runat="server"></asp:Literal>
        </div>
    </form>
</body>
</html>
