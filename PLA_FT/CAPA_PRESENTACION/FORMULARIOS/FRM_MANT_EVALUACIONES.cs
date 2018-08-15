using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CAPA_PRESENTACION.FORMULARIOS
{
    public partial class FRM_MANT_EVALUACIONES : CAPA_PRESENTACION.FORMULARIOS.FRM_PLANTILLA
    {
        public FRM_MANT_EVALUACIONES()
        {
            InitializeComponent();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            FRM_EVALUACION FRM = new FRM_EVALUACION();
            FRM.ShowDialog();
        }
    }
}
