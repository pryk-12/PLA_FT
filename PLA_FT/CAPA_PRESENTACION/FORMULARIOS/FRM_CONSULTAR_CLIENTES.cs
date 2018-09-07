using CAPA_NEGOCIOS;
using System;
using System.Windows.Forms;

namespace CAPA_PRESENTACION.FORMULARIOS
{
    public partial class FRM_CONSULTAR_CLIENTES : CAPA_PRESENTACION.FORMULARIOS.FRM_PLANTILLA
    {
        public FRM_CONSULTAR_CLIENTES()
        {
            InitializeComponent();
            DG.AutoGenerateColumns = false;
        }

        public void CONSULTAR()
        {
            string CONDICION = "(ID_CLIENTE LIKE'%" + txt_buscar.Text + "%' OR NOMBRES LIKE'%" + txt_buscar.Text + "%' OR IDENTIFICACION LIKE'%" + txt_buscar.Text + "%' OR OFICINA LIKE'%" + txt_buscar.Text + "%')";
            DG.DataSource = CN_CLIENTE.VISTA_CLIENTE(CONDICION);
            lbl_total.Text = "Total de Registro(s):  " + DG.Rows.Count.ToString();
        }

        private void lbl_total_Click(object sender, EventArgs e)
        {

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            FRM_EVALUACION FRM = new FRM_EVALUACION();
            FRM_REPORTES FRM_R = new FRM_REPORTES();
            FRM_CONOZCA_SU_CLIENTE FRM_C = new FRM_CONOZCA_SU_CLIENTE();

            foreach (Form frm in Application.OpenForms)
            {
                if(CP_UTILIDADES.DATOS_USUARIO.OPCION == 0)
                {
                    if (frm.Name == "FRM_EVALUACION")
                    {
                        FRM = (FRM_EVALUACION)frm;
                        FRM.txt_id_cliente.Text = DG.Rows[DG.CurrentRow.Index].Cells["ID_CLIENTE"].Value.ToString();
                        FRM.txt_nombre.Text = DG.Rows[DG.CurrentRow.Index].Cells["NOMBRES"].Value.ToString();
                        FRM.txt_identificacion.Text = DG.Rows[DG.CurrentRow.Index].Cells["IDENTIFICACION"].Value.ToString();
                        FRM.cb_oficina.Text = DG.Rows[DG.CurrentRow.Index].Cells["OFICINA"].Value.ToString();
                        FRM.cb_tipo.Text = DG.Rows[DG.CurrentRow.Index].Cells["TIPO_CLIENTE"].Value.ToString();
                        this.Close();
                        break;
                    }
                }
                if (CP_UTILIDADES.DATOS_USUARIO.OPCION == 1)
                {
                    if (frm.Name == "FRM_REPORTES")
                    {
                        FRM_R = (FRM_REPORTES)frm;
                        FRM_R.txt_id_cliente.Text = DG.Rows[DG.CurrentRow.Index].Cells["ID_CLIENTE"].Value.ToString();
                        FRM_R.txt_nombre_cliente.Text = DG.Rows[DG.CurrentRow.Index].Cells["NOMBRES"].Value.ToString();
                        this.Close();
                        break;
                    }
                }

                if (CP_UTILIDADES.DATOS_USUARIO.OPCION == 2)
                {
                    if (frm.Name == "FRM_CONOZCA_SU_CLIENTE")
                    {
                        FRM_C = (FRM_CONOZCA_SU_CLIENTE)frm;
                        FRM_C.txt_id_cliente.Text = DG.Rows[DG.CurrentRow.Index].Cells["ID_CLIENTE"].Value.ToString();
                        FRM_C.txt_nombres.Text = DG.Rows[DG.CurrentRow.Index].Cells["NOMBRES"].Value.ToString();
                        FRM_C.txt_identificacion.Text = DG.Rows[DG.CurrentRow.Index].Cells["IDENTIFICACION"].Value.ToString();
                        FRM_C.cb_oficina.Text = DG.Rows[DG.CurrentRow.Index].Cells["OFICINA"].Value.ToString();
                        FRM_C.cb_tipo_cliente.Text = DG.Rows[DG.CurrentRow.Index].Cells["TIPO_CLIENTE"].Value.ToString();
                        this.Close();
                        break;
                    }
                }

            }
        }

        private void FRM_CONSULTAR_CLIENTES_Load(object sender, EventArgs e)
        {
            CONSULTAR();
        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            CONSULTAR();
        }

        private void DG_DoubleClick(object sender, EventArgs e)
        {
            btn_agregar.PerformClick();
        }
    }
}
