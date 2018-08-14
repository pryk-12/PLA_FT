using CAPA_ENTIDAD;
using CAPA_NEGOCIOS;
using CAPA_PRESENTACION.FORMULARIOS;
using System;
using System.Windows.Forms;

namespace CAPA_PRESENTACION
{
    public partial class FRM_ACTIVIDAD_ECONOMICA : CAPA_PRESENTACION.FORMULARIOS.FRM_PLANTILLA
    {
        CE_ACTIVIDAD_ECONOMICA CE = new CE_ACTIVIDAD_ECONOMICA();
        CN_ACTIVIDAD_ECONOMICA CN = new CN_ACTIVIDAD_ECONOMICA();

        public FRM_ACTIVIDAD_ECONOMICA()
        {
            InitializeComponent();
        }

        public void RECIBIR_DATOS(CE_ACTIVIDAD_ECONOMICA CE)
        {
            txt_descripcion.Text = CE.DESCRIPCION;
            txt_valoracion.Text = CE.VALORACION.ToString();
            txt_id.Text = CE.ID_ACTIVIDAD.ToString();
            cb_nivel_riesgo.Text = CE.NIVEL_RIESGO;
            cb_estado.Text = CE.ESTADO;
        }

        public void INSERTAR_ACTUALIZAR()
        {
            string MENSAJE = "";
            CE.DESCRIPCION = txt_descripcion.Text.Trim();
            CE.VALORACION = txt_valoracion.Text.Length==0 ? 0: Convert.ToDouble(txt_valoracion.Text);
            CE.ESTADO = cb_estado.Text;
            CE.NIVEL_RIESGO = cb_nivel_riesgo.Text;
            try
            {
                if (txt_id.Text.Equals(""))
                {
                    CN_ACTIVIDAD_ECONOMICA.INSERTAR(CE);
                    MENSAJE = "Datos Insertados Correctamente";
                }
                else
                {
                    CE.ID_ACTIVIDAD = Convert.ToInt32(txt_id.Text);
                    CN_ACTIVIDAD_ECONOMICA.ACTUALIZAR(CE);
                    MENSAJE = "Datos Actualizados Correctamente";
                }

                CP_UTILIDADES.MENSAJE_INFORMACION(MENSAJE, this);

                FRM_MANT_ACTIVIDADES_ECONOMICAS FRM = new FRM_MANT_ACTIVIDADES_ECONOMICAS();
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.Name == "FRM_MANT_ACTIVIDADES_ECONOMICAS")
                    {
                        FRM = (FRM_MANT_ACTIVIDADES_ECONOMICAS)frm;
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

        private void FRM_ACTIVIDAD_ECONOMICA_Load(object sender, EventArgs e)
        {
            if (txt_id.Text.Equals(""))
            {
                this.Text = "Agregar Actividad Economica";
                cb_estado.Text = "ACTIVO";
                cb_estado.Enabled = false;
            }
            else
            {
                this.Text = "Editar Actividad Economica";
            }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (txt_descripcion.Text.Equals(""))
            {
                CP_UTILIDADES.MENSAJE_INFORMACION("La Descripción es Obligatoria", this);
                txt_descripcion.Focus();
                return;
            }
            if (cb_nivel_riesgo.Text.Equals(""))
            {
                CP_UTILIDADES.MENSAJE_INFORMACION("El Nivel de Riesgo es Obligatorio", this);
                cb_nivel_riesgo.Focus();
                return;
            }
            
            if (cb_estado.Text.Equals(""))
            {
                CP_UTILIDADES.MENSAJE_INFORMACION("El Estado es Obligatorio", this);
                cb_estado.Focus();
                return;
            }

            INSERTAR_ACTUALIZAR();
        }

        private void txt_valoracion_KeyPress(object sender, KeyPressEventArgs e)
        {
            CP_UTILIDADES.PERMITIR_NUMERO_Y_PUNTO(sender,e,txt_valoracion);
        }

    }
}
