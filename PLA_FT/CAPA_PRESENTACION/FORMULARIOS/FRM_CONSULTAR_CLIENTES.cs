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
    public partial class FRM_CONSULTAR_CLIENTES : CAPA_PRESENTACION.FORMULARIOS.FRM_PLANTILLA
    {
        public FRM_CONSULTAR_CLIENTES()
        {
            InitializeComponent();
            DG.AutoGenerateColumns = false;
        }

        public void CONSULTAR()
        {
            string CONDICION = "(ID_CLIENTE LIKE'%" + txt_buscar.Text + "%' OR NOMBRE LIKE'%" + txt_buscar.Text + "%' OR IDENTIFICACION LIKE'%" + txt_buscar.Text + "%' OR OFICINA LIKE'%" + txt_buscar.Text + "%')";
            DG.DataSource = CN_CLIENTE.VISTA_CLIENTE(CONDICION);
            lbl_total.Text = "Total de Registro(s):  " + DG.Rows.Count.ToString();
        }

        private void lbl_total_Click(object sender, EventArgs e)
        {

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            FRM_EVALUACION FRM = new FRM_EVALUACION();
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Name == "FRM_EVALUACION")
                {
                    FRM = (FRM_EVALUACION)frm;
                    FRM.txt_id_cliente.Text = DG.Rows[DG.CurrentRow.Index].Cells["ID_CLIENTE"].Value.ToString();
                    FRM.txt_nombre.Text = DG.Rows[DG.CurrentRow.Index].Cells["NOMBRE"].Value.ToString();
                    FRM.txt_identificacion.Text = DG.Rows[DG.CurrentRow.Index].Cells["IDENTIFICACION"].Value.ToString();
                    FRM.cb_oficina.Text = DG.Rows[DG.CurrentRow.Index].Cells["OFICINA"].Value.ToString();
                    FRM.cb_tipo.Text = DG.Rows[DG.CurrentRow.Index].Cells["TIPO"].Value.ToString();
                    this.Close();
                    break;
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
