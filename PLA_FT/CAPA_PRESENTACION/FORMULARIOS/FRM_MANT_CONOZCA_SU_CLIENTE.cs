using CAPA_ENTIDAD;
using CAPA_NEGOCIOS;
using System;

namespace CAPA_PRESENTACION.FORMULARIOS
{
    public partial class FRM_MANT_CONOZCA_SU_CLIENTE : CAPA_PRESENTACION.FORMULARIOS.FRM_PLANTILLA
    {
        public FRM_MANT_CONOZCA_SU_CLIENTE()
        {
            InitializeComponent();
            DG.AutoGenerateColumns = false;
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            FRM_CONOZCA_SU_CLIENTE frm = new FRM_CONOZCA_SU_CLIENTE();
            frm.ShowDialog();
        }

        //public void Permiso_Acceso_Panatallas()
        //{
        //    String condicion = "USUARIO = '" + CP_UTILIDADES.DATOS_USUARIO.USUARIO + "' AND PANTALLA = 'Procesos - Evaluación de Riesgo'";
        //    var Actividad_Economica = CN_PERMISO.CONSULTAR_PERMISO(condicion);
        //    btn_agregar.Enabled = Convert.ToBoolean(Actividad_Economica.Rows[0]["AGREGAR"].ToString()) == true ? true : false;
        //    btn_editar.Enabled = Convert.ToBoolean(Actividad_Economica.Rows[0]["EDITAR"].ToString()) == true ? true : false;
        //}


        public void CONSULTAR()
        {
            string CONDICION = "(A.ID_CLIENTE LIKE'%" + txt_buscar.Text + "%' OR B.NOMBRES LIKE'%" + txt_buscar.Text + "%' OR B.APELLIDO_PAT LIKE'%" + txt_buscar.Text + "%' OR B.APELLIDO_MAT LIKE'%" + txt_buscar.Text + "%') ORDER BY A.ID_CONOZCA DESC";
            DG.DataSource = CN_CONOZCA_SU_CLIENTE .CONSULTAR(CONDICION);
            lbl_total.Text = "Total de Registro(s):  " + DG.Rows.Count.ToString();
        }

        public void PASAR_DATOS()
        {
            if (DG.Rows.Count == 0)
            {
                return;
            }

            FRM_CONOZCA_SU_CLIENTE FRM = new FRM_CONOZCA_SU_CLIENTE();
            CE_CONOZCA_SU_CLIENTE CE = new CE_CONOZCA_SU_CLIENTE();
            CE.ID_CONOZCA = Convert.ToInt32(DG.Rows[DG.CurrentRow.Index].Cells["ID_CONOZCA"].Value.ToString());
            
            FRM.RECIBIR_DATOS(CE);
            FRM.ShowDialog();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            PASAR_DATOS();
        }

        private void DG_DoubleClick(object sender, EventArgs e)
        {
            btn_editar.PerformClick();
        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            CONSULTAR();
        }

        private void FRM_MANT_CONOZCA_SU_CLIENTE_Load(object sender, EventArgs e)
        {
            CONSULTAR();
            //Permiso_Acceso_Panatallas();
        }
    }
}
