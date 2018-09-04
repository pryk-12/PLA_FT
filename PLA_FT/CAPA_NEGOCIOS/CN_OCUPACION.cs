using CAPA_DATOS;
using CAPA_ENTIDAD;
using System.Data;

namespace CAPA_NEGOCIOS
{
   public class CN_OCUPACION
    {
        public static DataTable CONSULTAR(string condicion)
        {
            CD_OCUPACION metodo = new CD_OCUPACION();
            return metodo.CONSULTAR(condicion);
        }

        public static void INSERTAR(CE_OCUPACION obj)
        {
            CD_OCUPACION metodo = new CD_OCUPACION();
            metodo.INSERTAR(obj);
        }

        public static void ACTUALIZAR(CE_OCUPACION obj)
        {
            CD_OCUPACION metodo = new CD_OCUPACION();
            metodo.ACTUALIZAR(obj);
        }
    }
}
