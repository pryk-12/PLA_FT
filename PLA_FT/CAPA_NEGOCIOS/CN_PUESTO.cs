using CAPA_DATOS;
using CAPA_ENTIDAD;
using System.Data;

namespace CAPA_NEGOCIOS
{
   public class CN_PUESTO
    {
        public static DataTable CONSULTAR(string condicion)
        {
            CD_PUESTO metodo = new CD_PUESTO();
            return metodo.CONSULTAR(condicion);
        }

        public static void INSERTAR(CE_PUESTO obj)
        {
            CD_PUESTO metodo = new CD_PUESTO();
            metodo.INSERTAR(obj);
        }

        public static void ACTUALIZAR(CE_PUESTO obj)
        {
            CD_PUESTO metodo = new CD_PUESTO();
            metodo.ACTUALIZAR(obj);
        }
    }
}
