using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Datos;
using System.Data;

namespace Negocio
{
    public class log_Paquete_Transporte
    {
        // insertar
        public int insert(int id_paquete, int id_transporte)
        {
            AccesoDatos_Paquete_Transporte acceso = new AccesoDatos_Paquete_Transporte();

            return acceso.insert(id_paquete, id_transporte);
        }
        
        public static DataTable Consultar(int id_paquete)
        {
            return AccesoDatos_Paquete_Transporte.Consultar(id_paquete);
        }

        public int Modificar(int id_paquete, int id_transporte)
        {
            AccesoDatos_Paquete_Transporte acceso = new AccesoDatos_Paquete_Transporte();
            return acceso.Modificar(id_paquete, id_transporte);
        }


        public int Eliminar(int id_paquete)
        {
            AccesoDatos_Paquete_Transporte acceso = new AccesoDatos_Paquete_Transporte();

            return acceso.Eliminar(id_paquete);
        }
        
    }
}
