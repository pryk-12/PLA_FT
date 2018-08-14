using CAPA_DATOS;
using CAPA_ENTIDAD;
using System.Data;

namespace CAPA_NEGOCIOS
{
    public class CN_ACTIVIDAD_ECONOMICA
    {
        public static DataTable CONSULTAR(string condicion)
        {
            CD_ACTIVIDAD_ECONOMICA metodo = new CD_ACTIVIDAD_ECONOMICA();
            return metodo.CONSULTAR(condicion);
        }

        public static void INSERTAR(CE_ACTIVIDAD_ECONOMICA obj)
        {
            CD_ACTIVIDAD_ECONOMICA metodo = new CD_ACTIVIDAD_ECONOMICA();
            metodo.INSERTAR(obj);
        }

        public static void ACTUALIZAR(CE_ACTIVIDAD_ECONOMICA obj)
        {
            CD_ACTIVIDAD_ECONOMICA metodo = new CD_ACTIVIDAD_ECONOMICA();
            metodo.ACTUALIZAR(obj);
        }
    }
}
