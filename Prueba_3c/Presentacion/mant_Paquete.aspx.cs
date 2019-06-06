using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Negocio;

namespace Presentacion
{
    public partial class mant_Paquete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_guardar_Click(object sender, EventArgs e)
        {
            if (!Page.IsValid)
                return;

            int id_paquete = Convert.ToInt32(txt_id_paquete_3.Text);
            string descripcion = txt_descripcion_3.Text;
            string destinatario = txt_destinatario_3.Text;
            string direccion_destino = txt_direccion_destino_3.Text;
            int id_camionero = Convert.ToInt32(txt_id_camionero_3.Text);
            int id_provincia = Convert.ToInt32(txt_id_provincia_3.Text);

            log_Paquete negocio = new log_Paquete();
            int resultado = negocio.insert(id_paquete, descripcion, destinatario, direccion_destino, id_camionero, id_provincia);

            if (resultado > 0)
                lbl_msg.Text = "Registro agregado satisfactoriamente";
            else
                lbl_msg.Text = "el registro a ingresar ya existe";
            negocio = null;
        }

        protected void Btn_buscar_Click(object sender, EventArgs e)
        {
            int id_paquete = Convert.ToInt32(txt_id_paquete_3.Text);

            GridView1.DataSource = log_Paquete.Consultar(id_paquete);
            GridView1.DataBind();

            txt_id_paquete_3.Text = GridView1.Rows[0].Cells[0].Text;
            txt_descripcion_3.Text = GridView1.Rows[0].Cells[1].Text;
            txt_destinatario_3.Text = GridView1.Rows[0].Cells[2].Text;
            txt_direccion_destino_3.Text = GridView1.Rows[0].Cells[3].Text;
            txt_id_camionero_3.Text = GridView1.Rows[0].Cells[4].Text;
            txt_id_provincia_3.Text = GridView1.Rows[0].Cells[5].Text;
        }

        protected void btn_actualizar_Click(object sender, EventArgs e)
        {
            int id_paquete = Convert.ToInt32(txt_id_paquete_3.Text);
            string descripcion = txt_descripcion_3.Text;
            string destinatario = txt_destinatario_3.Text;
            string direccion_destino = txt_direccion_destino_3.Text;
            int id_camionero = Convert.ToInt32(txt_id_camionero_3.Text);
            int id_provincia = Convert.ToInt32(txt_id_provincia_3.Text);

            log_Paquete negocio = new log_Paquete();
            int resultado = negocio.Modificar(id_paquete, descripcion, destinatario, direccion_destino, id_camionero, id_provincia);

            if (resultado > 0)
                lbl_msg.Text = "Registro actualizado satisfactoriamente";
            else
                lbl_msg.Text = "el registro No se Actualizo";
            negocio = null;
        }


        protected void btn_eliminar_Click(object sender, EventArgs e)
        {
            int id_paquete = Convert.ToInt32(txt_id_paquete_3.Text);

            log_Paquete negocio = new log_Paquete();
            int resultado = negocio.Eliminar(id_paquete);

            if (resultado > 0)
                lbl_msg.Text = "Registro se elimino satisfactoriamente";
            else
                lbl_msg.Text = "el registro No se elimino";
            negocio = null;
        }

        protected void btn_anterior_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://www.microsoft.com");
        }

        protected void btn_siguiente_Click(object sender, EventArgs e)
        {
            Response.Redirect("mant_Provincia.aspx");

        }
    }
}