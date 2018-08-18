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
    public partial class FRM_MANT_EVALUACIONES : CAPA_PRESENTACION.FORMULARIOS.FRM_PLANTILLA
    {
        public FRM_MANT_EVALUACIONES()
        {
            InitializeComponent();
            DG.AutoGenerateColumns = false;
        }

        public void CONSULTAR()
        {
            string CONDICION = "(A.ID_CLIENTE LIKE'%" + txt_buscar.Text + "%' OR B.NOMBRE LIKE'%" + txt_buscar.Text + "%')";
            DG.DataSource = CN_EVALUACION.CONSULTAR(CONDICION);
            lbl_total.Text = "Total de Registro(s):  " + DG.Rows.Count.ToString();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            FRM_EVALUACION FRM = new FRM_EVALUACION();
            FRM.ShowDialog();
        }

        private void FRM_MANT_EVALUACIONES_Load(object sender, EventArgs e)
        {
            CONSULTAR();
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
    }
}
