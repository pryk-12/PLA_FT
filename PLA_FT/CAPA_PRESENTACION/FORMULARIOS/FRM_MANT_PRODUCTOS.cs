using CAPA_ENTIDAD;
using CAPA_NEGOCIOS;
using System;

namespace CAPA_PRESENTACION.FORMULARIOS
{
    public partial class FRM_MANT_PRODUCTOS : CAPA_PRESENTACION.FORMULARIOS.FRM_PLANTILLA
    {
        public FRM_MANT_PRODUCTOS()
        {
            InitializeComponent();
            DG.AutoGenerateColumns = false;
        }

        public void CONSULTAR()
        {
            string CONDICION = "(ID_PRODUCTO LIKE'%" + txt_buscar.Text + "%' OR DESCRIPCION LIKE'%" + txt_buscar.Text + "%')";
            DG.DataSource = CN_PRODUCTO.CONSULTAR(CONDICION);
            lbl_total.Text = "Total de Registro(s):  " + DG.Rows.Count.ToString();
        }

        public void PASAR_DATOS()
        {
            if (DG.Rows.Count == 0)
            {
                return;
            }

            FRM_PRODUCTO FRM = new FRM_PRODUCTO();
            CE_PRODUCTO CE = new CE_PRODUCTO();
            CE.ID_PRODUCTO = Convert.ToInt32(DG.Rows[DG.CurrentRow.Index].Cells["ID_PRODUCTO"].Value.ToString());
            CE.DESCRIPCION = DG.Rows[DG.CurrentRow.Index].Cells["DESCRIPCION"].Value.ToString();
            CE.VALORACION = Convert.ToDouble(DG.Rows[DG.CurrentRow.Index].Cells["VALORACION"].Value.ToString());
            CE.NIVEL_RIESGO = DG.Rows[DG.CurrentRow.Index].Cells["NIVEL_RIESGO"].Value.ToString();
            CE.ESTADO = DG.Rows[DG.CurrentRow.Index].Cells["ESTADO"].Value.ToString();
            FRM.RECIBIR_DATOS(CE);
            FRM.ShowDialog();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            FRM_PRODUCTO FRM = new FRM_PRODUCTO();
            FRM.ShowDialog();
        }


        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            PASAR_DATOS();
        }

        private void DG_DoubleClick(object sender, EventArgs e)
        {
            btn_editar.PerformClick();
        }

        private void FRM_MANT_PRODUCTOS_Load(object sender, EventArgs e)
        {
            CONSULTAR();
        }

        private void txt_buscar_TextChanged_1(object sender, EventArgs e)
        {
            CONSULTAR();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            PASAR_DATOS();
        }
    }
}
