<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="mantenedor.aspx.cs" Inherits="Presentacion.mantenedor" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
        <asp:Label ID="lbl_id_producto" runat="server" Text="Id Producto" Width="100px"></asp:Label>
        <asp:TextBox ID="txt_id_producto" runat="server" Width="100px"></asp:TextBox>
        <br />
        <asp:Label ID="lbl_producto" runat="server" Text="Producto" Width="100px"></asp:Label>
        <asp:TextBox ID="txt_producto" runat="server" Width="150px"></asp:TextBox>
        <br />
        <asp:Label ID="Lbl_descripcion" runat="server" Text="Descripción" Width="100px"></asp:Label>
        <asp:TextBox ID="txt_descripcion" runat="server" Width="200px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btn_guardar" runat="server" onclick="btn_guardar_Click" 
            Text="Guardar" />
        <br />
        <br />
        <asp:Label ID="lbl_msg" runat="server"></asp:Label>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
