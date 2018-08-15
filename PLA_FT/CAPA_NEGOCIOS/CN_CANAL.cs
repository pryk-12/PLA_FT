using CAPA_DATOS;
using CAPA_ENTIDAD;
using System.Data;

namespace CAPA_NEGOCIOS
{
   public class CN_CANAL
    {
        public static DataTable CONSULTAR(string condicion)
        {
            CD_CANAL metodo = new CD_CANAL();
            return metodo.CONSULTAR(condicion);
        }

        public static void INSERTAR(CE_CANAL obj)
        {
            CD_CANAL metodo = new CD_CANAL();
            metodo.INSERTAR(obj);
        }

        public static void ACTUALIZAR(CE_CANAL obj)
        {
            CD_CANAL metodo = new CD_CANAL();
            metodo.ACTUALIZAR(obj);
        }
    }
}
