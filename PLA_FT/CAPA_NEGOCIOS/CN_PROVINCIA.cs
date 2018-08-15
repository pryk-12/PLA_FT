using CAPA_DATOS;
using CAPA_ENTIDAD;
using System.Data;

namespace CAPA_NEGOCIOS
{
   public class CN_PROVINCIA
    {
        public static DataTable CONSULTAR(string condicion)
        {
            CD_PROVINCIA metodo = new CD_PROVINCIA();
            return metodo.CONSULTAR(condicion);
        }

        public static void INSERTAR(CE_PROVINCIA obj)
        {
            CD_PROVINCIA metodo = new CD_PROVINCIA();
            metodo.INSERTAR(obj);
        }

        public static void ACTUALIZAR(CE_PROVINCIA obj)
        {
            CD_PROVINCIA metodo = new CD_PROVINCIA();
            metodo.ACTUALIZAR(obj);
        }
    }
}
