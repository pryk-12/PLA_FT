using CAPA_ENTIDAD;
using CAPA_NEGOCIOS;
using System;

namespace CAPA_PRESENTACION.FORMULARIOS
{
    public partial class FRM_MANT_CANALES : CAPA_PRESENTACION.FORMULARIOS.FRM_PLANTILLA
    {
        public FRM_MANT_CANALES()
        {
            InitializeComponent();
            DG.AutoGenerateColumns = false;
        }

        public void CONSULTAR()
        {
            string CONDICION = "(ID_CANAL LIKE'%" + txt_buscar.Text + "%' OR DESCRIPCION LIKE'%" + txt_buscar.Text + "%')";
            DG.DataSource = CN_CANAL.CONSULTAR(CONDICION);
            lbl_total.Text = "Total de Registro(s):  " + DG.Rows.Count.ToString();
        }

        public void PASAR_DATOS()
        {
            if (DG.Rows.Count == 0)
            {
                return;
            }

            FRM_CANAL FRM = new FRM_CANAL();
            CE_CANAL CE = new CE_CANAL();
            CE.ID_CANAL = Convert.ToInt32(DG.Rows[DG.CurrentRow.Index].Cells["ID_CANAL"].Value.ToString());
            CE.DESCRIPCION = DG.Rows[DG.CurrentRow.Index].Cells["DESCRIPCION"].Value.ToString();
            CE.VALORACION = Convert.ToDouble(DG.Rows[DG.CurrentRow.Index].Cells["VALORACION"].Value.ToString());
            CE.NIVEL_RIESGO = DG.Rows[DG.CurrentRow.Index].Cells["NIVEL_RIESGO"].Value.ToString();
            CE.ESTADO = DG.Rows[DG.CurrentRow.Index].Cells["ESTADO"].Value.ToString();
            FRM.RECIBIR_DATOS(CE);
            FRM.ShowDialog();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            FRM_CANAL FRM = new FRM_CANAL();
            FRM.ShowDialog();
        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            CONSULTAR();
        }

        private void DG_DoubleClick(object sender, EventArgs e)
        {
            btn_editar.PerformClick();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            PASAR_DATOS();
        }

        private void FRM_MANT_CANALES_Load(object sender, EventArgs e)
        {
            CONSULTAR();
        }
    }
}
