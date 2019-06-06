<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="mant_Paquete.aspx.cs" Inherits="Presentacion.mant_Paquete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lbl_mant_paquete" runat="server" Text="MATENEDOR PAQUETE" Width="212px"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;
            <asp:Button ID="btn_siguiente" runat="server" OnClick="btn_siguiente_Click" Text="SIGUIENTE --&gt;" />
            <br />
            --------------------------------------------------------------<br />
            <br />
            <asp:Label ID="lbl_id_paquete_3" runat="server" Text="ID Paquete" Width="100px"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txt_id_paquete_3" runat="server" Width="100px" required="" type="number" min="1">1</asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Btn_buscar" runat="server" onclick="Btn_buscar_Click" Text="Buscar" />
            <br />
            <br />
            <asp:Label ID="lbl_producto" runat="server" Text="Descripción" Width="100px"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txt_descripcion_3" runat="server" Width="260px" required="">completar campo</asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Lbl_descripcion" runat="server" Text="Destinatario" Width="100px"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txt_destinatario_3" runat="server" Width="200px" required="">completar campo</asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Dirección Destino"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txt_direccion_destino_3" runat="server" Width="197px" required="">completar campo</asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="ID Camionero" ></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txt_id_camionero_3" runat="server" Width="99px" required="" type="number" min="1">1</asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="ID Provincia" ></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txt_id_provincia_3" runat="server" Width="95px" required="" type="number" min="1">1</asp:TextBox>
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            <br />
            <br />
            <br />
            <br />
            <asp:Button ID="btn_guardar" runat="server" onclick="btn_guardar_Click" Text="Guardar" />
            &nbsp;
            <asp:Button ID="btn_actualizar" runat="server" OnClick="btn_actualizar_Click" Text="Actualizar" />
            &nbsp;
            <asp:Button ID="Button1" runat="server" Text="Eliminar" OnClick="btn_eliminar_Click"/>
            <br />
            <br />
            <asp:Label ID="lbl_msg" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
