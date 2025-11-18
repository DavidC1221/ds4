
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Laboratorio16.WebForm1" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Calculadora Básica</title>
    <style type="text/css">
        body {
            background-color:dodgerblue;
        }
        #form1 {
            position:absolute;
            top:50px;
            left:50px;
        }
        .txtDisplay {
            width:280px;
            height:35px;
            font-size:25px;
            margin-bottom:10px;
        }
        .btnCalc {
            width:45px;
            height:35px;
            margin:1px;
        }
        .btnOp {
            width:45px;
            height:35px;
            margin:1px;
        }
        .btnClr {
            width:45px;
            height:35px;
            margin:1px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="CALCULADORA BASICA"
                Font-Size="XX-Large" ForeColor="White"></asp:Label>
            <br /><br />
            <asp:TextBox ID="txtDisplay" runat="server" CssClass="txtDisplay" ReadOnly="true"></asp:TextBox>
            <br />

            <!-- Fila 1 -->
            <asp:Button ID="b1" runat="server" Text="1" CssClass="btnCalc" OnClick="Digit_Click" />
            <asp:Button ID="b2" runat="server" Text="2" CssClass="btnCalc" OnClick="Digit_Click" />
            <asp:Button ID="b3" runat="server" Text="3" CssClass="btnCalc" OnClick="Digit_Click" />
            <asp:Button ID="b4" runat="server" Text="4" CssClass="btnCalc" OnClick="Digit_Click" />
            <asp:Button ID="b5" runat="server" Text="5" CssClass="btnCalc" OnClick="Digit_Click" />
            <asp:Button ID="b6" runat="server" Text="6" CssClass="btnCalc" OnClick="Digit_Click" />
            <asp:Button ID="btnClr" runat="server" Text="CLR" CssClass="btnClr" OnClick="btnClr_Click" />
            <br />

            <!-- Fila 2 -->
            <asp:Button ID="b7" runat="server" Text="7" CssClass="btnCalc" OnClick="Digit_Click" />
            <asp:Button ID="b8" runat="server" Text="8" CssClass="btnCalc" OnClick="Digit_Click" />
            <asp:Button ID="b9" runat="server" Text="9" CssClass="btnCalc" OnClick="Digit_Click" />
            <asp:Button ID="b0" runat="server" Text="0" CssClass="btnCalc" OnClick="Digit_Click" />
            <asp:Button ID="btnPlus" runat="server" Text="+" CssClass="btnOp" OnClick="Op_Click" />
            <asp:Button ID="btnMinus" runat="server" Text="-" CssClass="btnOp" OnClick="Op_Click" />
            <asp:Button ID="btnMul" runat="server" Text="*" CssClass="btnOp" OnClick="Op_Click" />
            <asp:Button ID="btnDiv" runat="server" Text="/" CssClass="btnOp" OnClick="Op_Click" />
            <br />

            <!-- Fila 3 -->
            <asp:Button ID="btnEq" runat="server" Text="=" CssClass="btnOp" OnClick="btnEq_Click" />
        </div>
    </form>
</body>
</html>
