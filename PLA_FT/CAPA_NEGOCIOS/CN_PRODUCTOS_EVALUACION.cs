using CAPA_DATOS;
using CAPA_ENTIDAD;
using System.Data;

namespace CAPA_NEGOCIOS
{
   public class CN_PRODUCTOS_EVALUACION
    {
        public static DataTable CONSULTAR(string condicion)
        {
            CD_PRODUCTO_EVALUACION metodo = new CD_PRODUCTO_EVALUACION();
            return metodo.CONSULTAR(condicion);
        }

        public static void INSERTAR(CE_PRODUCTO_EVALUACION obj)
        {
            CD_PRODUCTO_EVALUACION metodo = new CD_PRODUCTO_EVALUACION();
            metodo.INSERTAR(obj);
        }

        public static void ELIMINAR(int ID_EVALUACION)
        {
            CD_PRODUCTO_EVALUACION metodo = new CD_PRODUCTO_EVALUACION();
            metodo.ELIMINAR(ID_EVALUACION);
        }
    }
}
