using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;

namespace Datos
{
    public class AccesoDatos_Transporte
    {
        public int insert(int id_transporte, int id_camion, int id_camionero, int id_paquete, string fecha, int id_provincia)
        {
            SqlCommand cmd = MetodosDatos.CrearComando();
            cmd.CommandText = "insert into dbo.transporte  (id_transporte, id_camion, id_camionero, id_paquete, fecha, id_provincia) values (@id_transporte, @id_camion, @id_camionero, @id_paquete, @fecha, @id_provincia)";

            cmd.Parameters.Add("@id_transporte", id_transporte);
            cmd.Parameters.Add("@id_camion", id_camion);
            cmd.Parameters.Add("@id_camionero", id_camionero);
            cmd.Parameters.Add("@id_paquete", id_paquete);
            cmd.Parameters.Add("@fecha", fecha);
            cmd.Parameters.Add("@id_provincia", id_provincia);

            return MetodosDatos.EjecutarComandoInsert(cmd);

        }

        public static DataTable Consultar(int id_transporte)
        {


            SqlCommand cmd = MetodosDatos.CrearComando();
            cmd.CommandText = "Select * from dbo.transporte WHERE id_transporte = @id_transporte";
            cmd.Parameters.Add("@id_transporte", id_transporte);

            return MetodosDatos.EjecutarComandoConsultar(cmd);

        }

        public int Modificar(int id_transporte, int id_camion, int id_camionero, int id_paquete, string fecha, int id_provincia)
        {
            SqlCommand cmd = MetodosDatos.CrearComando();
            cmd.CommandText = "update dbo.transporte  set  id_camion=@id_camion, id_camionero=@id_camionero  , id_paquete=@id_paquete, fecha=@fecha, id_provincia=@id_provincia where id_transporte = @id_transporte ";

            cmd.Parameters.Add("@id_transporte", id_transporte);
            cmd.Parameters.Add("@id_camion", id_camion);
            cmd.Parameters.Add("@id_camionero", id_camionero);
            cmd.Parameters.Add("@id_paquete", id_paquete);
            cmd.Parameters.Add("@fecha", fecha);
            cmd.Parameters.Add("@id_provincia", id_provincia);

            return MetodosDatos.EjecutarComandoInsert(cmd);

        }

        public int Eliminar(int id_transporte)
        {
            SqlCommand cmd = MetodosDatos.CrearComando();
            cmd.CommandText = "delete from dbo.transporte  where id_transporte = @id_transporte ";
            cmd.Parameters.Add("@id_transporte", id_transporte);
         

            return MetodosDatos.EjecutarComandoInsert(cmd);

        }
                
    }
}
