using CAPA_DATOS;
using CAPA_ENTIDAD;
using System.Data;

namespace CAPA_NEGOCIOS
{
    public class CN_LISTA_DOCUMENTO
    {
        public static DataTable CONSULTAR(string condicion)
        {
            CD_LISTA_DOCUMENTO metodo = new CD_LISTA_DOCUMENTO();
            return metodo.CONSULTAR(condicion);
        }

        public static void INSERTAR(CE_LISTA_DOCUMENTO obj)
        {
            CD_LISTA_DOCUMENTO metodo = new CD_LISTA_DOCUMENTO();
            metodo.INSERTAR(obj);
        }

        public static void ACTUALIZAR(CE_LISTA_DOCUMENTO obj)
        {
            CD_LISTA_DOCUMENTO metodo = new CD_LISTA_DOCUMENTO();
            metodo.ACTUALIZAR(obj);
        }
    }
}
