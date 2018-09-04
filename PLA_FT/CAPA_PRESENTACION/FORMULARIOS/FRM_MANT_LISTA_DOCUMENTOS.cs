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
    public partial class FRM_MANT_LISTA_DOCUMENTOS : CAPA_PRESENTACION.FORMULARIOS.FRM_PLANTILLA
    {
        public FRM_MANT_LISTA_DOCUMENTOS()
        {
            InitializeComponent();
            DG.AutoGenerateColumns = false;
        }

        public void CONSULTAR()
        {
            string CONDICION = "(ID_DOCUMENTO LIKE'%" + txt_buscar.Text + "%' OR DESCRIPCION LIKE'%" + txt_buscar.Text + "%')";
            DG.DataSource = CN_LISTA_DOCUMENTO.CONSULTAR(CONDICION);
            lbl_total.Text = "Total de Registro(s):  " + DG.Rows.Count.ToString();
        }

        public void Permiso_Acceso_Panatallas()
        {
            String condicion = "USUARIO = '" + CP_UTILIDADES.DATOS_USUARIO.USUARIO + "' AND PANTALLA = 'Mantenimientos - Lista Documentos Solicitados'";
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

            FRM_LISTA_DOCUMENTO FRM = new FRM_LISTA_DOCUMENTO();
            CE_LISTA_DOCUMENTO CE = new CE_LISTA_DOCUMENTO();
            CE.ID_DOCUMENTO = Convert.ToInt32(DG.Rows[DG.CurrentRow.Index].Cells["ID_DOCUMENTO"].Value.ToString());
            CE.DESCRIPCION = DG.Rows[DG.CurrentRow.Index].Cells["DESCRIPCION"].Value.ToString();
            CE.ESTADO = DG.Rows[DG.CurrentRow.Index].Cells["ESTADO"].Value.ToString();
            FRM.RECIBIR_DATOS(CE);
            FRM.ShowDialog();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            FRM_LISTA_DOCUMENTO FRM = new FRM_LISTA_DOCUMENTO();
            FRM.ShowDialog();
        }

        private void FRM_MANT_LISTA_DOCUMENTOS_Load(object sender, EventArgs e)
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
