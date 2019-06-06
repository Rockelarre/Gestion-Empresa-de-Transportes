<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="mant_Paquete_Transporte.aspx.cs" Inherits="Presentacion.mant_Paquete_Transporte" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lbl_mant_prov" runat="server" Text="MANTENEDOR PAQUETE-TRANSPORTE" Width="319px"></asp:Label>
            <asp:Button ID="btn_anterior" runat="server" OnClick="btn_anterior_Click" Text="&lt;-- ANTERIOR" />
&nbsp;
            <br />
            --------------------------------------------------------------<br />
            <br />
            <br />
            <asp:Label ID="lbl_id_paquete" runat="server" Text="ID Paquete" Width="100px"></asp:Label>
            <asp:TextBox ID="txt_id_paquete_5" runat="server" Width="100px"  required="" type="number" min="1">1</asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Btn_buscar" runat="server" onclick="Btn_buscar_Click" Text="Buscar" />
            <br />
            <br />
            <asp:Label ID="lbl_id_transporte" runat="server" Text="ID Transporte" Width="100px"></asp:Label>
            <asp:TextBox ID="txt_transporte_5" runat="server" Width="99px"  required="" type="number" min="1">1</asp:TextBox>
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            <br />
            <br />
            <asp:Button ID="btn_guardar" runat="server" onclick="btn_guardar_Click" Text="Guardar" />
            &nbsp;
            <asp:Button ID="btn_actualizar" runat="server" OnClick="btn_actualizar_Click" Text="Actualizar" />
            &nbsp;
            <asp:Button ID="btn_eliminar" runat="server" OnClick="btn_eliminar_Click" Text="Eliminar" />
            <br />
            <br />
            <asp:Label ID="lbl_msg" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
