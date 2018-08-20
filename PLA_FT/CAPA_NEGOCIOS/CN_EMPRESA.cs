using CAPA_DATOS;
using CAPA_ENTIDAD;
using System.Data;

namespace CAPA_NEGOCIOS
{
   public class CN_EMPRESA
    {
        public static DataTable CONSULTAR()
        {
            CD_EMPRESA metodo = new CD_EMPRESA();
            return metodo.CONSULTAR();
        }
        public static void ACTUALIZAR(CE_EMPRESA obj)
        {
            CD_EMPRESA metodo = new CD_EMPRESA();
            metodo.ACTUALIZAR(obj);
        }
    }
}
