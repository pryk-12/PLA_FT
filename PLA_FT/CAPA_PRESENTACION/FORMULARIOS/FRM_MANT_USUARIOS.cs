using CAPA_ENTIDAD;
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
    public partial class FRM_MANT_USUARIOS : CAPA_PRESENTACION.FORMULARIOS.FRM_PLANTILLA
    {
        public FRM_MANT_USUARIOS()
        {
            InitializeComponent();
            DG.AutoGenerateColumns = false;
        }
        public void CONSULTAR()
        {
            string CONDICION = "(A.NOMBRE LIKE'%" + txt_buscar.Text + "%' OR A.USUARIO LIKE'%" + txt_buscar.Text + "%' OR B.DESCRIPCION LIKE'%" + txt_buscar.Text + "%' OR C.DESCRIPCION LIKE'%" + txt_buscar.Text + "%' OR D.DESCRIPCION LIKE'%" + txt_buscar.Text + "%')";
            DG.DataSource = CN_USUARIO.CONSULTAR(CONDICION);
            lbl_total.Text = "Total de Registro(s):  " + DG.Rows.Count.ToString();
        }

        public void PASAR_DATOS()
        {
            if (DG.Rows.Count == 0)
            {
                return;
            }

            FRM_USUARIO FRM = new FRM_USUARIO();
            CE_USUARIO CE = new CE_USUARIO();
            CE.ID_OFICINA = Convert.ToInt32(DG.Rows[DG.CurrentRow.Index].Cells["ID_OFICINA"].Value.ToString());
            CE.ID_DEPARTAMENTO = Convert.ToInt32(DG.Rows[DG.CurrentRow.Index].Cells["ID_DEPARTAMENTO"].Value.ToString());
            CE.ID_PUESTO = Convert.ToInt32(DG.Rows[DG.CurrentRow.Index].Cells["ID_PUESTO"].Value.ToString());
            CE.ID_USUARIO = Convert.ToInt32(DG.Rows[DG.CurrentRow.Index].Cells["ID_USUARIO"].Value.ToString());
            CE.NOMBRE = DG.Rows[DG.CurrentRow.Index].Cells["NOMBRE"].Value.ToString();
            CE.USUARIO = DG.Rows[DG.CurrentRow.Index].Cells["USUARIO"].Value.ToString();
            CE.CLAVE = DG.Rows[DG.CurrentRow.Index].Cells["CLAVE"].Value.ToString();
            CE.ESTADO = DG.Rows[DG.CurrentRow.Index].Cells["ESTADO"].Value.ToString();
            CE.SEXO = DG.Rows[DG.CurrentRow.Index].Cells["SEXO"].Value.ToString();
            FRM.RECIBIR_DATOS(CE);
            FRM.ShowDialog();
        }

        private void FRM_MANT_USUARIOS_Load(object sender, EventArgs e)
        {
            CONSULTAR();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            FRM_USUARIO FRM = new FRM_USUARIO();
            FRM.ShowDialog();
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
