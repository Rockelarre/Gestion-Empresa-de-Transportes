using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;

namespace Datos
{
    public class AccesoDatos_Paquete
    { 
        public int insert(int id_paquete, string descripcion, string destinatario, string direccion_destino, int id_camionero, int id_provincia)
        {
            SqlCommand cmd = MetodosDatos.CrearComando();
            cmd.CommandText = "insert into dbo.paquete  (id_paquete, descripcion, destinatario, direccion_destino, id_camionero, id_provincia) values (@id_paquete, @descripcion, @destinatario, @direccion_destino, @id_camionero, @id_provincia)";

            cmd.Parameters.Add("@id_paquete", id_paquete);
            cmd.Parameters.Add("@descripcion", descripcion);
            cmd.Parameters.Add("@destinatario", destinatario);
            cmd.Parameters.Add("@direccion_destino", direccion_destino);
            cmd.Parameters.Add("@id_camionero", id_camionero);
            cmd.Parameters.Add("@id_provincia", id_provincia);

            return MetodosDatos.EjecutarComandoInsert(cmd);

        }

        public static DataTable Consultar(int id_camionero)
        {


            SqlCommand cmd = MetodosDatos.CrearComando();
            cmd.CommandText = "Select * from dbo.paquete WHERE id_camionero = @id_camionero";
            cmd.Parameters.Add("@id_camionero", id_camionero);

            return MetodosDatos.EjecutarComandoConsultar(cmd);

        }

        public int Modificar(int id_paquete, string descripcion, string destinatario, string direccion_destino, int id_camionero, int id_provincia)
        {
            SqlCommand cmd = MetodosDatos.CrearComando();
            cmd.CommandText = "update dbo.paquete  set  descripcion=@descripcion  , destinatario=@destinatario, direccion_destino=@direccion_destino, id_camionero=@id_camionero, id_provincia=@id_provincia where id_paquete = @id_paquete ";

            cmd.Parameters.Add("@id_paquete", id_paquete);
            cmd.Parameters.Add("@descripcion", descripcion);
            cmd.Parameters.Add("@destinatario", destinatario);
            cmd.Parameters.Add("@direccion_destino", direccion_destino);
            cmd.Parameters.Add("@id_camionero", id_camionero);
            cmd.Parameters.Add("@id_provincia", id_provincia);

            return MetodosDatos.EjecutarComandoInsert(cmd);

        }

        public int Eliminar(int id_paquete)
        {
            SqlCommand cmd = MetodosDatos.CrearComando();
            cmd.CommandText = "delete from dbo.paquete  where id_paquete = @id_paquete ";
            cmd.Parameters.Add("@id_paquete", id_paquete);
         

            return MetodosDatos.EjecutarComandoInsert(cmd);

                        
        }
                
    }
}
