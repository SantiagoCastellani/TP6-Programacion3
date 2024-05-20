<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MostrarProducto.aspx.cs" Inherits="TP6_GRUPO_5.Ejercicio2.MostrarProducto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style2 {
            margin-left: 80px;
        }
        .auto-style3 {
            margin-left: 120px;
        }
        .auto-style4 {
            margin-left: 40px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
        </div>
        <div class="auto-style2">
            <asp:GridView ID="gvSeleccionados" runat="server">
            </asp:GridView>
        </div>
        <div class="auto-style3">
            <br />
            <br />
        </div>
        <p class="auto-style4">
            <asp:Button ID="btnDeleteSession" runat="server" OnClick="btnDeleteSession_Click" Text="Eliminar Seleccionados" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Ejercicio2/Ejercicio2.aspx">Volver...</asp:HyperLink>
        </p>
        <p class="auto-style3">
            &nbsp;</p>
        <p class="auto-style3">
            &nbsp;</p>
    </form>
</body>
</html>
