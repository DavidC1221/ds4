
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Laboratorio17._Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Laboratorio 17 - CRUD Básico</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin:30px;">
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="True"
                AllowPaging="True" PageSize="10">
            </asp:GridView>

            <asp:SqlDataSource ID="SqlDataSource1" runat="server"
                ConnectionString="data source=CORDOBA;initial catalog=Northwind;persist security info=True;Integrated Security=SSPI;"
                ProviderName="System.Data.SqlClient"
                SelectCommand="SELECT [ProductName],[UnitPrice] FROM [Products]"
                UpdateCommand="UPDATE [Products] SET [ProductName]=@ProductName,[UnitPrice]=@UnitPrice WHERE [ProductName]=@original_ProductName"
                DeleteCommand="DELETE FROM [Products] WHERE [ProductName]=@ProductName">
                <UpdateParameters>
                    <asp:Parameter Name="ProductName" Type="String" />
                    <asp:Parameter Name="UnitPrice" Type="Decimal" />
                    <asp:Parameter Name="original_ProductName" Type="String" />
                </UpdateParameters>
                <DeleteParameters>
                    <asp:Parameter Name="ProductName" Type="String" />
                </DeleteParameters>
            </asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
