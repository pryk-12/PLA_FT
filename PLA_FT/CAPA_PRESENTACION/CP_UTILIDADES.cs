using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Forms;
using System.Windows.Forms;

namespace CAPA_PRESENTACION
{
   public class CP_UTILIDADES
    {
        public void MENSAJE_INFORMACION(string mensaje, Form obj)
        {
            MetroFramework.MetroMessageBox.Show(obj,mensaje, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void MENSAJE_ERROR(string mensaje, Form obj)
        {
            MetroFramework.MetroMessageBox.Show(obj, mensaje, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
