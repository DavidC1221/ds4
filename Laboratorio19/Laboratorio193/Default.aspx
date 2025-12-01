<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs"
    Inherits="Laboratorio193._Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Laboratorio 19-3 - Consumir API (por ID)</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Lab 19-3 - Obtener SOLO el elemento con ID especificado</h2>

            <asp:Label ID="Label1" runat="server" Text="ID a consultar: "></asp:Label>
            <asp:TextBox ID="txtId" runat="server" Text="2" Width="40"></asp:TextBox>

            <asp:Button ID="btnGetById" runat="server" Text="Llamar API (GET /items/{id})"
                OnClick="btnGetById_Click" />

            <br /><br />

            <asp:Label ID="lblResultado" runat="server" Text="Resultado:"></asp:Label>
            <br />
            <asp:TextBox ID="txtResultado" runat="server" TextMode="MultiLine"
                Rows="15" Columns="80"></asp:TextBox>
        </div>
    </form>
</body>
</html>
