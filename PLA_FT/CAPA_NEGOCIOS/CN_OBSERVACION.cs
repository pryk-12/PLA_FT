using CAPA_DATOS;
using CAPA_ENTIDAD;
using System.Data;

namespace CAPA_NEGOCIOS
{
   public class CN_OBSERVACION
    {
        public static DataTable CONSULTAR(string condicion)
        {
            CD_OBSERVACION metodo = new CD_OBSERVACION();
            return metodo.CONSULTAR(condicion);
        }

        public static void INSERTAR(CE_OBSERVACION obj)
        {
            CD_OBSERVACION metodo = new CD_OBSERVACION();
            metodo.INSERTAR(obj);
        }
    }
}
