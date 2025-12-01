<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs"
    Inherits="Laboratorio192._Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Laboratorio 19-2 - Consumir API (Todos)</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Lab 19-2 - Obtener TODOS los elementos desde Web API</h2>

            <asp:Button ID="btnGetAll" runat="server" Text="Llamar API (GET /items)"
                OnClick="btnGetAll_Click" />

            <br /><br />

            <asp:Label ID="lblResultado" runat="server" Text="Resultado:"></asp:Label>
            <br />
            <asp:TextBox ID="txtResultado" runat="server" TextMode="MultiLine"
                Rows="15" Columns="80"></asp:TextBox>
        </div>
    </form>
</body>
</html>
