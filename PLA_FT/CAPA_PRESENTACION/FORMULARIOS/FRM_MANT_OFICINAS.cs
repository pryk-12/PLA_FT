﻿using System;
using CAPA_NEGOCIOS;
using CAPA_ENTIDAD;

namespace CAPA_PRESENTACION.FORMULARIOS
{
    public partial class FRM_MANT_OFICINAS : CAPA_PRESENTACION.FORMULARIOS.FRM_PLANTILLA
    {
        public FRM_MANT_OFICINAS()
        {
            InitializeComponent();
            DG.AutoGenerateColumns = false;
        }

        public void CONSULTAR()
        {
            string CONDICION = "(ID_OFICINA LIKE'%" + txt_buscar.Text + "%' OR DESCRIPCION LIKE'%" + txt_buscar.Text + "%')";
            DG.DataSource = CN_OFICINA.CONSULTAR(CONDICION);
            lbl_total.Text = "Total de Registro(s):  "+ DG.Rows.Count.ToString();
        }

        public void Permiso_Acceso_Panatallas()
        {
            String condicion = "USUARIO = '" + CP_UTILIDADES.DATOS_USUARIO.USUARIO + "' AND PANTALLA = 'Mantenimientos - Oficinas'";
            var Actividad_Economica = CN_PERMISO.CONSULTAR_PERMISO(condicion);
            btn_agregar.Enabled = Convert.ToBoolean(Actividad_Economica.Rows[0]["AGREGAR"].ToString()) == true ? true : false;
            btn_editar.Enabled = Convert.ToBoolean(Actividad_Economica.Rows[0]["EDITAR"].ToString()) == true ? true : false;
        }

        public void PASAR_DATOS()
        {
            if(DG.Rows.Count ==0)
            {
                return;
            }

            FRM_OFICINAS FRM = new FRM_OFICINAS();
            CE_OFICINA CE = new CE_OFICINA();
            CE.ID_OFICINA = Convert.ToInt32(DG.Rows[DG.CurrentRow.Index].Cells["ID_OFICINA"].Value.ToString());
            CE.DESCRIPCION = DG.Rows[DG.CurrentRow.Index].Cells["DESCRIPCION"].Value.ToString();
            CE.DIRECCION = DG.Rows[DG.CurrentRow.Index].Cells["DIRECCION"].Value.ToString();
            CE.TELEFONO = DG.Rows[DG.CurrentRow.Index].Cells["TELEFONO"].Value.ToString();
            CE.ESTADO = DG.Rows[DG.CurrentRow.Index].Cells["ESTADO"].Value.ToString();
            CE.NIVEL_RIESGO = DG.Rows[DG.CurrentRow.Index].Cells["NIVEL_RIESGO"].Value.ToString();
            CE.VALORACION = Convert.ToDouble(DG.Rows[DG.CurrentRow.Index].Cells["VALORACION"].Value.ToString());
            FRM.RECIBIR_DATOS(CE);
            FRM.ShowDialog();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            FRM_OFICINAS FRM = new FRM_OFICINAS();
            FRM.ShowDialog();
        }

        private void FRM_MANT_OFICINAS_Load(object sender, EventArgs e)
        {
            CONSULTAR();
            Permiso_Acceso_Panatallas();
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
