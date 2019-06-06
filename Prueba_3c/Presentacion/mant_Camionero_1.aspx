<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="mant_Camionero_1.aspx.cs" Inherits="Presentacion.mant_Camionero_1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lbl_MANT_CAMIONERO" runat="server" Text="MANTENEDOR CAMIONERO" Width="254px"></asp:Label>
            &nbsp;
            <asp:Button ID="btn_anterior" runat="server" OnClick="btn_anterior_Click" Text="&lt;-- ANTERIOR" />
&nbsp;
            <asp:Button ID="btn_siguiente" runat="server" OnClick="btn_siguiente_Click" Text="SIGUIENTE --&gt;" />
            <br />
            ------------------------------------------------------------------<br />
            <br />
            <asp:Label ID="lbl_id_producto" runat="server" Text="ID Camionero" Width="100px"></asp:Label>
            <asp:TextBox ID="txt_id_camionero_2" runat="server" Width="100px" required="" type="number" min="1">1</asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btn_buscar" runat="server" onclick="Btn_buscar_Click" Text="Buscar" />
            <br />
            <br />
            <asp:Label ID="lbl_producto" runat="server" Text="RUT" Width="100px"></asp:Label>
            <asp:TextBox ID="txt_rut_2" runat="server" Width="150px" required="">completar campo</asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Lbl_descripcion" runat="server" Text="Nombre" Width="100px"></asp:Label>
            <asp:TextBox ID="txt_nombre_2" runat="server" Width="200px" required="">completar campo</asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Telefono"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txt_telefono_2" runat="server" required="">completar campo</asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Direccion"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txt_direccion_2" runat="server" required="">completar campo</asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Salario"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txt_salario_2" runat="server" required="">completar campo</asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="Poblacion">completar campo</asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txt_poblacion_2" runat="server" required="">completar campo</asp:TextBox>
            <br />
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            <br />
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
