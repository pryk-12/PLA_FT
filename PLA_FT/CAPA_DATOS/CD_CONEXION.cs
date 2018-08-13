using System.Configuration;

namespace CAPA_DATOS
{
    public class CD_CONEXION
    {
      public static string cadena_conexion = ConfigurationManager.ConnectionStrings["BD_PLA_FT"].ConnectionString;
    }
}
