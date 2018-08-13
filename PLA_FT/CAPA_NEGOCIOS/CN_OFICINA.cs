using CAPA_DATOS;
using CAPA_ENTIDAD;
using System.Data;

namespace CAPA_NEGOCIOS
{
    public class CN_OFICINA
    {
        public static DataTable CONSULTAR(string condicion)
        {
            CD_OFICINA metodo = new CD_OFICINA();
            return metodo.CONSULTAR(condicion);
        }

        public static void INSERTAR(CE_OFICINA obj)
        {
            CD_OFICINA metodo = new CD_OFICINA();
            metodo.INSERTAR(obj);
        }

        public static void ACTUALIZAR(CE_OFICINA obj)
        {
            CD_OFICINA metodo = new CD_OFICINA();
            metodo.ACTUALIZAR(obj);
        }
    }
}
