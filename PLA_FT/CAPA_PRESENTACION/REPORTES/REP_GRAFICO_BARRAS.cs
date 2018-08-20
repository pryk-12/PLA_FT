using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace CAPA_PRESENTACION.REPORTES
{
    public partial class REP_GRAFICO_BARRAS : DevExpress.XtraReports.UI.XtraReport
    {
        public REP_GRAFICO_BARRAS()
        {
            InitializeComponent();
            lbl_usuario.Text = CP_UTILIDADES.DATOS_USUARIO.USUARIO;
        }

    }
}
