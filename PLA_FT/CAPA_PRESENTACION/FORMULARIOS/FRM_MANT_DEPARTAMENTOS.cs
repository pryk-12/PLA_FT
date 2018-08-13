using System;
using CAPA_NEGOCIOS;
using CAPA_ENTIDAD;

namespace CAPA_PRESENTACION.FORMULARIOS
{
    public partial class FRM_MANT_DEPARTAMENTOS : CAPA_PRESENTACION.FORMULARIOS.FRM_PLANTILLA
    {
        public FRM_MANT_DEPARTAMENTOS()
        {
            InitializeComponent();
            DG.AutoGenerateColumns = false;
        }

        public void CONSULTAR()
        {
            string CONDICION = "(A.ID_DEPARTAMENTO LIKE'%" + txt_buscar.Text + "%' OR B.DESCRIPCION LIKE'%" + txt_buscar.Text + "%' OR A.DESCRIPCION LIKE'%" + txt_buscar.Text + "%')";
            DG.DataSource = CN_DEPARTAMENTO.CONSULTAR(CONDICION);
            lbl_total.Text = "Total de Registro(s):  " + DG.Rows.Count.ToString();
        }

        public void PASAR_DATOS()
        {
            if (DG.Rows.Count == 0)
            {
                return;
            }

            FRM_DEPARTAMENTO FRM = new FRM_DEPARTAMENTO();
            CE_DEPARTAMENTO CE = new CE_DEPARTAMENTO();
            CE.ID_OFICINA = Convert.ToInt32(DG.Rows[DG.CurrentRow.Index].Cells["ID_OFICINA"].Value.ToString());
            CE.ID_DEPARTAMENTO = Convert.ToInt32(DG.Rows[DG.CurrentRow.Index].Cells["ID_DEPARTAMENTO"].Value.ToString());
            CE.DESCRIPCION = DG.Rows[DG.CurrentRow.Index].Cells["DEPARTAMENTO"].Value.ToString();
            CE.ESTADO = DG.Rows[DG.CurrentRow.Index].Cells["ESTADO"].Value.ToString();
            FRM.RECIBIR_DATOS(CE);
            FRM.ShowDialog();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            FRM_DEPARTAMENTO FRM = new FRM_DEPARTAMENTO();
            FRM.ShowDialog();
        }

        private void FRM_MANT_DEPARTAMENTOS_Load(object sender, EventArgs e)
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
