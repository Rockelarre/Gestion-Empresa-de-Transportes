using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Negocio;

namespace Presentacion
{
    public partial class mantenedor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_guardar_Click(object sender, EventArgs e)
        {
            if (!Page.IsValid)
                return;
            
            int id_producto = Convert.ToInt32(txt_id_producto.Text);
            string producto =  txt_producto.Text;
            string descripcion = txt_descripcion.Text;
            
            Logica negocio = new Logica();
            int resultado = negocio.insert(id_producto, producto, descripcion);

            if (resultado > 0)
                lbl_msg.Text = "Registro agregado satisfactoriamente";
            else
                lbl_msg.Text = "el registro a ingresar ya existe";
            negocio = null;



        }
    }
}