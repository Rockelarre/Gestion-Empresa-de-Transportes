using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Datos;
using System.Data;

namespace Negocio
{
    public class log_Transporte
    {
        // insertar
        public int insert(int id_transporte, int id_camion, int id_camionero, int id_paquete, string fecha, int id_provincia)
        {
            AccesoDatos_Transporte acceso = new AccesoDatos_Transporte();

            return acceso.insert(id_transporte, id_camion, id_camionero, id_paquete, fecha, id_provincia);
        }
        
        public static DataTable Consultar(int id_transporte)
        {
            return AccesoDatos_Transporte.Consultar(id_transporte);
        }

        public int Modificar(int id_transporte, int id_camion, int id_camionero, int id_paquete, string fecha, int id_provincia)
        {
            AccesoDatos_Transporte acceso = new AccesoDatos_Transporte();

            return acceso.Modificar(id_transporte, id_camion, id_camionero, id_paquete, fecha, id_provincia);
        }


        public int Eliminar(int id_transporte)
        {
            AccesoDatos_Transporte acceso = new AccesoDatos_Transporte();

            return acceso.Eliminar(id_transporte);
        }
        
    }
}
