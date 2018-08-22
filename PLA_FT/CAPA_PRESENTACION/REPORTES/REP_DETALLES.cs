using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace CAPA_PRESENTACION.REPORTES
{
    public partial class REP_DETALLES : DevExpress.XtraReports.UI.XtraReport
    {
        public REP_DETALLES()
        {
            InitializeComponent();
            lbl_usuario.Text = CP_UTILIDADES.DATOS_USUARIO.USUARIO;
        }

        private void cl_total_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            XRTableCell cell = sender as XRTableCell;
            decimal valor = Convert.ToInt32(GetCurrentColumnValue("VALOR_TOTAL"));
            if (valor <= 30)
            {
                cell.BackColor = Color.Red;
            }
            else if (valor > 30 && valor <= 60)
            {
                cell.BackColor = Color.Orange;
            }
            else
            {
                cell.BackColor = Color.Red;
            }
        }

    }
}
