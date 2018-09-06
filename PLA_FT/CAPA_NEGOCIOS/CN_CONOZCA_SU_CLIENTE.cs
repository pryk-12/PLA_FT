using CAPA_DATOS;
using CAPA_ENTIDAD;
using System.Data;

namespace CAPA_NEGOCIOS
{
   public class CN_CONOZCA_SU_CLIENTE
    {
        public static DataTable CONSULTAR(string condicion)
        {
            CD_CONOZCA_SU_CLIENTE metodo = new CD_CONOZCA_SU_CLIENTE();
            return metodo.CONSULTAR(condicion);
        }

        public static DataTable CONSULTAR_MAX()
        {
            CD_CONOZCA_SU_CLIENTE metodo = new CD_CONOZCA_SU_CLIENTE();
            return metodo.CONSULTAR_MAX();
        }

        public static DataTable CONSULTAR_REFERENCIAS_BANCARIAS(int ID)
        {
            CD_CONOZCA_SU_CLIENTE metodo = new CD_CONOZCA_SU_CLIENTE();
            return metodo.CONSULTAR_REFERENCIAS_BANCARIAS(ID);
        }

        public static DataTable CONSULTAR_REFERENCIAS_COMERCIALES(int ID)
        {
            CD_CONOZCA_SU_CLIENTE metodo = new CD_CONOZCA_SU_CLIENTE();
            return metodo.CONSULTAR_REFERENCIAS_COMERCIALES(ID);
        }

        public static DataTable CONSULTAR_REFERENCIAS_PERSONALES(int ID)
        {
            CD_CONOZCA_SU_CLIENTE metodo = new CD_CONOZCA_SU_CLIENTE();
            return metodo.CONSULTAR_REFERENCIAS_PERSONALES(ID);
        }

        public static DataTable CONSULTAR_LISTA_DOCUMENTOS(int ID)
        {
            CD_CONOZCA_SU_CLIENTE metodo = new CD_CONOZCA_SU_CLIENTE();
            return metodo.CONSULTAR_LISTA_DOCUMENTOS(ID);
        }
        public static void INSERTAR(CE_CONOZCA_SU_CLIENTE obj)
        {
            CD_CONOZCA_SU_CLIENTE metodo = new CD_CONOZCA_SU_CLIENTE();
            metodo.INSERTAR(obj);
        }

        public static void ACTUALIZAR(CE_CONOZCA_SU_CLIENTE obj)
        {
            CD_CONOZCA_SU_CLIENTE metodo = new CD_CONOZCA_SU_CLIENTE();
            metodo.ACTUALIZAR(obj);
        }

        public static void INSERTAR_REFERENCIAS_BANCARIAS(CE_CONOZCA_SU_CLIENTE obj)
        {
            CD_CONOZCA_SU_CLIENTE metodo = new CD_CONOZCA_SU_CLIENTE();
            metodo.INSERTAR_REFERENCIAS_BANCARIAS(obj);
        }

        public static void INSERTAR_REFERENCIAS_COMERCIALES(CE_CONOZCA_SU_CLIENTE obj)
        {
            CD_CONOZCA_SU_CLIENTE metodo = new CD_CONOZCA_SU_CLIENTE();
            metodo.INSERTAR_REFERENCIAS_COMERCIALES(obj);
        }

        public static void INSERTAR_REFERENCIAS_PERSONALES(CE_CONOZCA_SU_CLIENTE obj)
        {
            CD_CONOZCA_SU_CLIENTE metodo = new CD_CONOZCA_SU_CLIENTE();
            metodo.INSERTAR_REFERENCIAS_PERSONALES(obj);
        }

        public static void INSERTAR_LISTA_DOCUMENTO(CE_CONOZCA_SU_CLIENTE obj)
        {
            CD_CONOZCA_SU_CLIENTE metodo = new CD_CONOZCA_SU_CLIENTE();
            metodo.INSERTAR_LISTA_DOCUMENTO(obj);
        }

        public static void ELIMINAR_REFERENCIAS_BANCARIAS(int ID)
        {
            CD_CONOZCA_SU_CLIENTE metodo = new CD_CONOZCA_SU_CLIENTE();
            metodo.ELIMINAR_REFERENCIAS_BANCARIAS(ID);
        }

        public static void ELIMINAR_REFERENCIAS_COMERCIALES(int ID)
        {
            CD_CONOZCA_SU_CLIENTE metodo = new CD_CONOZCA_SU_CLIENTE();
            metodo.ELIMINAR_REFERENCIAS_COMERCIALES(ID);
        }

        public static void ELIMINAR_REFERENCIAS_PERSONALES(int ID)
        {
            CD_CONOZCA_SU_CLIENTE metodo = new CD_CONOZCA_SU_CLIENTE();
            metodo.ELIMINAR_REFERENCIAS_PERSONALES(ID);
        }

        public static void ELIMINAR_LISTA_DOCUMENTO(int ID)
        {
            CD_CONOZCA_SU_CLIENTE metodo = new CD_CONOZCA_SU_CLIENTE();
            metodo.ELIMINAR_LISTA_DOCUMENTO(ID);
        }
    }
}
