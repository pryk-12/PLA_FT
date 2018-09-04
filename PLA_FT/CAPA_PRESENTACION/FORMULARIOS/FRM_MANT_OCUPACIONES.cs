using CAPA_ENTIDAD;
using CAPA_NEGOCIOS;
using System;

namespace CAPA_PRESENTACION.FORMULARIOS
{
    public partial class FRM_MANT_OCUPACIONES : CAPA_PRESENTACION.FORMULARIOS.FRM_PLANTILLA
    {
        public FRM_MANT_OCUPACIONES()
        {
            InitializeComponent();
            DG.AutoGenerateColumns = false;
        }

        public void CONSULTAR()
        {
            string CONDICION = "(ID_OCUPACION LIKE'%" + txt_buscar.Text + "%' OR DESCRIPCION LIKE'%" + txt_buscar.Text + "%')";
            DG.DataSource = CN_OCUPACION.CONSULTAR(CONDICION);
            lbl_total.Text = "Total de Registro(s):  " + DG.Rows.Count.ToString();
        }

        public void Permiso_Acceso_Panatallas()
        {
            String condicion = "USUARIO = '" + CP_UTILIDADES.DATOS_USUARIO.USUARIO + "' AND PANTALLA = 'Mantenimientos - Ocupaciones'";
            var Actividad_Economica = CN_PERMISO.CONSULTAR_PERMISO(condicion);
            btn_agregar.Enabled = Convert.ToBoolean(Actividad_Economica.Rows[0]["AGREGAR"].ToString()) == true ? true : false;
            btn_editar.Enabled = Convert.ToBoolean(Actividad_Economica.Rows[0]["EDITAR"].ToString()) == true ? true : false;
        }

        public void PASAR_DATOS()
        {
            if (DG.Rows.Count == 0)
            {
                return;
            }

            FRM_OCUPACION FRM = new FRM_OCUPACION();
            CE_OCUPACION CE = new CE_OCUPACION();
            CE.ID_OCUPACION = Convert.ToInt32(DG.Rows[DG.CurrentRow.Index].Cells["ID_OCUPACION"].Value.ToString());
            CE.DESCRIPCION = DG.Rows[DG.CurrentRow.Index].Cells["DESCRIPCION"].Value.ToString();
            CE.ESTADO = DG.Rows[DG.CurrentRow.Index].Cells["ESTADO"].Value.ToString();
            FRM.RECIBIR_DATOS(CE);
            FRM.ShowDialog();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            FRM_OCUPACION FRM = new FRM_OCUPACION();
            FRM.ShowDialog();
        }

        private void FRM_MANT_OCUPACIONES_Load(object sender, EventArgs e)
        {
            CONSULTAR();
            Permiso_Acceso_Panatallas();
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
    }
}
