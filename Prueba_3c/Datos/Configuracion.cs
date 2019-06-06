using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Datos
{
   
   public class Configuracion
    {
       static string cadenaConexion = @"Data Source = DESKTOP-HEVRTCF; Initial Catalog=PRUEBA3; Trusted_Connection=True";

       public static string Cadena
       {
           get 
           { 
               return cadenaConexion; 
           }
       }
    }
}
