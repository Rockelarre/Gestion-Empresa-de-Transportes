using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;

namespace Datos
{
    public class AccesoDatos_Provincia
    {
        public int insert(int id_provincia, string nombre_provincia)
        {
            SqlCommand cmd = MetodosDatos.CrearComando();
            cmd.CommandText = "insert into dbo.provincia  (id_provincia, nombre_provincia) values (@id_provincia, @nombre_provincia)";

            cmd.Parameters.Add("@id_provincia", id_provincia);
            cmd.Parameters.Add("@nombre_provincia", nombre_provincia);

            return MetodosDatos.EjecutarComandoInsert(cmd);

        }

        public static DataTable Consultar(int id_provincia)
        {

            SqlCommand cmd = MetodosDatos.CrearComando();
            cmd.CommandText = "Select * from dbo.provincia WHERE id_provincia = @id_provincia";
            cmd.Parameters.Add("@id_provincia", id_provincia);

            return MetodosDatos.EjecutarComandoConsultar(cmd);

        }

        public int Modificar(int id_provincia, string nombre_provincia)
        {
            SqlCommand cmd = MetodosDatos.CrearComando();
            cmd.CommandText = "update dbo.provincia  set  id_provincia=@id_provincia, nombre_provincia=@nombre_provincia  where id_provincia = @id_provincia ";

            cmd.Parameters.Add("@id_provincia", id_provincia);
            cmd.Parameters.Add("@nombre_provincia", nombre_provincia);

            return MetodosDatos.EjecutarComandoInsert(cmd);

        }

        public int Eliminar(int id_provincia)
        {
            SqlCommand cmd = MetodosDatos.CrearComando();
            cmd.CommandText = "delete from dbo.provincia  where id_provincia = @id_provincia ";
            cmd.Parameters.Add("@id_provincia", id_provincia);
         

            return MetodosDatos.EjecutarComandoInsert(cmd);

        }
                
    }
}
