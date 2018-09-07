
namespace CAPA_PRESENTACION.REPORTES
{
    public partial class REP_GRAFICO_CIRCULAR : DevExpress.XtraReports.UI.XtraReport
    {
        public REP_GRAFICO_CIRCULAR()
        {
            InitializeComponent();
            lbl_usuario.Text = CP_UTILIDADES.DATOS_USUARIO.USUARIO;
        }

    }
}
