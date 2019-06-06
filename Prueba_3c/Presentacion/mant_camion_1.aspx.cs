using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Negocio;

namespace Presentacion
{
    public partial class mant_camion_1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn_guardar_Click(object sender, EventArgs e)
        {
            if (!Page.IsValid)
                return;

            int id_camion = Convert.ToInt32(txt_id_camion_1.Text);
            string matricula = txt_matricula_1.Text;
            string modelo = txt_modelo_1.Text;
            string tipo = txt_tipo_1.Text;
            string potencia = txt_potencia_1.Text;

            log_Camion negocio = new log_Camion();
            int resultado = negocio.insert(id_camion, matricula, modelo, tipo, potencia);

            if (resultado > 0)
                lbl_msg_0.Text = "Registro agregado satisfactoriamente";
            else
                lbl_msg_0.Text = "el registro a ingresar ya existe";
            negocio = null;
        }

        protected void Btn_buscar_Click(object sender, EventArgs e)
        {
            int id_camion = Convert.ToInt32(txt_id_camion_1.Text);

            GridView1.DataSource = log_Camion.Consultar(id_camion);
            GridView1.DataBind();

            txt_id_camion_1.Text = GridView1.Rows[0].Cells[0].Text;
            txt_matricula_1.Text = GridView1.Rows[0].Cells[1].Text;
            txt_modelo_1.Text = GridView1.Rows[0].Cells[2].Text;
            txt_tipo_1.Text = GridView1.Rows[0].Cells[3].Text;
            txt_potencia_1.Text = GridView1.Rows[0].Cells[4].Text;

        }

        protected void Btn_actualizar_Click(object sender, EventArgs e)
        {
            int id_camion = Convert.ToInt32(txt_id_camion_1.Text);
            string matricula = txt_matricula_1.Text;
            string modelo = txt_modelo_1.Text;
            string tipo = txt_tipo_1.Text;
            string potencia = txt_potencia_1.Text;

            log_Camion negocio = new log_Camion();
            int resultado = negocio.Modificar(id_camion, matricula, modelo, tipo, potencia);

            if (resultado > 0)
                lbl_msg_0.Text = "Registro actualizado satisfactoriamente";
            else
                lbl_msg_0.Text = "el registro No se Actualizo";
            negocio = null;

        }

        protected void Btn_eliminar_0_Click(object sender, EventArgs e)
        {
            int id_camion = Convert.ToInt32(txt_id_camion_1.Text);

            log_Camion negocio = new log_Camion();
            int resultado = negocio.Eliminar(id_camion);

            if (resultado > 0)
                lbl_msg_0.Text = "Registro se elimino satisfactoriamente";
            else
                lbl_msg_0.Text = "el registro No se elimino";
            negocio = null;

        }

        protected void btn_anterior_Click(object sender, EventArgs e)
        {
            Response.Redirect("mant_Provincia.aspx");
        }

        protected void btn_siguiente_Click(object sender, EventArgs e)
        {
            Response.Redirect("mant_Camionero_1.aspx");
        }
    }
}