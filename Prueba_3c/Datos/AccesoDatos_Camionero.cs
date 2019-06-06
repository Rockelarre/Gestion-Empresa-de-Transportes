using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;

namespace Datos
{
    public class AccesoDatos_Camionero
    {
        public int insert(int id_camionero, string rut, string nombre, string telefono, string direccion, string salario, string poblacion)
        {
            SqlCommand cmd = MetodosDatos.CrearComando();
            cmd.CommandText = "insert into dbo.camionero  (id_camionero, rut, nombre, telefono, direccion, salario, poblacion) values (@id_camionero, @rut, @nombre, @telefono, @direccion, @salario, @poblacion)";

            cmd.Parameters.Add("@id_camionero", id_camionero);
            cmd.Parameters.Add("@rut", rut);
            cmd.Parameters.Add("@nombre", nombre);
            cmd.Parameters.Add("@telefono", telefono);
            cmd.Parameters.Add("@direccion", direccion);
            cmd.Parameters.Add("@salario", salario);
            cmd.Parameters.Add("@poblacion", poblacion);

            return MetodosDatos.EjecutarComandoInsert(cmd);

        }

        public static DataTable Consultar(int id_camionero)
        {


            SqlCommand cmd = MetodosDatos.CrearComando();
            cmd.CommandText = "Select * from dbo.camionero WHERE id_camionero = @id_camionero";
            cmd.Parameters.Add("@id_camionero", id_camionero);

            return MetodosDatos.EjecutarComandoConsultar(cmd);

        }

        public int Modificar(int id_camionero, string rut, string nombre, string telefono, string direccion, string salario, string poblacion)
        {
            SqlCommand cmd = MetodosDatos.CrearComando();
            cmd.CommandText = "update dbo.camionero  set  id_camionero=@id_camionero, rut=@rut  , nombre=@nombre, telefono=@telefono, direccion=@direccion, salario=@salario, poblacion=@poblacion where id_camionero = @id_camionero ";

            cmd.Parameters.Add("@id_camionero", id_camionero);
            cmd.Parameters.Add("@rut", rut);
            cmd.Parameters.Add("@nombre", nombre);
            cmd.Parameters.Add("@telefono", telefono);
            cmd.Parameters.Add("@direccion", direccion);
            cmd.Parameters.Add("@salario", salario);
            cmd.Parameters.Add("@poblacion", poblacion);

            return MetodosDatos.EjecutarComandoInsert(cmd);

        }

        public int Eliminar(int id_camionero)
        {
            SqlCommand cmd = MetodosDatos.CrearComando();
            cmd.CommandText = "delete from dbo.camionero  where id_camionero = @id_camionero ";
            cmd.Parameters.Add("@id_camionero", id_camionero);
         

            return MetodosDatos.EjecutarComandoInsert(cmd);

        }
                
    }
}
