<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs"
    Inherits="Laboratorio201._Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Laboratorio 20-1 - Tabla de multiplicar</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Problema 1 - Tabla de multiplicar hasta 25</h2>

            <asp:Label ID="Label1" runat="server" Text="Número: "></asp:Label>
            <asp:TextBox ID="txtNumero" runat="server" Width="60"></asp:TextBox>

            <asp:Button ID="btnGenerar" runat="server" Text="Generar tabla"
                OnClick="btnGenerar_Click" />

            <br /><br />

            <asp:TextBox ID="txtResultado" runat="server" TextMode="MultiLine"
                Rows="15" Columns="40"></asp:TextBox>
        </div>
    </form>
</body>
</html>
