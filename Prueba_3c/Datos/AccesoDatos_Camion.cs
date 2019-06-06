using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;

namespace Datos
{
    public class AccesoDatos_Camion
    {
        public int insert(int id_camion, string matricula, string modelo, string tipo, string potencia)
        {
            SqlCommand cmd = MetodosDatos.CrearComando();
            cmd.CommandText = "insert into dbo.camion  (id_camion, matricula, modelo, tipo, potencia) values (@id_camion, @matricula, @modelo, @tipo, @potencia)";

            cmd.Parameters.Add("@id_camion", id_camion);
            cmd.Parameters.Add("@matricula", matricula);
            cmd.Parameters.Add("@modelo", modelo);
            cmd.Parameters.Add("@tipo", tipo);
            cmd.Parameters.Add("@potencia", potencia);

            return MetodosDatos.EjecutarComandoInsert(cmd);

        }

        public static DataTable Consultar(int id_camion)
        {


            SqlCommand cmd = MetodosDatos.CrearComando();
            cmd.CommandText = "Select * from dbo.camion WHERE id_camion = @id_camion";
            cmd.Parameters.Add("@id_camion", id_camion);

            return MetodosDatos.EjecutarComandoConsultar(cmd);

        }

        public int Modificar(int id_camion, string matricula, string modelo, string tipo, string potencia)
        {
            SqlCommand cmd = MetodosDatos.CrearComando();
            cmd.CommandText = "update dbo.camion  set  id_camion=@id_camion, matricula=@matricula  , modelo=@modelo, tipo=@tipo, potencia=@potencia where id_camion = @id_camion ";

            cmd.Parameters.Add("@id_camion", id_camion);
            cmd.Parameters.Add("@matricula", matricula);
            cmd.Parameters.Add("@modelo", modelo);
            cmd.Parameters.Add("@tipo", tipo);
            cmd.Parameters.Add("@potencia", potencia);

            return MetodosDatos.EjecutarComandoInsert(cmd);

        }

        public int Eliminar(int id_camion)
        {
            SqlCommand cmd = MetodosDatos.CrearComando();
            cmd.CommandText = "delete from dbo.camion  where id_camion = @id_camion ";
            cmd.Parameters.Add("@id_camion", id_camion);
         

            return MetodosDatos.EjecutarComandoInsert(cmd);

        }
                
    }
}
