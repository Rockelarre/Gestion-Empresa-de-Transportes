using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;

namespace Datos
{
    public class AccesoDatos_Paquete_Transporte
    {
        public int insert(int id_paquete, int id_transporte)
        {
            SqlCommand cmd = MetodosDatos.CrearComando();
            cmd.CommandText = "insert into dbo.paquete_transporte  (id_paquete, id_transporte) values (@id_paquete, @id_transporte)";

            cmd.Parameters.Add("@id_paquete", id_paquete);
            cmd.Parameters.Add("@id_transporte", id_transporte);

            return MetodosDatos.EjecutarComandoInsert(cmd);

        }

        public static DataTable Consultar(int id_paquete)
        {

            SqlCommand cmd = MetodosDatos.CrearComando();
            cmd.CommandText = "Select * from dbo.paquete_transporte WHERE id_paquete = @id_paquete";
            cmd.Parameters.Add("@id_paquete", id_paquete);

            return MetodosDatos.EjecutarComandoConsultar(cmd);

        }

        public int Modificar(int id_paquete, int id_transporte)
        {
            SqlCommand cmd = MetodosDatos.CrearComando();
            cmd.CommandText = "update dbo.paquete_transporte  set  id_paquete=@id_paquete, id_transporte=@id_transporte  where id_paquete = @id_paquete ";

            cmd.Parameters.Add("@id_paquete", id_paquete);
            cmd.Parameters.Add("@id_transporte", id_transporte);

            return MetodosDatos.EjecutarComandoInsert(cmd);

        }

        public int Eliminar(int id_paquete)
        {
            SqlCommand cmd = MetodosDatos.CrearComando();
            cmd.CommandText = "delete from dbo.paquete_transporte  where id_paquete = @id_paquete ";
            cmd.Parameters.Add("@id_paquete", id_paquete);
         

            return MetodosDatos.EjecutarComandoInsert(cmd);

        }
                
    }
}
