using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Negocio;

namespace Presentacion
{
    public partial class mant_Camionero_1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_guardar_Click(object sender, EventArgs e)
        {
            if (!Page.IsValid)
                return;

            int id_camionero = Convert.ToInt32(txt_id_camionero_2.Text);
            string rut = txt_rut_2.Text;
            string nombre = txt_nombre_2.Text;
            string telefono = txt_telefono_2.Text;
            string direccion = txt_direccion_2.Text;
            string salario = txt_salario_2.Text;
            string poblacion = txt_poblacion_2.Text;

            log_Camionero negocio = new log_Camionero();
            int resultado = negocio.insert(id_camionero, rut, nombre, telefono, direccion, salario, poblacion);

            if (resultado > 0)
                lbl_msg.Text = "Registro agregado satisfactoriamente";
            else
                lbl_msg.Text = "el registro a ingresar ya existe";
            negocio = null;
        }

        protected void Btn_buscar_Click(object sender, EventArgs e)
        {
            int id_camionero = Convert.ToInt32(txt_id_camionero_2.Text);

            GridView1.DataSource = log_Camionero.Consultar(id_camionero);
            GridView1.DataBind();

            txt_id_camionero_2.Text = GridView1.Rows[0].Cells[0].Text;
            txt_rut_2.Text = GridView1.Rows[0].Cells[1].Text;
            txt_nombre_2.Text = GridView1.Rows[0].Cells[2].Text;
            txt_telefono_2.Text = GridView1.Rows[0].Cells[3].Text;
            txt_direccion_2.Text = GridView1.Rows[0].Cells[4].Text;
            txt_salario_2.Text = GridView1.Rows[0].Cells[5].Text;
            txt_poblacion_2.Text = GridView1.Rows[0].Cells[6].Text;
        }

        protected void btn_actualizar_Click(object sender, EventArgs e)
        {
            int id_camionero = Convert.ToInt32(txt_id_camionero_2.Text);
            string rut = txt_rut_2.Text;
            string nombre = txt_nombre_2.Text;
            string telefono = txt_telefono_2.Text;
            string direccion = txt_direccion_2.Text;
            string salario = txt_salario_2.Text;
            string poblacion = txt_poblacion_2.Text;

            log_Camionero negocio = new log_Camionero();
            int resultado = negocio.Modificar(id_camionero, rut, nombre, telefono, direccion, salario, poblacion);

            if (resultado > 0)
                lbl_msg.Text = "Registro actualizado satisfactoriamente";
            else
                lbl_msg.Text = "el registro No se Actualizo";
            negocio = null;
        }


        protected void btn_eliminar_Click(object sender, EventArgs e)
        {
            int id_camionero = Convert.ToInt32(txt_id_camionero_2.Text);

            log_Camionero negocio = new log_Camionero();
            int resultado = negocio.Eliminar(id_camionero);

            if (resultado > 0)
                lbl_msg.Text = "Registro se elimino satisfactoriamente";
            else
                lbl_msg.Text = "el registro No se elimino";
            negocio = null;
        }

        protected void btn_anterior_Click(object sender, EventArgs e)
        {
            Response.Redirect("mant_camion_1.aspx");
        }

        protected void btn_siguiente_Click(object sender, EventArgs e)
        {
            Response.Redirect("mant_Transporte_1.aspx");
        }
    }
}