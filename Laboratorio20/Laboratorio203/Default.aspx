<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs"
    Inherits="Laboratorio203._Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Laboratorio 20-3 - CRUD Laptops (Productos)</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Problema 3 - CRUD de Laptops (Base de datos Productos)</h2>

            <table>
                <tr>
                    <td>Id:</td>
                    <td><asp:TextBox ID="txtId" runat="server" Width="100"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Nombre:</td>
                    <td><asp:TextBox ID="txtNombre" runat="server" Width="200"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Precio:</td>
                    <td><asp:TextBox ID="txtPrecio" runat="server" Width="100"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Stock:</td>
                    <td><asp:TextBox ID="txtStock" runat="server" Width="100"></asp:TextBox></td>
                </tr>
            </table>

            <br />

            <asp:Button ID="btnNuevo" runat="server" Text="Nuevo" OnClick="btnNuevo_Click" />
            <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
            <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" />
            <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" />
            <asp:Button ID="btnBuscar" runat="server" Text="Buscar por Id" OnClick="btnBuscar_Click" />

            <br /><br />

            <asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
