using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Negocio;

namespace Presentacion
{
    public partial class mant_Paquete_Transporte : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_guardar_Click(object sender, EventArgs e)
        {
            if (!Page.IsValid)
                return;

            int id_paquete = Convert.ToInt32(txt_id_paquete_5.Text);
            int id_transporte = Convert.ToInt32(txt_transporte_5.Text);

            log_Paquete_Transporte negocio = new log_Paquete_Transporte();
            int resultado = negocio.insert(id_paquete, id_transporte);

            if (resultado > 0)
                lbl_msg.Text = "Registro agregado satisfactoriamente";
            else
                lbl_msg.Text = "el registro a ingresar ya existe";
            negocio = null;
        }

        protected void Btn_buscar_Click(object sender, EventArgs e)
        {
            int id_provincia = Convert.ToInt32(txt_id_paquete_5.Text);

            GridView1.DataSource = log_Paquete_Transporte.Consultar(id_provincia);
            GridView1.DataBind();

            txt_id_paquete_5.Text = GridView1.Rows[0].Cells[0].Text;
            txt_transporte_5.Text = GridView1.Rows[0].Cells[1].Text;
        }

        protected void btn_actualizar_Click(object sender, EventArgs e)
        {
            int id_paquete = Convert.ToInt32(txt_id_paquete_5.Text);
            int id_transporte = Convert.ToInt32(txt_transporte_5.Text);

            log_Paquete_Transporte negocio = new log_Paquete_Transporte();
            int resultado = negocio.Modificar(id_paquete, id_transporte);

            if (resultado > 0)
                lbl_msg.Text = "Registro actualizado satisfactoriamente";
            else
                lbl_msg.Text = "el registro No se Actualizo";
            negocio = null;
        }

        protected void btn_eliminar_Click(object sender, EventArgs e)
        {
            int id_paquete = Convert.ToInt32(txt_id_paquete_5.Text);

            log_Paquete_Transporte negocio = new log_Paquete_Transporte();
            int resultado = negocio.Eliminar(id_paquete);

            if (resultado > 0)
                lbl_msg.Text = "Registro se elimino satisfactoriamente";
            else
                lbl_msg.Text = "el registro No se elimino";
            negocio = null;
        }

        protected void btn_anterior_Click(object sender, EventArgs e)
        {
            Response.Redirect("mant_Transporte_1.aspx");
        }
                
    }
}