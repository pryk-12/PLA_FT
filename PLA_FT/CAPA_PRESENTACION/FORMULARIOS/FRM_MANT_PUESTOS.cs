using CAPA_ENTIDAD;
using CAPA_NEGOCIOS;
using System;

namespace CAPA_PRESENTACION.FORMULARIOS
{
    public partial class FRM_MANT_PUESTOS : CAPA_PRESENTACION.FORMULARIOS.FRM_PLANTILLA
    {
        public FRM_MANT_PUESTOS()
        {
            InitializeComponent();
            DG.AutoGenerateColumns = false;
        }

        public void CONSULTAR()
        {
            string CONDICION = "(C.DESCRIPCION LIKE'%" + txt_buscar.Text + "%' OR B.DESCRIPCION LIKE'%" + txt_buscar.Text + "%' OR A.ID_PUESTO LIKE'%"+ txt_buscar.Text +"%' OR A.DESCRIPCION LIKE'%" + txt_buscar.Text + "%')";
            DG.DataSource = CN_PUESTO.CONSULTAR(CONDICION);
            lbl_total.Text = "Total de Registro(s):  " + DG.Rows.Count.ToString();
        }

        public void PASAR_DATOS()
        {
            if (DG.Rows.Count == 0)
            {
                return;
            }

            FRM_PUESTO FRM = new FRM_PUESTO();
            CE_PUESTO CE = new CE_PUESTO();
            CE.ID_OFICINA = Convert.ToInt32(DG.Rows[DG.CurrentRow.Index].Cells["ID_OFICINA"].Value.ToString());
            CE.ID_DEPARTAMENTO = Convert.ToInt32(DG.Rows[DG.CurrentRow.Index].Cells["ID_DEPARTAMENTO"].Value.ToString());
            CE.ID_PUESTO = Convert.ToInt32(DG.Rows[DG.CurrentRow.Index].Cells["ID_PUESTO"].Value.ToString());
            CE.DESCRIPCION = DG.Rows[DG.CurrentRow.Index].Cells["PUESTO"].Value.ToString();
            CE.ESTADO = DG.Rows[DG.CurrentRow.Index].Cells["ESTADO"].Value.ToString();
            FRM.RECIBIR_DATOS(CE);
            FRM.ShowDialog();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            FRM_PUESTO FRM = new FRM_PUESTO();
            FRM.ShowDialog();
        }

        private void FRM_MANT_PUESTOS_Load(object sender, EventArgs e)
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
