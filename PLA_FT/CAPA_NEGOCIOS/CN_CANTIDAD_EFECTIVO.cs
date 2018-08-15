using CAPA_DATOS;
using CAPA_ENTIDAD;
using System.Data;

namespace CAPA_NEGOCIOS
{
   public class CN_CANTIDAD_EFECTIVO
    {
        public static DataTable CONSULTAR(string condicion)
        {
            CD_CANTIDAD_EFECTIVO metodo = new CD_CANTIDAD_EFECTIVO();
            return metodo.CONSULTAR(condicion);
        }

        public static void INSERTAR(CE_CANTIDAD_EFECTIVO obj)
        {
            CD_CANTIDAD_EFECTIVO metodo = new CD_CANTIDAD_EFECTIVO();
            metodo.INSERTAR(obj);
        }

        public static void ACTUALIZAR(CE_CANTIDAD_EFECTIVO obj)
        {
            CD_CANTIDAD_EFECTIVO metodo = new CD_CANTIDAD_EFECTIVO();
            metodo.ACTUALIZAR(obj);
        }
    }
}
