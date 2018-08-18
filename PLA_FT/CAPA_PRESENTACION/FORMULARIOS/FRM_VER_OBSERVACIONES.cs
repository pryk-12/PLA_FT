using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CAPA_NEGOCIOS;

namespace CAPA_PRESENTACION.FORMULARIOS
{
    public partial class FRM_VER_OBSERVACIONES : CAPA_PRESENTACION.FORMULARIOS.FRM_PLANTILLA
    {
        public FRM_VER_OBSERVACIONES()
        {
            InitializeComponent();
        }



        private void DG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_observacion.Text = DG.SelectedCells[2].Value.ToString();
        }

        public void CARGAR_OBSERVACION(int ID_EVALUACION)
        {
            DG.DataSource = CN_OBSERVACION.CONSULTAR("ID_EVALUACION=" + ID_EVALUACION +"");
        }

        private void FRM_VER_OBSERVACIONES_Load(object sender, EventArgs e)
        {
            
        }
    }
}
