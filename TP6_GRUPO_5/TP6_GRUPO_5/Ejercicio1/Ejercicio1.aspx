<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio1.aspx.cs" Inherits="TP6_GRUPO_5.Ejercicio1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 40px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="XX-Large" Text="Productos"></asp:Label>
            <br />
            <br />
        </div>
        <div class="auto-style1">
            <asp:GridView ID="gvProductos" runat="server">
            </asp:GridView>
        </div>
    </form>
</body>
</html>
