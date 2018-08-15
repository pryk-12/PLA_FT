using CAPA_ENTIDAD;
using CAPA_NEGOCIOS;
using System;

namespace CAPA_PRESENTACION.FORMULARIOS
{
    public partial class FRM_MANT_PROVINCIAS : CAPA_PRESENTACION.FORMULARIOS.FRM_PLANTILLA
    {
        public FRM_MANT_PROVINCIAS()
        {
            InitializeComponent();
            DG.AutoGenerateColumns = false;
        }

        public void CONSULTAR()
        {
            string CONDICION = "(ID_PROVINCIA LIKE'%" + txt_buscar.Text + "%' OR DESCRIPCION LIKE'%" + txt_buscar.Text + "%')";
            DG.DataSource = CN_PROVINCIA.CONSULTAR(CONDICION);
            lbl_total.Text = "Total de Registro(s):  " + DG.Rows.Count.ToString();
        }

        public void PASAR_DATOS()
        {
            if (DG.Rows.Count == 0)
            {
                return;
            }

            FRM_PROVINCIA FRM = new FRM_PROVINCIA();
            CE_PROVINCIA CE = new CE_PROVINCIA();
            CE.ID_PROVINCIA = Convert.ToInt32(DG.Rows[DG.CurrentRow.Index].Cells["ID_PROVINCIA"].Value.ToString());
            CE.DESCRIPCION = DG.Rows[DG.CurrentRow.Index].Cells["DESCRIPCION"].Value.ToString();
            CE.VALORACION = Convert.ToDouble(DG.Rows[DG.CurrentRow.Index].Cells["VALORACION"].Value.ToString());
            CE.NIVEL_RIESGO = DG.Rows[DG.CurrentRow.Index].Cells["NIVEL_RIESGO"].Value.ToString();
            CE.ESTADO = DG.Rows[DG.CurrentRow.Index].Cells["ESTADO"].Value.ToString();
            FRM.RECIBIR_DATOS(CE);
            FRM.ShowDialog();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            FRM_PROVINCIA FRM = new FRM_PROVINCIA();
            FRM.ShowDialog();
        }

        private void FRM_MANT_PROVINCIAS_Load(object sender, EventArgs e)
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
