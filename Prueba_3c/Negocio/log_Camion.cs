using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Datos;
using System.Data;

namespace Negocio
{
    public class log_Camion
    {
        // insertar
        public int insert(int id_camion, string matricula, string modelo, string tipo, string potencia)
        {
            AccesoDatos_Camion acceso = new AccesoDatos_Camion();

            return acceso.insert(id_camion, matricula, modelo, tipo, potencia);
        }
        
        public static DataTable Consultar(int id_camion)
        {
            return AccesoDatos_Camion.Consultar(id_camion);
        }

        public int Modificar(int id_camion, string matricula, string modelo, string tipo, string potencia)
        {
            AccesoDatos_Camion acceso = new AccesoDatos_Camion();

            return acceso.Modificar(id_camion, matricula, modelo, tipo, potencia);
        }


        public int Eliminar(int id_camion)
        {
            AccesoDatos_Camion acceso = new AccesoDatos_Camion();

            return acceso.Eliminar(id_camion);
        }
        
    }
}
