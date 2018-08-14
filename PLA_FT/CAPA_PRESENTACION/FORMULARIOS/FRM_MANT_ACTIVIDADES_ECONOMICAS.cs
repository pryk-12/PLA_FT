using CAPA_ENTIDAD;
using CAPA_NEGOCIOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CAPA_PRESENTACION.FORMULARIOS
{
    public partial class FRM_MANT_ACTIVIDADES_ECONOMICAS : CAPA_PRESENTACION.FORMULARIOS.FRM_PLANTILLA
    {
        public FRM_MANT_ACTIVIDADES_ECONOMICAS()
        {
            InitializeComponent();
            DG.AutoGenerateColumns = false;
        }
        public void CONSULTAR()
        {
            string CONDICION = "(ID_ACTIVIDAD LIKE'%" + txt_buscar.Text + "%' OR DESCRIPCION LIKE'%" + txt_buscar.Text + "%')";
            DG.DataSource = CN_ACTIVIDAD_ECONOMICA.CONSULTAR(CONDICION);
            lbl_total.Text = "Total de Registro(s):  " + DG.Rows.Count.ToString();
        }

        public void PASAR_DATOS()
        {
            if (DG.Rows.Count == 0)
            {
                return;
            }

            FRM_ACTIVIDAD_ECONOMICA FRM = new FRM_ACTIVIDAD_ECONOMICA();
            CE_ACTIVIDAD_ECONOMICA CE = new CE_ACTIVIDAD_ECONOMICA();
            CE.ID_ACTIVIDAD = Convert.ToInt32(DG.Rows[DG.CurrentRow.Index].Cells["ID_ACTIVIDAD"].Value.ToString());
            CE.DESCRIPCION = DG.Rows[DG.CurrentRow.Index].Cells["DESCRIPCION"].Value.ToString();
            CE.VALORACION = Convert.ToDouble(DG.Rows[DG.CurrentRow.Index].Cells["VALORACION"].Value.ToString());
            CE.NIVEL_RIESGO = DG.Rows[DG.CurrentRow.Index].Cells["NIVEL_RIESGO"].Value.ToString();
            CE.ESTADO = DG.Rows[DG.CurrentRow.Index].Cells["ESTADO"].Value.ToString();
            FRM.RECIBIR_DATOS(CE);
            FRM.ShowDialog();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            FRM_ACTIVIDAD_ECONOMICA FRM = new FRM_ACTIVIDAD_ECONOMICA();
            FRM.ShowDialog();
        }

        private void FRM_MANT_ACTIVIDADES_ECONOMICAS_Load(object sender, EventArgs e)
        {
            CONSULTAR();
        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            CONSULTAR();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            PASAR_DATOS();
        }

        private void DG_DoubleClick(object sender, EventArgs e)
        {
            btn_editar.PerformClick();
        }
    }
}
