using CAPA_DATOS;
using CAPA_ENTIDAD;
using System.Data;

namespace CAPA_NEGOCIOS
{
   public class CN_RECOMENDACION
    {
        public static DataTable CONSULTAR(string condicion)
        {
            CD_RECOMENDACION metodo = new CD_RECOMENDACION();
            return metodo.CONSULTAR(condicion);
        }

        public static void ACTUALIZAR(CE_RECOMENDACION obj)
        {
            CD_RECOMENDACION metodo = new CD_RECOMENDACION();
            metodo.ACTUALIZAR(obj);
        }
    }
}
