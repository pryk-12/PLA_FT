using CAPA_ENTIDAD;
using CAPA_NEGOCIOS;
using DevExpress.XtraReports.UI;
using System;
using System.Windows.Forms;
using System.Linq;
using System.Drawing;

namespace CAPA_PRESENTACION.FORMULARIOS
{
    public partial class FRM_MANT_EVALUACIONES : CAPA_PRESENTACION.FORMULARIOS.FRM_PLANTILLA
    {
        public FRM_MANT_EVALUACIONES()
        {
            InitializeComponent();
            DG.AutoGenerateColumns = false;
        }

        public void Permiso_Acceso_Panatallas()
        {
            String condicion = "USUARIO = '" + CP_UTILIDADES.DATOS_USUARIO.USUARIO + "' AND PANTALLA = 'Procesos - Evaluación de Riesgo'";
            var Actividad_Economica = CN_PERMISO.CONSULTAR_PERMISO(condicion);
            btn_agregar.Enabled = Convert.ToBoolean(Actividad_Economica.Rows[0]["AGREGAR"].ToString()) == true ? true : false;
            btn_editar.Enabled = Convert.ToBoolean(Actividad_Economica.Rows[0]["EDITAR"].ToString()) == true ? true : false;
        }


        public void CONSULTAR()
        {
            string CONDICION = "(A.ID_CLIENTE LIKE'%" + txt_buscar.Text + "%' OR B.NOMBRE LIKE'%" + txt_buscar.Text + "%') ORDER BY A.ID_EVALUACION DESC";
            DG.DataSource = CN_EVALUACION.CONSULTAR(CONDICION);
            lbl_total.Text = "Total de Registro(s):  " + DG.Rows.Count.ToString();

            lbl_fisico.Text = "Fisico: "+ Convert.ToDecimal(DG.Rows.Cast<DataGridViewRow>().Count(a => a.Cells["TIPO"].Value.ToString()=="FISICO"));
            lbl_juridico.Text = "Juridico: " + Convert.ToDecimal(DG.Rows.Cast<DataGridViewRow>().Count(a => a.Cells["TIPO"].Value.ToString() == "JURIDICO"));
            COLOR_FILAS();
        }
        public void COLOR_FILAS()
        {
            int alto = 0;
            int bajo = 0;
            int medio = 0;
            foreach (DataGridViewRow row in DG.Rows)
            {
                if (Convert.ToDecimal(row.Cells["VALOR_TOTAL"].Value.ToString()) <=30)
                {
                    row.DefaultCellStyle.BackColor = Color.Green;
                    bajo++;
                }
                else if(Convert.ToDecimal(row.Cells["VALOR_TOTAL"].Value.ToString()) > 30 && Convert.ToDecimal(row.Cells["VALOR_TOTAL"].Value.ToString()) <= 60)
                {
                    row.DefaultCellStyle.BackColor = Color.Orange;
                    medio++;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                    alto++;
                }
            }
            lbl_alto.Text = alto.ToString();
            lbl_bajo.Text = bajo.ToString();
            lbl_medio.Text = medio.ToString();

            DG.ClearSelection();
        }
         
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            FRM_EVALUACION FRM = new FRM_EVALUACION();
            FRM.ShowDialog();
        }

        private void FRM_MANT_EVALUACIONES_Load(object sender, EventArgs e)
        {
            CONSULTAR();
            Permiso_Acceso_Panatallas();
        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            CONSULTAR();
        }

        public void PASAR_DATOS()
        {
            if (DG.Rows.Count == 0)
            {
                return;
            }

            FRM_EVALUACION FRM = new FRM_EVALUACION();
            CE_EVALUACION CE = new CE_EVALUACION();
            CE.ID_ACTIVIDAD = Convert.ToInt32(DG.Rows[DG.CurrentRow.Index].Cells["ID_ACTIVIDAD"].Value.ToString());
            CE.ID_CANTIDAD = Convert.ToInt32(DG.Rows[DG.CurrentRow.Index].Cells["ID_CANTIDAD"].Value.ToString());
            CE.ID_CLIENTE = Convert.ToInt32(DG.Rows[DG.CurrentRow.Index].Cells["ID_CLIENTE"].Value.ToString());
            CE.ID_EVALUACION = Convert.ToInt32(DG.Rows[DG.CurrentRow.Index].Cells["ID_EVALUACION"].Value.ToString());
            CE.ID_NACIONALIDAD = Convert.ToInt32(DG.Rows[DG.CurrentRow.Index].Cells["ID_NACIONALIDAD"].Value.ToString());
            CE.ID_PAIS = Convert.ToInt32(DG.Rows[DG.CurrentRow.Index].Cells["ID_PAIS"].Value.ToString());
            CE.ID_PROVINCIA = Convert.ToInt32(DG.Rows[DG.CurrentRow.Index].Cells["ID_PROVINCIA"].Value.ToString());
            CE.ID_RECOMENDACION = Convert.ToInt32(DG.Rows[DG.CurrentRow.Index].Cells["ID_RECOMENDACION"].Value.ToString());
            CE.VALOR_ACTIVIDAD = Convert.ToDecimal(DG.Rows[DG.CurrentRow.Index].Cells["VALOR_ACTIVIDAD"].Value.ToString());
            CE.VALOR_CANAL = Convert.ToDecimal(DG.Rows[DG.CurrentRow.Index].Cells["VALOR_CANAL"].Value.ToString());
            CE.VALOR_CANTIDAD = Convert.ToDecimal(DG.Rows[DG.CurrentRow.Index].Cells["VALOR_CANTIDAD"].Value.ToString());
            CE.VALOR_NACIONALIDAD = Convert.ToDecimal(DG.Rows[DG.CurrentRow.Index].Cells["VALOR_NACIONALIDAD"].Value.ToString());
            CE.VALOR_PAIS = Convert.ToDecimal(DG.Rows[DG.CurrentRow.Index].Cells["VALOR_PAIS"].Value.ToString());
            CE.VALOR_PRODUCTO = Convert.ToDecimal(DG.Rows[DG.CurrentRow.Index].Cells["VALOR_PRODUCTO"].Value.ToString());
            CE.VALOR_PROVINCIA = Convert.ToDecimal(DG.Rows[DG.CurrentRow.Index].Cells["VALOR_PROVINCIA"].Value.ToString());
            CE.VALOR_TOTAL = Convert.ToDecimal(DG.Rows[DG.CurrentRow.Index].Cells["VALOR_TOTAL"].Value.ToString());

            FRM.RECIBIR_DATOS(CE);
            FRM.ShowDialog();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            PASAR_DATOS();
        }

        private void verObservaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(DG.RowCount==0)
            {
                return;
            }
            FRM_VER_OBSERVACIONES FRM = new FRM_VER_OBSERVACIONES();
            FRM.CARGAR_OBSERVACION( Convert.ToInt32(DG.SelectedCells[0].Value.ToString()));
            FRM.ShowDialog();
        }

        private void DG_DoubleClick(object sender, EventArgs e)
        {
            btn_editar.PerformClick();
        }

        private void reporteDeBarrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DG.RowCount == 0)
            {
                return;
            }
            string condicion = "";
            condicion = @"([ID_EVALUACION] =" + DG.SelectedCells[0].Value.ToString() +")";

            REPORTES.REP_GRAFICO_BARRAS report = new REPORTES.REP_GRAFICO_BARRAS();
            report.FilterString = condicion;
            ReportPrintTool tool = new ReportPrintTool(report);
            tool.ShowPreview();
        }

        private void reporteDePastelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DG.RowCount == 0)
            {
                return;
            }
            string condicion = "";
            condicion = @"([ID_EVALUACION] =" + DG.SelectedCells[0].Value.ToString() + ")";

            REPORTES.REP_GRAFICO_CIRCULAR report = new REPORTES.REP_GRAFICO_CIRCULAR();
            report.FilterString = condicion;
            ReportPrintTool tool = new ReportPrintTool(report);
            tool.ShowPreview();
        }

        private void FRM_MANT_EVALUACIONES_Activated(object sender, EventArgs e)
        {
            COLOR_FILAS();
        }
    }
}
