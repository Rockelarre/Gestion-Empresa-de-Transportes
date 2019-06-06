using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Negocio;

namespace Presentacion
{
    public partial class mant_Transporte_1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn_guardar_Click(object sender, EventArgs e)
        {
            if (!Page.IsValid)
                return;

            int id_transporte = Convert.ToInt32(txt_id_transporte_0.Text);
            int id_camion = Convert.ToInt32(txt_id_camion_0.Text);
            int id_camionero = Convert.ToInt32(txt_id_camionero_0.Text);
            int id_paquete = Convert.ToInt32(txt_id_paquete_0.Text);
            string fecha = txt_fecha_0.Text;
            int id_provincia = Convert.ToInt32(txt_id_provincia_0.Text);

            log_Transporte negocio = new log_Transporte();
            int resultado = negocio.insert(id_transporte, id_camion, id_camionero, id_paquete, fecha, id_provincia);

            if (resultado > 0)
                lbl_msg_0.Text = "Registro agregado satisfactoriamente";
            else
                lbl_msg_0.Text = "el registro a ingresar ya existe";
            negocio = null;
        }

        protected void Btn_buscar_Click(object sender, EventArgs e)
        {
            int id_transporte = Convert.ToInt32(txt_id_transporte_0.Text);

            GridView1.DataSource = log_Transporte.Consultar(id_transporte);
            GridView1.DataBind();

            txt_id_transporte_0.Text = GridView1.Rows[0].Cells[0].Text;
            txt_id_camion_0.Text = GridView1.Rows[0].Cells[1].Text;
            txt_id_camionero_0.Text = GridView1.Rows[0].Cells[2].Text;
            txt_id_paquete_0.Text = GridView1.Rows[0].Cells[3].Text;
            txt_fecha_0.Text = GridView1.Rows[0].Cells[4].Text;
            txt_id_provincia_0.Text = GridView1.Rows[0].Cells[5].Text;

        }

        protected void Btn_actualizar_Click(object sender, EventArgs e)
        {
            int id_transporte = Convert.ToInt32(txt_id_transporte_0.Text);
            int id_camion = Convert.ToInt32(txt_id_camion_0.Text);
            int id_camionero = Convert.ToInt32(txt_id_camionero_0.Text);
            int id_paquete = Convert.ToInt32(txt_id_paquete_0.Text);
            string fecha = txt_fecha_0.Text;
            int id_provincia = Convert.ToInt32(txt_id_provincia_0.Text);

            log_Transporte negocio = new log_Transporte();
            int resultado = negocio.Modificar(id_transporte, id_camion, id_camionero, id_paquete, fecha, id_provincia);

            if (resultado > 0)
                lbl_msg_0.Text = "Registro actualizado satisfactoriamente";
            else
                lbl_msg_0.Text = "el registro No se Actualizo";
            negocio = null;

        }

        protected void Btn_eliminar_0_Click(object sender, EventArgs e)
        {
            int id_transporte = Convert.ToInt32(txt_id_transporte_0.Text);

            log_Transporte negocio = new log_Transporte();
            int resultado = negocio.Eliminar(id_transporte);

            if (resultado > 0)
                lbl_msg_0.Text = "Registro se elimino satisfactoriamente";
            else
                lbl_msg_0.Text = "el registro No se elimino";
            negocio = null;
        }

        protected void btn_anterior_Click(object sender, EventArgs e)
        {
            Response.Redirect("mant_Camionero_1.aspx");
        }

        protected void btn_siguiente_Click(object sender, EventArgs e)
        {
            Response.Redirect("mant_Paquete_Transporte.aspx");
        }
    }
}