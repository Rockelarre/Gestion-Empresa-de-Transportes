using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Datos;
using System.Data;

namespace Negocio
{
    public class log_Paquete
    {
        // insertar
        public int insert(int id_paquete, string descripcion, string destinatario, string direccion_destino, int id_camionero, int id_provincia)
        {
            AccesoDatos_Paquete acceso = new AccesoDatos_Paquete();

            return acceso.insert(id_paquete, descripcion, destinatario, direccion_destino, id_camionero, id_provincia);
        }
        
        public static DataTable Consultar(int id_paquete)
        {
            return AccesoDatos_Paquete.Consultar(id_paquete);
        }

        public int Modificar(int id_paquete, string descripcion, string destinatario, string direccion_destino, int id_camionero, int id_provincia)
        {
            AccesoDatos_Paquete acceso = new AccesoDatos_Paquete();

            return acceso.Modificar(id_paquete, descripcion, destinatario, direccion_destino, id_camionero, id_provincia);
        }


        public int Eliminar(int id_paquete)
        {
            AccesoDatos_Paquete acceso = new AccesoDatos_Paquete();

            return acceso.Eliminar(id_paquete);

        }
        
    }
}
