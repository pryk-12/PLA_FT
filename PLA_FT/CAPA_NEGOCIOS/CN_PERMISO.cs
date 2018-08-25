using CAPA_DATOS;
using CAPA_ENTIDAD;
using System.Data;

namespace CAPA_NEGOCIOS
{
    public class CN_PERMISO
    {
        public static DataTable CONSULTAR_MENU()
        {
            CD_PERMISO metodo = new CD_PERMISO();
            return metodo.CONSULTAR_MENU();
        }

        public static DataTable CONSULTAR_PANTALLAS(string CONDICION)
        {
            CD_PERMISO metodo = new CD_PERMISO();
            return metodo.CONSULTAR_PANTALLAS(CONDICION);
        }

        public static DataTable CONSULTAR_PERMISO(string CONDICION)
        {
            CD_PERMISO metodo = new CD_PERMISO();
            return metodo.CONSULTAR_PERMISO(CONDICION);
        }

        public static DataTable CONSULTAR_PERMISO_MENU(string CONDICION)
        {
            CD_PERMISO metodo = new CD_PERMISO();
            return metodo.CONSULTAR_PERMISO_MENU(CONDICION);
        }

        public static void INSERTAR_MENU(CE_PERMISO obj)
        {
            CD_PERMISO metodo = new CD_PERMISO();
            metodo.INSERTAR_MENU(obj);
        }

        public static void INSERTAR_PERMISO(CE_PERMISO obj)
        {
            CD_PERMISO metodo = new CD_PERMISO();
            metodo.INSERTAR_PERMISO(obj);
        }
        public static void ELIMINAR_MENU(string USUARIO)
        {
            CD_PERMISO metodo = new CD_PERMISO();
            metodo.ELIMINAR_MENU(USUARIO);
        }

        public static void ELIMINAR_PERMISO(string USUARIO)
        {
            CD_PERMISO metodo = new CD_PERMISO();
            metodo.ELIMINAR_PERMISO(USUARIO);
        }
    }
}
