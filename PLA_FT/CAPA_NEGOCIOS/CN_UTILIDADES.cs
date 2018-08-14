using CAPA_DATOS;
using System.Windows.Forms;

namespace CAPA_NEGOCIOS
{
   public class CN_UTILIDADES
    {
       public static void LLENAR_COMBOBOX(ComboBox COMBO, string SP, string TABLA, string VALOR, string CODIGO, string CONDICION)
       {
           CD_UTILIDADES CD = new CD_UTILIDADES();
           CD.LLENAR_COMBOBOX(COMBO, SP, TABLA, VALOR, CODIGO, CONDICION);
       }

        public void CREAR_BACKUP()
        {
            CD_UTILIDADES CD = new CD_UTILIDADES();
            CD.CREAR_BACKUP();
        }
    }
}
