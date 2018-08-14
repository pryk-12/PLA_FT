using CAPA_DATOS;
using CAPA_ENTIDAD;
using System.Data;

namespace CAPA_NEGOCIOS
{
    public class CN_USUARIO
    {
        public static DataTable CONSULTAR(string condicion)
        {
            CD_USUARIO metodo = new CD_USUARIO();
            return metodo.CONSULTAR(condicion);
        }

        public static void INSERTAR(CE_USUARIO obj)
        {
            CD_USUARIO metodo = new CD_USUARIO();
            metodo.INSERTAR(obj);
        }

        public static void ACTUALIZAR(CE_USUARIO obj)
        {
            CD_USUARIO metodo = new CD_USUARIO();
            metodo.ACTUALIZAR(obj);
        }

        public static void CAMBIAR_CLAVE(CE_USUARIO obj)
        {
            CD_USUARIO metodo = new CD_USUARIO();
            metodo.CAMBIAR_CLAVE(obj);
        }
    }
}
