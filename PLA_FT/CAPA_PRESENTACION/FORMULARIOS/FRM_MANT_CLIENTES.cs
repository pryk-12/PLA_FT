using CAPA_ENTIDAD;
using CAPA_NEGOCIOS;
using System;

namespace CAPA_PRESENTACION.FORMULARIOS
{
    public partial class FRM_MANT_CLIENTES : CAPA_PRESENTACION.FORMULARIOS.FRM_PLANTILLA
    {
        public FRM_MANT_CLIENTES()
        {
            InitializeComponent();
            DG.AutoGenerateColumns = false;
        }

        public void CONSULTAR()
        {
            string CONDICION = "(A.ID_CLIENTE LIKE'%" + txt_buscar.Text + "%' OR A.NOMBRE LIKE'%" + txt_buscar.Text + "%' OR A.IDENTIFICACION LIKE'%" + txt_buscar.Text + "%' OR B.DESCRIPCION LIKE'%" + txt_buscar.Text + "%')";
            DG.DataSource = CN_CLIENTE.CONSULTAR(CONDICION);
            lbl_total.Text = "Total de Registro(s):  " + DG.Rows.Count.ToString();
        }

        public void Permiso_Acceso_Panatallas()
        {
            String condicion = "USUARIO = '" + CP_UTILIDADES.DATOS_USUARIO.USUARIO + "' AND PANTALLA = 'Mantenimientos - Clientes'";
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

            FRM_CLIENTE FRM = new FRM_CLIENTE();
            CE_CLIENTE CE = new CE_CLIENTE();
            CE.ID_CLIENTE = Convert.ToInt32(DG.Rows[DG.CurrentRow.Index].Cells["ID_CLIENTE"].Value.ToString());
            CE.NOMBRE = DG.Rows[DG.CurrentRow.Index].Cells["NOMBRE"].Value.ToString();
            CE.IDENTIFICACION = DG.Rows[DG.CurrentRow.Index].Cells["IDENTIFICACION"].Value.ToString();
            CE.ID_OFICINA = Convert.ToInt32(DG.Rows[DG.CurrentRow.Index].Cells["ID_OFICINA"].Value.ToString());
            CE.TIPO = DG.Rows[DG.CurrentRow.Index].Cells["TIPO"].Value.ToString();
            CE.ESTADO = DG.Rows[DG.CurrentRow.Index].Cells["ESTADO"].Value.ToString();
            FRM.RECIBIR_DATOS(CE);
            FRM.ShowDialog();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            FRM_CLIENTE FRM = new FRM_CLIENTE();
            FRM.ShowDialog();
        }

        private void FRM_MANT_CLIENTES_Load(object sender, EventArgs e)
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
