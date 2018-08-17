using CAPA_DATOS;
using CAPA_ENTIDAD;
using System.Data;

namespace CAPA_NEGOCIOS
{
  public  class CN_CANALES_EVALUACION
    {
        public static DataTable CONSULTAR(string condicion)
        {
            CD_CANALES_EVALUACION metodo = new CD_CANALES_EVALUACION();
            return metodo.CONSULTAR(condicion);
        }

        public static void INSERTAR(CE_CANALES_EVALUACION obj)
        {
            CD_CANALES_EVALUACION metodo = new CD_CANALES_EVALUACION();
            metodo.INSERTAR(obj);
        }

        public static void ELIMINAR(int ID_EVALUACION)
        {
            CD_CANALES_EVALUACION metodo = new CD_CANALES_EVALUACION();
            metodo.ELIMINAR(ID_EVALUACION);
        }
    }
}
