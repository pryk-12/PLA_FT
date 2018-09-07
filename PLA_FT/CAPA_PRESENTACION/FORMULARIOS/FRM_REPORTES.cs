using DevExpress.XtraReports.UI;
using System;

namespace CAPA_PRESENTACION.FORMULARIOS
{
    public partial class FRM_REPORTES : CAPA_PRESENTACION.FORMULARIOS.FRM_PLANTILLA
    {
        public FRM_REPORTES()
        {
            InitializeComponent();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            string condicion = "";
            int id_evaluacion = txt_id_evaluacion.Text.Length == 0 ? 0 : Convert.ToInt32(txt_id_evaluacion.Text);
            int id_cliente = txt_id_cliente.Text.Length == 0 ? 0 : Convert.ToInt32(txt_id_cliente.Text);

            if (ch_incluir_fecha.Checked == true)
            {
                condicion = @"([ID_EVALUACION] = " + id_evaluacion + " OR 0 = " + id_evaluacion + @")
                          and ([ID_CLIENTE] = " + id_cliente + " OR 0 = " + id_cliente + @")
                          and ([FECHA] Between('" + dt_fecha1.Value.Date + "', '" + dt_fecha2.Value.Date + "'))";
            }
            else
            {
                condicion = @"([ID_EVALUACION] = " + id_evaluacion + " OR 0 = " + id_evaluacion + @")
                          and ([ID_CLIENTE] = " + id_cliente + " OR 0 = " + id_cliente + @")";
            }

            REPORTES.REP_LISTADO report = new REPORTES.REP_LISTADO();
            report.FilterString = condicion;
            ReportPrintTool tool = new ReportPrintTool(report);
            tool.ShowPreview();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CP_UTILIDADES.DATOS_USUARIO.OPCION = 1;
            FRM_CONSULTAR_CLIENTES FRM = new FRM_CONSULTAR_CLIENTES();
            FRM.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string condicion = "";
            int id_evaluacion = txt_id_evaluacion.Text.Length == 0 ? 0 : Convert.ToInt32(txt_id_evaluacion.Text);
            int id_cliente = txt_id_cliente.Text.Length == 0 ? 0 : Convert.ToInt32(txt_id_cliente.Text);

            if (ch_incluir_fecha.Checked == true)
            {
                condicion = @"([ID_EVALUACION] = " + id_evaluacion + " OR 0 = " + id_evaluacion + @")
                          and ([ID_CLIENTE] = " + id_cliente + " OR 0 = " + id_cliente + @")
                          and ([FECHA] Between('" + dt_fecha1.Value.Date + "', '" + dt_fecha2.Value.Date + "'))";
            }
            else
            {
                condicion = @"([ID_EVALUACION] = " + id_evaluacion + " OR 0 = " + id_evaluacion + @")
                          and ([ID_CLIENTE] = " + id_cliente + " OR 0 = " + id_cliente + @")";
            }

            REPORTES.REP_DETALLES report = new REPORTES.REP_DETALLES();
            report.FilterString = condicion;
            ReportPrintTool tool = new ReportPrintTool(report);
            tool.ShowPreview();
        }
    }
}
