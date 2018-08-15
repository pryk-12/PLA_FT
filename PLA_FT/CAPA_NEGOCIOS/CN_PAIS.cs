using CAPA_DATOS;
using CAPA_ENTIDAD;
using System.Data;

namespace CAPA_NEGOCIOS
{
  public class CN_PAIS
    {
        public static DataTable CONSULTAR(string condicion)
        {
            CD_PAIS metodo = new CD_PAIS();
            return metodo.CONSULTAR(condicion);
        }

        public static void INSERTAR(CE_PAIS obj)
        {
            CD_PAIS metodo = new CD_PAIS();
            metodo.INSERTAR(obj);
        }

        public static void ACTUALIZAR(CE_PAIS obj)
        {
            CD_PAIS metodo = new CD_PAIS();
            metodo.ACTUALIZAR(obj);
        }
    }
}
