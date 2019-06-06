<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="mant_camion_1.aspx.cs" Inherits="Presentacion.mant_camion_1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            &nbsp;&nbsp;&nbsp;&nbsp; MANTENEDOR CAMIÓN&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btn_anterior" runat="server" OnClick="btn_anterior_Click" Text="&lt;-- ANTERIOR" />
&nbsp;
            <asp:Button ID="btn_siguiente" runat="server" OnClick="btn_siguiente_Click" Text="SIGUIENTE --&gt;" />
            <br />
            ---------------------------------------------------------------<br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp; ID Camión&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txt_id_camion_1" runat="server" Width="140px" required="" type="number" min="1">1</asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btn_buscar_0" runat="server" onclick="Btn_buscar_Click" Text="Buscar" />
            <br />
        <br />
            &nbsp;&nbsp;&nbsp;&nbsp; Matrícula&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txt_matricula_1" runat="server" Width="144px" required="">completar campo</asp:TextBox>
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp; Modelo&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txt_modelo_1" runat="server" Width="147px" required="">completar campo</asp:TextBox>
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp; Tipo&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txt_tipo_1" runat="server" Width="149px" required="">completar campo</asp:TextBox>
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp; Potencia&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txt_potencia_1" runat="server" Width="147px" required="">completar campo</asp:TextBox>
            <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
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
