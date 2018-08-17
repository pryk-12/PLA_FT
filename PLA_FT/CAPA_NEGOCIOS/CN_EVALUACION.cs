using CAPA_DATOS;
using CAPA_ENTIDAD;
using System.Data;

namespace CAPA_NEGOCIOS
{
   public class CN_EVALUACION
    {
        public static DataTable CONSULTAR(string condicion)
        {
            CD_EVALUACION metodo = new CD_EVALUACION();
            return metodo.CONSULTAR(condicion);
        }

        public static DataTable CONSULTAR_MAX()
        {
            CD_EVALUACION metodo = new CD_EVALUACION();
            return metodo.CONSULTAR_MAX();
        }

        public static void INSERTAR(CE_EVALUACION obj)
        {
            CD_EVALUACION metodo = new CD_EVALUACION();
            metodo.INSERTAR(obj);
        }

        public static void ACTUALIZAR(CE_EVALUACION obj)
        {
            CD_EVALUACION metodo = new CD_EVALUACION();
            metodo.ACTUALIZAR(obj);
        }
    }
}
