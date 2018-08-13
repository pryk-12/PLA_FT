using CAPA_DATOS;
using CAPA_ENTIDAD;
using System.Data;

namespace CAPA_NEGOCIOS
{
   public class CN_DEPARTAMENTO
    {
        public static DataTable CONSULTAR(string condicion)
        {
            CD_DEPARTAMENTO metodo = new CD_DEPARTAMENTO();
            return metodo.CONSULTAR(condicion);
        }

        public static void INSERTAR(CE_DEPARTAMENTO obj)
        {
            CD_DEPARTAMENTO metodo = new CD_DEPARTAMENTO();
            metodo.INSERTAR(obj);
        }

        public static void ACTUALIZAR(CE_DEPARTAMENTO obj)
        {
            CD_DEPARTAMENTO metodo = new CD_DEPARTAMENTO();
            metodo.ACTUALIZAR(obj);
        }
    }
}
