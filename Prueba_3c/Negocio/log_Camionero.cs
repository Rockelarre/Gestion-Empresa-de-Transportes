using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Datos;
using System.Data;

namespace Negocio
{
    public class log_Camionero
    {
        // insertar
        public int insert(int id_camionero, string rut, string nombre, string telefono, string direccion, string salario, string poblacion)
        {
            AccesoDatos_Camionero acceso = new AccesoDatos_Camionero();

            return acceso.insert(id_camionero, rut, nombre, telefono, direccion, salario, poblacion);
        }
        
        public static DataTable Consultar(int id_camionero)
        {
            return AccesoDatos_Camionero.Consultar(id_camionero);
        }

        public int Modificar(int id_camionero, string rut, string nombre, string telefono, string direccion, string salario, string poblacion)
        {
            AccesoDatos_Camionero acceso = new AccesoDatos_Camionero();

            return acceso.Modificar(id_camionero, rut, nombre, telefono, direccion, salario, poblacion);
        }


        public int Eliminar(int id_camionero)
        {
            AccesoDatos_Camionero acceso = new AccesoDatos_Camionero();

            return acceso.Eliminar(id_camionero);
        }
        
    }
}
