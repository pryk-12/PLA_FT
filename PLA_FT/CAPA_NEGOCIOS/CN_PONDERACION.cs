using CAPA_DATOS;
using CAPA_ENTIDAD;
using System.Data;

namespace CAPA_NEGOCIOS
{
    public class CN_PONDERACION
    {
        public static DataTable CONSULTAR(int ID_PONDERACION)
        {
            CD_PONDERACION metodo = new CD_PONDERACION();
            return metodo.CONSULTAR(ID_PONDERACION);
        }

        public static void ACTUALIZAR(CE_PONDERACION obj)
        {
            CD_PONDERACION metodo = new CD_PONDERACION();
            metodo.ACTUALIZAR(obj);
        }
    }
}
