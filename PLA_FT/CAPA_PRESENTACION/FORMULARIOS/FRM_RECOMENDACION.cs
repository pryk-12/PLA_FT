using CAPA_ENTIDAD;
using CAPA_NEGOCIOS;
using System;
using System.Windows.Forms;

namespace CAPA_PRESENTACION
{
    public partial class FRM_RECOMENDACION : CAPA_PRESENTACION.FORMULARIOS.FRM_PLANTILLA
    {
        CE_RECOMENDACION CE = new CE_RECOMENDACION();
        CN_RECOMENDACION CN = new CN_RECOMENDACION();

        public FRM_RECOMENDACION()
        {
            InitializeComponent();
        }

        public void RECIBIR_DATOS(CE_RECOMENDACION CE)
        {
            txt_descripcion.Text = CE.DESCRIPCION;
            txt_condicion.Text = CE.CONDICION.ToString();
            txt_id.Text = CE.ID_RECOMENDACION.ToString();
        }

        public void INSERTAR_ACTUALIZAR()
        {
            string MENSAJE = "";
            CE.DESCRIPCION = txt_descripcion.Text.Trim();
            CE.CONDICION = txt_condicion.Text;
            try
            {

                CE.ID_RECOMENDACION = Convert.ToInt32(txt_id.Text);
                CN_RECOMENDACION.ACTUALIZAR(CE);
                MENSAJE = "Datos Actualizados Correctamente";

                CP_UTILIDADES.MENSAJE_INFORMACION(MENSAJE, this);

                FRM_MANT_RECOMENDACIONES FRM = new FRM_MANT_RECOMENDACIONES();
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.Name == "FRM_MANT_RECOMENDACIONES")
                    {
                        FRM = (FRM_MANT_RECOMENDACIONES)frm;
                        FRM.CONSULTAR();
                        this.Close();
                        break;
                    }
                }

                Close();
            }
            catch (Exception ex)
            {
                CP_UTILIDADES.MENSAJE_ERROR(ex.Message, this);
            }

        }

        private void FRM_RECOMENDACION_Load(object sender, EventArgs e)
        {
            this.Text = "Editar Recomendación";
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (txt_descripcion.Text.Equals(""))
            {
                CP_UTILIDADES.MENSAJE_INFORMACION("La Descripción es Obligatoria", this);
                txt_descripcion.Focus();
                return;
            }

            INSERTAR_ACTUALIZAR();
        }
    }
}
