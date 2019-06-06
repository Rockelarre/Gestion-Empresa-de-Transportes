using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Datos;
using System.Data;

namespace Negocio
{
    public class log_Provincia
    {
        // insertar
        public int insert(int id_provincia, string nombre_provincia)
        {
            AccesoDatos_Provincia acceso = new AccesoDatos_Provincia();

            return acceso.insert(id_provincia, nombre_provincia);
        }
        
        public static DataTable Consultar(int id_provincia)
        {
            return AccesoDatos_Provincia.Consultar(id_provincia);
        }

        public int Modificar(int id_provincia, string nombre_provincia)
        {
            AccesoDatos_Provincia acceso = new AccesoDatos_Provincia();

            return acceso.Modificar(id_provincia, nombre_provincia);
        }


        public int Eliminar(int id_camion)
        {
            AccesoDatos_Provincia acceso = new AccesoDatos_Provincia();

            return acceso.Eliminar(id_camion);
        }
        
    }
}
