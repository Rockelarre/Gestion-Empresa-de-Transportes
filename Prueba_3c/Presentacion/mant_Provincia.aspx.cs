using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Negocio;

namespace Presentacion
{
    public partial class mant_Provincia : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void Btn_buscar_Click(object sender, EventArgs e)
        {
            int id_provincia = Convert.ToInt32(txt_id_provincia_4.Text);

            GridView1.DataSource = log_Provincia.Consultar(id_provincia);
            GridView1.DataBind();

            txt_id_provincia_4.Text = GridView1.Rows[0].Cells[0].Text;
            txt_nombre_provincia_4.Text = GridView1.Rows[0].Cells[1].Text;

        }

        
        protected void btn_guardar_Click(object sender, EventArgs e)
        {
            if (!Page.IsValid)
                return;

            int id_provincia = Convert.ToInt32(txt_id_provincia_4.Text);
            string nombre_provincia = txt_nombre_provincia_4.Text;

            log_Provincia negocio = new log_Provincia();
            int resultado = negocio.insert(id_provincia, nombre_provincia);

            if (resultado > 0)
                lbl_msg.Text = "Registro agregado satisfactoriamente";
            else
                lbl_msg.Text = "el registro a ingresar ya existe";
            negocio = null;
        }

        protected void btn_actualizar_Click(object sender, EventArgs e)
        {
            int id_provincia = Convert.ToInt32(txt_id_provincia_4.Text);
            string nombre_provincia = txt_nombre_provincia_4.Text;

            log_Provincia negocio = new log_Provincia();
            int resultado = negocio.Modificar(id_provincia, nombre_provincia);

            if (resultado > 0)
                lbl_msg.Text = "Registro actualizado satisfactoriamente";
            else
                lbl_msg.Text = "el registro No se Actualizo";
            negocio = null;
        }

        protected void btn_eliminar_Click(object sender, EventArgs e)
        {
            int id_provincia = Convert.ToInt32(txt_id_provincia_4.Text);

            log_Provincia negocio = new log_Provincia();
            int resultado = negocio.Eliminar(id_provincia);

            if (resultado > 0)
                lbl_msg.Text = "Registro se elimino satisfactoriamente";
            else
                lbl_msg.Text = "el registro No se elimino";
            negocio = null;
        }

        protected void btn_anterior_Click(object sender, EventArgs e)
        {
            Response.Redirect("mant_Paquete.aspx");
        }

        protected void btn_siguiente_Click(object sender, EventArgs e)
        {
            Response.Redirect("mant_camion_1.aspx");
        }
    }
}