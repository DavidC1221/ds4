<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>
<!DOCTYPE html>
<html>
<body>
<form runat="server">
    <asp:TextBox ID="txtNum1" runat="server" />
    <asp:TextBox ID="txtNum2" runat="server" />
    <asp:Button ID="btnSumar" runat="server" Text="Sumar" OnClick="btnSumar_Click" />
    <asp:Label ID="lblResultado" runat="server" />
</form>
</body>
</html>
