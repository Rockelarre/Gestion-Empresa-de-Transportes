<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="mant_Transporte_1.aspx.cs" Inherits="Presentacion.mant_Transporte_1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
    
            <asp:Label ID="lbl_mant_transporte" runat="server" Text="MANTENEDOR TRANSPORTE"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btn_anterior" runat="server" OnClick="btn_anterior_Click" Text="&lt;-- ANTERIOR" />
&nbsp;
            <asp:Button ID="btn_siguiente" runat="server" OnClick="btn_siguiente_Click" Text="SIGUIENTE --&gt;" />
            <br />
            ----------------------------------------------------<br />
    
        <br />
        ID Transporte&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txt_id_transporte_0" runat="server" Width="117px" required="" type="number" min="1">1</asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="btn_buscar_0" runat="server" onclick="Btn_buscar_Click" Text="Buscar" />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        ID Camión&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txt_id_camion_0" runat="server" Width="117px">completar campo</asp:TextBox>
            <br />
        <br />
        ID Camionero&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txt_id_camionero_0" runat="server" Width="119px">completar campo</asp:TextBox>
            <br />
        <br />
        ID Paquete&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
        <asp:TextBox ID="txt_id_paquete_0" runat="server">completar campo</asp:TextBox>
            <br />
        <br />
        Fecha&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txt_fecha_0" runat="server">completar campo</asp:TextBox>
            <br />
        <br />
        ID Provincia&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txt_id_provincia_0" runat="server">completar campo</asp:TextBox>
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
        <br />
        <br />
        <br />
        <asp:Button ID="btn_guardar_0" runat="server" onclick="Btn_guardar_Click" Text="Guardar" />
        &nbsp;
        <asp:Button ID="btn_actualizar_0" runat="server" OnClick="Btn_actualizar_Click" Text="Actualizar" />
        &nbsp;
        <asp:Button ID="btn_eliminar_0" runat="server" Text="Eliminar" OnClick="Btn_eliminar_0_Click" />
        <br />
        <br />
        <asp:Label ID="lbl_msg_0" runat="server"></asp:Label>
  
    
        </div>
    </form>
</body>
</html>
