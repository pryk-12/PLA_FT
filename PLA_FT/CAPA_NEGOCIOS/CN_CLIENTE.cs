using CAPA_DATOS;
using CAPA_ENTIDAD;
using System.Data;

namespace CAPA_NEGOCIOS
{
   public class CN_CLIENTE
    {
        public static DataTable CONSULTAR(string condicion)
        {
            CD_CLIENTE metodo = new CD_CLIENTE();
            return metodo.CONSULTAR(condicion);
        }

        public static DataTable VISTA_CLIENTE(string condicion)
        {
            CD_CLIENTE metodo = new CD_CLIENTE();
            return metodo.VISTA_CLIENTE(condicion);
        }

        public static void INSERTAR(CE_CLIENTE obj)
        {
            CD_CLIENTE metodo = new CD_CLIENTE();
            metodo.INSERTAR(obj);
        }

        public static void ACTUALIZAR(CE_CLIENTE obj)
        {
            CD_CLIENTE metodo = new CD_CLIENTE();
            metodo.ACTUALIZAR(obj);
        }
    }
}
