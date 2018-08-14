using CAPA_DATOS;
using CAPA_ENTIDAD;
using System.Data;

namespace CAPA_NEGOCIOS
{
  public  class CN_PRODUCTO
    {
        public static DataTable CONSULTAR(string condicion)
        {
            CD_PRODUCTO metodo = new CD_PRODUCTO();
            return metodo.CONSULTAR(condicion);
        }

        public static void INSERTAR(CE_PRODUCTO obj)
        {
            CD_PRODUCTO metodo = new CD_PRODUCTO();
            metodo.INSERTAR(obj);
        }

        public static void ACTUALIZAR(CE_PRODUCTO obj)
        {
            CD_PRODUCTO metodo = new CD_PRODUCTO();
            metodo.ACTUALIZAR(obj);
        }
    }
}
